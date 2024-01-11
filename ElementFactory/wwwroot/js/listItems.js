function PageSettings(atomicMasses) {
    console.log(atomicMasses);
    var select = document.getElementById('seeItemsList');   
    function StyleCell(element) {
        element.classList = [];
    }

    select
    .addEventListener('change', function (event) {

        event.preventDefault();

        var cellsCollection = document.getElementsByTagName('td');
        var cellsCollectionArray = Array.from(cellsCollection)
            .filter(x => x.classList.length != 0);

        console.log(array);

        var selectedIndex = select.selectedIndex;
        var selectedOption = select.options[selectedIndex].id;

        for (var i = 0; i < cellsCollectionArray.length; i++) {

            var currentCell = cellsCollectionArray[i];

            if (selectedOption == 'seeAtomicNumber') {

            
            } else if (selectedOption == 'seeAtomicMass') {
                
            } else if (selectedOption == 'seePhysicalAppearance') {

            } else if (selectedOption == 'seeAtomicRadius') {

            } else if (selectedOption == 'seeMeltingPoint') {

            } else if (selectedOption == 'seeBoilingPoint') {

            } else if (selectedOption == 'seeByYear') {

            } 
        }
    });
}
