let matrix = [
    [1, 1, 1, 2],
    [8, 5, 0, 4],
    [2, 1, 3, 6],
];

let position = 2;
PrintResult(ExtractMatrixColumn(matrix, position));

function PrintResult (args)
{
    for (let index = 0; index < args.length; index++) {
        const element = args[index];
        alert(element);
    }
}

 function  ExtractMatrixColumn(matrix,  position)
        {
            const column = [];
            for(i = 0; i < matrix.length; i++)
            {
                for(j =0 ; j < matrix.length; j++)
                {
                    if (j == position)
                    {
                        column.push(matrix[i][j]);
                    }
                }
            }
            return column;
        }