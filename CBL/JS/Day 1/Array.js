const strings = [
        "abc",
        "xyz",
        "pqr"
];
PrintDetails(AddBorder(strings));

function AddBorder(arr){
    arr.forEach((element, index) => {
        arr[index] = `*${element}*`;
    });
    arr.unshift("*****");
    arr.push("*****");   
    return arr;
}

function PrintDetails(arr){
arr.forEach(element => {
    console.log(element);
})
}




