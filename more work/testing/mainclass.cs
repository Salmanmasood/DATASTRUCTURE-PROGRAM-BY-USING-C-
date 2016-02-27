using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class mainclass
    {
        public void emptyarray()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There is nothing inserted yet.....");
            Console.ForegroundColor = ConsoleColor.White;

        }


        public void mainmenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===================================MAIN MENU===================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n1-Create an Array");
            Console.WriteLine("\n2-Insert element in Array");
            Console.WriteLine("\n3-Replace element in Array");
            Console.WriteLine("\n4-Delete element in Array");
            Console.WriteLine("\n5-Search element in Array");
            Console.WriteLine("\n6-Sort the Array");
            Console.WriteLine("\n7-Display the Array");
            Console.WriteLine("\n8-Switiching  Array");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("select a no. to perform the following the funtion: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
          
        }


        public int createarray()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("============================CREATING AN ARRAY============================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Create Array A:");
            Console.WriteLine("\n2-Create Array B:");
            Console.Write("\nSelect a Number to Create the respective Array: ");
                int arrayselection = int.Parse(Console.ReadLine());
           
            
            return arrayselection;
       
        }

      public void invalidinput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input!!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int insertarray()
      {

          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("=======================INSERTING ELEMENTS IN ARRAY=======================");

          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("\n1-Insertion by Last availabe space");
          Console.WriteLine("\n2-Insertion by Index");
          Console.Write("\n select a number to perform the following funtions: ");
          int input = int.Parse(Console.ReadLine());
          return input;

      }
        public int replacearray()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================REPLACEMENT ELEMENTS IN ARRAY=======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Replacement by Elements");
            Console.WriteLine("\n2-Replacement by Index");
            Console.Write("\n select a number to perform the following funtions: ");
            int input = int.Parse(Console.ReadLine());
            return input;
            
        }
        public int DELETEARRAY()
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================DELETE ELEMENTS IN ARRAY=======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Deletion by Elements");
            Console.WriteLine("\n2-Deletion by Index");
            Console.Write("\n select a number to perform the following funtions: ");
            int deleteoption = int.Parse(Console.ReadLine());
            return deleteoption;
        }
        public int search()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================SEARCH ELEMENTS IN ARRAY=======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Search by Elements");
            Console.WriteLine("\n2-Search by Index");
            Console.Write("\n select a number to perform the following funtions: ");
            int searchoption = int.Parse(Console.ReadLine());

            return searchoption;

        }
        public int sort()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================SORT ELEMENTS IN ARRAY=======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Insertion Sort");
            Console.WriteLine("\n2-Merge Sort");
            Console.WriteLine("\n3-Bubble Sort");
            Console.WriteLine("\n4-Quick Sort");
            Console.Write("\n select a number to perform the following funtions: ");
            int sortoption = int.Parse(Console.ReadLine());

            return sortoption;
        }

        public int switchingarray()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================SWITCHING ARRAY=======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Switch to Array A");
            Console.WriteLine("\n2-Switch to Array B");
            Console.Write("\n select a number to perform the following funtions: ");
            int sortoption = int.Parse(Console.ReadLine());

            return sortoption;
        }


    }
}
