/// <reference path="../angular.js" />

//Create the module
var myApp = angular.module('myModule', []);

// Creating the controller and registering with the module all done in one line
myApp.controller("schoolController", schoolController); 

myApp.directive("nadShopDirective", nadShopDirective);

myApp.service("ValidatorService", ValidatorService);

schoolController.$inject = ['$scope', 'ValidatorService'];

function schoolController($scope, ValidatorService) {   

    $scope.checkNumber = function () {
        $scope.message = ValidatorService.checkNumber($scope.num);
    }

    $scope.num = 1;
}


function ValidatorService($window) {
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

function nadShopDirective() {
    return {
        //template: "<h1>This is the first Directive</h1>"
        restrict: "A",
        templateUrl: "/Scripts/spa/nadShopDirective.html"
    }
}