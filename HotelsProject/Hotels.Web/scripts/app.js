(function () {
    var app = angular.module("Hotels", ["ngRoute"]);
    app.config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/hotels', {
                templateUrl: 'hotels.html',
                controller: 'HotelsController'
            })
            .when('/hotels/:id', {
                templateUrl: 'details.html',
                controller: 'HotelDetailsController'
            })
            .otherwise({
                redirectTo: '/hotels'
            });
    });
}());