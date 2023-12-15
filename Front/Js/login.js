const urlAuth = "http://localhost:5094/api/User/token";
const headers = new Headers({ 'Content-Type': 'application/json' });
const boton = document.getElementById('botonlogin');

boton.addEventListener("click", function (e) {
    e.preventDefault();
    autorizarUsuario();
});

async function autorizarUsuario() {
    let inputUsuario = document.getElementById('username').value;
    let inputPassword = document.getElementById('password').value;

    let data = {
        "nombre": inputUsuario,
        "password": inputPassword
    };

    const config = {
        method: 'POST',
        headers: headers,
        body: JSON.stringify(data)
    };

    try {
        const response = await fetch(urlAuth, config);
    
        if (response.ok) {
            console.log(response) 
            window.location.href = "../html/catalogo.html";
        } else {
            const errorData = await response.json();
            console.log(errorData);
            alert("Autenticación fallida, verifique sus credenciales o regístrese.");
        }
    } catch (error) {
        console.error("Error al realizar la autenticación:", error);
    }
}