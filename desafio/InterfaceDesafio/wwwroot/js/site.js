﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const uri = "https://localhost:44393/api/item";
let items = null;

$(function () {
    $('#form').bind('submit', function (e) {

        let item = {
            type: $("#type").val(),
            name: $("#name").val(),
            state: $("#state").val(),
            year: $("#year").val(),
            BorrowedTo: "Ninguem",
            genres: $("#genres").val(),
            description: $("#description").val()
        };

        e.preventDefault();
        console.log(item);

        $.ajax({
            url: uri,
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify(item),
            dataType: 'json',
            success: function(item) {
                console.log(item);
            },
            error: function (item) {
                console.log("Falhou");
            }

        });
    });
});

/* --------------------------------------------------------------------------------------------- */
$(document).ready(function () {
    getData();
    getContatos();
});

function getContatos() {
    let option = null;
    $.ajax({
        type: "GET",
        url: "https://localhost:44393/api/Contact",
        cache: false,
        success: function (data) {
            const optContatos = $("#contatos");

            $(optContatos).empty();
            $.each(data, function (key, item) {
                option = $("<option></option>").text(item.name);
                option.appendTo(optContatos);
            });
        }
    });
}

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#items");

            $(tBody).empty();
            
            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.type))
                    .append($("<td></td>").text(item.name))
                    .append($("<td></td>").text(item.state))
                    .append($("<td></td>").text(item.borrowedTo))
                    .append($("<td></td>").text(item.year))
                    .append($("<td></td>").text(item.genres))
                    .append($("<td></td>").text(item.description))
                  
                    .append(
                        $("<td></td>").append(
                            $("<button>Emprestar</button>").on("click", function () {
                                emprestarItem(item.id);
                            })
                        )
                    )
                    .append(
                        $("<td></td>").append(
                            $("<button>Pegar</button>").on("click", function () {
                                pegarItem(item.id);
                            })
                        )
                ).append(
                    $("<td></td>").append(
                        $("<a href='#my-top'><button class='editar' >Editar</button></a>").on("click", function () {
                            editItem(item.id);
                        })
                    )
                ).append(
                    $("<td></td>").append(
                        $("<button class='btn-danger'>X</button>").on("click", function () {
                            deleteItem(item.id);
                        })
                    )
                );

                tr.appendTo(tBody);
            });

            items = data;
        }
    });
}

function emprestarItem(id) {
    $.each(items, function (key, item) {
        if (item.id === id) {
            alert("Emprestar");
            $("#emprestar-id").val(item.id);
            $("#emprestar-type").val(item.type);
            $("#emprestar-name").val(item.name);
            $("#emprestar-state").val(item.state);
            $("#emprestar-year").val(item.year);
            $("#emprestar-genres").val(item.genres);
            $("#emprestar-description").val(item.description);
        }
    });
    $("#spoilerEmprestar").css({ display: "block" });
}
let borrowedTo = "";
function editItem(id) { 
    $.each(items, function (key, item) {
        if (item.id === id) {
            $("#edit-id").val(item.id);
            $("#edit-type").val(item.type);
            $("#edit-name").val(item.name);
            $("#edit-state").val(item.state);
            borrowedTo = item.borrowedTo;
            $("#edit-year").val(item.year);
            $("#edit-genres").val(item.genres);
            $("#edit-description").val(item.description);
        }
    });
    $("#spoiler").css({ display: "block" });
}

$(".my-form").on("submit", function (e) {
    e.preventDefault();

    const item = {
        id: $("#edit-id").val(),
        type: $("#edit-type").val(),
        name: $("#edit-name").val(),
        state: $("#edit-state").val(),
        borrowedTo: borrowedTo,
        year: $("#edit-year").val(),
        genres: $("#edit-genres").val(),
        description: $("#edit-description").val()
    };
    console.log(item);
    $.ajax({
        url: uri + "/" + $("#edit-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        success: function (result) {
            getData();
        }
    });

    closeInput();
    return false;
});

$(".my-form-emprestar").on("submit", function (e) {
    e.preventDefault();

    const item = {
        id: $("#emprestar-id").val(),
        type: $("#emprestar-type").val(),
        name: $("#emprestar-name").val(),
        state: "Indisponível",
        borrowedTo: $("#contatos").val(),
        year: $("#emprestar-year").val(),
        genres: $("#emprestar-genres").val(),
        description: $("#emprestar-description").val()
    };
    console.log(item);
    $.ajax({
        url: uri + "/" + $("#emprestar-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        success: function (result) {
            getData();
        }
    });

    closeInput();
    return false;
});



function closeInput() {
    $("#spoiler").css({ display: "none" });
    $("#spoilerEmprestar").css({ display: "none" });
}


function deleteItem(id) {
    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        success: function (result) {
            getData();
        }
    });
}

function pegarItem(id) {
    $.each(items, function (key, item) {
        if (item.id === id && item.borrowedTo != "Ninguém" && item.state != "Disponível") {
            alert("O " + item.type + ", " + item.name+" "+"foi pego de volta");
            $("#emprestar-id").val(item.id);
            $("#emprestar-type").val(item.type);
            $("#emprestar-name").val(item.name);
            $("#emprestar-year").val(item.year);
            $("#emprestar-genres").val(item.genres);
            $("#emprestar-description").val(item.description);

        }
    });

    let item = {
        id: $("#emprestar-id").val(),
        type: $("#emprestar-type").val(),
        name: $("#emprestar-name").val(),
        state: "Disponível",
        borrowedTo: "Ninguem",
        year: $("#emprestar-year").val(),
        genres: $("#emprestar-genres").val(),
        description: $("#emprestar-description").val()
    };
    console.log(item);
    $.ajax({
        url: uri + "/" + $("#emprestar-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        success: function (result) {
            getData();
        }
    });

}