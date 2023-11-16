// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    // подписать кнопки пейджера на событие click
    $(".page-link").click(function (e) {
        e.preventDefault();
        // получить адрес
        var uri = this.attributes["href"].value;
        // отправить асинхронный запрос и поместить ответ 
        // в контейнер с id="list"
        $("#list").load(uri);
        // снять выделение с кнопки
        $(".active").removeClass("active disabled");
        // выделить текущую кнопку
        $(this).parent().addClass("active");
        // изменить адрес в адресной строке браузера
        history.pushState(null, null, uri);
    });
});
