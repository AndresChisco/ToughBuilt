
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

$("#tableProducts").on("click", "tr", async function () {
    var id = parseInt(productTable.row(this).data()[1]);
    var datosProducto = await getProduct(id);
    console.log(datosProducto);
    var images = datosProducto.FeaturedImages.split(';');
    console.log("nombres imagenes:", images)
    //$("#carouselList").html("");
    $("#carouselImages").html("");
    var active = "";
    $.each(images, function (index, value) {
        if (index === 0)
            active = "active"
        else
            active = "";
        //var optionCarousel = $("#carouselList").html();
        var imagesCarousel = $("#carouselImages").html();
        console.log("contenido del carrusel: ", imagesCarousel)
        //var newOption = '<li data-target="#carouselIndicators" data-slide-to="' + index + '" class="' + active + '"></li>';
        var newImage = '<div class="carousel-item ' + active + '"><img class="d-block w-100" src="/Resources/Images/Products/' + datosProducto.Name + '/' + value + '" alt = "' + value + '" style="width: 450px; height: 500px" /></div>'
        //$("#carouselList").html(optionCarousel + newOption);
        $("#carouselImages").html(imagesCarousel + newImage);
        $('.carousel').carousel(); 
    });
    $("#carouselImages").html();
    $("#ProductDetailsTitle").text(productTable.row(this).data()[2]);
    $("#txtDescription").text(productTable.row(this).data()[3]);
    $("#txtCharacteristics").text(productTable.row(this).data()[6]);
    $("#txtPrice").text(parseFloat(productTable.row(this).data()[4]));
    $("#txtStock").text(parseInt(productTable.row(this).data()[5]));
    $('#ProductDetailsModal').modal("show");
});

$(".modalTrigger").on("click", async function () {
    var id = parseInt(productTable.row(this).data()[1]);
    var datosProducto = await getProduct(id);
    console.log(datosProducto);
    var images = datosProducto.FeaturedImages.split(';');
    console.log("nombres imagenes:", images)
    $("#carouselImages").html("");
    var active = "";
    $.each(images, function (index, value) {
        if (index === 0)
            active = " active"
        else
            active = "";
        var imagesCarousel = $("#carouselImages").html();
        console.log("contenido del carrusel: ", imagesCarousel)
        var newImage = '<div class="carousel-item' + active + '"><img class="d-block w-100" src="/Resources/Images/Products/' + datosProducto.Name + '/' + value + '" alt = "' + value + '" style="width: 250px; height: 300px" /></div>'
        $("#carouselImages").html(imagesCarousel + newImage);
        $('.carouselImages').carousel();
    });
    $("#carouselImages").html();
    $("#ProductDetailsTitle").text(productTable.row(this).data()[2]);
    $("#txtDescription").text(productTable.row(this).data()[3]);
    $("#txtCharacteristics").text(productTable.row(this).data()[6]);
    $("#txtPrice").text(parseFloat(productTable.row(this).data()[4]));
    $("#txtStock").text(parseInt(productTable.row(this).data()[5]));
    $('#ProductDetailsModal').modal("show");
});