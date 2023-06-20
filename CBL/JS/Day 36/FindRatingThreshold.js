function findRatingThreshold(jaggedArray, threshold) {
    let sum = 0;
    let avg = 0;
    let list = [];
  
    for (let n = 0; n < jaggedArray.length; n++) {
      for (let k = 0; k < jaggedArray[n].length; k++) {
        sum += jaggedArray[n][k];
      }
      avg = sum / jaggedArray[n].length;
      if (avg < threshold) {
        list.push(n);
      }
      sum = 0;
    }
    return list;
  }
  
  function printResult(list) {
    list.forEach(function (item) {
      console.log(item);
    });
  }
  
  let jaggedArray = [  [3, 2],
    [3, 3, 3, 4],
    [4],
    [3, 5],
    [3]
  ];
  
  let ratingThreshold = 3.5;
  printResult(findRatingThreshold(jaggedArray, ratingThreshold));
  