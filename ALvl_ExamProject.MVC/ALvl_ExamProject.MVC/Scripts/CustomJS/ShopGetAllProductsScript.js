$(function () {

    $("#SelectCategory").on("change", function () {
        var url = $(this).val();

        if (url) {
            window.location = "/admin/shop/GetAllProducts?categoryId=" + url;
        }
        return false;
    });
});