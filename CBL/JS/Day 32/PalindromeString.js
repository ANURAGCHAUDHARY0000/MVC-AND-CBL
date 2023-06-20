function palindromeRearranging(s) {
    let hmap = new Map();

    for (let i = 0; i < s.length; i++) {
        if (hmap.has(s[i]))
            hmap.set(s[i], hmap.get(s[i]) + 1);
        else
            hmap.set(s[i], 1);
    }

    let oddCount = 0;

    for (let [key, value] of hmap) {
        if (value % 2 === 0)
            continue;
        else
            oddCount++;
    }

    if (s.length % 2 === 0 && oddCount === 0)
        return true;
    if (s.length % 2 !== 0 && oddCount === 1)
        return true;
    else
        return false;
}

let s1 = "aabb";
console.log(palindromeRearranging(s1));
alert(palindromeRearranging(s1));
