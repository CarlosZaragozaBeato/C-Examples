

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {

            Cancion song = new Cancion();

            song.Title = "ALgo";
            song.Seconds = 400L;
            song.position = new ShelvePosition(0, 0);

            Console.WriteLine(song.Title);
            Console.WriteLine(song.Seconds);
            song.play();

            Console.ReadKey();

        }
    }
}