var mainModule = angular.module('mainModule', []);

mainModule.controller('mainController', ['$scope', '$window', function ($scope, $window) {

    $scope.John = {
        name: 'John',
        address: '58 collins st, Melbourne'
    };

    $scope.Jack = {
        name: 'Jack',
        address: 'Jacks Address'
    };

    $scope.name = 'Tobias';

    $scope.Clicked = function () {
        
        $window.alert("Click Event");
    };

    $scope.Text = "abc";

}]);

mainModule.directive('myCustomer', function () {

    return {
        restrict: 'AE',
        scope: {
            customerInfo : '=infoCustomer'
        },
        //transclude : true,
        templateUrl : 'MyTemplate.html'
    };

});

mainModule.directive('myTest', function () {

    return {
        restrict: 'E',
        //transclude : true,
        template : '<div>Name : {{Jack.name}} <br />Address : {{Jack.address}}</div>'
    };

});

mainModule.directive('myDialog', function () {

    return {
        restrict: 'E',
        transclude: true,
        template: '<div class="alert" ng-transclude></div>'
    };

});

mainModule.directive('myButton', function () {

    return {
        restrict: 'E',
        scope: {
            clickFunction : '&'
        },
        template: '<input type="button", value="Click Directive" ng-click="clickFunction()" />',

        link: function ($scope) {
            
            $scope.myfunction = function () {
                alert("Click From Directive");
            };
        }
    };

});