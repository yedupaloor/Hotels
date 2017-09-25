(function () {
    var module = angular.module("Hotels");

    var HotelsController = function ($scope, Hotel) {
        var onHotelLoadComplete = function (data) {
            $scope.hotels = data;
        }
        var onError = function (reason) {
            $scope.error = "Something went wrong!";
        }
        Hotel.getHotels().then(onHotelLoadComplete, onError);

        var onHotelDetailsLoadComplete = function (data) {
            $scope.hotel = data;
        }
        $scope.showDetails = function (id) {
            Hotel.getHotel(id).then(onHotelDetailsLoadComplete, onError);
        }
    };

    module.controller("HotelsController", ["$scope", "Hotel", HotelsController]);

}());