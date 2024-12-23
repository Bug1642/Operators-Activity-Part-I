using System;
namespace ConsoleAppTest
{
    public class StudentCode
    {
        public bool CheckEverything()
        {
            bool bool1 = true;
            bool bool2 = true;
            bool bool3 = true;
            bool isAllTrue;
            if (bool1 && bool2 && bool3 )
                isAllTrue=true;
                
            else
                isAllTrue=false;
            return isAllTrue;
        }
    }
    class Program{
        static void Main (string [] args){
            StudentCode checking = new StudentCode();
            Console.WriteLine(checking.CheckEverything());
        }
    }

}