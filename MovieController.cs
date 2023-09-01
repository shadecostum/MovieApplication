namespace MovieApplication
{
    internal class MovieController
    {
        private MovieManager manager;
        public MovieController()
        {

            manager = new MovieManager();

        }

        public void Run()
        {
            while (true)
            {
                int choose = Display();

                switch (choose)
                {
                    case 1:
                        if (MovieManager.Counter < 2)
                        {
                            Console.WriteLine("Enter the movie id");
                            int movieId = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter the movie Name");
                            string movieName = Console.ReadLine();
                            Console.WriteLine("Enter movie year");
                            int movieYear = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter movie director");
                            string moviePerson = Console.ReadLine();
                            string sizeLimit = "";

                            manager.AddFunction(movieId, movieName, movieYear, moviePerson);
                           
                        }
                        else
                        {
                            Console.WriteLine("insuficient list space limit 2 movies only can add");
                        }
                        Console.WriteLine("+++++++++++============++++++++++");
                        break;
                    case 2:
                        string details=  manager.ReadFunction();
                        Console.WriteLine("+++++++++++================+++++++++");
                        Console.WriteLine(details);

                        break;
                    case 3:
                        Console.WriteLine("Enter Id to update");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        string detailsupdated;
                        manager.UpdateList(updateId,out detailsupdated);
                        Console.WriteLine("+++++++++++================+++++++++");
                        Console.WriteLine("Updated Movie from database : "+detailsupdated);

                        break;
                    case 4:
                        Console.WriteLine("Enter the Name of Movie to delete");
                        string deleteMovieName = Console.ReadLine();
                        string deletedMovieDetails;
                        manager.DeletList(deleteMovieName, out deletedMovieDetails);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Deletd the movie from Database"+deletedMovieDetails);
                        break;

                        
                    case 5:
                        Console.WriteLine("Enter the Year to find Movie");
                        int yearFind = Convert.ToInt16(Console.ReadLine());
                        string data;
                        manager.FindMovie(yearFind, out data);
                        Console.WriteLine("You Entered movie Details"+data);
                        Console.WriteLine("+++++++++++================+++++++++");
                        break;
                    case 6:
                        manager.ClearMovies();

                        Console.WriteLine("Database is cleared");
                        Console.WriteLine("+++++++++++================+++++++++");
                        break;
                    case 7: return;

                    default:
                        Console.WriteLine("invalid");
                        break;
                }
            }
        }

        public int Display()
        {
            Console.WriteLine("Choose \n1.Add a movie\n2.Display all movies\n3.Update\n4.Remove movie by name\n5.Find movie by year\n6.Clear list\n7.Exit  ");
            int choose = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("+++++++++++============++++++++++");
            return choose;
        }


    }
}
