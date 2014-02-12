


demoApp.factory('dataContext', ['$http', '$log', '$q', function ($http, $log, $q) {
    //Parte pública
    var context = {
        ConcesionariosDb: {
            getAll: getConcesionarios
        },
        CochesDb: {
            getById: getCocheDetalle,
            update: updateCoche
        },
        ProvinciasDb: {
            getAll: getProvincias
        }
    };
    
    //Parte privada
    var ruta = "http://localhost:9409/api/values/";
    var rutaMaestros = "http://localhost:9409/api/Maestros/";
    
    function getProvincias() {
        var deferred = $q.defer();
        $http.get(rutaMaestros).success(function (data) {
            data = data || {};
            deferred.resolve(data);
        }).error(function (data) {
            $log.error("Error en la llamada get Provincias" + data.ExceptionMessage);
            deferred.reject(error);
        });

        return deferred.promise;
    }

   
    function getConcesionarios() {
        var deferred = $q.defer();
        $http.get(ruta).success(function (data) {
            data = data || {};
            deferred.resolve(data);
        }).error(function (data) {
            $log.error("Error en la llamada get Concesionarios" + data.ExceptionMessage);
            deferred.reject(error);
        });
        
        return deferred.promise;
    }
    function getCocheDetalle(id) {
        var deferred = $q.defer();
        $http.get(ruta + id).success(function (data) {
            data = data || {};
            deferred.resolve(data);
        }).error(function (data) {
            $log.error("Error en la llamada get detalle" + data.ExceptionMessage);
            deferred.reject(error);
        });

        return deferred.promise;
    }
    function updateCoche(id, coche) {
        var deferred = $q.defer();
        $http.put(ruta + id, coche).success(function (data) {
            data = data || {};
            deferred.resolve(data);
        }).error(function (data) {
            $log.error("Error en la llamada get detalle" + data.ExceptionMessage);
            deferred.reject(error);
        });

        return deferred.promise;
        
    }

    return context;

}]);

