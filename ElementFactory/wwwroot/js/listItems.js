function PageSettings(model) {
    var isPopUpContainerShown = false;

    function CreateDOMElement(tagName, parent, id) {
        var element = document.createElement(tagName);
        element.id = id;
        parent.appendChild(element);
        return element;
    }

    function UpdateElement(element, className) {
        element.classList = [];
        if (className != null) {
            element.classList.add(className);
        }
        element.style = null;
    }

    function ShowElementError(number) {
        var errorDiv = document.getElementsByClassName(`errorDiv${number}`)[0];
        errorDiv.style.display = 'block';

        setTimeout(function () {
            errorDiv.style.display = 'none';
        }, 3000);
    }

    function CreateTableRows(number, table, textContent, elementProperty) {

        var tr = CreateDOMElement('tr', table, `popUpTr${number}`);

        var th = CreateDOMElement('th', tr, `popUpTh${number}`);

        var p = CreateDOMElement('p', th, `popUpP${number}`);
        p.textContent = textContent;

        var td = CreateDOMElement('td', tr, `popUpTd${number}`);

        var p1 = CreateDOMElement('p', td, `popUpP${number + 1}`);
        p1.textContent = elementProperty;
    }

    function PopulateTable(table, currentElement, counter) {

        //First Row
        CreateTableRows(counter, table, 'Агрегатно състояние:', currentElement.State);
        counter += 2;

        //Second Row
        CreateTableRows(counter, table, 'Период:', currentElement.Period);
        counter += 2;

        //Third Row
        CreateTableRows(counter, table, 'Група:', currentElement.Group);
        counter += 2;

        //Fourth Row
        CreateTableRows(counter, table, 'Електроотрицателност:', currentElement.Electronegativity);
        counter += 2;

        //Fifth Row
        CreateTableRows(counter, table, 'Атомна Маса:', currentElement.AtomicMass);
        counter += 2;

        //Sixth Row
        CreateTableRows(counter, table, 'Атомен Радиус:', currentElement.AtomicRadius);
        counter += 2;

        //Seventh Row
        CreateTableRows(counter, table, 'Плътност:', currentElement.Density);
        counter += 2;

        //Eighth Row
        CreateTableRows(counter, table, 'Температура на топене:', currentElement.MeltingPoint);
        counter += 2;

        //Ninth Row
        CreateTableRows(counter, table, 'Температура на кипене:', currentElement.BoilingPoint);
        counter += 2;

        //Tenth Row
        CreateTableRows(counter, table, 'Електронни Слоеве:', currentElement.ElectronicLayers);
        counter += 2;

        //Eleventh Row
        if (currentElement.IsRadioactive) {
            CreateTableRows(counter, table, 'Радиоктивен:', 'Да');
        }
        else {
            CreateTableRows(counter, table, 'Радиоктивен:', 'Не');
        }
        counter += 2;

        //Twelfth Row
        if (currentElement.IsSynthetic) {
            CreateTableRows(counter, table, 'Синтетичен:', 'Да');
        }
        else {
            CreateTableRows(counter, table, 'Синтетичен:', 'Не');
        }
    }

    function AddListenerToCell(currentCell, currentElement) {

        currentCell.addEventListener('click', function (event) {
            event.preventDefault();
            if (!isPopUpContainerShown) {

                var body = document.getElementsByTagName('body')[0]; var popUpContainerOverlay = CreateDOMElement('div', body, 'popUpContainerOverlay');

                var popUpContainer = CreateDOMElement('div', popUpContainerOverlay, 'popUpContainer');

                var main = CreateDOMElement('main', popUpContainer, 'popUpMain');

                var xMark = CreateDOMElement('a', main, 'xMark');
                xMark.textContent = 'X';

                xMark.addEventListener('click', function (event2) {
                    event2.preventDefault();
                    body.removeChild(popUpContainerOverlay);
                    isPopUpContainerShown = false;
                });

                isPopUpContainerShown = true;

                var header = CreateDOMElement('header', main, 'popUpHeader');

                var article1 = CreateDOMElement('article', header, 'popUpArticle1');

                article1.textContent = 'Свойства на елемента';

                var article2 = CreateDOMElement('article', main, 'popUpArticle2');

                var section1 = CreateDOMElement('section', article2, 'popUpSection1');

                var elementClasses = Array.from(currentCell.classList);

                for (var i = 0; i < elementClasses.length; i++) {
                    var currentClass = elementClasses[i];
                    section1.classList.add(currentClass);
                }

                section1.style.backgroundColor = currentCell.style.backgroundColor;
                section1.style.border = currentCell.style.border;

                var h2_1 = CreateDOMElement('h2', section1, 'popUpH2_1');
                h2_1.textContent = currentElement.AtomicNumber;

                var h1_1 = CreateDOMElement('h1', section1, 'popUpH1_1');
                h1_1.textContent = currentElement.Symbol;

                var p1 = CreateDOMElement('p', section1, 'popUpP1');
                p1.textContent = currentElement.Name;

                var p2 = CreateDOMElement('p', section1, 'popUpP2');
                p2.textContent = currentElement.ChemicalType.Name;

                var section2 = CreateDOMElement('section', article2, 'popUpSection2');

                var table = CreateDOMElement('table', section2, 'popUpTable');

                PopulateTable(table, currentElement, 3);
            }
        })
    }

    function CreatePopUpMenu(cellsCollectionArray, values) {

        for (var i = 0; i < cellsCollectionArray.length; i++) {

            var currentCell = cellsCollectionArray[i];

            var currentElement = values[i];

            AddListenerToCell(currentCell, currentElement, isPopUpContainerShown);
        }
    }

    function CreateEventListeners(cellsCollectionArray, values, select,
        yearInputField, elementInputField, darkModeBtn) {

        select.addEventListener('change', function (event) {
            event.preventDefault();

            var selectedIndex = select.selectedIndex;
            var selectedOption = select.options[selectedIndex].id;
            yearInputField.style.display = 'none';
            elementInputField.style.display = 'none';

            for (var i = 0; i < cellsCollectionArray.length; i++) {

                var currentCell = cellsCollectionArray[i];
                var currentValue = values[i];

                if (selectedOption == 'seeAtomicNumber') {

                    var chemicalType = currentValue.ChemicalType.Name;
                    UpdateElement(currentCell, null);

                    for (var j = 0; j < chemicalType.split(' ').length; j++) {
                        currentCell.classList.add(chemicalType.split(' ')[j]);
                    }
                }

                else if (selectedOption == 'seeAtomicMass') {

                    var mass = currentValue.AtomicMass * 0.60;

                    UpdateElement(currentCell, 'hasAtomicMass');

                    currentCell.style.backgroundColor = `rgba(115, ${235 - mass}, 255)`;

                    currentCell.style.border = `3px solid rgba(115, ${160 - mass}, 255)`;
                }

                else if (selectedOption == 'seePhysicalAppearance') {

                    var state = currentValue.State;

                    UpdateElement(currentCell, state);
                }

                else if (selectedOption == 'seeAtomicRadius') {

                    var atomicRadius = parseFloat(currentValue.AtomicRadius) / parseFloat(5);

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

                    var meltingPoint = parseFloat(currentValue.MeltingPoint) / parseFloat(31);

                    UpdateElement(currentCell, 'hasMeltingPoint');

                    currentCell.style.backgroundColor = `rgba(${meltingPoint * 2.5}, 30, 70)`;

                    currentCell.style.border = `3px solid rgba(${meltingPoint * 4}, 30, 60)`;
                }

                else if (selectedOption == 'seeBoilingPoint') {
                    var boilingPoint = parseFloat(currentValue.BoilingPoint) / parseFloat(31);

                    UpdateElement(currentCell, 'hasBoilingPoint');

                    currentCell.style.backgroundColor = `rgba(${boilingPoint}, 0, 0)`;

                    currentCell.style.border = `3px solid rgba(${boilingPoint * 0.6}, 0, 0)`;
                }

                else if (selectedOption == 'seeByYear') {
                    yearInputField.style.display = 'inline-block';
                    break;
                }

                else if (selectedOption == 'seeByName') {
                    elementInputField.style.display = 'inline-block';
                    break;
                }
            }

        });

        yearInputField.addEventListener('focus', function (event) {
            for (var i = 0; i < cellsCollectionArray.length; i++) {
                var chemicalType = values[i].ChemicalType.Name;

                var currentCell = cellsCollectionArray[i];

                UpdateElement(currentCell, null);

                for (var j = 0; j < chemicalType.split(' ').length; j++) {
                    currentCell.classList.add(chemicalType.split(' ')[j]);
                }
            }
        });

        yearInputField.addEventListener('blur', function (event) {
            event.preventDefault();

            var yearValue = yearInputField.value;

            if (!yearValue || yearValue == '' || yearValue == ' ' || yearValue < 0 || yearValue > 2024) {
                ShowElementError(1);
            }
            else {
                for (var i = 0; i < cellsCollectionArray.length; i++) {
                    var currYear = values[i].YearFound;

                    if (currYear > yearValue) {
                        var cell = cellsCollectionArray[i];
                        UpdateElement(cell, 'hasNotYear');
                    }
                }
            }
        });

        elementInputField.addEventListener('focus', function (event) {
            for (var i = 0; i < cellsCollectionArray.length; i++) {
                var chemicalType = values[i].ChemicalType.Name;

                var currentCell = cellsCollectionArray[i];

                UpdateElement(currentCell, null);

                for (var j = 0; j < chemicalType.split(' ').length; j++) {
                    currentCell.classList.add(chemicalType.split(' ')[j]);
                }
            }
        });

        elementInputField.addEventListener('blur', function (event) {
            event.preventDefault();

            var elementIsFound = false;
            var elementValue = elementInputField.value;

            if (!elementInputField || elementInputField == '' || elementInputField == ' ') {
                ShowElementError(2);
            }
            else {
                for (var i = 0; i < cellsCollectionArray.length; i++) {
                    var currName = values[i].Name;

                    if (currName == elementValue) {
                        elementIsFound = true;
                        break;
                    }
                }
            }

            if (elementIsFound == false) {
                ShowElementError(2);
            }
            else {
                for (var i = 0; i < cellsCollectionArray.length; i++) {
                    var cell = cellsCollectionArray[i];
                    UpdateElement(cell, 'hasNotName');
                }
            }
        });

        darkModeBtn.addEventListener('click', function (event) {
            event.preventDefault();
            var textContent = darkModeBtn.textContent;
            var header = document.querySelector('body > header');
            if (textContent == 'Dark Mode') {
                darkModeBtn.textContent = 'Light Mode';
                UpdateElement(darkModeBtn, 'lightModeBtn');
                UpdateElement(header, 'darkModeHeader');
            }
            else {
                darkModeBtn.textContent = 'Dark Mode';
                UpdateElement(darkModeBtn, 'darkModeBtn');
                UpdateElement(header, 'lightModeHeader');
            }
        });
    }

    var values = Array.from(model);
    var select = document.getElementById('seeItemsList');

    var cellsCollection = document.getElementsByTagName('td');

    var cellsCollectionArray = Array.from(cellsCollection)
        .filter(x => x.classList.length != 0).sort((a, b) =>
        a.getElementsByClassName('atomicNumber')[0].textContent -
        b.getElementsByClassName('atomicNumber')[0].textContent);

    var yearInputField = document.getElementsByClassName('yearInput')[0];
    var elementInputField = document.getElementsByClassName('elementInput')[0];
    var darkModeBtn = document.getElementsByClassName('darkModeBtn')[0];

    CreatePopUpMenu(cellsCollectionArray,values);
   
    CreateEventListeners(cellsCollectionArray, values,
        select, yearInputField, elementInputField, darkModeBtn);
}
