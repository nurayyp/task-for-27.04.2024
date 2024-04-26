//1ci yol
//string[] cars = { "BMW", "Mercedes", "Audi", "Porche" };
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}
//2ci yol
//string[] cars = { "BMW", "Mercedes", "Audi", "Porche" };
//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//string word = "salam";
//for (int i = 0; i < word.Length; i++)
//{
//    Console.WriteLine(word[i]);
//}

//int[,] array =
//{
//    {100,200,300 },
//    {50,40,20 },
//    {70,90,30 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}


//1
//int[,] array =
//{
//    {1,2,3 },
//    {4,5,6 },
//    {7,8,9 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//2
//int sum = 0;
//int[,] array =
//{
//    {1,2,3 },
//    {4,5,6 },
//    {7,8,9 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[i, j];
//    }
//}
//Console.WriteLine(sum);

//3
//int sum = 0;
//int[,] array =
//{
//    {1,2,3 },
//    {4,5,6 },
//    {7,8,9 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    sum += array[i,0];
//}
//Console.WriteLine(sum);

//4
//int[,] array =
//{
//    {1,-2,3 },
//    {4,5,-6},
//    {-7,8,9}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i,j] < 0)
//        {
//            Console.WriteLine(array[i,j]);
//        }
//    }
//}

//5
//int min = 1;
//int max = 1;
//int[,] array =
//{
//    {1,-2,3 },
//    {4,5,-6},
//    {-7,8,9}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++) 
//    {
//        if (array[i,j] > max)
//        {
//            max = array[i,j];
//        }
//        else if (array[i,j] < min)
//        {
//            min = array[i,j];
//        }
//    }
//}
//Console.WriteLine(max);
//Console.WriteLine(min);

//6
//using System.ComponentModel.Design;

//int[,] array =
//{
//    {1,2,3 },
//    {-4,5,6 },
//    {7,8,-9 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] == 0)
//        {
//            continue;
//        }
//        else if (array[i, j] > 0)
//        {
//            if (array[i, j] % 2 == 0)
//            {
//                array[i, j] = 2;
//            }
//            else
//            {
//                array[i, j] = 1;
//            }
//        }
//        else
//        {
//            if (array[i, j] % 2 == 0)
//            {
//                array[i, j] = -2;
//            }
//            else
//            {
//                array[i, j] = -1;
//            }
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//7
//int[,] array =
//{
//    {1,2,3,4 },
//    {5,6,7,8 },
//    {9,10,11,12},
//    {10,11,12,13}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, 1] = 0;
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//8
//int[,] array =
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, 2] = 0;
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//9
//int sum = 0;
//int[,] array =
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i==j)
//        {
//            sum += array[i,j];
//        }
//    }
//}
//Console.WriteLine(sum);

//10
//int sum = 0;
//int[,] array =
//{
//    {1,2,3,4 },
//    {5,6,7,8 },
//    {9,10,11,12},
//    {10,11,12,13}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i==j)
//        {
//            sum += array[i,j];
//        }
//    }
//}
//Console.WriteLine(sum);

//11
//int sum = 0;
//int[,] array =
//{
//    {1,2,3,4,5},
//    {6,7,8,9,10},
//    {11,12,13,14,15},
//    {16,17,18,19,20},
//    {21,22,23,24,25}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i>j)
//        {
//            sum += array[i, j]; 
//        }
//    }
//}
//Console.WriteLine(sum);

//12
//int sum = 0;
//int[,] array =
//{
//    {1,2,3,4,5},
//    {6,7,8,9,10},
//    {11,12,13,14,15},
//    {16,17,18,19,20},
//    {21,22,23,24,25}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i < j)
//        {
//            sum += array[i, j];
//        }
//    }
//}
//Console.WriteLine(sum);

//13
//int[,] array1 =
//{
//    {1,2,3},
//    {4,5,6},
//    {8,9,10}
//};
//int[,] array2 =
//{
//    {11,12,13},
//    {14,15,16},
//    {17,18,19}
//};
//for (int i = 0; i < array1.GetLength(0); i++)
//{
//    for (int j = 0; j < array2.GetLength(0); j++)
//    {
//        Console.Write(array1[i, j] + array2[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//14
//int row1 = 0;
//int row2 = 0;
//int row3 = 0;
//int[,] array =
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    row1 += array[0, i];
//    row2 += array[1, i];
//    row3 += array[2, i];
//}
//Console.WriteLine(row1);
//Console.WriteLine(row2);
//Console.WriteLine(row3);

//15
//int col1 = 0;
//int col2 = 0;
//int col3 = 0;
//int[,] array =
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    col1 += array[i,0];
//    col2 += array[i,1];
//    col3 += array[i,2];
//}
//Console.WriteLine(col1);
//Console.WriteLine(col2);
//Console.WriteLine(col3);

//16
//int[,] array =
//{
//   {1, 1, 5, 0, 1, 1},
//   {1, 1, 2, 0, 1, 1},
//   {1, 1, 3, 0, 1, 1},
//   {1, 1, 4, 0, 1, 1}
//};
//int shift = 3;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = array.GetLength(1) - 1; j >= 0; j--)
//    {
//        if (j - shift >= 0)
//        {
//            array[i, j] = array[i, j - shift];
//        }
//        else
//        {
//            array[i, j] = 0;
//        }
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//17
//int[,] array1 =
//{
//    {1,2,3},
//    {4,5,6},
//    {8,9,10}
//};
//int[,] array2 =
//{
//    {11,12,13},
//    {14,15,16},
//    {17,18,19}
//};
//for (int i = 0; i < array1.GetLength(0); i++)
//{
//    for (int j = 0; j < array2.GetLength(0); j++)
//    {
//        Console.Write(array1[i, j] * array2[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//18
//bool iscomplex = false;
//int[,] array =
//{
//    {1,2,3,},
//    {4,5,6,},
//    {7,8,9},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i,j] <= 1)
//        {
//            continue;
//        }
//        else
//        {
//            iscomplex = false;
//            int squareroot = Convert.ToInt32(Math.Sqrt(array[i,j]));
//            for (int k = 2; k <= squareroot; k++)
//            {
//                if(array[i, j] % k == 0)
//                {
//                    iscomplex = true;
//                }
//            }
//            if (! iscomplex)
//            {
//                Console.WriteLine(array[i,j]);
//            }
//        }
//    }
//}