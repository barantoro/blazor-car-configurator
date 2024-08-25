function getElementContentById(id) {
    var element = document.getElementById(id);
    if (element) {
        return element.innerHTML;
    }
    return null;
}
