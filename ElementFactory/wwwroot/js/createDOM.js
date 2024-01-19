window.CreateDOMElement = function CreateDOMElement(tagName, parent, id) {
    var element = document.createElement(tagName);
    element.id = id;
    parent.appendChild(element);
    return element;
}

window.CreateTableRows = function CreateTableRows(number, table, textContent, elementProperty) {

    var tr = CreateDOMElement('tr', table, `popUpTr${number}`);

    var th = CreateDOMElement('th', tr, `popUpTh${number}`);

    var p = CreateDOMElement('p', th, `popUpP${number}`);
    p.textContent = textContent;

    var td = CreateDOMElement('td', tr, `popUpTd${number}`);

    var p1 = CreateDOMElement('p', td, `popUpP${number + 1}`);
    p1.textContent = elementProperty;
}

window.PopulateTable = function PopulateTable(table, currentElement, counter) {

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