number = 21;
PrintResult(FermFactor(number));

function PrintResult(ints) {
   ints.forEach(element => {
    console.log(element);
    alert(element);
   });
}

function FermFactor(number) {

    const array = []

    for ( i = 1; i < number / 2 ; i++)
    {
        for ( j = i; j < number / 2; j++)
        {
            if ((j + 1) * (j + 1) - (i) * (i) == number) {
               array.push(j+1)
               array.push(i)
                break;

            }
        }
        if (array.length == 2)
            break;

    }

    return array;


}
