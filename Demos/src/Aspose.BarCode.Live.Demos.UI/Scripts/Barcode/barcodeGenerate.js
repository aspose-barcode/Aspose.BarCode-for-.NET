function selectBarcodeType(selectedType, selectedTypeTitle, typeDescription, defaultCodetext, url, productTitle, productTitleSub, defaultCodetext) {
    $('#barcodeTypeDdl').val(selectedType);
    $('#barcodeTypeDdl>span').html(selectedTypeTitle);
    $('#barcodeTypeDescription').text(typeDescription);
    $('#barcodePreviewSm').attr('src', url);
    $('#ProductTitle').html(productTitle);
    $('#ProductTitleSub').html(productTitleSub);
    $('#barcodeCodetext').attr('placeholder', defaultCodetext);
}

function selectImageFormat(imageFormat) {
    $('#imageFormatsDdl').val(imageFormat);
    $('#imageFormatsDdl').html(imageFormat);
}

function selectBarcodeSize(size) {
    $('#barcodeSizesContainer>button').removeClass("selected");
    $('#barcodeSizesContainer button:nth-child(' + size + ')').addClass("selected");
}

function generateBarcode() {
    var codetext = $('#barcodeCodetext').val();
    var barcodetype = $('#barcodeTypeDdl').val();
    var imageformat = $('#imageFormatsDdl').val();
    var barcodesize = $('#barcodeSizesContainer>button.selected').val();
    if (typeof barcodesize === 'undefined') {
        barcodesize = 2;
    }

    $("#barcodeImageContainer").hide();
    $("#barcodeLoader").show();
    $.ajax({
        type: 'POST',
        data: {
            barcodetype: barcodetype,
            content: codetext,
            filetype: imageformat,
            filesize: barcodesize
        },
        url: "../../barcode/generatebarcode"
    }).done(function (res) {
        if (res.success) {
            $('#barcodeimg').attr('src', 'data:image/png;base64,' + res.imgBase64);
            $('#downloadBtn').attr('href', res.url);
            $("#barcodeImageContainer").show();
        } else {
            showToast(res.errorMsg);
        }
    }).always(function() {
        $("#barcodeLoader").hide();
    });

}
