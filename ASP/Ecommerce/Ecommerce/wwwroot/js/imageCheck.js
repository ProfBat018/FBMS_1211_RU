tinymce.init({
    selector: 'textarea',
    plugins: 'advlist autolink lists link image charmap print preview hr anchor pagebreak',
    toolbar_mode: 'floating',
});

function ValidateInput() {
    if (document.getElementById("uploadBox").value == "") {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Please upload an Image!',
        });
        return false;
    }
    return true;
}