function pigLatin(s1) {
    let chars = s1.toLowerCase().split('');
    let result = '';
    let firstVowelIndex = -1;
    
    for (let i = 0; i < chars.length; i++) {
      if (chars[i] === 'a' || chars[i] === 'e' || chars[i] === 'i' || chars[i] === 'o' || chars[i] === 'u') {
        firstVowelIndex = i;
        break;
      }
    }
  
    if (firstVowelIndex === 0) {
      result = s1 + 'way';
      return result;
    } else if (firstVowelIndex > 0) {
      result = s1.slice(firstVowelIndex) + s1.slice(0, firstVowelIndex);
    }
    
    return result + 'ay';
  }
  
  console.log(pigLatin('eight'));
  