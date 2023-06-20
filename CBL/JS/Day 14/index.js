let s1 = "1233";
let s2 = "1233";
PrintResult(CommonCharacterCount(s1,s2));

function CommonCharacterCount(s1,s2){
   let chars = Array.from(s1);
   let  chars2 = Array.from(s2);
     commonCharactercount = 0;   
    for( i = 0; i < chars.length; i++)
    {
        for( j = 0; j < chars2.length; j++)
        {
            if(chars[i] == chars2[j])
            {
                chars2[j] = '*';
                commonCharactercount++;
                break;
            }
        }
    }

    return commonCharactercount;
}

function PrintResult(v)
{
    console.log(v);
    alert(v);
}