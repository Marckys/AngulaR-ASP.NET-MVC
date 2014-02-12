




demoApp.controller('ListaCtrl',
['$scope', 'dataContext', '$location',
    function ($scope, $dataContext, $location) {

        //Propiedades públicas
        $scope.list = [];
        $scope.getData = getData;
        $scope.loading = false;
        $scope.error = "";


        $scope.getData();
        $scope.edit = function (id) {
            $location.path("edit/" + id);
        };


        //Metodos privados
        function getData() {
            $scope.loading = true;
            $dataContext.ConcesionariosDb.getAll()
                .then(getSucceeded, failed);
        }

        function getSucceeded(data) {
            $scope.list = data || [];
            $scope.loading = false;
        }
        function failed(error) {
            $scope.error = error.Message || "";
            $scope.loading = false;
        }
        
        function getPprovincias() {
            $dataContext.ProvinciasDb.getAll()
             .then(function (data) { $scope.provincias = data; }, failed);
        }
    }
]);