// patients.js
const getAllPatientUrl = 'http://localhost:5097/api/MyApp/GetAllPatient'; // URL вашего API
const getPatientUrl = 'http://localhost:5097/api/MyApp/'; // URL вашего API
const updatePatientApiUrl = 'http://localhost:5097/api/MyApp/UpdatePatient'; // URL для обновления пациента
const deletePatientApiUrl = 'http://localhost:5097/api/MyApp/DeletePatient'; // URL для удаления пациента
const createPatientApiUrl = 'http://localhost:5097/api/MyApp/CreatePatient'; // URL для удаления пациента


async function loadPatients() {
    try {
        const response = await fetch(getAllPatientUrl);
        if (!response.ok) {
            throw new Error('Ошибка при загрузке пациентов: ' + response.statusText);
        }
        const patients = await response.json();
        const patientsBody = document.getElementById('patientsBody');
        patientsBody.innerHTML = ''; // Очищаем существующие данные

        patients.forEach(patient => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${patient.fullname}</td>
                <td>${patient.guid}</td>
                <td>${patient.gender}</td>
                <td>${new Date(patient.birthday).toLocaleDateString('ru-RU')}</td>
            `;
            patientsBody.appendChild(row);
        });
    } catch (error) {
        console.error('Ошибка при загрузке пациентов:', error);
    }
}
async function loadPatientByGuid() {
    const guid = document.getElementById('guidInput').value;
    try {
        const response = await fetch(`${getPatientUrl}${guid}`);
        if (!response.ok) {
            throw new Error('Ошибка при загрузке пациента: ' + response.statusText);
        }
        const patient = await response.json();

        // Вывод информации о пациенте
        const patientInfo = document.getElementById('patientInfo');
        patientInfo.innerHTML = ''; // Очищаем существующую информацию
        if (patient) {
            patientInfo.innerHTML = `
                <h4>Найденный пациент:</h4>
                <p>ФИО: ${patient.fullname}</p>
                <p>Дата рождения: ${patient.birthday}</p>
                <p>Пол: ${patient.gender}</p>
                <p>Дата рождения: ${new Date(patient.birthday).toLocaleDateString('ru-RU')}</p>
            `;
        } else {
            patientInfo.innerHTML = '<p>Пациент не найден.</p>';
        }
    } catch (error) {
        console.error('Ошибка при загрузке пациента:', error);
    }
}
async function loadPatientByName() {
    const name = document.getElementById('nameInput').value;
    try {
        
        const response = await fetch(`${getPatientUrl}${name}`);
        if (!response.ok) {
            throw new Error('Ошибка при загрузке пациента: ' + response.statusText);
        }
        const patient = await response.json();

        // Вывод информации о пациенте
        const patientByNameInfo = document.getElementById('patientByNameInfo');
        patientByNameInfo.innerHTML = ''; // Очищаем существующую информацию
        if (patient) {
            patientByNameInfo.innerHTML = `
                <h4>Найденный пациент:</h4>
                <p>GUID: ${patient.guid}</p>
               <p>Дата рождения: ${patient.birthday}</p>
                <p>Пол: ${patient.gender}</p>
                <p>Дата рождения: ${new Date(patient.birthday).toLocaleDateString('ru-RU')}</p>
            `;
        } else {
            patientByNameInfo.innerHTML = '<p>Пациент не найден.</p>';
        }
    } catch (error) {
        console.error('Ошибка при загрузке пациента:', error);
    }
}
async function updatePatient() {
    const guid = document.getElementById('updateGuidInput').value;
    const fullName = document.getElementById('updateFullName').value;
    const gender = document.getElementById('updateGender').value;
    const birthday = document.getElementById('updateBirthday').value;

    const patientData = {
        fullname: fullName,
        gender: gender ? parseInt(gender) : null, // Преобразуем gender к числу или оставляем null
        birthday: birthday || null // Устанавливаем в null, если дата пустая
    };

    try {
        const response = await fetch(`${updatePatientApiUrl}?id=${guid}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(patientData)
        });

        if (!response.ok) {
            throw new Error('Ошибка при обновлении пациента: ' + response.statusText);
        }

        alert('Пациент успешно обновлен');
        loadPatients(); // Обновляем список пациентов
    } catch (error) {
        console.error('Ошибка при обновлении пациента:', error);
    }
}

async function deletePatient() {
    const guid = document.getElementById('deleteGuidInput').value;

    try {
        const response = await fetch(`${deletePatientApiUrl}?id=${guid}`, {
            method: 'DELETE'
        });

        if (!response.ok) {
            throw new Error('Ошибка при удалении пациента: ' + response.statusText);
        }

        alert('Пациент успешно удален');
        loadPatients(); // Обновляем список пациентов
    } catch (error) {
        console.error('Ошибка при удалении пациента:', error);
    }
}
async function createPatient() {
    const fullName = document.getElementById('newFullName').value;
    const gender = document.getElementById('newGender').value;
    const birthday = document.getElementById('newBirthday').value;

    const newPatient = {
        fullName: fullName,
        gender: gender,
        birthday: birthday
    };

    try {
        const response = await fetch(createPatientApiUrl, {  // Fix here: both arguments must be within the same parentheses
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(newPatient)
        });

        if (!response.ok) {
            throw new Error('Ошибка при добавлении пациента: ' + response.statusText);
        }

        alert('Пациент успешно добавлен');

       
        loadPatients(); // Обновляем список пациентов
    } catch (error) {
        document.getElementById('addPatientInfo').innerText = error.message;
    }
}
