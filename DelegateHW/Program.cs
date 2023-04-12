
#region Task1
//namespace PrintMessage
//{
//    class Program
//    {
//        public delegate void Print(int val);

//        static void ConsolePrint(int i)
//        {
//            Console.WriteLine(i);
//        }
//       public static void Main(string[] args)
//        {
//            Print print = ConsolePrint;
//            print(10);
//        }

//    }
//}
#endregion

#region Task2
//namespace Square
//{
//    class Program
//    {
//        public delegate TResult Func<in T, out TResult>(T arg);
//        static void Main(string[] args)
//        {
//            int Square(int x)
//            {
//                return x * x;

//             }

//            Func<int,int> add = Square;

//            int result = add(15);

//            Console.WriteLine(result);
//        }
//    }
//}
#endregion
#region Task5
//namespace Task5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Action<string> text = new Action<string>(Display);
//            text("Game World");
//            Console.Read();
//        }

//        static void Display(string message)
//        {
//            Console.WriteLine(message);
//        }
//    }
//}
#endregion




