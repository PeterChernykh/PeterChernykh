$(function () {

    $("#SelectCategory").on("change", function () {
        var url = $(this).val();

        if (url) {
            window.location = "/admin/shop/GetAllProducts?categoryId=" + url;
        }
        return false;
    });

    $("a.delete").click(function () {
        if (!confirm("Confirm page deletion")) return false;
    });
});