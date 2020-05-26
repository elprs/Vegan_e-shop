

var app = angular.module('VeganApp', []);

app.controller("ProductController", function ($scope, $http) {

    var url = "product.json"

    FetchData();

    function FetchData() {
        $http.get(url)
            .then(function (response) {

                $scope.Products = respone.data[1].products;

            }, function myError(response) {
                console.log(response);
            });
    }
});