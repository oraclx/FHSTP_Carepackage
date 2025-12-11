function quickSort(lst, pivotChoice, step, resElem) {
    if (lst.length <= 1) {
        return lst; // Basisfall: Ein-Element-Arrays sind schon sortiert
    }

    resElem.innerHTML += (`<h3>Schritt ${step}:</h3>`)

    let pivotIdx = -1;

    if (pivotChoice == "first") {
        pivotIdx = 0
    } else if (pivotChoice == "last") {
        pivotIdx = lst.length - 1
    }

    if (pivotIdx == -1) {
        return null
    }

    const pivot = lst[pivotIdx]; // Pivot ist das erste Element
    const left = [];
    const right = [];

    resElem.innerHTML += (`<p style="margin-left:2em">Pivot Element: ${pivot}</p>`)

    for (let i = 1; i < lst.length; i++) { // Beginne bei 1, da 0 das Pivot ist
        if (lst[i] < pivot) {
            left.push(lst[i]);
        } else {
            right.push(lst[i]);
        }
    }

    resElem.innerHTML += (`<p style="margin-left:2em">A: ${formatList(left)}</p>`)
    resElem.innerHTML += (`<p style="margin-left:2em">B: ${formatList(right)}</p>`)

    return [...quickSort(left, pivotChoice, step + 1, resElem), pivot, ...quickSort(right, pivotChoice, step + 1, resElem)];
}

function sort() {
    const resElem = document.getElementById("res")
    resElem.innerHTML = ""

    const selected = document.querySelector('#settings input[name="sep"]:checked')
    let sep = selected.value
    if (selected.value === 't') {
        sep = '\t'
    }

    const lstInput = document.getElementById("list-input")
    let lst = lstInput.value.trim().split(sep)
    lst = lst.map(e => e.trim())
    lst = lst.map(e => parseInt(e))

    resElem.innerHTML += (`<h3>Schritt ${0}:</h3>`)
    resElem.innerHTML += (`<p style="margin-left:2em">${formatList(lst)}</p>`)

    const pivotChoice = document.querySelector('#settings input[name="pivot"]:checked')
    quickSort(lst, pivotChoice.value, 1, resElem)
}

function formatList(lst) {
    out = ""
    for (let i = 0; i < lst.length; i++) {
        if (i < lst.length - 1) out += `${lst[i]},`
        else out += `${lst[i]}`
    }
    return out
}

function clearInputs() {
    const inputs = document.querySelectorAll("input[type='text']")
    console.log("btn clicked!")
    inputs.forEach(input => input.value = "")

    const radios = document.querySelectorAll("input[type='radio']")
    radios.forEach(radio => radio.checked = false)

    const resElem = document.getElementById("res")
    resElem.innerHTML = ""
}