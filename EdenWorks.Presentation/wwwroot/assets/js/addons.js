function dropdownMenuListFunc() {
    document.getElementById("dropdownMenuList").classList.toggle("show");
}


window.onclick = function (event) {
    if (!event.target.matches('.dropdownMenuList')) {
        var dropdowns = document.getElementsByClassName("dropdownMenuBtn-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}

