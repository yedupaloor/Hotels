(function () {
    var Hotel = function ($http, $location) {

        var getHotels = function () {
            var domain = $location.protocol() + "://" + location.host;
            var url = domain + "/api/Hotels/get";
            return $http.get(url)
                .then(function (response) {
                    return response.data;
                });
        };

        var getHotel = function (id) {
            var domain = $location.protocol() + "://" + location.host;
            var url = domain + "/api/hotels/gethotels/";
            url += id;
            return $http.get(url)
                .then(function (response) {
                    return response.data;
                });
        };

        var getComments = function (id) {
            var domain = $location.protocol() + "://" + location.host;
            var url = domain + "/api/hotels/getcomments/";
            url += id;
            return $http.get(url)
                .then(function (response) {
                    return response.data;
                });
        };

        var saveComment = function (newComment) {
            return $http({
                method: 'POST',
                url: 'api/hotels/postcomment/',
                data: newComment
            })
                .then(function (response) {
                    return response.data;
                });
        };

        return {
            getHotels: getHotels,
            getHotel: getHotel,
            getComments: getComments,
            saveComment: saveComment
        };

    };
    var module = angular.module("Hotels");
    module.factory("Hotel", Hotel);

}());