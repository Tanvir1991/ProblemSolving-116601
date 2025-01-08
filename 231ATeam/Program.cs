


int n = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int patya = int.Parse(input[0]);
    int vasya = int.Parse(input[1]);
    int tonya = int.Parse(input[2]);

    if (patya + vasya + tonya >= 2)
    {
        count++;

    }


}
Console.WriteLine(count);



//int n = int.Parse(Console.ReadLine());

//var count = Enumerable.Range(0, n).Select(_ => Console.ReadLine().Split(' ').Select(int.Parse).Sum()).Count(sum => sum >= 2);

//Console.WriteLine(count);


//int n = int.Parse(Console.ReadLine());

//int count = 0;
//for (int i = 0; i < n; i++)
//{

//    if (Array.ConvertAll(Console.ReadLine().Split(), int.Parse).Sum() >= 2)
//    {
//        count++;

//    }

//}
//Console.WriteLine(count);

//int n = int.Parse(Console.ReadLine()); // Read the number of problems
//int count = 0;

//for (int i = 0; i < n; i++)
//{

//    if (Array.ConvertAll(Console.ReadLine().Split(), int.Parse).Sum() >= 2)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count); // Print the result








//// Read the number of problems
//int n = int.Parse(Console.ReadLine());

//// Use LINQ to read and process the input, counting valid problems
//int count = Enumerable.Range(0, n)
//    .Select(_ => Console.ReadLine().Split(' ').Select(int.Parse).Sum())
//    .Count(sum => sum >= 2);

//int test = Enumerable.Range(0, n).Select(_ => Console.ReadLine().Split(' ').Select(int.Parse).Sum()).Count(sum => sum >= 2);

//// Output the result
//Console.WriteLine(count);






//// Read the number of problems
//int n = int.Parse(Console.ReadLine());
//int count = 0;

//for (int i = 0; i < n; i++)
//{
//    // Read the opinions for the current problem
//    string[] input = Console.ReadLine().Split(' ');
//    int petya = int.Parse(input[0]);
//    int vasya = int.Parse(input[1]);
//    int tonya = int.Parse(input[2]);

//    // Check if at least two friends are confident
//    if (petya + vasya + tonya >= 2)
//    {
//        count++;
//    }
//}

//// Output the count of problems they will implement
//Console.WriteLine(count);
