(function () {
    var Hotel = function ($http, $location) {
        var domain = $location.protocol() + "://" + location.host;
        var getHotels = function () {
            return $http.get(domain + "/hotels.json")
                .then(function (response) {
                    return response.data;
                });
        };

        var getHotel = function (id) {
            return $http.get(domain + "/" + id + ".json")
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