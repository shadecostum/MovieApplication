namespace MovieApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MovieController manager = new MovieController();
            manager.Run();
        }
    }
}