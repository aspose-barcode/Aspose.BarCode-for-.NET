$.extend($.expr[':'], {
    isEmpty: function (e) {
        return e.value === '';
    }
});

var getAbsoluteUrl = (function () {
    var a;
    return function (url) {
        if (!a) a = document.createElement('a');
        a.href = url;

        return a.href;
    };
})();

window.onWorkSuccess = function () {
};

window.workSuccess = function (data, textStatus, xhr) {
    hideLoader();
    if (data.IsSuccess) {

        if (window.nextStage) {
            window.nextStage(data);
            return;
        }

        $('.UploadPlaceHolder').addClass("hidden");
        $('#WorkPlaceHolder').addClass("hidden");
        $('#DownloadPlaceHolder').removeClass("hidden");
        $('#OtherApps').removeClass("hidden");

        let url = `${APIBasePath}api/Common/DownloadFile/${data.id}?file=${data.FileName}`;
        url = getAbsoluteUrl(url);

        $('#DownloadUrlInputHidden').val(url);
        $('#DownloadButton').attr("href", url);

        SEONavigate('result');

        if (window.AllowedViewAfterProcesing && window.AllowedViewAfterProcesing(data)) {
            let viewurl = `/slides/storage/view/${data.id}/${data.FileName}/`;
            viewurl = getAbsoluteUrl(viewurl);
            $('#ViewerButton').attr("href", viewurl);
            $('#viewerplaceholder').removeClass("hidden");
        }

        onWorkSuccess();
    }
    else {
        dataErrorAlert(data);
    }
}

function validateWork() {
    if ($('input[name="FileName"]:isEmpty').length > 0) {
        showAlert(Resources["FileSelectMessage"]);
        return false;
    }

    return true;
}

window.registerWorkFormHandlers = function () {
    $('.workForm').ajaxForm({
        url: APIMethodWorkUrl,
        dataType: "json",
        beforeSubmit: validateWork,
        beforeSend: showLoader,
        success: workSuccess,
        complete: hideLoader,
        error: handleError
    });
};