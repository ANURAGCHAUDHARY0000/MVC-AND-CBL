function firstDigit(alphaNum) {
    const chars = alphaNum.split('');
    let result = 0;
    for (let i = 0; i < alphaNum.length; i++) {
      if (chars[i] >= '0' && chars[i] <= '9') {
        result = chars[i] - '0';
        break;
      }
    }
    return result;
  }
  
  function printResult(v) {
    console.log(v);
  }
  
  const alphaNum = 'q30s3s';
  printResult(firstDigit(alphaNum));
  