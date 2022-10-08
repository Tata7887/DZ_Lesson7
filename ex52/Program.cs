//  Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размерность массива m=");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива n=");
int n = int.Parse(Console.ReadLine()!);
int[,] myMatrix = CreateIntMatrix(m,n);
PrintMatrix(myMatrix);

FindСolumnAvg(myMatrix);
	
int[,] CreateIntMatrix(int m, int n){
		int[,] resultMatrix = new int[m,n];
		Random rnd = new Random();
		for(int i = 0; i< m; i++){
			for(int j = 0; j < n; j++){
				resultMatrix[i,j] = rnd.Next(5);
			}
		}
		return resultMatrix;
	}

void PrintMatrix(int[,] matrix){
		for(int i = 0; i< matrix.GetLength(0);i++){
			for(int j = 0; j< matrix.GetLength(1);j++)
            {
				Console.Write($"{matrix[i, j],5} ");
         
			}
			Console.WriteLine();
		}
	}

void FindСolumnAvg(int[,] matrix){
		for(int j = 0; j< matrix.GetLength(1);j++){
			double sum = 0;
			for(int i = 0; i< matrix.GetLength(0);i++){
				sum = sum +  matrix[i, j];
			}
			Console.Write($"{sum / matrix.GetLength(0),5} ");
		}
	}