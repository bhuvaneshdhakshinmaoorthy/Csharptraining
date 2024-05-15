using  System;

namespace DictionaryDs
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomDictionary<string,string> myDictionary = new CustomDictionary<string,string>();
            myDictionary.Add("SF4606","BHUVANESH");
            myDictionary.Add("SF4607","GNANAM");
            myDictionary.Add("SF4607","ANAND");
            myDictionary.Add("SF4609","DHANUSH");
            myDictionary.Add("SF4610","SHIBU");

            foreach(KeyValue<string, string> i in myDictionary)
            {
                // System.Console.WriteLine($"Key: {i.Key} Value: {i.Value}"); 
            }
            string name = myDictionary["SF4606"];
            System.Console.WriteLine(name);
            myDictionary["SF4606"] = "BHUVANESH WARAN";
            string name2 = myDictionary["SF4606"];
            System.Console.WriteLine(name2);
        }
    }
}