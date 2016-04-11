var mainModule = angular.module('mainModule', ['factoryModule', 'serModule', 'provModule']);

mainModule.config(function (greetProvider) {
    greetProvider.setName('From Provider');
});

mainModule.controller('mainModuleController', ['$scope', 'greetFactory', 'greetService', 'greet', function ($scope, greetFactory, greetService, greet) {

    $scope.greet = "Hello World";
    $scope.greetFromFactory = greetFactory.SayHello();
    $scope.Servicegreeting = greetService.SayHello();
    $scope.greetProvider = greet.sayHello();

}]);

var factoryModule = angular.module('factoryModule', []);

factoryModule.factory('greetFactory', function () {
    return { 
        SayHello: function(){
            return "Hello From Factory"
        }
    };
});


var serModule = angular.module('serModule', []);

serModule.service('greetService', function () {
    
    this.SayHello = function () {
        return "Hello from Service";
    }
});

var provModule = angular.module('provModule', []);

provModule.provider('greet', function () {
    
    this.name = 'Default';

    this.setName = function (name) {
        this.name = name;
    };


    this.$get = function() {
        var name = this.name;

        return {
            sayHello: function () {
                return "Hello " + name;
            }
        }
    }

});
