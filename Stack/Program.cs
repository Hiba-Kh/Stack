
namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var intStack = new MyStack<int>(100);
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);
            //intStack.Push(4);
            //intStack.Print();
            //intStack.Pop();
            //intStack.Peak();

            for (int i = 0; i < 100; i++)
                intStack.Push(i);
            intStack.Print();
            intStack.Push(1111);
            intStack.Pop();
            var strStack = new MyStack<string>(100);
            strStack.Push("hi");
            strStack.Push("a");
            strStack.Push("b");
            strStack.Push("c");
            strStack.Push("d");
            strStack.Push("Bye");
            strStack.Print();
            strStack.Peak();
        }
    }
}
