using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// compile with: /doc:france_cities.xml 
namespace france_cities.tools
{
    class citiesManager
    {
        private String DataSource;
        private Char DataSeparator = ',';
        private Char mKeysSplitter = '-';
        private int CityNameColumn = 3;
        private int PostCodeColumn = 8;

   

        public citiesManager(String s)
        {
            ///<param name="s">this parameter is to set the data source file (cvs file)</param>   
            this.DataSource = s;
        }
     
        
        public void setDataSource(String s)
        {
            this.DataSource = s;
        }
        public void setDataSeparator(char s)
        {
            this.DataSeparator = s;
        }
        public void setmKeysSplitter(char s)
        {
            this.mKeysSplitter = s;
        }


        private Hashtable dataToHashtable(int column)
        {
            // i usually use Dictionary instead if hashtable which both implement 
            // the same interfaces in c# , but since you mentioned it 
            // on our interview , i thought why not use it 
            /// <summary>dataToHashtable is simply a methode
            /// that gets data from the source (cvs) and turns it
            /// into a hashtable (key : depends on our query , value: city name)
            /// </summary>


            Hashtable result = new Hashtable();
            try {
                using (StreamReader reader = new StreamReader(DataSource))  {

                 //the keyword "using"  releases the resource after finishing  (memory management)
                while (!reader.EndOfStream)
                {
                    String row = reader.ReadLine();
                    String[] values = row.Split(DataSeparator);

                    //this line takes too much time but it is necessary , it removes these (") 
                    values[column] = values[column].Replace("\"","");


                    //this line was added just because one city can have more than one post code , like paris
                    String[] multiple_keys = column == PostCodeColumn ? values[column].Split(mKeysSplitter) : new[] { values[column] };

                    foreach (String key in multiple_keys) {

                        //populating our hashtable 
                        if (!result.ContainsKey(key))
                            result.Add(key, values[CityNameColumn]);

                    else
                            result[key] += "," + values[CityNameColumn];
                    }
                }
            }
            
                }
            catch (Exception)
            {
                Console.WriteLine("couldn't parse data to a hashtable");
            }

            return result;

        }

        public String getCities(String value, int criteria)
        {
            /// <param name="value">Used to set the value of our search query  (Ex : 75)</param>
            /// <param name="criteria">Used to set the criteria of our search query  (Ex : 1 => "departement")</param> 

            Hashtable data = dataToHashtable(criteria);
            if (data.ContainsKey(value)) return (string)data[value];
            return "Key not found!";
        }
  
     
        
        
        
        
        public String getCitiesByDepartement(String d)
        {
            return getCities(d, 1);
        }      
        public String getCityByPostCode(String d)
        {
            return getCities(d, PostCodeColumn);
        }
     

        }
}
