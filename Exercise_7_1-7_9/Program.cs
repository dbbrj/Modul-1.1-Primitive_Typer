Console.WriteLine("opg 7.1");
double pi=3.14;
double r;
r=1;
Console.WriteLine("r=" + r +" -> area = " + (pi * r * r));
Console.WriteLine();
r=3;
Console.WriteLine("r=" + r +" -> area = " + (pi * r * r));
Console.WriteLine();
r=5;
Console.WriteLine("r=" + r +" -> area = " + (pi * r * r));
Console.WriteLine();
Console.WriteLine("opg 7.2");
r=1;
Console.WriteLine("r=" + r +" -> circumference = " + (2 * pi * r));
Console.WriteLine();
r=3;
Console.WriteLine("r=" + r +" -> circumference = " + (2 * pi * r));
Console.WriteLine();
r=5;
Console.WriteLine("r=" + r +" -> circumference = " + (2 * pi * r));
Console.WriteLine();
Console.WriteLine("opg 7.3");
double tc;
tc=10;
Console.WriteLine("Temperatur Celcius: " + tc + " is in Fahrenheit: " + (32 + (( 9 / 5.0) * tc)));
Console.WriteLine();
tc=20;
Console.WriteLine("Temperatur Celcius: " + tc + " is in Fahrenheit: " + (32 + (( 9 / 5.0 ) * tc)));
Console.WriteLine();
Console.WriteLine("opg 7.4");

Console.WriteLine();
Console.WriteLine("opg 7.5");
int month;
month=9;
Console.WriteLine("month = " + month);
int month_1 = month + 1/2;
Console.WriteLine("month increased with 1/2 is month_1 = " + month_1);
int month_2 = month_1 + 1/2;
Console.WriteLine("month_1 increased with 1/2 is month_2 = " + month_2);
Console.WriteLine("When adding different types, C# does an implicit conversion to the first type.");
Console.WriteLine("This type is integer and the value 1/2 will therefore be rounded down to 0.");
Console.WriteLine("Therefore, zero is added twice in practice");
Console.WriteLine();
Console.WriteLine("opg 7.6");
Console.WriteLine("A variable is a symbolic reference (or indirection) to a value.");
Console.WriteLine("We say that the variable points to the value." );
Console.WriteLine("We can change which value a variable points to by assigning it a new value. ");
Console.WriteLine("In practice, the value resides somewhere in memory and the variable contains the address of this location.");
Console.WriteLine("This is an abstraction that makes it possible to write code that is independent of specific values.");
Console.WriteLine();
Console.WriteLine("opg 7.7");
double day1 = 21.5;
double day2 = 23.7;
double day3 = 19.6;
double day4 = 22.5;
double day5 = 25.3;
double day6 = 21.7;
double day7 = 18.9;
Console.WriteLine(day2 - day1);
Console.WriteLine(day3 - day2);
Console.WriteLine(day4 - day3);
Console.WriteLine(day5 - day4);
Console.WriteLine(day6 - day5);
Console.WriteLine(day7 - day6);
Console.WriteLine("It calculates wrong, because the way you represent decimal numbers is not exact.");
Console.WriteLine("This will often result in very small errors. There are more precise ways of representing decimal numbers.");
Console.WriteLine("For example through a fraction of whole numbers. This is but somewhat slower.");
Console.WriteLine();
Console.WriteLine("opg 7.8");
int ada_lovelace      = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie    = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper      = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr       = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra   = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);
Console.WriteLine();
//Programmet har en main metode der består af 6 variabel erklæringer med initielle værdier, en række variabel erklæringer der initialiseres til at holde resultatet af nogle udregninger, og til sidst udskrives resultaterne.
//I den første del erklæres 6 int variabler. Hver af disse er navngivet efter en kendt datalog og initialiseres til hvor gamle de blev. 
//For hver af disse er der et udkommenteret link til deres side på Wikipedia. 
//Dernæst kommer der fire udregninger. 
//Hver udregning gemmes i en float variabel.
//I den første udregning lægges samtlige mandlige variable sammen. 
//Resultatet af denne opsummering castes til en float hvorefter det divideres med 3 (antallet) og gemmes i male_avg variablen. 
//Tilsvarende udregnes og gemmes gennemsnittet for kvinder i female_avg. 
//I den tredje udregning lægges disse to gennemsnit sammen og resulatet af dette divideres med 2 og gemmes i variablen avg. 
//Dette er korrekt eftersom der er lige mange mænd og kvinder, og da male_avg er af typen float er det ikke nødvendigt at caste for at undgår afrundingsfejl i divisionen.
//I den sidste udregning trækkes female_avg fra male_avg og resultatet gemmes i variablen diff.
//Til sidst printes hver af disse 4 udregnede variable ud på skærmen. 
//For hver af dem bruges to statements. I det første statement udskrives en streng der beskriver hvad værdien betyder uden linjebrud. 
//I det andet og sidste statement udskrives værdien med linjebrud.
Console.WriteLine("opg 7.9");
int i = 42;
long l = 56;
float f = 3.314159F;
double d = 3.14159*10;
Console.WriteLine(string.Format("i={0} l={1,4} f={2} d={3,6:F2}", i, l, f, d));
Console.WriteLine("i = {0} \nl = {1,4} \nf = {2} \nd = {3,6:0.00}", i, l, f, d);
// i is printed as normal.
// l is printed with a width of 4.
// f is printed as normal.
// d is printed with a width of 6 and 2 decimal places.
Console.WriteLine();