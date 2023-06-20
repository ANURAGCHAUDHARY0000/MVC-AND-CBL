number  = 642386;
PrintResult(CheckEvenDigits(number));
PrintResult(CheckEvenDigitsWithoutString(number));

function PrintResult(result)
{
    console.log(result);
    alert(result);
}

function CheckEvenDigits(number){
      checkNumber = number.toString();
      count = 0;
      for( i = 0; i < checkNumber.length; i++)
      {
            if (parseInt(checkNumber[i].toString()) % 2 == 0)
            count++;
      }

        return count == checkNumber.Length;
}


function CheckEvenDigitsWithoutString(number)
{
     digit = 0;
    while (number != 0)
    {
        digit = number % 10;
        if (digit % 2 != 0)
         return false;
         number /= 10;
    }
            return true;
}