var myApp = angular.module('myApp', []);
/*
myApp.service('thisservice', function () {
    this.Reference = "yyy";
});
*/
myApp.controller('SearchControl', function ($scope, $http) {
    $scope.OnTextChange = function (keyEvent) {
        if (keyEvent.which === 13)
        {
            var fullHost = window.location.pathname;
            var partsBlitz = fullHost.split('.');
            var subDomain = null;
            if (partsBlitz.length > 2)
                subDomain = parts[0];
            if (location.hostname === 'localhost') fullHost = '';
            //$http.get(fullHost + "/Home/Search2/" + $scope.searchString).then(function (response) {
            $http.get("/Home/Search2/" + $scope.searchString).then(function (response) {
                $scope.SearchResults = response.data;
                $scope.SearchResults.map(function (item) {
                    if (item.Customer_Phone === "") {item.Customer_Phone = "999-999-9999";}
                    if (item.Shipping_Notes === "") { item.Shipping_Notes = "No Notes Available"; }
                    item.Ship_to_Address = item.Ship_to_Address + ',';
                    item.Ship_to_County = item.Ship_to_County + ',';
                    item.Ship_to_Post_Code = item.Ship_to_Post_Code + '.';
                    
                });
            }, function (error) {
                console.log(error);
            });
        }
    }
});
/*
myApp.controller('jobHeaderCtrl',
    ['$rootScope', '$scope', 'thisservice',
        function ($scope, $http) {
            $scope.JobHeaders = $scope.SearchResults;
        }]);

myApp.controller('documentsCtrl', function ($scope) {
    $scope.Documents = [
        {
            "Document1": "276560",
            "Document2": "0",
            "Document3": "C-80820",
            "Document4": "Havtech Air Distribution",
            "Document5": "9505 Berger Rd",
            "Document6": "Columbia"
        }
    ];
});
myApp.controller('productionCtrl', function ($scope) {
    $scope.ProductionDocs = [
        {
            "Document1": "276560",
            "Document2": "0",
            "Document3": "C-80820",
            "Document4": "Havtech Air Distribution",
            "Document5": "9505 Berger Rd",
            "Document6": "Columbia"
        }
    ];
});
myApp.controller('specsCtrl', function ($scope) {
    $scope.SpecsDocs = [
        {
            "Document1": "276560",
            "Document2": "0",
            "Document3": "C-80820",
            "Document4": "Havtech Air Distribution",
            "Document5": "9505 Berger Rd",
            "Document6": "Columbia"
        }
    ];
});

myApp.controller('xmlfilesCtrl', function ($scope) {
    $scope.xmlDocs = [
        {
            "Document1": "276560",
            "Document2": "0",
            "Document3": "C-80820",
            "Document4": "Havtech Air Distribution",
            "Document5": "9505 Berger Rd",
            "Document6": "Columbia"
        }
    ];
});

myApp.controller('customerserviceCtrl', function ($scope) {
    $scope.customerDocs = [
        {
            "Document1": "276560",
            "Document2": "0",
            "Document3": "C-80820",
            "Document4": "Havtech Air Distribution",
            "Document5": "9505 Berger Rd",
            "Document6": "Columbia"
        }
    ];
});

myApp.controller('notesCtrl', function ($scope) {
    $scope.notesDocs = [
        {
            "Document1": "276560",
            "Document2": "0",
            "Document3": "C-80820",
            "Document4": "Havtech Air Distribution",
            "Document5": "9505 Berger Rd",
            "Document6": "Columbia"
        }
    ];
});

myApp.controller('MenuCntrl', function ($scope) {
    //This will hide the DIV by default.
    $scope.IsVisible = false;
    $scope.ShowHide = function () {
        //If DIV is visible it will be hidden and vice versa.
        $scope.IsVisible = $scope.IsVisible ? false : true;
    }
});*/