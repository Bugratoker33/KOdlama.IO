using System.Net.Http.Headers;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {//generic yapılara örnek
            
            MyList<string> myList = new MyList<string>();
            myList.Add("Engin");
            myList.Add("buğra");

           MyList<int> myList1 = new MyList<int>();

            myList1.Add(1);

            
           
            
           
        }
    }
}