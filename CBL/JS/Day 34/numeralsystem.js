function newNumeralSystem(str) {
    const num = str.charCodeAt(0) - 65;
    const result = [];
  
    for (let i = 0; i <= Math.floor(num / 2); i++) {
      const j = num - i;
      const first = String.fromCharCode(i + 65);
      const second = String.fromCharCode(j + 65);
      result.push(`${first}+${second}`);
    }
  
    return result;
  }
  
  function printResult(list) {
    for (const s of list) {
      console.log(s);
    }
  }
  
  const s = 'G';
  printResult(newNumeralSystem(s));
  