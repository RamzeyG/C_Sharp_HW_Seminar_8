// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// задание из семинара


int size1 = Convert.ToInt32(new Random().Next(4, 6));
int size2 = Convert.ToInt32(new Random().Next(8, 10));
int minI = 0;
int minJ = 0;
int[,] NewArray = new int[size1-1, size2-1];

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
    for (int i = 0; i < array.GetUpperBound(0)+1; i++)
    {
        for (int j = 0; j < array.Length/(array.GetUpperBound(0) + 1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArrayWithoutMinimal(int[,] array, int minI, int minJ){
    for (int i = 0 ; i < size1; i++)
    {
        if(i != minI){
            for (int j = 0 ; j < size2; j++)
            {
                if(j != minJ){
                    Console.Write($"{array[i, j]} \t");
                }
            }
            Console.WriteLine();
        }
            
    }
}

void CreateArrayWithoutMinimal(int[,] array){
    

    int count1 = 0;
    
    int i = 0;
    
    
    while (count1 < size1-1){
        int count2 = 0;
        
        if(i != minI){
            int j = 0;
            while(count2 <size2-1){
                if(j != minJ){
                    
                    NewArray[count1, count2] = array[i,j];
                    j++;
                    count2++;
                }
                else{
                    j++;
                    NewArray[count1, count2] = array[i,j];
                    count2++;
                }
                   
            }
            count1++;
            i++;
        
            
        }    
        else{
            i++;
            
        }
        
        
    }
    
}

void FindMinimal(int[,] array){
    
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            
            if(array[minI, minJ]> array[i, j]){
                minI = i;
                minJ = j;
            }
           
        }
        
    }
    
}



int[,] array = CreateTwoLevelArray(size1, size2);

Console.WriteLine("Был создан массив:");
PrintArray(array);
Console.WriteLine();

Console.WriteLine();
FindMinimal(array);
Console.WriteLine($"Минимальное значение {array[minI, minJ]} находится в {minI + 1} строке, {minJ + 1} столбце");

Console.WriteLine();
Console.WriteLine($"Выводим массив методом исключения стобца и строки: ");
PrintArrayWithoutMinimal(array, minI, minJ);


Console.WriteLine();
Console.WriteLine($"Выводим массив методом создания нового массива: ");
CreateArrayWithoutMinimal(array);
PrintArray(NewArray);