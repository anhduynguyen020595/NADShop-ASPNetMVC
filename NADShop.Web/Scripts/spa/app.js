/// <reference path="../angular.js" />

//Create the module
var myApp = angular.module('myModule', []);

// Creating the controller and registering with the module all done in one line
myApp.controller("myController", myController);
myApp.controller("schoolController", schoolController)
myApp.controller("studentController", studentController)
myApp.controller("teacherController", teacherController)

myController.$inject = ['$scope'];

function myController($scope) {
    $scope.message = "Hello World";
}

// Scope nested
function schoolController($scope) {
    $scope.message = "School";
}

function studentController($scope) {
    $scope.message = "Student";
}

function teacherController($scope) {
    $scope.message = "Teacher";
}