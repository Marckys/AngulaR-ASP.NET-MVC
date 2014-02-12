
demoApp.controller('DetalleCtrl',
        [
            '$scope', '$routeParams', '$location', 'dataContext',
            function ($scope, $routeParams, $location, $dataContext) {

                //Parte Pública
                $scope.loading = true;
                $scope.getData = getData;
                $scope.volver = function () {
                    $location.path('/');
                };

                //Carga los datos al entrar
                $scope.getData();


                //Parte Privada
                function getData() {
                    $scope.loading = true;
                    $dataContext.CochesDb.getById($routeParams.id)
                        .then(getSucceeded, failed);
                }

                function getSucceeded(data) {
                    $scope.coche = data || {};
                    $scope.loading = false;
                }
                function failed(error) {
                    $scope.error = error.Message || "";
                    $scope.loading = false;
                }
            }
        ]);





