// Задайте думерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int size1 = Convert.ToInt32(new Random().Next(4, 6));
int size2 = Convert.ToInt32(new Random().Next(8, 10));


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

void SortRowMaxToMin(int[,] array){
    for (int i = 0; i < size1; i++)
    {
        for(int minJ = 0; minJ < size2; minJ++){
            for (int j = 0; j < size2; j++)
            {
                
                if(array[i, minJ]> array[i, j]){
                    (array[i, minJ], array[i, j]) = (array[i, j], array[i, minJ]);
                    
                }
            
            }
        }
        
    }
}



int[,] array = CreateTwoLevelArray(size1, size2);

Console.WriteLine("Был создан массив:");
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Массив отсортирован по убыванию элементов в строке:");
SortRowMaxToMin(array);
PrintArray(array);


