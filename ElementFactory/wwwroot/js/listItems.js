function PageSettings(atomicMasses) {

    var select = document.getElementById('seeItemsList'); 

    function StyleCell(element) {
        var array = Array.from(element.classList);
        var cellClass = array[0];
        //element.classList.remove(cellClass);
        console.log(element.classList);
        element.classList.remove(cellClass);
        console.log(element.classList);
       
    }

    select
    .addEventListener('change', function (event) {

        event.preventDefault();

        var cellsCollection = document.getElementsByTagName('td');
        var cellsCollectionArray = Array.from(cellsCollection)
            .filter(x => x.classList.length != 0);

        var selectedIndex = select.selectedIndex;
        var selectedOption = select.options[selectedIndex].id;

        for (var i = 0; i < cellsCollectionArray.length; i++) {

            var currentCell = cellsCollectionArray[i];

            if (selectedOption == 'seeAtomicNumber') {

            
            } else if (selectedOption == 'seeAtomicMass') {
 
                    var mass = atomicMasses[i];                    

                    StyleCell(currentCell);
                    
            } else if (selectedOption == 'seePhysicalAppearance') {

            } else if (selectedOption == 'seeAtomicRadius') {

            } else if (selectedOption == 'seeMeltingPoint') {

            } else if (selectedOption == 'seeBoilingPoint') {

            } else if (selectedOption == 'seeByYear') {

            } 
        }
    });
}
