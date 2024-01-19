using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml.Serialization;


namespace MovieLists
{
	class MovieList
	{
		
		public class Päävalikko		
		{
			int syote;
			

            public Päävalikko(){}

			//user does the choice here, on the main menu
            public void Valinta()
			{
				MovieAdd movieAdd = new MovieAdd();
				SaveMovie saveMovie = new SaveMovie();


				//user selects an option
				while (true)
                {
					Console.WriteLine("\n\nLeffojen Katseluloki \n ================= \n 1)Lisää Leffa \n 2)Poista Leffa \n 3)Näytä Raportti \n 4)Lataa Tietokanta \n 5)Tallena Tietokanta \n 6)Lopeta \n");
					Console.Write("Syöte: ");

					try
					{
						syote = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine();
						
					}
					catch (Exception)
					{
						Console.WriteLine("Unknown Command");
						Console.WriteLine();
					}

					while (true)
					{
						switch (syote)
						{
							case 1:
								movieAdd.Add();
								break;

							case 2:
								//Console.WriteLine("Delete a movie");
								//break;
							case 3:
								
							
							case 4:
								//Console.WriteLine("Load DataBase");
								//break;
							case 5:
								//Console.WriteLine("Save DataBase");
								//break;
							case 6:
								Console.WriteLine("Quit");
								Environment.Exit(0);
								break;

						}

					}
				}
			}
			//Here the movies are saved to a list/file
			
			static void Main()
			{
				//the program stats
				Päävalikko valikko = new Päävalikko();
				valikko.Valinta();



			}
		}

		public class MovieAdd 
		{
			Päävalikko päävalikko = new Päävalikko();

			public string Nimi;
			public int Kesto;
			public int Vuosi;

			public MovieAdd(string nimi, int kesto, int vuosi) 
			{
				this.Nimi = nimi;
				this.Kesto = kesto;
				this.Vuosi = vuosi;
			}

            

            public void Add() 
			{
				Console.WriteLine("New Movie:");

				//Name
				Console.Write("Name:");
				Nimi = Console.ReadLine();

				//Lenght
				while (true)
				{
					try
					{
						Console.Write("Lenght:");
						Kesto = Convert.ToInt32(Console.ReadLine());
						break;
					}
					catch (Exception)
					{
						Console.WriteLine("Wrong input");
					}
				}

				//Year
				while (true)
				{
					try
					{
						Console.Write("Year:");
						Vuosi = Convert.ToInt32(Console.ReadLine());
						break;
					}
					catch (Exception)
					{
						Console.WriteLine("Wrong input");
					}
				}

				//End of case 1
				//Choice to save or add or go back
				Console.WriteLine("1) Save Movie to folder");
				Console.WriteLine("\n2) New movie \n3) Back");

				int choice = Convert.ToInt32(Console.ReadLine());

				while (true)
				{
					if (choice == 1)
					{
						SaveMovie.saveMovie();
						break;
					}
					else if (choice == 2)
					{
						Console.WriteLine("Going back");
						päävalikko.Valinta();
					}
                    else if (choice == 3)
                    {
                        Console.WriteLine("Going back");
                        päävalikko.Valinta();
                    }
                    else
					{
						Console.WriteLine("Choose 1 or 2");
					}
				}
				
			}

		}

		public class SaveMovie 
		{
            public SaveMovie(){}

			
            public void saveMovie() 
			{

				List<MovieAdd> movies = new List<MovieAdd>() { };
				movies.Add(new MovieAdd(nimi, kesto, vuosi));

                foreach (var movie in movies)
                {
					Console.WriteLine("Nimi: " + movie.Nimi + ", kesto: " + movie.Kesto + "min, vuosi: " + movie.Vuosi + "\n\r");
                }
			}  
        }
		

		
		
		
	}
   

	
}			
	

