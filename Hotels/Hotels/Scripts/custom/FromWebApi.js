(function () {
    var Hotel = function ($http, $location) {

        var getHotels = function () {
            var domain = $location.protocol() + "://" + location.host;
            var url = domain + "/api/Hotels/";
            return $http.get(url)
                .then(function (response) {
                    return response.data;
                });
        };

        var getHotel = function (id) {
            var domain = $location.protocol() + "://" + location.host;
            var url = domain + "/api/Hotels/";
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