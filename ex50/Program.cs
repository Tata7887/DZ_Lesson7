//  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет


Console.Write("Введите размерность массива m=");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива n=");
int n = int.Parse(Console.ReadLine()!);
int[,] myMatrix = CreateIntMatrix(m,n);
PrintMatrix(myMatrix);

Console.Write("Введите позицию искомого элемента i=");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию искомого элемента j=");
int j = int.Parse(Console.ReadLine()!);

FindElement(i, j, myMatrix);
	




int[,] CreateIntMatrix(int m, int n){
		int[,] resultMatrix = new int[m,n];
		Random rnd = new Random();
		for(int i = 0; i< m; i++){
			for(int j = 0; j < n; j++){
				resultMatrix[i,j] = rnd.Next(100);
			}
		}
		return resultMatrix;
	}

void PrintMatrix(int[,] matrix){
		for(int i = 0; i< matrix.GetLength(0);i++){
			for(int j = 0; j< matrix.GetLength(1);j++){
				Console.Write(matrix[i,j] + "  ");
			}
			Console.WriteLine();
		}
	}

void FindElement(int i, int j, int[,] matrix){
		if (i < 1 || j < 1 || i > matrix.GetLength(0) || j > matrix.GetLength(1)){
			Console.WriteLine("Введены индексы больше размерности массива. Такого элемента тут нет");
		} else{
			Console.WriteLine("Элемент на позиции " + i + ", " + j + " = " + matrix[i -1, j -1]);
		}
}	