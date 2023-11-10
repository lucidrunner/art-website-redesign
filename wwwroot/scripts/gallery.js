//function alertMe(url) {
//    console.log("Test");
//    console.log(url);
//}

var elem = document.querySelector('.main-gallery');
if (elem) {
    var flkty = new Flickity(elem, {
        // options
        cellAlign: 'center',
        contain: true,
        wrapAround: true,
        autoPlay: 12000,
        friction: 0.3,
        selectedAttraction: 0.01,
        prevNextButtons: false,
        pageDots: false
    });

    // element argument can be a selector string
    //   for an individual element
    var flkty = new Flickity('.main-gallery', {
        // options
    });
}
