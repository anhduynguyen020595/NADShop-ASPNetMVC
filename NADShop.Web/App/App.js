/// <reference path="../scripts/angular.js" />

(function () {
    angular.module('NADShop', ['NADShop.Product','NADShop.Common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('Home', {
            url: "/Admin",
            templateUrl: "/App/Component/Home/HomeView.html",
            controller: "HomeController"
        });
        $urlRouterProvider.otherwise('/Admin')
    }
})();