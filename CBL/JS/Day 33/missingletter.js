function findMissingCharacters(s) {
  
  let result = '_';
  if (s.charAt(0) !== 'a') {
    return result;
  }

  for (let c = 'a'; c <= 'z'; c++) {
    if (s.toLowerCase().indexOf(c) === -1) {
      result = c;
      break;
    }
  }

  return result;
}

function printResult(v) {
  console.log(v);
  alert(v);
}

const st1 = "abcdefghijklmnopqrstuvwxyz";
const s  = "abce";
printResult(findMissingCharacters(st1));
printResult(findMissingCharacters(s));
