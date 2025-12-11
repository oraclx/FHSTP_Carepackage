function bubbleSort() {
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

    let n = lst.length;
    let swapped;
    let step = 0
    resElem.innerHTML += (`<h3>Schritt ${step++}:</h3>`)
    resElem.innerHTML += (`<p style="margin-left:2em">${formatList(lst)}</p>`)

    do {
        swapped = false;
        for (let i = 0; i < n - 1; i++) {
            resElem.innerHTML += (`<h3>Schritt ${step++}:</h3>`)
            if (lst[i] > lst[i + 1]) {
                let temp = lst[i];
                lst[i] = lst[i + 1];
                lst[i + 1] = temp;
                swapped = true;
                resElem.innerHTML += (`<p style="margin-left:2em">${temp} (${i}) <-> ${lst[i]} (${i + 1})</p>`)
            }
            resElem.innerHTML += (`<p style="margin-left:2em">${formatList(lst)}</p>`)
        }
        n--;
    } while (swapped);
}

function formatList(lst) {
    out = ""
    for (let i = 0; i < lst.length; i++) {
        if (i < lst.length - 1) out += `${lst[i]} `
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