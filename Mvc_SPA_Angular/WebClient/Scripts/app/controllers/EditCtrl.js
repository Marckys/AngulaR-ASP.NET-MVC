

demoApp.controller('EditCtrl',
        [
            '$scope', '$routeParams', '$location', 'dataContext',
            function ($scope, $routeParams, $location, $dataContext) {

                //Parte Pública
                $scope.coche = {};
                $scope.getData = getData;
                $scope.update = update;
                $scope.loading = true;
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
                function update(coche) {
                    $scope.loading = false;
                    $dataContext.CochesDb.update($routeParams.id, coche)
                        .then(function() { $scope.volver(); }, failed);

                };
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



