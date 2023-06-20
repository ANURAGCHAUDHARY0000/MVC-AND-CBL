console.log("Circle of Number ");
CircleNumber = prompt("Circle of Number ");
console.log("Enter Number ");
Input = prompt("Enter Number ");
PrintResult(CircleofNumber(CircleNumber,Input));

function CircleofNumber(circleNumber,input){
 let opposite = 0;
 if(input >= 1 && input <= circleNumber)
  {
     opposite = (input + circleNumber) % 10;
   }
   return opposite;
}

function PrintResult(opposite){
    console.log(opposite);
    alert(opposite);
}

