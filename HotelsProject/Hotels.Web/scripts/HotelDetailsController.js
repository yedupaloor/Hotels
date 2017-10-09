(function () {
    var module = angular.module("Hotels");

    var HotelDetailsController = function ($scope, Hotel, $routeParams) {
        var onLoad = function (data) {
            $scope.hotel = data;
        }
        var onError = function (reason) {
            $scope.error = "Something went wrong!";
        }
        $scope.id = $routeParams.id;
        Hotel.getHotel($scope.id).then(onLoad, onError);
    };

    module.controller("HotelDetailsController", ["$scope", "Hotel", "$routeParams", HotelDetailsController]);
}());

