# getCityBy

the csv file should be in the same folder as the program 

how to use it : 
* creat a citiesManager object : citiesManager CM = new citiesManager(file_location); 

with the file directory as a parameter 
  
 *  call the methode getCities(String value, int criteria) 
 
 value    : Used to set the value of our search query  (Ex : 75)
 
 criteria : Used to set the criteria of our search query  (Ex : 1 => "departement")
 
 it should return a list of city names or nothing if the key doesn't exist .
 
 ************************************************************************************
 execution exemple :
 
 Console.WriteLine(CM.getCities("92", "1"));
 
 result : 
 
 "NEUILLY-SUR-SEINE","CHATILLON","BOIS-COLOMBES","PUTEAUX","CLAMART","MEUDON","MARNES-LA-COQUETTE","ISSY-LES-MOULINEAUX","VAUCRESSON","RUEIL-MALMAISON","ANTONY","LE PLESSIS-ROBINSON","LEVALLOIS-PERRET","BOULOGNE-BILLANCOURT","ASNIERES-SUR-SEINE","COLOMBES","FONTENAY-AUX-ROSES","GARCHES","VILLENEUVE-LA-GARENNE","COURBEVOIE","MONTROUGE","CHATENAY-MALABRY","CLICHY","VANVES","VILLE-D'AVRAY","SURESNES","SEVRES","SCEAUX","CHAVILLE","LA GARENNE-COLOMBES","GENNEVILLIERS","NANTERRE","SAINT-CLOUD","MALAKOFF","BAGNEUX","BOURG-LA-REINE"
