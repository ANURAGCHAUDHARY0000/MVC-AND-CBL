function CheckDigitDegree(numbers) {
    if (numbers <= 9) {
        return 0;
    }

    let sum = 0;
    while (numbers > 0) {
        let remainder = numbers % 10;
        sum += remainder;
        numbers = Math.floor(numbers / 10);
    }

    if (sum <= 9) {
        return 1;
    }

    return 1 + CheckDigitDegree(sum);
}

function PrintResult(v) {
    console.log(v);
    alert(v);
}

let numbers = 12345;
PrintResult(CheckDigitDegree(numbers));
