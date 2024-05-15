using System;

namespace ListDs
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            CustomList<int> numberList = new CustomList<int>();
            // CustomList<string> stringList = new CustomList<string>();
            // CustomList<char> string1List = new CustomList<char>();
            // CustomList numberList1 = new CustomList();
            numberList.Add(50);
            numberList.Add(30);
            numberList.Add(40);
            numberList.Add(10);
            numberList.Add(20);
            CustomList<int> numbers  = new CustomList<int>();
            numbers.Add(70);
            numbers.Add(60);
            numberList.AddRange(numbers);
            
            // CustomList<string> nameList = new CustomList<string>();
            // CustomList<char> charList = new CustomList<char>();
            bool result = numberList.Contains(60);
            System.Console.WriteLine(numberList.IndexOff(77)); 
            // numberList.Insert(3,100);
            // numberList.RemoveAt(3);
            // bool ans = numberList.RemoveMethod(50);
            // for( int i=0; i<numberList.Count; i++)
            // {
            //     System.Console.WriteLine(numberList[i]);
            // }
            // numberList.Reverse();
            // numberList.InsertRange(3,numbers);
            // numberList.Sort();
            // foreach(int i in numberList)
            // {
            //     System.Console.WriteLine(i);
            // }
            // System.Console.WriteLine(result);

            

        }
    }
}