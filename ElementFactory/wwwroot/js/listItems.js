function PageSettings(
    atomicNumbers,
    chemicalSymbols,
    elementNames,
    chemicalTypeNames,
    atomicMasses,
    states,
    atomicRadiuses,
    meltingPoints,
    boilingPoints,
    years) {

    function CreateDOMElement(tagName,parent,className) {
        var element = document.createElement(tagName);
        element.classList.add(className);
        parent.innerHTML += element;
        return element;
    }
    var cellsCollection = document.getElementsByTagName('td');

    var cellsCollectionArray = Array.from(cellsCollection)
        .filter(x => x.classList.length != 0).sort((a, b) =>
            a.getElementsByClassName('atomicNumber')[0].textContent -
            b.getElementsByClassName('atomicNumber')[0].textContent);

    for (var i = 0; i < cellsCollectionArray.length; i++) {

        var currentCell = cellsCollectionArray[i];
        currentCell.addEventListener('click', function (event) {
            event.preventDefault();

            var popUpContainer = CreateDOMElement('div', document.getElementsByTagName('body')[0], 'popUpContainer');
            popUpContainer.style.display = 'none';

            var main = CreateDOMElement('main', popUpContainer, 'popUpMain');

            var header = CreateDOMElement('header', main, 'popUpHeader');

            var article1 = CreateDOMElement('article', header, 'popUpHeaderArticle1');
            article1.textContent = 'Свойства на елемента';

            var article2 = CreateDOMElement('article', main, 'popUpMainArticle2');

            var section1 = CreateDOMElement('section', article2, 'popUpMainSection1');

            var h2_1 = CreateDOMElement('h2', section1, 'popUpMainArticleSectionH2_1');
            h2_1.textContent = atomicNumbers[i];

            var h1_1 = CreateDOMElement('h1', section1, 'popUpMainArticleSectionH1_1');
            h1_1.textContent = chemicalSymbols[i];

            var p1 = CreateDOMElement('p', section1, 'popUpMainArticleSectionP1');
            p1.textContent = elementNames[i];

            var p2 = CreateDOMElement('p', section1, 'popUpMainArticleSectionP2');
            p2.textContent = chemicalTypeNames[i];


        })
    }

    var select = document.getElementById('seeItemsList');

    select
        .addEventListener('change', function (event) {
        event.preventDefault();

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
