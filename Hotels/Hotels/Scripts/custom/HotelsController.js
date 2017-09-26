(function () {
    var module = angular.module("Hotels");

    var HotelsController = function ($scope, Hotel, NgTableParams) {
        var onHotelLoadComplete = function (data) {
            $scope.hotels = new NgTableParams({}, { dataset: data });
        }
        Hotel.getHotels().then(onHotelLoadComplete, onError);

        var onHotelDetailsLoadComplete = function (data) {
            $scope.hotel = data;
        }
        $scope.showDetails = function (id) {
            $scope.hotelComments = null;
            clearNewComment();
            Hotel.getHotel(id).then(onHotelDetailsLoadComplete, onError);
        }

        function clearNewComment() {
            $scope.newComment = {
                Id: '',
                Name: '',
                Email: '',
                Comment: '',
                HotelId: '',
                CreatedOn: ''
            };
        }

        var onHotelCommentsLoadComplete = function (data) {
            $scope.hotelComments = new NgTableParams({}, { dataset: data });
        };

        $scope.loadHotelComments = function (hotelId) {
            Hotel.getComments(hotelId).then(onHotelCommentsLoadComplete, onError);
        };
        var onHotelCommentSaveComplete = function (data) {
            $scope.hotelComments.data.push(data);
            $scope.clearComment();
        };

        $scope.postComment = function () {
            var aNewComment = $scope.newComment;
            aNewComment.HotelId = $scope.hotel.Id;
            Hotel.saveComment(aNewComment).then(onHotelCommentSaveComplete, onError);
        };

        $scope.clearComment = function () {
            clearNewComment();
        };

        $scope.add = function () {
            $scope.newComment.Id = 0;
        };
        $scope.cancel = function () {
            clearNewComment();
        };

        var onError = function (reason) {
            $scope.error = "Something went wrong!";
        }

    };

    module.controller("HotelsController", ["$scope", "Hotel", "NgTableParams", HotelsController]);
}());