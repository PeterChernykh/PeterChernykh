$(function () {
    var newCatA = $("a#newcata");
    var newCatTextInput = $("#newcatname");
    var ajaxText = $("span.ajax-text");
    var table = $("table#pages tbody");

    newCatTextInput.keyup(function (e) {
        if (e.keyCode == 13) {
            newCatA.click();
        }
    });

    newCatA.click(function (e) {
        e.preventDefault();

        var catName = newCatTextInput.val();

        if (catName.length < 3) {
            alert("Category name must be at least 3 characters long.");
            return false;
        }

        ajaxText.show();

        var url = "AddNewCategory";

        $.post(url, { catName: catName }, function (data) {
            var response = data.trim();

            if (response == "titletaken") {
                ajaxText.html("<span class='alert alert-danger'>That title is taken!</span>");
                setTimeout(function () {
                    ajaxText.fadeOut("fast", function () {
                        ajaxText.html(" ");
                    });
                });
                return false;
            }
            else {
                if (!$("table#pages").length) {
                    location.reload();
                }
                else {
                    ajaxText.html("<span class='alert alert-success'>The category has been added!</span>");
                    setTimeout(function () {
                        ajaxText.fadeOut("fast", function () {
                            ajaxText.html("");
                        });
                    });

                    newCatTextInput.val("");

                    var toAppend = $("table#pages tbody tr:last").clone();
                    toAppend.attr("id", "id_" + data);
                    toAppend.find("#item_Name").val(catName);
                    toAppend.find("a.delete").attr("href", "DeleteCategory/" + data);
                    table.append(toAppend);
                    table.sortable("refresh");
                }
            }
        });
    });

    $("body").on("click", "a.delete", function () {
        if (!confirm("You are going to delete this page. Do you want to proceed?")) return false;
    });

    var originalTextBoxValue;

    $("table#pages input.text-box").dblclick(function () {
        originalTextBoxValue = $(this).val();
        $(this).attr("readonly", false);
    });

    $("table#pages input.text-box").keyup(function (e) {
        if (e.keyCode == 13) {
            $(this).blur();
        }
    });

    $("table#pages input.text-box").blur(function () {
        var $this = $(this);
        var ajaxdiv = $this.parent().parent().parent().find(".ajaxdivtd");
        var newCatName = $this.val();
        var id = $this.parent().parent().parent().parent().parent().attr("id").substring(3);
        var url = "/admin/shop/RenameCategory";

        if (newCatName.length < 3) {
            alert("Category name must be at least 3 characters long.");
            $this.attr("readonly", true);
            return false;
        }

        $.post(url, { newCatName: newCatName, id: id }, function (data) {
            var response = data.trim();

            if (response == "titletaken") {
                $this.val(originalTextBoxValue);
                ajaxdiv.html("<div class='alert alert-danger'>That title is taken!</div>").show();
            }
            else {
                ajaxdiv.html("<div class='alert alert-success'>The category name has been changed!</div>").show();
            }

            setTimeout(function () {
                ajaxdiv.fadeOut("fast", function () {
                    ajaxdiv.html("");
                });
            }, 3000);
        }).done(function () {
            $this.attr("readonly", true);
        });
    });

    $("table#pages tbody").sortable({
        items: "tr:not(.home)",
        placeholder: "ui-state-highlight",
        update: function () {
            var ids = $("table#pages tbody").sortable("serialize");
            var url = "/Admin/Shop/ReorderCategories";

            $.post(url, ids, function (data) {
            });
        },
    });
});