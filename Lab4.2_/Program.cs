using System;
using System.Collections.Generic;

namespace Lab4._2_
{
    class Program
    {
        class Movies
        {
            public string title;
            public string category;

            public Movies(string t, string c)
            {
                title = t;
                category = c;
            }
        }
        static void Main(string[] args)
        {
            List<Movies> collection = new List<Movies>();
            collection.Add(new Movies("The Pebble and the Penguin", "Animated"));
            collection.Add(new Movies("A Troll in Central Park", "Animated"));
            collection.Add(new Movies("Wreck it Ralph", "Animated"));
            collection.Add(new Movies("Titanic", "Drama"));
            collection.Add(new Movies("Pay it Forward", "Drama"));
            collection.Add(new Movies("The Truman Show", "Drama"));
            collection.Add(new Movies("Scream 1", "Horror"));
            collection.Add(new Movies("The Ring", "Horror"));
            collection.Add(new Movies("Birdbox", "Horror"));
            collection.Add(new Movies("Coneheads", "Sci Fi"));
            collection.Add(new Movies("Little Shop of Horrors", "Sci Fi"));
            collection.Add(new Movies("Eternal Sunshine of the Spotless Mind", "Sci Fi"));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"There are {collection.Count} movies in this list.");
            bool done = false;

            while (!done)
            {
                Console.WriteLine("What category are you interested in? (Animated, Drama, Horror, Sci Fi)");
                string genre = Console.ReadLine();

                if (genre != "Animated" && genre != "Drama" && genre != "Horror" && genre != "Sci Fi")
                {
                    Console.WriteLine("I'm sorry, you did not enter a list from the category. Please try again");
                    done = false;
                }

                else
                {
                    Console.WriteLine($"\nHere are all of the {genre} movies: ");

                    foreach (Movies type in collection)
                    {
                        if (genre == "Animated")
                        {
                            if (type.category == "Animated")
                            {
                                Console.WriteLine($"- {type.title}");
                            }
                        }

                        if (genre == "Drama")
                        {
                            if (type.category == "Drama")
                            {
                                Console.WriteLine($"- {type.title}");
                            }
                        }
                        if (genre == "Horror")
                        {
                            if (type.category == "Horror")
                            {
                                Console.WriteLine($"- {type.title}");
                            }
                        }
                        if (genre == "Sci Fi")
                        {
                            if (type.category == "Sci Fi")
                            {
                                Console.WriteLine($"- {type.title}");
                            }
                        }
                    }
                    bool validResponse = false;

                    while (!validResponse)
                    {
                        Console.Write("\nWould you like to continue? (y/n): ");
                        string response = Console.ReadLine();

                        if (response != "Y" && response != "y" && response != "N" && response != "n")
                        {
                            Console.Write("Please only enter \"y\" or \"n\". \n");
                        }
                        else
                        {
                            validResponse = true;
                            if (response == "N" || response == "n")
                            {
                                done = true;
                                Console.WriteLine("\nThank you for playing, goodbye!\n");
                            }
                        }
                    }
                }

            }







        }
    }
}
