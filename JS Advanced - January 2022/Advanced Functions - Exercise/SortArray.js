function sortArr(arr, way) {

    const utilsSorting = {
        ascSort,
        descSort
    }

    function ascSort(arrToSort) {
        arrToSort = arrToSort.sort((a, b) => a - b)
    }

    function descSort(arrToSort) {
        arrToSort = arrToSort.sort((a, b) => b - a)
    }

    switch (way) {
        case "asc":
            utilsSorting.ascSort(arr);
            break;
        case "desc":
            utilsSorting.descSort(arr);
            break;
    }
    return arr;
}

sortArr([14, 7, 17, 6, 8], 'asc');

sortArr([14, 7, 17, 6, 8], 'desc');