$(document).ready(function () {
    var productTable = $("#tableProducts").DataTable(
        {
            responsive: true,
            scrollX: true
        }
    );
    console.log("data: ", productTable.data());
    return true;
});