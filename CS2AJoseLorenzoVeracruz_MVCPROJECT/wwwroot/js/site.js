


$(document).ready(function () {
    $('#addStudentForm').on('submit', function(e) {
        e.preventDefault();
        const student = {
            FirstName: $('#FirstName').val(),
            LastName: $('#LastName').val(),
            Age: $('#Age').val(),
            Course: $('#Course').val(),
        };
        addStudent(student);
    });
});



const addStudent = async (student) => {
    try {
        const result = await AjaxPOST('/Student/AddStudent', student);
        if (result.success) {
            alert('Student Added Successfully!');
            window.location.href = '/Student/Index';
        } else {
            alert('Failed to Add Student!' + result.message);
        }
    }
    catch (error){
        console.error('Error adding student: ' + error);
        alert('An error occured while adding the student.');
    }
};


const getStudentByID = async (id) => {
    try {

    }
    catch {

    }
}