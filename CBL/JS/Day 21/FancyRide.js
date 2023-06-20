const uberRide  = [ "UberX", "UberXL", "UberPlus", "UberBlack", "UberSUV"];
totalDistance = 30;
affordableamount = 20;
PrintResult(FancyRide(uberRide, totalDistance, affordableamount));

   function FancyRide(uberRide,  totalDistance,  affordableamount)
    {

        debugger;
        totalAmount = 0;
        fancyCar = "";
          var Dict = 
           {
               "UberX" : .3,
               "UberXL" : .5,
               "UberPlus" : .7, 
               "UberBlack": 1, 
               "UberSUV" : 1.3
           };

            for (i = 0; i < uberRide.length; i++)
            {
                if (Dict.hasOwnProperty(uberRide[i]))
                {
                    totalAmount = Dict[uberRide[i]] * totalDistance;
                }

                if(totalAmount > affordableamount)
                {
                    fancyCar = uberRide[i-1];
                    break;  
                }
                else if(totalAmount == affordableamount) 
                {
                    fancyCar = uberRide[i];
                    break;
                }

             }

            return fancyCar;

    }
    

        function PrintResult(v)
        {
            console.log(v);
            alert(v);
        }