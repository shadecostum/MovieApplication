using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    internal class MovieManager
    {
        public List<Movie> staticList;
        public static int Counter=0;

        public MovieManager()
        {
            staticList = new List<Movie>();
        }



            public void AddFunction(int movieId, string movieName, int movieYear, string moviePerson)
            {
            
                staticList.Add(new Movie { MovieId = movieId, MovieName = movieName, MovieYear = movieYear, Director = moviePerson });
              
                Counter++;
            }


        public string ReadFunction()
        {
            if (staticList == null)
            {
                return "list is null";
            }

            StringBuilder detailsBuilder = new StringBuilder();

            foreach (var item in staticList)
            {
                if (item != null)
                {
                    string itemDetails = $"ID: {item.MovieId}, Movie Name: {item.MovieName}, Movie Year: {item.MovieYear}, Movie Director: {item.Director}";
                    detailsBuilder.AppendLine(itemDetails);
                }
            }

            if (detailsBuilder.Length == 0)
            {
                return "No items in the list";
            }

            return detailsBuilder.ToString();
        }



        public void DeletList(string deleteMovieName, out string data)
        {
            if (deleteMovieName == null)
            {
               
                data = "Enter the valid Movie name";
                return;
            }

            Movie deletingMovie = staticList.Find(ListArray => ListArray.MovieName == deleteMovieName);
            if (deletingMovie != null)
            {
                staticList.Remove(deletingMovie);
                Counter--;
                data = $" Movie Name: {deletingMovie.MovieName},ID : {deletingMovie.MovieId},Movie Director : {deletingMovie.Director},Movie Year : {deletingMovie.MovieYear}";
            }
            else {
                data = "Enter the valid Movie name";
            }
            

        }


        public void UpdateList(int updateId,out string details)
            {

                Movie updatingId = staticList.Find(ListArray => ListArray.MovieId == updateId);
            if (updatingId != null)
            {

                Console.WriteLine("enter the Name");
                string updatenamePerson = Console.ReadLine();
                updatingId.MovieName = updatenamePerson;
                details = $" Movie Name: {updatingId.MovieName},ID : {updatingId.MovieId},Movie Director : {updatingId.Director},Movie Year : {updatingId.MovieYear}";
            }
            else
            {
                details = string.Empty;
            }
              
            }
            public void FindMovie(int yearmovie, out string data)
            {

                Movie yearMovie = staticList.Find(ListArray => ListArray.MovieYear == yearmovie);
                if (yearMovie != null)
                {
                    data = $"{yearMovie.MovieName},{yearMovie.MovieId},{yearMovie.Director},{yearMovie.MovieYear}";

                }
                else {
                    data = "Enter a valid year";
                }

            }

            public void ClearMovies()
            {
                staticList.Clear();
                 Counter = 0;
            }

    }
 }

