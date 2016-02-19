var hub = $.connection.productsHub;

hub.client.productAdded = function (product) {
    $("#productsList").append('<li id=product' + product.Id + '>' + product.Name + '</li>');
};

$.ajax({
    url: '/api/Products/GetAllProducts',
    method: 'GET',
    dataType: 'json',
    success: populateProductList
});

function populateProductList(products) {
    $.each(products, function (index) {
        var product = products[index];
        $("#productsList").append('<li id=product' + product.Id + '>' + product.Name + '</li>');
    });
}

$("#createButton").click(function () {
    var product = {
        Id: $("#idInput").val(),
        Name: $("#nameInput").val(),
        Category: $("#categoryInput").val(),
        Price: $("#priceInput").val()
    };

    $.ajax({
        url: '/api/Products/CreateProduct',
        type: 'POST',
        data: product
    });

});

$.connection.hub.logging = true;
$.connection.hub.start();
