const ints = [ 2,1,3,5,3,2 ];
PrintResult(FindFirstDuplicate(ints));
PrintResult(FindFirstDuplicateWithHash(ints));

function PrintResult(v)
{
    console.log(v);
    alert(v);
}

function FindFirstDuplicate(ints) {
    const list = [];
    for(let i = 0; i < ints.length; i++) {
      for(let j = i+1; j < ints.length; j++) {
        if(ints[i] === ints[j]) {
          list.push(j);
        }
      }
    }
    if(list.length === 0) {
      return -1;
    }
    const result = Math.min(...list);
    return ints[result];
  }
  
  function FindFirstDuplicateWithHash(ints) {
    const set = new Set();
    for(let i = 0; i < ints.length; i++) {
      if(set.has(ints[i])) {
        return ints[i];
      }
      set.add(ints[i]);
    }
    return -1;
  }
  