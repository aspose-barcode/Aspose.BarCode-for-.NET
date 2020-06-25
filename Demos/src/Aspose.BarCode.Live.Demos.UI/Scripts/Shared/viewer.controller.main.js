

angular.module('AsposeViewerApp').controller('ViewerController', function ($scope, $http, $q) {

	var initialized = false;
	$scope.loading = false;

	$scope.Init = function () {
		if (initialized === false) {
			initialized = true;
			$.support.cors = true;
			$('#viewer').viewer({
				applicationPath: asposeViewerAPI,
				documentGuid: fileName,
				folderName: folderName,
				defaultDocument: fileName,
				htmlMode: true,
				preloadPageCount: 3,
				zoom: true,
				pageSelector: true,
				search: false,
				thumbnails: true,
				rotate: false,
				download: false,
				upload: false,
				print: false,
				browse: false,
				rewrite: true,
				saveRotateState: false,
				enableRightClick: false,
				showThumbnails: true
			});
			
			// var beforeQueryString = window.location.href.split("?")[0];
			// window.history.pushState({}, document.title, beforeQueryString);
		}
	};
	
	$scope.Download = function (outputType) {
		$('#page-loading').show();
		$('#loader').show();
		$http({
			method: 'POST',
			url: asposeViewerAPI + '/Conversion',
			data: {
				'id': folderName,
				'FileName': fileName,
				'Format': outputType
			},
			responseType: "application/json"
		}).then(function (response) {
			var data = response.data;
            if (data.IsSuccess) {
                window.location = `${fileDownloadLink}/${data.id}?file=${data.FileName}`;
            } else {
                $scope.ShowError(data.Status);
            }
        }, function (error) {
			$scope.ShowError(error.message);
		}).finally(function () {
			$('#page-loading').fadeOut(600);
		});
	};

	$scope.ShowError = function (message) {
		$('#alert > p')[0].innerText = message;
		$('#alert').show();
	};

	$scope.Init();
});