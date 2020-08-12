/// <reference path="../angular.js" />

//Create the module
var myApp = angular.module('myModule', []);

// Creating the controller and registering with the module all done in one line
myApp.controller("myController", myController);

myController.$inject = ['$scope'];

function myController($scope) {
    $scope.message = "Hello World";
}