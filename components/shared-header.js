class SharedHeader extends HTMLElement {
    constructor() {
        super();
        // Attach Shadow DOM
        this.attachShadow({ mode: 'open' });
    }

    connectedCallback() {
        const root = this.getAttribute("root") || "";

        const style = document.createElement("style");
        style.textContent = `
        @import url('${root}styles.css');

        /* Header container */
        header {
            background: linear-gradient(90deg, var(--secondary-color), var(--tertiary-color));
            padding: 2em 2.5em;
            display: flex;
            justify-content: space-between;
            align-items: center;
            box-shadow: 0 0.2em 0.5em rgba(0, 0, 0, 0.5);
            max-width: 100%;
        }

        /* Site title */
        .site-title {
            font-size: 1.5rem;
            font-weight: bold;
            margin-right: 1rem;
            color: var(--main-bg-color);
            letter-spacing: 0.05rem;
            text-transform: uppercase;
            text-decoration: none;
        }

        /* Navigation links */
        nav a {
            text-decoration: none;
            color: var(--main-font-color);
            margin-left: 2rem;
            font-size: 1rem;
            position: relative;
            transition: color 0.3s;
        }

        /* Hover effect for links */
        nav a:hover {
            color: var(--highlight-color);
        }

        /* Underline animation */
        nav a::after {
            content: "";
            display: block;
            height: 0.1rem;
            background: var(--highlight-color);
            width: 0;
            transition: width 0.3s;
            position: absolute;
            bottom: -0.5rem;
            left: 0;
        }

        nav a:hover::after {
            width: 100%;
        }

        /* Hamburger Menu */
        .hamburger {
            display: none;
            flex-direction: column;
            cursor: pointer;
            gap: 0.3em;
        }

        .hamburger div {
            width: 25px;
            height: 3px;
            background: var(--tertiary-color);
            transition: 0.3s;
        }
        `;

        // Component HTML
        const wrapper = document.createElement("header");
        wrapper.innerHTML = `
            <a class="site-title" href="${root}index.html">USTP Carepackage</a>
            <!--<nav>
                <a href="index.html">1. Semester</a>
                <a href="index.html">2. Semester</a>
                <a href="index.html">3. Semester</a>
                <a href="index.html">4. Semester</a>
                <a href="index.html">5. Semester</a>
                <a href="index.html">6. Semester</a>
            </nav>-->`;

        this.shadowRoot.appendChild(style);
        this.shadowRoot.appendChild(wrapper);
    }
}
customElements.define('shared-header', SharedHeader);