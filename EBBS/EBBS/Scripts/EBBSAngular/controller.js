var app;
(function () {
    app = angular.module("app", []);
})();

app.controller("AngularJs_SecurityQuestionController", function ($scope, $timeout, $rootScope, $window, $http) {

    $scope.message("Add this");

});


app.controller("AngularJs_UsersController", function ($scope, $timeout, $rootScope, $window, $http) {

    $scope.message("Add this User");

});

app.controller("AngularJs_RoleController", function ($scope, $timeout, $rootScope, $window, $http) {

    $scope.message("Add this Role");

});