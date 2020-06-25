function removeFile(event) {
    var parent = $(event.target).closest('.filedrop');

    parent.find('.fileupload').remove();
    parent.find('.uploadfileinput').removeClass("hidden");
    parent.find('.uploadfileinput').val("");

    $('input[name="id"]').val("");
    $('input[name="FileName"]').val("");

    afterRemoveFile(event);
}

function uploadFileSelected(event) {
    if (event.target.files[0] === undefined)
        return;

    hideAlert();

    var parent = $(event.target).closest('.filedrop');

    for (let i = 0; i < event.target.files.length; i++) {
        let file = event.target.files[i];
        parent.append(
            `<div class='fileupload'>
    <span class="filename">
        <a class="fileRemoveLink">
            <label for="UploadFileInput" class="custom-file-upload">${file.name}</label>
            <i class="fa fa-times"></i>
        </a>
    </span>
</div>`
        );
    }

    registerUploadHandlers();

    $(event.target).closest('.uploadForm.activeForm').submit();
};

function validateFilesSelection(arr, $form, options) {
    if ($form.find('.uploadfileinput:isEmpty').length > 0) {
        showAlert(Resources["FileSelectMessage"]);
        return false;
    }
}

function beforeUpload() {
    $('#workButton').addClass("hidden");
    showLoader();
}

function completeUpload() {
    //hideLoader();
    $('#workButton').removeClass("hidden");
}

function uploadProgress(event, position, total, percentComplete) {
}

function uploadSuccess(data, textStatus, xhr) {
    hideLoader();
    if (data.IsSuccess) {
        $('input[name="id"]').val(data.id);
        $('input[name="FileName"]').val(data.FileName);
        SEONavigate('uploaded');
        afterUploadSuccess(data, textStatus, xhr);        
    }
    else {
        dataErrorAlert(data);
    }
}

window.registerUploadHandlers = function () {
    $('.uploadfileinput').unbind();
    $('.fileRemoveLink').unbind();
    $('.uploadfileinput').unbind();

    $('.uploadfileinput').click(removeFile);
    $('.fileRemoveLink').click(removeFile);
    $('.uploadfileinput').change(uploadFileSelected);

    $('.uploadForm.activeForm').ajaxForm({
        url: `${APIBasePath}api/Common/UploadFile`,
        dataType: "json",
        beforeSubmit: validateFilesSelection,
        beforeSend: beforeUpload,
        uploadProgress: uploadProgress,
        success: uploadSuccess,
        complete: completeUpload,
        error: handleError
    });
};

window.afterUploadSuccess = function (data, textStatus, xhr) {
};

window.afterRemoveFile = function (event) {
};
