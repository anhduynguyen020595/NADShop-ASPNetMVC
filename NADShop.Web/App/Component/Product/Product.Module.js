(function () {
    angular.module('NADShop.Product', ['NADShop.Common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('Product', {
            url: "/Product", 
            templateUrl: "/App/Component/Product/ProductListView.html",
            controller: "ProductListController"
        }).state("ProductAdd", {
            url: "/ProductAdd",
            templateUrl: "/App/Component/Product/ProductAddView.html",
            controller: "ProductAddController"
        });
    }
})();