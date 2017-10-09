(function () {
    var module = angular.module("Hotels");

    var HotelsController = function ($scope, Hotel, $location) {
        var onLoad = function (data) {
            $scope.hotels = data;
        }
        var onError = function (reason) {
            $scope.error = "Something went wrong!";
        }
        Hotel.getHotels().then(onLoad, onError);

        $scope.showImages = function (id) {
            $location.path("/hotels/" + id);
        }
    };

    module.controller("HotelsController", ["$scope", "Hotel", "$location", HotelsController]);

}());