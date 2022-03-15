using System;


namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> StrSore = new DataStore<string>();
            StrSore.Data = "This is Generic  data type ";
            Console.WriteLine(StrSore.Data);
            /*We Cannot store int value if we did we will have compile time error try it */

            KeyValuePairs<int, string> dic = new KeyValuePairs<int, string>();
            dic.Key = 0;
            dic.Vlaue = "Zero";

            Console.WriteLine("the index: "+ dic.Key+ " is having the value :" + dic.Vlaue);

            KeyValuePairs<string, string> dept = new KeyValuePairs<string, string>();
            dept.Key = "IT";
            dept.Vlaue = "Information Technlogy";

            Console.WriteLine("The department short name is :" + dept.Key +"    " + "The dept fullname is: " + dept.Vlaue);


                


            
        }
    }

    class DataStore<T>
    {
        public T Data { get; set; }
    }

    class KeyValuePairs<TKey, TValue>
    {
        public TKey Key { set; get; }
        public TValue Vlaue { get; set; }

    }
}
