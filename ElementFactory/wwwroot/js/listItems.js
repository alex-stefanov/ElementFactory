function PageSettings(
    chemicalTypeNames,
    atomicMasses,
    states,
    atomicRadiuses,
    meltingPoints,
    boilingPoints,
    years) {

    var select = document.getElementById('seeItemsList');

    select
        .addEventListener('change', function (event) {
        event.preventDefault();

        var cellsCollection = document.getElementsByTagName('td');

        var cellsCollectionArray = Array.from(cellsCollection)
                    .filter(x => x.classList.length != 0).sort((a, b) =>
                    a.getElementsByClassName('atomicNumber')[0].textContent - 
                    b.getElementsByClassName('atomicNumber')[0].textContent);

        var selectedIndex = select.selectedIndex;
        var selectedOption = select.options[selectedIndex].id;

        for (var i = 0; i < cellsCollectionArray.length; i++) {

            var currentCell = cellsCollectionArray[i];

            if (selectedOption == 'seeAtomicNumber') {

                var chemicalType = chemicalTypeNames[i]
                    .map(x => String.fromCharCode(x)).join('');

                currentCell.classList = [];

                for (var j = 0; j < chemicalType.split(' ').length; j++) { 
                    currentCell.classList.add(chemicalType.split(' ')[j]);
                }

                currentCell.style = null;
            }
            else if (selectedOption == 'seeAtomicMass') {
 
                var mass = atomicMasses[i];                    
                currentCell.classList = [];

                if (mass > 255) {
                    mass *= 0.9;
                }

                console.log(mass);

                currentCell.style.backgroundColor = `rgba(130, ${Math.abs(mass - 255)}, 255)`;
                currentCell.style.border = `4px solid rgba(60, ${Math.abs(mass - 255)}, 255)`;
                currentCell.classList.add('hasAtomicMass');
            }
            else if (selectedOption == 'seePhysicalAppearance') {
                var state = states[i]
                    .map(x => String.fromCharCode(x)).join('');

                currentCell.classList = [];
                currentCell.style = null;
                currentCell.classList.add(state);
            }
            else if (selectedOption == 'seeAtomicRadius') {
                var atomicRadius = atomicRadiuses[i];
            } else if (selectedOption == 'seeMeltingPoint') {
                var meltingPoint = meltingPoints[i];
            } else if (selectedOption == 'seeBoilingPoint') {
                var boilingPoint = boilingPoints[i];
            } else if (selectedOption == 'seeByYear') {
                var year = years[i];
            } 
        }
    });
}
