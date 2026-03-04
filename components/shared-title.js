class SharedTitle extends HTMLElement {
    constructor() {
        super();
        // Attach Shadow DOM
        this.attachShadow({ mode: 'open' });
    }

    connectedCallback() {
        const title = this.getAttribute("title") || "My Site";
        const showBack = this.getAttribute("showBack") === "true";
        const root = this.getAttribute("root") || ".";

        const style = document.createElement("style");
        style.textContent = `
        @import url('https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css');
        @import url('${root}styles.css');

        .back-arrow {
            margin-top: 1em;
            width: 100%;
        }

        .back-btn {
            gap: 0.4em;
            padding: 0em 0.8em;
            border-radius: 0.5em;
            text-decoration: none;
            color: var(--tertiary-color);
        }

        .title {
            text-align: center;
            font-size: 2rem;
            margin: 0;
        }
        `;

        // Component HTML
        const wrapper = document.createElement("div");
        wrapper.classList.add("back-arrow")
        wrapper.innerHTML = `
                ${showBack ? `<a href="javascript:history.back()" class="back-btn"><i class="fa-solid fa-arrow-left"></i> Back</a>` : ""}
                <h1 class="title">${title}</h1>`;

        this.shadowRoot.appendChild(style);
        this.shadowRoot.appendChild(wrapper);
    }
}
customElements.define('shared-title', SharedTitle);