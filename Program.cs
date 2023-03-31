namespace Shopmaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("header");
            {
                Console.WriteLine("헤더");  //A#2
                Console.WriteLine("회원가입");  //B#4
                Console.WriteLine("관리자");   //B#5
            }
            Console.WriteLine("article"); 
            {
                Console.WriteLine("본문");    //A#3
                Console.WriteLine("기사1");   //A#5
                Console.WriteLine("기사2");   //A#5
            }
            Console.WriteLine("footer");
            {
                Console.WriteLine("푸터");    //A#3
            }

        }
    }
}