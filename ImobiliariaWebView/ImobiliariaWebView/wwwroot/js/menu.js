document.addEventListener("DOMContentLoaded", function (event) {

    const showNavbar = (toggleId, navId, bodyId, headerId) => {
        const toggle = document.getElementById(toggleId),
            nav = document.getElementById(navId),
            bodypd = document.getElementById(bodyId),
            headerpd = document.getElementById(headerId)

        // Valida todas as variáveis existentes
        if (toggle && nav && bodypd && headerpd) {
            toggle.addEventListener('click', () => {
                // Exibe navbar
                nav.classList.toggle('show')
                // Altera icone
                toggle.classList.toggle('bx-x')
                // adiciona padding no body
                bodypd.classList.toggle('body-pd')
                // adiciona padding no header
                headerpd.classList.toggle('body-pd')
            })
        }
    }

    showNavbar('header-toggle', 'nav-bar', 'body-pd', 'header')

    /*===== LINK ATIVO =====*/
    const linkColor = document.querySelectorAll('.nav_link')

    function colorLink() {
        if (linkColor) {
            linkColor.forEach(l => l.classList.remove('active'))
            this.classList.add('active')
        }
    }
    linkColor.forEach(l => l.addEventListener('click', colorLink))
});

$(window).on('load', function () {
    $('.modal.fade').appendTo('body');

})