using System;
using System.Dynamic;

public class Seminar05 {
    static void Zadanie01(){
        
        Console.WriteLine("Программа приниmает на вход позицию элемента в двумерном массиве, \nи возвращяет его значение. ");
       

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


        int n = ReadInt("Введите количество строк массива: ");
        int m = ReadInt("Введите количество столбцов массива: ");

        int[,] Matrix = NewMatrx(n,m, 0, 50);

        Console.WriteLine("Исходный двумерный массив: ");
        PrintMatrx(Matrix);


        Console.Write("Введите индексы элемента через запятую: ");
        string[] index = Console.ReadLine().Split(", ");
        int a = int.Parse(index[0]);
        int b = int.Parse(index[1]);
        if (a<=n && b <=m) Console.WriteLine($"Элемент массива который находится в {a} строке {b} столбца равен {Matrix[a,b]}");
        else Console.WriteLine("Некорректный индекс элемента! ");


    }
    static void Main(){
        Zadanie01();
    }

}

