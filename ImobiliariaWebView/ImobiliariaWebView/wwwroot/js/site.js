// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Filtra tabela

$(document).ready(function () {
    $("#tableSearch").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#showTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});