  upSpeed = 100;
  downSpeed = 10;
  desiredHeight = 800;
  PrintResult(GrowingPlant(upSpeed, downSpeed, desiredHeight));

  function PrintResult(result)
  {
    console.log(result);
    alert(result);
  }

 function GrowingPlant( upSpeed,  downSpeed,  desiredHeight)
 {
            result = 0;
            count = 0;
            while(result <= desiredHeight)
            {
                result = result + upSpeed;
                if(result == desiredHeight)
                {
                    count++;
                    break;
                }
                result = result - downSpeed;
                count++;
            }
            return count;
            
}