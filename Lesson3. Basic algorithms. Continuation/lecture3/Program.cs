// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Consle.WriteLine(Math.Pow(3,3));
// System.Console.WriteLine(Math.Round(Math.Sqrt(27),3));

int[] coordsA = new int [2];
coordsA [0] = Convert.ToInt32(Console.ReadLine);
coordsA [1] = Convert.ToInt32(Console.ReadLine);

int[] coordsB = new int[2];
coordsB [0] = Convert.ToInt32(Console.ReadLine);
coordsB [1] = Convert.ToInt32(Console.ReadLine);

double distance = Math.Sqrt(Math.Pow(coordsA[0]-coordsB[0],2)+ Math.Pow(coordsA[1]-coordsB[1],2));
