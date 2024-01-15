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

    function CreateDOMElement(tagName, parent, className) {
        var element = document.createElement(tagName);
        element.classList.add(className);
        parent.innerHTML += element;
        return element;
    }

    function UpdateElement(element, className) {
        element.classList = [];
        if (className != null) {
            element.classList.add(className);
        }
        element.style = null;
    }

    var cellsCollection = document.getElementsByTagName('td');

    var cellsCollectionArray = Array.from(cellsCollection)
        .filter(x => x.classList.length != 0).sort((a, b) =>
            a.getElementsByClassName('atomicNumber')[0].textContent -
            b.getElementsByClassName('atomicNumber')[0].textContent);

    var inputField = document.getElementsByClassName('yearInput')[0];

    //TODO: -> structure
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
    //

    var select = document.getElementById('seeItemsList');

    select
    .addEventListener('change', function (event) {
          event.preventDefault();

          var selectedIndex = select.selectedIndex;
          var selectedOption = select.options[selectedIndex].id;
          inputField.style.display = 'none';

          for (var i = 0; i < cellsCollectionArray.length; i++) {

                var currentCell = cellsCollectionArray[i];

                if (selectedOption == 'seeAtomicNumber') {

                    var chemicalType = chemicalTypeNames[i]
                        .map(x => String.fromCharCode(x)).join('');

                    UpdateElement(currentCell, null);

                    for (var j = 0; j < chemicalType.split(' ').length; j++) { 
                        currentCell.classList.add(chemicalType.split(' ')[j]);
                    }
                }

                else if (selectedOption == 'seeAtomicMass') {
 
                    var mass = atomicMasses[i] * 0.60;  
                
                    UpdateElement(currentCell, 'hasAtomicMass');
                

                    currentCell.style.backgroundColor = `rgba(115, ${235 - mass}, 255)`;

                    currentCell.style.border = `3px solid rgba(115, ${160 - mass}, 255)`;
                }

                else if (selectedOption == 'seePhysicalAppearance') {

                    var state = states[i]
                        .map(x => String.fromCharCode(x)).join('');

                    UpdateElement(currentCell, state);
                }

                else if (selectedOption == 'seeAtomicRadius') {

                    var atomicRadius = parseFloat(atomicRadiuses[i]) / parseFloat(5);

                    UpdateElement(currentCell, 'hasAtomicRadius');

                    if (atomicRadius > 0) {
                        currentCell.style.backgroundColor = `rgba(0, ${atomicRadius * 2.5}, 70)`;

                        currentCell.style.border = `3px solid rgba(0, ${atomicRadius * 2.5}, 60)`;
                    }
                    else {

                        currentCell.style.backgroundColor = `rgba(0, 62, 70)`;

                        currentCell.style.border = `3px solid rgba(0, 52, 60)`;
                    }
                }

                else if (selectedOption == 'seeMeltingPoint') {

                    var meltingPoint = parseFloat(meltingPoints[i]) / parseFloat(31);

                    UpdateElement(currentCell, 'hasMeltingPoint');

                    currentCell.style.backgroundColor = `rgba(${meltingPoint * 2.5}, 30, 70)`;

                    currentCell.style.border = `3px solid rgba(${meltingPoint * 4}, 30, 60)`;
                }

                else if (selectedOption == 'seeBoilingPoint') {
                var boilingPoint = parseFloat(boilingPoints[i]) / parseFloat(31);

                UpdateElement(currentCell, 'hasBoilingPoint');

                currentCell.style.backgroundColor = `rgba(${boilingPoint}, 0, 0)`;

                currentCell.style.border = `3px solid rgba(${boilingPoint * 0.6}, 0, 0)`;
            }

                else if (selectedOption == 'seeByYear') {
                    inputField.style.display = 'inline-block';
                    break;
                } 
            }
    });

    inputField.addEventListener('focus', function (event) {
        for (var i = 0; i < cellsCollectionArray.length; i++) {
            var chemicalType = chemicalTypeNames[i]
                .map(x => String.fromCharCode(x)).join('');

            var currentCell = cellsCollectionArray[i];

            UpdateElement(currentCell, null);

            for (var j = 0; j < chemicalType.split(' ').length; j++) {
                currentCell.classList.add(chemicalType.split(' ')[j]);
            }
        }
    });

    inputField.addEventListener('blur', function (event) {
        event.preventDefault();

        var yearValue = inputField.value;

        if (!yearValue || yearValue < 0 || yearValue > 2024) {
            var errorDiv = document.getElementsByClassName('errorDiv')[0];
            errorDiv.style.display = 'block';

            setTimeout(function () {
                errorDiv.style.display = 'none';
            }, 3000);
        }
        else {
            for (var i = 0; i < cellsCollectionArray.length; i++) {
                var currYear = years[i];
                if (currYear > yearValue) {
                    var cell = cellsCollectionArray[i];
                    UpdateElement(cell, 'hasYear');
                }
            }
        }
    });
}
