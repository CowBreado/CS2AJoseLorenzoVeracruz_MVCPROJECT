


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

$(document).ready(function () {
    $('#getStudentByID').on('submit', function (e) {
        e.preventDefault();
        const student = {
            FirstName: $('#FirstName').val(),
            LastName: $('#LastName').val(),
            Age: $('#Age').val(),
            Course: $('#Course').val(),
            id: $('#id').val(),
        };
        getStudentByID(student);
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





const updateStudent = async (student) => {
    try {
        const result = await AjaxPOST('/Student/UpdateStudent', student);
        if (result.success) {
            alert('Student updated successfully!');
            window.location.href = '/Student/Index';
        } else {
            alert('Failed to update student: ' + result.message);
        }
    } catch (error) {
        console.error('Error updating student : ' + error);
        alert('An error occured while updating the student.');
    }
}



 const DeleteStudent = async (id) => {
        if (!confirm("Are you sure you want to delete this student?")) return;

        try {
            const result = await AjaxPOST('/Student/DeleteStudent', { ID: id });
            if (result.success) {
                alert('Student deleted successfully!');
                window.location.href = '/Student/Index';
            } else {
                alert('Failed to delete student: ' + result.message);
            }
        } catch (error) {
            console.error('Error deleting student:', error);
            alert('An error occurred while deleting the student.');
        }
    };

    $('.delete-student').on('click', function () {
        const studentId = $(this).data('id');
        DeleteStudent(studentId);
    });





