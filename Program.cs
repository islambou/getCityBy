using france_cities.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace france_cities
{
    class Program
    {

        enum Cre { Département = 1, Slug, Nom, Nom_simple, Nom_reel, Nom_soundex, Nom_metaphone,
        Code_postal, Numéro_de_commune, Code_commune, Arrondissement, Canton, Population_en_2010 ,
        Population_en_1999, Population_en_2012, Densité_en_2010, Surface, Longitude_latitude_en_degré,
        Longitude_latitude_en_GRD, Longitude_latitude_en_DMS, Altitude_minimale_maximale
        }; 

        static void Main(string[] args)
        {
            howto();
            String file_location = @"C:\fv.csv";

            

            citiesManager CM = new citiesManager(file_location);

            while(true){
                Console.WriteLine("********************************");
                Console.WriteLine("enter criteria");
                int c = int.Parse(Console.ReadLine()); 

                Console.WriteLine("enter value");
                String v = Console.ReadLine();

                Console.WriteLine(CM.getCities(v, c));
            }

            

        
        }

        static void howto()
        {
            Console.WriteLine("*** the file should be like this : c:\\fv.csv ***");
            Console.WriteLine("*** Search cretearia ***");
            foreach (Cre val in Enum.GetValues(typeof(Cre)))
            {
                Console.WriteLine((int)val + " : " + val);
            }
            
            
        }    

        }
    }
 
