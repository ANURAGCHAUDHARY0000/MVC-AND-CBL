const strings  = [
"abc",
"ab",
"pqr",
"lmn",
"p"
]

function FindLongestStrings(arr){
    
    maxlength = 0;
    arr.forEach(element => {
       if(element.Length > maxlength)
       {
        maxlength = element.Length;
       } 
    });
    arr.forEach(elements => {
        if(elements.Length == maxlength)
        {

        }
    });
} 