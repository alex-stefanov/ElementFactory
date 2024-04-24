//Getting the buttonElements
let atomicReactionButtonElement = document.getElementById("chemical-animation-primary");
let flamesReactionButtonElement = document.getElementById("chemical-animation-danger");

//Getting the div with all the buttons
let allButtonsDivElement = document.getElementById("chemical-animation-allButtons");

//Getting the canvas
let canvas = document.getElementById("chemical-animation-canvas");

//Event Listener for atomic reactions
atomicReactionButtonElement.addEventListener("click", () => {
    let formElement = document.getElementById("atomic-reaction-form");
    formElement.submit();   
});

//Event Listener for flame reactions
flamesReactionButtonElement.addEventListener("click", () => {

    clearButtonsAndMakeCanvasVisibale();


    //Initial data
    const ctx = canvas.getContext('2d');

    let window_height = window.innerHeight;
    let window_width = window.innerWidth;
    canvas.width = window_width;
    canvas.height = window_height;

    //Classes
    class Particle {
        constructor(x, y, color, speedY) {
            this.x = x;
            this.y = y;
            this.color = color;
            this.radius = Math.random() * 3 + 2;
            this.speedY = speedY;
        }

        update(element) {
            this.y -= this.speedY / 3;
            if (Math.random() > 0.5) {
                this.x -= this.speedY / 1.2;
            } else {
                this.x += this.speedY / 1.2;
            }
            if (element && this.x > element.x && this.x < element.x + element.width &&
                this.y > element.y && this.y < element.y + element.height) {
                this.color = element.flameColor;
            }
            ctx.beginPath();
            ctx.arc(this.x, this.y, this.radius, 0, Math.PI * 2);
            ctx.fillStyle = this.color;
            ctx.fill();
            ctx.closePath();

        }
    }

    class Torch {
        constructor(x, y, width, height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.flameColor = '#000080';
        }

        draw() {
            ctx.beginPath();
            ctx.rect(this.x - this.width / 2, this.y - this.height, this.width, this.height);
            ctx.fillStyle = '#000080';
            ctx.fill();
            ctx.closePath();

            for (let i = 0; i < 30; i++) {
                const x = this.x + Math.random() * 20 - 10;
                const y = this.y - this.height + Math.random() * 30;
                const speedY = Math.random() * 2 + 1;
                const color = this.flameColor;
                const particle = new Particle(x, y, color, speedY);
                particle.update();
            }
        }
    }

    class Element {
        constructor(x, y, width, height, color, text, flameColor) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            this.text = text;
            this.flameColor = flameColor;
            this.isDragging = false;
        }

        draw() {
            ctx.beginPath();
            ctx.rect(this.x, this.y, this.width, this.height);
            ctx.fillStyle = this.color;
            ctx.fill();

            ctx.textAlign = "center";
            ctx.textBaseline = "middle";
            ctx.font = "18px Arial";
            ctx.fillStyle = 'black';
            ctx.fillText(this.text, this.x + this.width / 2, this.y + this.height / 2);
            ctx.closePath();

        }

        isPointInside(x, y) {
            return x > this.x && x < this.x + this.width && y > this.y && y < this.y + this.height;
        }
    }

    //Busisness logic
    let particles = [];
    const torch = new Torch(canvas.width / 2, canvas.height, 70, 170);

    let Al = new Element(window_width / 8, window_height / 6, 100, 100, '#848789', 'Al', '#C0C0C0');

    let Cu = new Element(window_width / 8, window_height / 3, 100, 100, '#b87333', 'Cu', '#98FB98');

    let In = new Element(window_width / 8, window_height / 2, 100, 100, '#818589', 'In', '#330099');

    let Mg = new Element(window_width / 8, window_height / 1.5, 100, 100, '#c1c2c3', 'Mg', '#F8F9FA');

    let K = new Element(window_width * 0.8, window_height / 6, 100, 100, '#ffc7c6', 'K', '#C8A2C8');

    let Li = new Element(window_width * 0.8, window_height / 3, 100, 100, '#E5E4E2', 'Li', '#ff0038');

    let Sn = new Element(window_width * 0.8, window_height / 2, 100, 100, '#d3d4d5', 'Sn', '#9bbdd7');

    let Fe = new Element(window_width * 0.8, window_height / 1.5, 100, 100, '#a19d94', 'Fe', '#d4af37');
    animate();

    //Main function
    function animate() {
        requestAnimationFrame(animate);
        ctx.clearRect(0, 0, canvas.width, canvas.height);

        torch.draw();

        particles.forEach((particle, index) => {
            particle.update(Al);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(Cu);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(In);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(Mg);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(K);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(Li);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(Sn);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        particles.forEach((particle, index) => {
            particle.update(Fe);
            if (particle.y < 0) {
                particles.splice(index, 1);
            }
        });

        if (Al) {
            Al.draw();
        }
        if (Cu) {
            Cu.draw();
        }
        if (In) {
            In.draw();
        }
        if (Mg) {
            Mg.draw();
        }
        if (K) {
            K.draw();
        }
        if (Li) {
            Li.draw();
        }
        if (Sn) {
            Sn.draw();
        }
        if (Fe) {
            Fe.draw();
        }
    }

    //Repeatable action
    setInterval(() => {
        const x = torch.x;
        const y = torch.y - torch.height - 40 + Math.random() * 30;
        const color = `rgba(255, ${Math.random() * 100}, 0, 1)`;
        const speedY = Math.random() * 2 + 1;
        const particle = new Particle(x, y, color, speedY);
        particles.push(particle);
    }, 7);

    //Event listeners for dragging the element
    canvas.addEventListener('mousedown', (event) => {
        const mouseX = event.clientX - canvas.getBoundingClientRect().left;
        const mouseY = event.clientY - canvas.getBoundingClientRect().top;

        if (Al && Al.isPointInside(mouseX, mouseY)) {
            Al.isDragging = true;
        }

        if (Cu && Cu.isPointInside(mouseX, mouseY)) {
            Cu.isDragging = true;
        }

        if (In && In.isPointInside(mouseX, mouseY)) {
            In.isDragging = true;
        }

        if (Mg && Mg.isPointInside(mouseX, mouseY)) {
            Mg.isDragging = true;
        }

        if (K && K.isPointInside(mouseX, mouseY)) {
            K.isDragging = true;
        }

        if (Li && Li.isPointInside(mouseX, mouseY)) {
            Li.isDragging = true;
        }

        if (Sn && Sn.isPointInside(mouseX, mouseY)) {
            Sn.isDragging = true;
        }

        if (Fe && Fe.isPointInside(mouseX, mouseY)) {
            Fe.isDragging = true;
        }
    });

    canvas.addEventListener('mousemove', (event) => {
        const mouseX = event.clientX - canvas.getBoundingClientRect().left;
        const mouseY = event.clientY - canvas.getBoundingClientRect().top;

        if (Al && Al.isDragging) {
            Al.x = mouseX - Al.width / 2;
            Al.y = mouseY - Al.height / 2;
        }

        if (Cu && Cu.isDragging) {
            Cu.x = mouseX - Cu.width / 2;
            Cu.y = mouseY - Cu.height / 2;
        }

        if (In && In.isDragging) {
            In.x = mouseX - In.width / 2;
            In.y = mouseY - In.height / 2;
        }

        if (Mg && Mg.isDragging) {
            Mg.x = mouseX - Mg.width / 2;
            Mg.y = mouseY - Mg.height / 2;
        }

        if (K && K.isDragging) {
            K.x = mouseX - K.width / 2;
            K.y = mouseY - K.height / 2;
        }

        if (Li && Li.isDragging) {
            Li.x = mouseX - Li.width / 2;
            Li.y = mouseY - Li.height / 2;
        }

        if (Sn && Sn.isDragging) {
            Sn.x = mouseX - Sn.width / 2;
            Sn.y = mouseY - Sn.height / 2;
        }

        if (Fe && Fe.isDragging) {
            Fe.x = mouseX - Fe.width / 2;
            Fe.y = mouseY - Fe.height / 2;
        }
    });

    canvas.addEventListener('mouseup', () => {
        if (Al) {
            Al.isDragging = false;
        }

        if (Cu) {
            Cu.isDragging = false;
        }

        if (In) {
            In.isDragging = false;
        }

        if (Mg) {
            Mg.isDragging = false;
        }

        if (K) {
            K.isDragging = false;
        }

        if (Li) {
            Li.isDragging = false;
        }

        if (Sn) {
            Sn.isDragging = false;
        }

        if (Fe) {
            Fe.isDragging = false;
        }
    });
});

//Functions
function clearButtonsAndMakeCanvasVisibale() {
    allButtonsDivElement.style.display = "none";
    canvas.style.display = "block";
}