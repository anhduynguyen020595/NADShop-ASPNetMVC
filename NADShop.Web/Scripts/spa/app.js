/// <reference path="../angular.js" />

//Create the module
var myApp = angular.module('myModule', []);

// Creating the controller and registering with the module all done in one line
myApp.controller("schoolController", schoolController)
myApp.service("Validator", Validator);

schoolController.$inject = ['$scope', 'Validator'];

function schoolController($scope, Validator) {   

    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }

    $scope.num = 1;
}


function Validator($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            //$window.alert("This is even");
            return "This is even";
        } else {
            //$window.alert("This is odd");
            return "This is odd";
        }
    }
}