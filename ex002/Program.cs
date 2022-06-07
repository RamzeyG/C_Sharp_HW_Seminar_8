// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int size1 = Convert.ToInt32(new Random().Next(4, 6));
int size2 = Convert.ToInt32(new Random().Next(8, 10));
int MinSumm = 0;
int[] summ = new int[size1];

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

void SummRowAndGetMinimal(int[,] array){
    
    for (int i = 0; i < size1; i++)
    {
        
        int SummRow = 0;
        for (int j = 0; j < size2; j++)
        {
            SummRow = SummRow + array[i, j];
        }
        summ[i] = SummRow;
    }
    
    for (int i = 0; i<size1; i++){
        if(summ[MinSumm]>summ[i]){
            MinSumm = i;
        }
    }
    
}

void OutputArrayAndSumm(int[,] array){
    Console.WriteLine();
    Console.WriteLine($"Был создан массив размером: {size2} столбцов, {size1} строк.");
    Console.WriteLine($"{MinSumm+1} строка с наименьшей суммой элементов отмечена знаком '<--'.");
    Console.WriteLine();

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        if (summ[i] == summ[MinSumm]){
            Console.Write($"Сумма = {summ[i]} <--");
        }
        else{
            Console.Write($"Сумма = {summ[i]}");
        }
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = CreateTwoLevelArray(size1, size2);
SummRowAndGetMinimal(array);
OutputArrayAndSumm(array);