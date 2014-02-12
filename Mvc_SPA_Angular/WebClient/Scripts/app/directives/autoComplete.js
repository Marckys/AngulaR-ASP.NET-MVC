


demoApp.directive('autoComplete', function ($timeout) {
    return function (scope, element, attrs) {
        element.autocomplete({
            minLength: 2,
            source: scope[attrs.datasource],
            select: function (event, ui) {
                scope[attrs.ngSelectedItem] = ui.item;
                scope[attrs.ngModel] = ui.item.label;
                scope.$apply();
                return false;
            },
            focus: function (event, ui) {
                element.val(ui.item.label);
                return false;
            }
        });
    };
});


