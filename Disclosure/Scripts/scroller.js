var animate = function (elem, style, unit, from, to, time, prop) {
    if (!elem) {
        return;
    }
    var start = new Date().getTime();
    var timer = setInterval(function () {
        var step = Math.min(1, (new Date().getTime() - start) / time);
        if (prop) {
            elem[style] = (from + step * (to - from)) + unit;
        }
        else {
            elem.style[style] = (from + step * (to - from)) + unit;
        }
        if (step === 1) {
            clearInterval(timer);
        }
    }, 25);
    if (prop) {
        elem[style] = from + unit;
    }
    else {
        elem.style[style] = from + unit;
    }
};
var scrollToSection = function (scrollTo) {
    var target;
    if (/\#(.*)/gi.test(scrollTo) !== null) {
        target = document.getElementById(/\#(.*)/gi.exec(scrollTo)[1]);
    } else {
        target = document.getElementById(scrollTo);
    }
    animate(document.scrollingElement || document.documentElement, "scrollTop", "", 0, target.offsetTop - 30, 400, true);
};