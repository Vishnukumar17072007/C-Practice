using C__Practice.OOPS;
using C__Practice.Stack_and_Queue;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] x)
        {
            //Diamond a = new Diamond();
            //HallowSquare b = new HallowSquare();

            //a.Print();
            //b.Print();

            //// Array

            //Find Minimum and Maximum value in an array

            //HighestLowestInArray c = new HighestLowestInArray();
            ////c.Print();
            //var minAndMaxValue = c.FindMinAndMaxValue();
            //Console.WriteLine($"Highest value in Array : {minAndMaxValue.Max}");
            //Console.WriteLine($"Lowest value in Array : {minAndMaxValue.Min}");

            //Slice the string into array

            //Slicing d = new Slicing();
            //string[] arr = d.Slice();

            //Search Target in an Array

            //SearchTarget e = new SearchTarget();
            //Console.Write("Enter target to be searched : ");
            //string target = Console.ReadLine();
            //int index = e.Search(arr, target);

            // Merge Sort

            //MergeSort f = new MergeSort();
            //Console.Write("Enter array to sort : ");
            //string input = Console.ReadLine();
            //var split = d.Slice(input, ',').ToArray();
            //int[] arr = System.Array.ConvertAll(split, int.Parse);
            //f.Merge_Sort(arr, 0, arr.Length-1);
            //Console.WriteLine("Sorted Array : " + string.Join(", ", arr));

            //Find Sum of an Array

            //ArraySum g = new ArraySum();
            //int[] arr = [1, 2, 3, 4, 5];
            //int sumArray = g.Sum(arr);
            //float average = g.Average(sumArray, arr);

            //Reverse an array

            //ReverseArray h = new ReverseArray();
            //Console.Write("Enter string to reverse : ");
            //string str = Console.ReadLine();
            //string strRev = h.Reverse(str);
            //Console.WriteLine($"Reverse Of the string : {strRev}");

            //Count Vowels and Consonants in an string

            //VowelsAndConsonants i = new VowelsAndConsonants();
            //Console.Write("Enter a string to count vowels and consonants : ");
            //string str = Console.ReadLine();
            //var vowelsAndConsonants = i.count(str);
            //Console.WriteLine($"Vowels = {vowelsAndConsonants.Vowels} \n Consonants = {vowelsAndConsonants.Consonants}");

            //Fibonacci series

            //Factorial j = new Factorial();
            //Console.Write("Enter a number to find Factorial : ");
            //int input = int.Parse(Console.ReadLine());
            //int fibo = j.Factorials(input);
            //Console.WriteLine($"Factorial of {input} is {fibo}");

            //Find Prime number upto N numbers

            //PrimeNumber k = new PrimeNumber();
            //Console.Write("Enter a number to find prime number upto that number : ");
            //int num = int.Parse(Console.ReadLine());
            //k.PrintPrimeNumbers(num);

            //Swap Two Numbers without temp variable

            //SwapNumbers l = new SwapNumbers();
            //Console.Write("Enter value 1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter value 2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //var swappedNumbers = l.swap(num1, num2);
            //Console.WriteLine("Before Swap ");
            //Console.WriteLine($"num1 = {num1} \nnum2 = {num2}");
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"num1 = {swappedNumbers.Num1} \nnum2 = {swappedNumbers.Num2}");

            //FizzBuzz game

            //FizzBuzz game = new FizzBuzz();
            //Console.Write("Enter a number greater than 15(optional but recommended) : ");
            //int gameValue = int.Parse(Console.ReadLine());
            //game.Start(gameValue);

            //Find second largest element in an array

            //SecondLargest m = new SecondLargest();
            //int[] arr = { 54,67,34,98,12,09,34,86 };
            //int secondLargest = m.find(arr);

            //Rotate an Array by it's k position

            //RotateArray m = new RotateArray();
            //Console.WriteLine("Rotating Array Elements by it's k position");
            //Console.Write("Enter left rotation number : ");
            //int left = int.Parse(Console.ReadLine());
            //Console.Write("Enter right rotation number : ");
            //int right = int.Parse(Console.ReadLine());
            //int[] rotatedArray = m.Rotate([1, 2, 3, 4, 5], left, right);
            //if (rotatedArray.Length!= 0 )
            //{
            //    Console.WriteLine($"Rotated Array : {string.Join(", ", rotatedArray)}");
            //}

            //Remove Duplicate Values from the array

            //Console.WriteLine("Remove duplicate values");
            //Duplicate duplicateArr = new Duplicate();
            //string[] resultArr = duplicateArr.Find(["hi", "vishnu", "vishnu", "kumar", "vishnu kumar", "vishnu kumar", "", " "]);
            //Console.WriteLine($"After removing duplicate elements : {String.Join(", ",resultArr)}");

            //Find missing number from 1 to n series

            //MissingNum n = new MissingNum();
            //n.Find([1, 3, 4, 7, 4, 15, 8, 2]);

            //Transpose Matrix

            //Console.WriteLine("Transpose Matrix");
            //TransposeMatrix mat = new TransposeMatrix();
            //int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] TransMatrix = mat.Transpose(matrix);
            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for(int j = 0; j< matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{TransMatrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //Anagram - checking if str2 contains all the characters in str1

            //Console.WriteLine("Anagram");
            //Anagram anagram = new Anagram();
            //Console.Write("Enter String 1 : ");
            //string str1 = Console.ReadLine();
            //Console.Write("Enter String 2 : ");
            //string str2 = Console.ReadLine();
            //bool isAnagram = anagram.find(str1, str2);

            //if (isAnagram)
            //{
            //    Console.WriteLine("Given strings are Anagram!.");
            //}
            //else
            //{
            //    Console.WriteLine("Given Strings are not Anagram!.");
            //}

            //Find Longest word in a string

            //Console.WriteLine("Longest word in a string");
            //LongestWord str1 = new LongestWord();
            //Console.Write("Enter a string with backspaces : ");
            //string str = Console.ReadLine();
            //string LnWord = str1.FindLnString(str);
            //Console.WriteLine("Longest Word : " + LnWord);

            //Find the index of the substring in main string

            //Console.WriteLine("Find the IndexOf the substring");
            //IndexOf strInd = new IndexOf();
            //Console.Write("Enter the main string : ");
            //string mainString = Console.ReadLine();
            //Console.Write("Enter substring : ");
            //string substring = Console.ReadLine();
            //int index = strInd.Find(mainString, substring);
            //if (index == -1)
            //{
            //    Console.WriteLine("Substring not found in main string!");
            //}
            //else
            //{
            //    Console.WriteLine("Substring found in index : " + index);
            //}

            //// Find if the main string contains the substring
            //// IndexOf and Contains classes are used together to get the output!

            //Contains strCon = new Contains();
            //Console.WriteLine("Conatins substring or not!");
            //bool isPresent = strCon.Find(mainString, substring);
            //if (isPresent)
            //{
            //    Console.WriteLine("Yes, main string contains substring!.");
            //}
            //else
            //{
            //    Console.WriteLine("No, main string does not conatins substring!.");
            //}

            //Quick sort

            //Console.WriteLine("Quick Sort");
            //QuickSort arr1 = new QuickSort();
            //int[] arr = [7, 2, 6, 8, 3, 4];
            //arr1.sort(arr, 0, arr.Length - 1);

            //Binary Search

            //BinarySearch nums1 = new BinarySearch();//Binary search is used in sorted array only
            //int[] nums = { 2, 4, 7, 9, 23, 76, 89, 123, 456 };
            //int target = 89;
            ////Iterative Search
            //int IterativeIndex = nums1.IterativeSearch(nums, target);

            //if(IterativeIndex < 0)
            //{
            //    Console.WriteLine("Target not found!.");
            //}
            //else
            //{
            //    Console.WriteLine($"Target found in index : {IterativeIndex}");
            //}

            ////Recursive Search
            //int RecursiveIndex = nums1.RecursiveSearch(nums, target, 0, nums.Length);

            //if (RecursiveIndex < 0)
            //{
            //    Console.WriteLine("Target not found!.");
            //}
            //else
            //{
            //    Console.WriteLine($"Target found in index : {RecursiveIndex}");
            //}

            //Selection Sort

            //Console.WriteLine("Selection Sort");
            //SelectionSort nums1 = new SelectionSort();
            //int[] nums = { 5, 3, 8, 9, 2, 3 };
            //int[] SortedNums = nums1.Sort(nums);
            //Console.Write($"{string.Join(", ", SortedNums)}");

            //CustomList

            //CustomList<int> myList = new CustomList<int>();
            //myList.Add(7);
            //myList.Add(6);
            //myList.Add(5);
            //myList.Add(4);
            //myList.Add(3);
            //myList.Insert(3, 9);
            //myList.RemoveAt(0);

            //for(int i = 0; i<myList.Count; i++)
            //{
            //    Console.Write(myList[i] + ", ");
            //}

            //Bank Account OOP's

            //SavingAccount user1 = new SavingAccount();
            //user1.Deposit(4000);
            //user1.Withdraw(3500);
            //user1.CheckBalance();

            //CurrentAccount user2 = new CurrentAccount();
            //user2.Deposit(2000);
            //user2.Withdraw(3000);
            //user2.CheckBalance();

            //Shapes OOP's

            //Circle shape1 = new Circle();
            //double result1 = shape1.Area();
            //Console.WriteLine("Area of circle : " +  result1);

            //Rectangle shape2 = new Rectangle();
            //double result2 = shape2.Area();
            //Console.WriteLine("Area of Rectangle : " + result2);

            //Triangle shape3 = new Triangle();
            //double result3 = shape3.Area();
            //Console.WriteLine("Area of Triangle : " + result3);

            //Stack

            //GStack<int> nums = new GStack<int>();
            //nums.Push(1);
            //nums.Push(2);
            //nums.Push(3);
            //nums.Push(4);
            //nums.Push(5);
            //nums.Push(6);
            //int removedNum = nums.Pop();
            //int peekedElement = nums.Peek();
            //nums.Display();
            //Console.WriteLine("\nRemoved item = " + removedNum);
            //Console.WriteLine("Peeked Element = " + peekedElement);

            //Queue

            //GQueue<int> nums = new GQueue<int>();
            //nums.Push(1);
            //nums.Push(2);
            //nums.Push(3);
            //nums.Push(4);
            //nums.Push(5);
            //int removedNum = nums.Pop();
            //int peekedNum = nums.Peek();
            //Console.WriteLine("Removed Element = " + removedNum);
            //Console.WriteLine("Peeked Element = " + peekedNum);
            //nums.Display();

            //Abstract Example

            List<AbstractEg> emps = new List<AbstractEg> { new Employee("vishnu"), new HR("siva"), new SoftwareEngineer("muthu") };
            for(int i = 0; i<emps.Count; i++)
            {
                emps[i].DispName();
                int salary = emps[i].DispSalary();
                Console.WriteLine("Salary: " + salary);
            }

            Console.ReadKey();
        }
    }
}