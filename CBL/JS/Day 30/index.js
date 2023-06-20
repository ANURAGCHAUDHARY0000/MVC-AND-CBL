function main() {
    const strings = [["a"], ["b"]];
    const ints = [
        [[[1, 2]]],
        [[[3, 4]]],
        [[[5, 6]]]
    ];

    printResult(flattenNestedArray(ints));
    printResult(flattenNestedArray(strings));
}

function printResult(objects) {
    for (let i = 0; i < objects.length; i++) {
        console.log(objects[i]);
    }
    console.log();
}

function flattenNestedArray(obj) {
    const totalLength = obj.flat(Infinity).length;
    const result = new Array(totalLength);
    let index = 0;

    for (const item of obj.flat(Infinity)) {
        result[index++] = item;
    }

    return result;
}

main();
