function isEmailValid(email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}

function validateEmailAndAlert(email) {
    if (!isEmailValid(email)) {
        showAlert(Resources["ValidateEmailMessage"]);
        return false;
    }
    else
        hideAlert();

    return true;
}

function sendEmail(data, textStatus, xhr) {
    var email = $('#EmailToInput').val();
    if (!validateEmailAndAlert(email))
        return;

    var url = $('#DownloadUrlInputHidden').val();

    $('#sendEmailButton').addClass("hidden");

    $.ajax({
        method: "POST",
        url: `/common/SendUrlToEmail/${Product}/${Method}`,
        data: { url: url, email: email },
        dataType: "json",
        beforeSend: showLoader,
        success: sendEmailSuccess,
        complete: completeSendEmail,
        error: handleError
    });
}

function completeSendEmail() {
    $('#sendEmailButton').removeClass("hidden");
    hideLoader();
}

function sendEmailSuccess(data, textStatus, xhr) {
    showInfo(data.Message);
    SEONavigate('email');
}

$(document).ready(function () {
    $('#sendEmailButton').click(sendEmail);
});