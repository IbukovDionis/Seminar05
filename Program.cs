using System;
using System.Dynamic;

public class Seminar05 {
    static void Zadanie01(){
        
        int ReadInt(string text){ //функция 
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        int[,] NewMatrx(int row, int col, int LR, int RR){
            int[,] Matrix = new int[row,col];
            Random R = new Random();
            for (int i = 0; i < row; i++){
                for (int j = 0; j < col; j++){
                    Matrix[i,j] = R.Next(LR,RR+1);
                }
            }
            return Matrix;
        }
        
        void PrintMatrx(int [,] Matrix){
            for (int i = 0; i < Matrix.GetLength(0); i++){
                for (int j = 0; j < Matrix.GetLength(1); j++){
                    Console.Write(Matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }



        void ReplaceInMatrix(int [,] Matrix,int print){
            int Replace;
            for (int column = 0; column < Matrix.GetLength(1); column++ ){
                Replace = Matrix[0,column];
                Matrix[0,column] = Matrix[Matrix.GetLength(0)-1,column];
                Matrix[Matrix.GetLength(0)-1,column] = Replace;
            }
            if (print == 0) PrintMatrx(Matrix);
        }


        int FindMinSummSrting(int [,] Matrix, int operation){
            int MinStringSumm = 0;
            for (int j = 0; j < Matrix.GetLength(1); j++){
                    MinStringSumm += Matrix[0,j];
                }
            
            int ResultIndex = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++){
                int summ = 0;
                for (int j = 0; j < Matrix.GetLength(1); j++){
                    summ += Matrix[i,j];
                }
                if (MinStringSumm >= summ) {
                    MinStringSumm = summ;
                    ResultIndex = i;
                }
            }

            if (operation == 1) return MinStringSumm;
            if (operation == 2) return ResultIndex;
            else return 0;
        }

        

        Console.WriteLine("Домашнее задание к семинару №5 (Работа с двумерными массивами)\n\nДля начала создадим двумерный массив");
        int n = ReadInt("Введите количество строк массива: ");
        int m = ReadInt("Введите количество столбцов массива: ");
        int[,] Matrix = NewMatrx(n,m, 0, 50);


        // Задание 1
        Console.WriteLine("\nЗадание 1\nПрограмма приниmает на вход позицию элемента в двумерном массиве, и возвращяет его значение. ");
        Console.WriteLine("Исходный двумерный массив: ");
        PrintMatrx(Matrix);
        Console.Write("Введите индексы элемента через пробел в одной строке: ");
        string[] index = Console.ReadLine().Split(" ");
        int a = int.Parse(index[0]);
        int b = int.Parse(index[1]);
        if (a<n && b <m) Console.WriteLine($"Элемент массива который находится в {a} строке {b} столбца равен {Matrix[a,b]}");
        else {
            Console.WriteLine("Элемента с таким индексом нет!");
            }

        // Задание 2
        Console.WriteLine("\nЗадание 2\nПрограмма меняет местами первую и последнюю строки массива.");
        Console.WriteLine("Исходный массив: ");
        PrintMatrx(Matrix);
        Console.WriteLine("Полученный в результате массив: ");
        ReplaceInMatrix(Matrix,0);
        ReplaceInMatrix(Matrix,1);

        // Задание 3
        Console.WriteLine("\nЗадание 3 \nПрограмма находит строку с наименьшей суммой элементов в данном массиве: ");
        PrintMatrx(Matrix);
        Console.WriteLine($"В строке с индексом {FindMinSummSrting(Matrix,2)} наименьшая сумма элементов - {FindMinSummSrting(Matrix,1)} ");

       
        
    }



    static void Main(){
        


        Zadanie01();
    }

}

