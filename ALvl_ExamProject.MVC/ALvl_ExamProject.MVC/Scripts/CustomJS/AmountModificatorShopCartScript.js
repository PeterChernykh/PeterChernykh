$(function () {

    $("a.plusproduct").click(function (e) {
        e.preventDefault();

        var prodId = $(this).data("id");
        var url = "/ShopCart/AddProductToShopCart";

        $.getJSON(url, { prodId: prodId }, function (data) {
            $("td.qty" + prodId).html(data.qty);

            var price = data.qty * data.price;
            var priceHtml = price.toFixed(2) + "$";

            $("td.total" + prodId).html(priceHtml);

            var gt = parseFloat($("td.totalamount span").text());
            var grandtotal = (gt + data.price).toFixed(2);

            $("td.grandtotal span").text(grandtotal);
        });
    });
});

/* Decriment product */
$(function () {

    $("a.minusproduct").click(function (e) {
        e.preventDefault();

        var $this = $(this);
        var prodId = $(this).data("id");
        var url = "/ShopCart/RemoveProductFromShopCart";

        $.getJSON(url, { prodId: prodId }, function (data) {

            if (data.qty == 0) {
                $this.parent().fadeOut("fast", function () {
                    location.reload();
                });
            }
            else {
                $("td.qty" + prodId).html(data.qty);

                var price = data.qty * data.price;
                var priceHtml = "€" + price.toFixed(2);

                $("td.total" + prodId).html(priceHtml);

                var gt = parseFloat($("td.grandtotal span").text());
                var grandtotal = (gt - data.price).toFixed(2);

                $("td.grandtotal span").text(grandtotal);
            }
        });
    });
});
/*-----------------------------------------------------------*/

/* Remove product */
$(function () {

    $("a.removeproduct").click(function (e) {
        e.preventDefault();

        var $this = $(this);
        var prodId = $(this).data("id");
        var url = "/ShopCart/RemoveProduct";

        $.get(url, { prodId: prodId }, function (data) {
            location.reload();
        });
    });
});