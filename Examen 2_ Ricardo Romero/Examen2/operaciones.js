let pacientes = JSON.parse(localStorage.getItem("pacientes")) || [];


function cargarPacientes() {
    let tabla = document.getElementById("tabla-pacientes");
    tabla.innerHTML = "";

    pacientes.forEach((paciente, index) => {
        let fila = `
            <tr>
                <td>${paciente.nombre}</td>
                <td>${paciente.edad}</td>
                <td>${paciente.telefono}</td>
                <td>
                    <button onclick="eliminarPaciente(${index})">Eliminar</button>
                </td>
            </tr>
        `;
        tabla.innerHTML += fila;
    });
}

function mostrarFormulario() {
    document.getElementById("formulario").style.display = "flex";
}

function cerrarFormulario() {
    document.getElementById("formulario").style.display = "none";
}

function agregarPaciente() {
    let nombre = document.getElementById("nombre").value;
    let edad = document.getElementById("edad").value;
    let telefono = document.getElementById("telefono").value;

    if (nombre && edad && telefono) {
        pacientes.push({ nombre, edad, telefono });
        localStorage.setItem("pacientes", JSON.stringify(pacientes));
        cargarPacientes();
        cerrarFormulario();
    } else {
        alert("Todos los campos son obligatorios.");
    }
}

function eliminarPaciente(index) {
    pacientes.splice(index, 1);
    localStorage.setItem("pacientes", JSON.stringify(pacientes));
    cargarPacientes();
}
cargarPacientes();