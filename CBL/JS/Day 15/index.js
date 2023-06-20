let number = -23589;
PrintResult(reverseInt(number));
PrintResult(reversedNum(number));

function reverseInt(num) {
    let sign = Math.sign(num);
    if (sign === -1) {
        num = num*sign;
    }
  let reverseInteger = 0;
  while (num > 0) {
    const remainder = num % 10;
    reverseInteger = (reverseInteger * 10) + remainder;
    num = Math.floor(num / 10);
  }
  if (sign === -1) {
    return reverseInteger * sign;

   }
   return reverseInteger;
}


function reversedNum(num) {
    return (
      parseFloat(
        num
          .toString()
          .split('')
          .reverse()
          .join('')
      ) * Math.sign(num)
    )                 
  }



function PrintResult(num) {
  console.log(num);
  alert(num);
}
