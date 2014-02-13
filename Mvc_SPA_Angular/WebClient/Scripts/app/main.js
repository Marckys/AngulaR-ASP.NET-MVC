


demoApp = angular.module('demoApp', [])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/Concesionarios/List',
                controller: 'ListaCtrl'
            })
            .when('/detalle/:id', {
                templateUrl: function (parameter) {
                    return '/Concesionarios/Detail/' + parameter.id;
                },
                controller: 'DetalleCtrl'
            })
            .when('/edit/:id', {
                templateUrl: '/Concesionarios/Edit',
                controller: 'EditCtrl'
            })
            .otherwise({ redirectTo: '/' });

    }]);




