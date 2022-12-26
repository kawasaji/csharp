// ex1
//Console.Write("enter number ~# ");
//int num = Convert.ToInt32(Console.ReadLine());



//if (num % 3 == 0 && num % 5 == 0)
//{
//    Console.WriteLine("Fizz Buzz");
//}

//else if (num % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//}

//else
//{
//    Console.WriteLine(num);
//}

// ex2

//Console.Write("enter num ~#");
//int num = Convert.ToInt32(Console.ReadLine());

//Console.Write("enter num ~#");
//int percent = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(num / 100 * percent);

// ex3

//int number = 0;
//int k = 1000;

//for (int i = 0; i < 4; i++)
//{
//    number += Convert.ToInt32(Console.ReadLine()) * k;
//    k /= 10;
//}
//Console.WriteLine(number);

// ex4



//Console.Write("enter num ~#");
//int num = Convert.ToInt32(Console.ReadLine());
//string number = "";
//if (num < 100000 || num > 999999)
//{
//    Console.WriteLine("your number must be 6 digits");
//}

//else
//{

//    for (int i = 5; i != -1; i--)
//    {
//        number += num.ToString()[i];
//        //Console.WriteLine(num.ToString()[i]);
//    }


//}
//int newNum = Convert.ToInt32((string)number);
//Console.WriteLine(newNum);

// ex6

//Console.Write("enter num ~# ");
//double tempreture = Convert.ToInt32(Console.ReadLine());

//Console.Write("[1] - To celsius\n[2] - To fahrenheit\n~# ");
//int choice = Convert.ToInt32(Console.ReadLine());

//if (choice == 1)
//{
//    Console.WriteLine((tempreture - 32) * 5 /9);
//}

//else if (choice == 2)
//{
//    Console.WriteLine((tempreture * 9 / 5) + 32);
//}

//else
//{
//    Console.WriteLine("error");
//}

// ex7

//Console.Write("enter first num ~# ");
//int num1 = Convert.ToInt32(Console.ReadLine()); 

//Console.Write("enter second num ~# ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int tmp_num = num1;
//for (int i = 0; i < num2 - num1; i++)
//{
    
//    tmp_num++;
//    if (tmp_num % 2 == 0)
//    {
//        Console.WriteLine(tmp_num);
//    }
//}