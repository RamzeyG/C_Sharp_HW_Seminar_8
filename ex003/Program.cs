// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int size1 = Convert.ToInt32(new Random().Next(5, 10));
int size2 = Convert.ToInt32(new Random().Next(5, 10));

int[,] CreateTwoLevelArray(int size1, int size2){
    
       
    int [,] array = new int[size1, size2];
    int count1 = 0;
     

    while (count1 < size1){
        int count2 = 0;
        while(count2 <size2){
            Random x = new Random();
            int random1 = Convert.ToInt32(x.Next(0, 100));
            
            
            array[count1, count2] = random1;
            

            count2++;
        }
        count1++;
    }
    
    return array;
}

void PrintArray(int[,] array){
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ProductArray(int[,] array1, int[,] array2){
    for (int i = 0; i < size1; i++){
        for (int j = 0; j<size2; j++){
            Console.Write($"{array1[i, j]}*{array2[i, j]} = {array1[i, j] * array2[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int[,] array1 = CreateTwoLevelArray(size1, size2);
int[,] array2 = CreateTwoLevelArray(size1, size2);

Console.WriteLine("Первый массив:");
PrintArray(array1);

Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintArray(array2);

Console.WriteLine();
Console.WriteLine("Произведение двух массивов:");
ProductArray(array1, array2);
