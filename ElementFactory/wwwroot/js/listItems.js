function LoadLists() {
    var select = document.getElementsByClassName("seeItemsList")[0];   
    console.log(select);
        select
        .addEventListener('change', function (event) {
            event.preventDefault();
            var items = document.getElementsByTagName("td");
            for (var i in items) {
                console.log(i.children);
            }
        });
    console.log(2);
}
