
var productTable;
$(document).ready(function () {
    productTable = $("#tableProducts").DataTable(
        {
            responsive: true,
            scrollX: true,
            columnDefs: {
                target: [1], visible: false }
        }
    );
});

//$("#tableProducts").on("click", "tr", async function () {
//    var id = parseInt(productTable.row(this).data()[1]);
//    var datosProducto = await getProduct(id);
//    var images = datosProducto.FeaturedImages.split(';');
//    $(".carousel-inner").html("");
//    var active = "";
//    $.each(images, function (index, value) {
//        if (index === 0)
//            active = "active"
//        else
//            active = "";
//        var imagesCarousel = $(".carousel-inner").html();
//        var newImage = '<div class="carousel-item ' + active + '"><img class="d-block w-100" src="/Resources/Images/Products/' + datosProducto.Name + '/' + value + '" alt = "' + value + '" style="width: 450px; height: 500px" /></div>'
//        $(".carousel-inner").html(imagesCarousel + newImage);
//        $('.carousel').carousel(); 
//    });
//    $("#ProductDetailsTitle").text(datosProducto.Name);
//    $("#txtDescription").text(datosProducto.Description);
//    $("#txtCharacteristics").text(datosProducto.FeaturedCharacteristics);
//    $("#txtPrice").text(datosProducto.Price);
//    $("#txtStock").text(datosProducto.Stock);
//    $('#ProductDetailsModal').modal("show");
//});

$(".modalTrigger").on("click", async function () {

    var id = $(this).data("id");
    var datosProducto = await getProduct(id);
    var images = datosProducto.FeaturedImages.split(';');
    $(".carousel-inner").html("");
    var active = "";
    $.each(images, function (index, value) {
        if (index === 0)
            active = " active"
        else
            active = "";
        var imagesCarousel = $(".carousel-inner").html();
        var newImage = '<div class="carousel-item' + active + '"><img class="d-block w-100" src="/Resources/Images/Products/' + datosProducto.Name + '/' + value + '" alt = "' + value + '" style="width: 250px; height: 300px" /></div>'
        $(".carousel-inner").html(imagesCarousel + newImage);
        $('.carouselImages').carousel();
    });
    $("#ProductDetailsTitle").text(datosProducto.Name);
    $("#txtDescription").text(datosProducto.Description);
    $("#txtCharacteristics").text(datosProducto.FeaturedCharacteristics);
    $("#txtPrice").text(datosProducto.Price);
    $("#txtStock").text(datosProducto.Stock);
    $('#ProductDetailsModal').modal("show");
});