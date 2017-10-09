(function () {
    var Hotel = function ($http, $location) {
        var url = "http://localhost:4383/api/Hotels/";

        var getHotels = function () {
            return $http.get(url)
                .then(function (response) {
                    return response.data;
                });
        };

        var getHotel = function (id) {
            url += id;
            return $http.get(url)
                .then(function (response) {
                    return response.data;
                });
        };

        return {
            getHotels: getHotels,
            getHotel: getHotel
        };

    };
    var module = angular.module("Hotels");
    module.factory("Hotel", Hotel);

}());