namespace Shopmaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("header");
            {
                Console.WriteLine("it is header");  //A#2
            }
            Console.WriteLine("article"); 
            {
                Console.WriteLine("본문");    //A#3
            }
            Console.WriteLine("footer");
            {
                Console.WriteLine("푸터");    //A#3
            }

        }
    }
}