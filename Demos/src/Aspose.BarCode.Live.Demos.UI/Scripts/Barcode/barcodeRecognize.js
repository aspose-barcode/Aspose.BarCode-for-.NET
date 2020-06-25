function selectBarcodeType(selectedType, selectedTypeTitle, productTitle, productTitleSub) {
    $('#barcodeTypeDdl').val(selectedType);
    $('#barcodeTypeDdl').html(selectedTypeTitle);
    $('#ProductTitle').html(productTitle);
    $('#ProductTitleSub').html(productTitleSub);
    $('#barcodeTypeDescription').html('');
}

function selectQuality(size) {
    $('#recognizeQualityContainer>button').removeClass("selected");
    $('#recognizeQualityContainer button:nth-child(' + size + ')').addClass("selected");
}

function selectCamera(i) {
    $('#inputTypesContainer>.btn').removeClass("selected");
    $('#inputTypesContainer>.btn:nth-child(' + i + ')').addClass("selected");
}

var file = null;

function recognizeBarcode() {
    var barcodetype = $('#barcodeTypeDdl').val();
    var quality = $('#recognizeQualityContainer>button.selected').val();

    if ('ga' in window) {
        try {
            var tracker = window.ga.getAll()[0];
            if (tracker !== undefined) {
                tracker.send('event', {
                    'eventCategory': 'Barcode',
                    'eventAction': 'Recognize'
                });
            }
        } catch (err) { }
    }

    if (file) {
        if (window.FormData !== undefined) {
            var data = new FormData();
            data.append("type", barcodetype);
            data.append("quality", quality);
            data.append("file", file);
            $("#recognitionLoader").show();
            $('#recognitionResult').hide();
            $.ajax({
                type: "POST",
                url: "../../barcode/recognizebarcode",
                contentType: false,
                processData: false,
                data: data
            }).done(function(result) {
                if (!result.success) {
                    $('#recognitionResult>pre').html(result.errorMsg);
                } else {
                    $('#recognitionResult>pre').html(result.foundBarcodes);
                    location.hash = "#result";
                }
            }).always(function() {
                $("#recognitionLoader").hide();
                $('#recognitionResult').show();
            });

        } else {
            showToast("Something went wrong! Please try again.");
        }
    } else {
        showToast("Please upload barcode image.");
    }
}

$(document).ready(function() {
    $("#recognitionLoader").hide();
    $('#recognitionResult').hide();
    $("#barcodeUploadFile").change(function (e) {
        if (e.target.files.length > 0) {
            $('#recognitionResult>pre').html("");
            $('#recognitionResult').hide();
            file = e.target.files[0];
            $('#selectedFileName').html(file.name);
        }
    });
    $("#barcodeCaptureFile").change(function (e) {
        if (e.target.files.length > 0) {
            $('#recognitionResult>pre').html("");
            $('#recognitionResult').hide();
            file = e.target.files[0];
            $('#selectedFileName').html('Captured image');
        }
    });
});
