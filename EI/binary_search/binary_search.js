// 3	4	14	28	29	31	 33	 35
//5, 12, 17, 23, 38, 41, 47, 52, 59
function binarySearch() {
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

    const searchTermInput = document.getElementById("search-term")
    let searchTerm = parseInt(searchTermInput.value)

    let step = 0
    let high = lst.length - 1
    let low = 0

    resElem.innerHTML += (`<h3>Schritt ${step}:</h3>`)
    resElem.innerHTML += (`<p style="margin-left:2em">Liste: ${lst}</p>`)
    resElem.innerHTML += (`<p style="margin-left:2em">Gesuchter Wert: ${searchTerm}</p>`)
    resElem.innerHTML += (`<hr>`)

    let searchLst = lst.slice()

    while (true) {
        step++
        if (step > 15) break
        resElem.innerHTML += (`<h3>Schritt ${step}:</h3>`)

        let mid = Math.floor((low + high) / 2)
        let new_lst = []
        resElem.innerHTML += (`<p style="margin-left:2em">Low = ${low}, High = ${high}, Mid = (${low} + ${high}) / 2 = ${mid}</p>`)
        resElem.innerHTML += (`<p style="margin-left:2em">Suchindex: ${mid}</p>`)

        if (searchTerm === lst[mid]) {
            resElem.innerHTML += (`<h3>Gefunden!</h3>`)
            return null
        } else if (searchTerm < lst[mid]) {
            new_lst = lst.slice(low, mid)
            resElem.innerHTML += (`<p style="margin-left:2em">Suche links weiter...</p>`)
            high = mid - 1
        } else {
            mid++
            new_lst = lst.slice(mid)
            resElem.innerHTML += (`<p style="margin-left:2em">Suche rechts weiter...</p>`)
            low = mid
        }

        resElem.innerHTML += (`<p style="margin-left:2em">Neue Liste: ${new_lst}</p>`)

        if (!res) {
            resElem.innerHTML += (`<hr>`)
            break
        }

        console.log(searchLst)

        if (new_lst.length === 0) {
            resElem.innerHTML += (`<h3> ${searchTerm} nicht in der Liste enthalten! </h3>`)
            break
        }

        resElem.innerHTML += (`<hr>`)
    }
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