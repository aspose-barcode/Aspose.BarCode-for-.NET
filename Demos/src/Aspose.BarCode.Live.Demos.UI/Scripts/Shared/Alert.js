window.hideAlert = function () {
    $('#alertMessage').addClass("hidden");
    $('#alertMessage').text("");
};

window.showAlert = function (msg) {
    $('#alertMessage').text(msg);
    $('#alertMessage').addClass("alert-danger");
    $('#alertMessage').removeClass("hidden");
    $('#alertMessage').fadeOut(100).fadeIn(100).fadeOut(100).fadeIn(100);
};

window.showInfo = function (msg) {
    $('#alertMessage').text(msg);
    $('#alertMessage').removeClass("alert-danger");
    $('#alertMessage').removeClass("hidden");
    $('#alertMessage').fadeOut(100).fadeIn(100).fadeOut(100).fadeIn(100);
};


window.dataErrorAlert = function (data) {
    switch (data.idError) {
        case "InvalidFile":
            showAlert(Resources["InvalidFile"]);
            break;
        case "InvalidReg":
            showAlert(Resources["WrongRegExpMessage"]);
            break;
        case "NotFound":
            showAlert(Resources["NoSearchResultsMessage"]);
            break;
        case "InvalidPassword":
            showAlert(Resources["UnlockInvalidPassword"]);
            break;
        default:
            showAlert(data.idError);
            break;
    }
};

window.handleError = function (xhr, exception) {
    hideLoader();
    $('#workButton').removeClass("hidden");

    var msg = '';
    if (xhr.status === 0) {
        msg = 'Not connect.\n Verify Network.';
    } else if (xhr.status == 404) {
        msg = 'Requested page not found. [404]';
    } else if (xhr.status == 500) {
        msg = 'Internal Server Error [500].';
    } else if (exception === 'parsererror') {
        msg = 'Requested JSON parse failed.';
    } else if (exception === 'timeout') {
        msg = 'Time out error.';
    } else if (exception === 'abort') {
        msg = 'Ajax request aborted.';
    } else {
        msg = 'Uncaught Error.\n' + xhr.responseText;
    }

    showAlert(msg);
};
