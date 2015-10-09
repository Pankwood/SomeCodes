var starter = angular.module('starter', ['ionic'])

starter.config(function($stateProvider, $urlRouterProvider) {
  $stateProvider
  .state('index', {
    url: '/',
    templateUrl: 'index.html'
  })
  .state('detalhe', {
    url: '/detalhe.html',
    templateUrl: 'detalhe.html'
  });

})

starter.controller('MeuPacote', function($scope, $http, $window) {
 $http.get('IMPUT WEBAPI LINK').then(function(resp) {
      $scope.pacotes = resp.data.ListaPacoteResult;
      $scope.valor = 0;
      console.log('Showing', resp.data.ListaPacoteResult);
  }, function(err) {
    console.error('ERR', err);
  })

  $scope.DetalheDoPacote = function(ID)
  {
    console.log(ID);
    $window.localStorage.setItem("ID", ID);
    $window.location='/detalhe.html';
  };
})


var detail = angular.module('detail', ['ionic'])

detail.controller('MeuDetalhe', function($scope, $http, $window) {
    $http.get('IMPUT WEBAPI LINK' + $window.localStorage.getItem('ID')).then(function (resp) {
      $scope.detalhes = resp.data.DetalhesDoPacoteResult;
      $scope.incluis = resp.data.DetalhesDoPacoteResult[0].Inclui;
      $window.localStorage.removeItem('ID');
      console.log('Detailing', resp.data.DetalhesDoPacoteResult);
      console.log('Incluiing', resp.data.DetalhesDoPacoteResult[0].Inclui);
      $scope.goBack = function() {
   $window.location='/index.html';
 };
  }, function(err) {
    console.error('ERR', err);
  })
})
