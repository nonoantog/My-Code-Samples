'use strinct'

var sample1 = (function () {
    var getFlatten = function (nestedArray) {
        var flatArray = new Array();

        for (let index = 0; index < nestedArray.length; index++) {
            console.log(nestedArray[index]);
            if (Array.isArray(nestedArray[index])) {
                flatArray = flatArray.concat(nestedArray[index]);
            } else {
                flatArray.push(nestedArray[index]);
            }

        }
        return flatArray;
    };


    var getFlattenRecursive = function (nestedArray, flatArray) {
        var currentArray = flatArray || {};
        if (nestedArray && nestedArray.length > 0) {
            nestedArray.forEach(function (value, index, array) {
                if (Array.isArray(value)) {
                    getFlattenRecursive(value, currentArray);
                }
                else {
                    flatArray.push(value);
                }
            });
        }
        return currentArray;
    };

    var getArrayToTest = function () {
        var arrayToTest = new Array();
        arrayToTest.push(1);
        arrayToTest.push(new Array(2, 3, 4));
        arrayToTest.push(new Array(5, 6));
        arrayToTest.push(7);
        return arrayToTest;
    };
    return {
        getFlatten: getFlatten,
        getArrayToTest: getArrayToTest,
        getFlattenRecursive: getFlattenRecursive
    }
})();