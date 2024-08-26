window.showToastr = function (type, message) {
    if (type === "success") {
        toastr.success(message);
    }
    if (type === "error") {
        toastr.error(message);
    }
}

window.showSwal = function (type, message) {
    Swal.fire({
        title: type === "success" ? "Good job!" : "Error!",
        text: message,
        icon: type
    });
}