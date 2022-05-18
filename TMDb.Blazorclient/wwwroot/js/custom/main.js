
window.sliderFunctions = {

    startMovieRowSlider: function () {
        $(document).ready(function () {

            $('.owl-carousel.movieRow').owlCarousel({
                loop: true,
                margin: 10,
                nav: true,
                navText: [
                    "<i class='fa fa-caret-left'></i>",
                    "<i class='fa fa-caret-right'></i>"
                ],
                responsive: {
                    0: {
                        items: 2
                    },
                    600: {
                        items: 4
                    },
                    1000: {
                        items: 5
                    },
                    1400: {
                        items: 7
                    }
                }
            })

        });
    },

    startStandardSlider: function () {
        $(document).ready(function () {

            $('.owl-carousel.standardCarousel').owlCarousel({
                loop: false,
                margin: 10,
                nav: true,
                navText: [
                    "<i class='fa fa-caret-left'></i>",
                    "<i class='fa fa-caret-right'></i>"
                ],
                items: 1

            })

        })
    }

}
