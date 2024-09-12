namespace FunctionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> f;
            f = GetAddress;
            Console.WriteLine(f(10, 20)); //GetAddress is called
            f = delegate (int x, int y) { return "delegate anonymous function"; }; // delegate function - A variable that stores address of a function
            Console.WriteLine(f(10, 20));
            f = (int a, int b) => "arrow function";
            Console.WriteLine(f(10, 20));

            Action<int,string> ff = (x,y) => { Console.WriteLine(x + y); }; // Always returns void
            ff(4, "niketh");

            Predicate<int> pd = (x) => true; // only one parameter can be passed and it should only return boolean value



        }
        static string GetAddress(int a,int b)
        {
            return "address";
        }
    }
    internal class Slot
    {
        public static void Create(Func<int, int, string> f)
        {
            f(10, 20);
        }
    }
}
