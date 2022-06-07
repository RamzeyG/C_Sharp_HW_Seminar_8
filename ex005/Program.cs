// Составить частотный словарь элементов двумерного массива. Частотный словарь содежржит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0-9.


int size1 = 5;//Convert.ToInt32(new Random().Next(10, 10));
int size2 = 5;//Convert.ToInt32(new Random().Next(10, 10));

int[] x = new int[10];

int[,] CreateTwoLevelArray(int size1, int size2){
    
       
    int [,] array = new int[size1, size2];
    int count1 = 0;
     

    while (count1 < size1){
        int count2 = 0;
        while(count2 <size2){
            Random x = new Random();
            int random1 = Convert.ToInt32(x.Next(0, 10));
            
            
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

void FrequencyDictionary(int[,] array){
    int count = 0;
    
    while(count < 10){
        int i = 0;
        while(i < size1){
            int j = 0;
            while(j<size2){
                if (array[i, j] == count){
                    x[count]++;
                }
                j++;
            }
            i++;
        }
        count++;
    }
    
    Console.WriteLine("Массив данных:");
    for (int i = 0; i < 10; i++){
        Console.WriteLine($" Число {i}, встречается -- {x[i]} раз \t");
    }

}



int[,] array = CreateTwoLevelArray(size1, size2);

Console.WriteLine("Был создан массив:");
PrintArray(array);
Console.WriteLine();

FrequencyDictionary(array);

