﻿namespace DataStructure.ObjectReferences
{

    

    internal class Program
    {
        delegate void MgTestDelegate();
        static MgTestDelegate mgTestDelegate;


        delegate int MgTestDelegateGivenAParameter(int num1);
        static MgTestDelegateGivenAParameter testDelegateGivenAParameter;
        static void Main(string[] args)
        {
            #region Referanse Types
            //Otomobil otomobil1 = new Otomobil("Audi");
            //Console.WriteLine(otomobil1.Marka);

            //Otomobil otomobil2;
            //otomobil2 = otomobil1;

            //otomobil1 = new Otomobil("Opel");

            //Console.WriteLine(otomobil2.Marka);
            //Console.WriteLine(otomobil1.Marka);

            //otomobil2 = new Otomobil("Mercedes");

            //Console.WriteLine(otomobil2.Marka);
            //Console.ReadLine(); 
            #endregion

            #region BinarySearch
            //int[] numbers = { 2,4,6,8,10,12,14,16,18,20,22,24,26,28,30 };
            //int target = 30;
            //int index = BinarySearch(numbers, target);
            //if (index != -1)
            //{
            //    Console.WriteLine($"The value {target} was found at index {index}");
            //}
            //else 
            //{
            //    Console.WriteLine("Value not found");
            //} 
            #endregion


            string[,] arr = new string[,]
            {
                { "John","Doe","30" },
                { "Jane","Smith","25" },
                { "Bob","Johnson","35" },
                { "Old","Man","191" },
                { "Jess","Dunk","19" },
                { "Jeff","Dave","23" },
                { "Frank","Grimes","35" },
                { "Older","Man","3500" },
                { "Old","Dude","230" }

            };
            // did not complete

            //int a, b;

            //Test(out a, out b);

            //SortStringArray(arr);

            //mgTestDelegate = new MgTestDelegate(MgTestMethod);
            //MgTestDelegate mgTestDelegate = new MgTestDelegate(() =>
            //{
            //    Console.WriteLine("bu da anonim");
            //});
            //mgTestDelegate += MgTestMethod;
            //mgTestDelegate.Invoke();


            testDelegateGivenAParameter = new MgTestDelegateGivenAParameter((int num1) =>
            {
                return num1;
            });


            var result = testDelegateGivenAParameter.Invoke(45);

            Console.WriteLine(result);
            Console.ReadLine();

        }

        static void MgTestMethod() 
        {
            Console.WriteLine("Dur gardaş test ediyom");
        }
        static void Test(out int x, out int y) { x = 42; y = 123; Console.WriteLine(x == y); }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right) 
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target) 
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public static void SortStringArray(string[,] data) 
        {
            for (int i = 0; i < data.GetLength(0); i++) 
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($"{data[i,j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
