// ex 1
//int[] arr = new int[5];

//int[][] arr_a = new int[5][];


//for (int i = 0; i < 5; i++)
//{
//    Console.Write($"enter {i + 1} number ~# ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}


//for (int i = 0; i < arr.Length; i++) // Вывод
//{
//    Console.WriteLine(arr[i]);
//}

//Console.WriteLine();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Random rnd = new Random();
//        arr_a[i] = new int[5] { rnd.Next(10), rnd.Next(10), rnd.Next(10), rnd.Next(10), rnd.Next(10) };
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write($"{arr_a[i][j]} ");
//    }

//    Console.WriteLine();
//}

//Console.WriteLine();

//Console.WriteLine($"{arr.Min()} {arr.Max()}");

//Console.WriteLine();

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"{arr_a[i].Min()} {arr_a[i].Max()}");
//    Console.WriteLine();
//}

// ex 2

//int[][] arr_b = new int[5][];
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Random rnd = new Random();
//        arr_b[i] = new int[5] { rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100) };
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write($"{arr_b[i][j]} ");
//    }

//    Console.WriteLine();
//}


//int[] min_arr = new int[5];
//int[] max_arr = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        min_arr[i] = arr_b[i].Min();
//        max_arr[i] = arr_b[i].Max();
//    }
//}
//int min_b = min_arr.Min();
//int max_b = max_arr.Max();
//Console.WriteLine("\n");

//Console.WriteLine($"{min_b} {max_b}");

//int min_index_i = 0;
//int max_index_i = 0;
//int min_index_j = 0;
//int max_index_j = 0;

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if (arr_b[i][j] == min_b)
//        {
//            min_index_i = i; min_index_j = j;
            
//        }
//        else if (arr_b[i][j] == max_b)
//        {
//            max_index_i = i; max_index_j = j;
//        }
//    }
//}

//int sum = 0;

//for (int i = min_index_i; i < max_index_i; i++)
//{
//    for (int j = min_index_j; j < max_index_j; j++)
//    {
//        sum = sum + arr_b[i][j];
//        Console.WriteLine(arr_b[i][j]);
//    }
//}

//Console.WriteLine($"\nsum = {sum}");

// ex 3

//Console.Write("write text ~# ");
//string name = Console.ReadLine();

//string newName = name;


//Console.Write("enter rot ~# ");
//int rot = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < name.Length; i++)
//{
//    //new_name[i] = Convert.ToChar(name[i]);
//    newName[i] = Convert.ToInt32(name[i]) + rot;
//}
