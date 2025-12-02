const questions = document.querySelectorAll('.question');
let currentQuestion = 0;
let score = 0;

// Load JSON
fetch(quizFile)
    .then(res => res.json())
    .then(data => {
        questions = data;
        showQuestion();
    });

// Show a question
function showQuestion() {
    const q = questions[currentQuestion];
    let html = `<div class="question active">
                <h2>${currentQuestion + 1}) ${q.question}</h2>
                <ul class="options">`;

    for (const key in q.options) {
        const type = q.multiple ? 'checkbox' : 'radio';
        html += `<li><label>
               <input type="${type}" name="q${currentQuestion}" value="${key}"> ${q.options[key]}
             </label></li>`;
    }

    html += `</ul>
           <button onclick="checkAnswer()">Next</button>
           </div>`;

    html += `<div id="result"></div>`;

    quizContainer.innerHTML = html;
}

function checkAnswer(questionIndex, mc = false) {
    resetResult();
    let success = true;
    const question = questions[questionIndex];
    const selected = Array.from(question.querySelectorAll('input:checked'));

    if (selected.length === 0) {
        alert('Please select an answer before proceeding.');
        return;
    }

    if (mc) {
        const correct = question.getAttribute('data-answer').split(',');
        const userAnswers = selected.map(input => input.value).sort();
        if (JSON.stringify(correct.sort()) === JSON.stringify(userAnswers)) score += 1;
        else success = false;
    } else {
        const userAnswer = selected[0].value;
        const correctAnswer = question.getAttribute('data-answer');
        if (userAnswer === correctAnswer) score++;
        else success = false;
    }

    if (!success) {
        displayError();
        return;
    }

    showNextQuestion();
}

function showNextQuestion() {
    questions[currentQuestion].classList.remove('active');
    currentQuestion++;
    if (currentQuestion < questions.length) {
        questions[currentQuestion].classList.add('active');
    } else {
        displayResult();
    }
}

function displayResult() {
    const resultDiv = document.getElementById('result');
    resultDiv.innerHTML = `<h2>Your Score: ${score} / ${questions.length}</h2>`;
}

function displayError() {
    const resultDiv = document.getElementById('result');
    resultDiv.innerHTML = `<p style="color: red;">Incorrect answer. Please try again.</p>`;
}

function resetResult() {
    const resultDiv = document.getElementById('result');
    resultDiv.innerHTML = '';
}