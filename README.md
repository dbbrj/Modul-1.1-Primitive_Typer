# 5 Typer
## 5.1 Hello, World
Skriv et program, der udskriver teksten “Hello, World”, få det oversat og udfør det.
## 5.2 Temperatur
Hvilke datatyper er velegnede til at representere en temperatur?
## 5.3 Måned 
Hvilke typer er velegnede til at repræsentere en måned?
## 5.4 Heltallige Grænser
1. Hvilke heltallige datatyper kan man benytte sig af i C#?
2. Vælg én af dem.
3. Skriv et program der eksperimentelt afslører hvad der sker når man overskrider den størst mulige værdi.
4. Beskriv hvad det er I observerer?
## 5.5 Casting 
Når vi godt vil konvertere mellem int værdier og long værdier skal der udføres et cast. Men, hvornår er det at dette cast skal gøres eksplicit, og hvornår må det være implicit?
- Hvorved adskilder int og long sig?
- Prøv at skrive et program der (i) erklærer i som en int variabel, (ii) tildeler den en værdi, (iii) erklærer l som en long variabel, (iv) tildeler værdien af i til l, og (v) slutteligt tildeler værdien af l til i.
- Eksperimentér med hvor det er nødvendigt at have eksplicitte casts.
- Gør nu det samme med en float variabel f og en double variabel d.
- Eksperimentér igen med hvor det er nødvendigt at have eksplicitte casts.
- Afhænger resultatet af disse eksperimenter af den værdi som I initielt tildeler den første variabel?

# 6 Expressions
## 6.1 Definition
Hvad er et expression?
## 6.2 Tildeling
Er en tildeling (af en værdi til en variabel) et expression.

Hvordan tester I en hypotese om dette?
## 6.3 Expression vs Statement 
Hvad er forskellen på et expression og et statement?

# 7 Variable
## 7.1 Areal af Cirkler
Skriv et program der udregner og udskriver arealet (π · r2) af tre cirkler med radius på hhv. 1, 3 og 5.
## 7.2 Sum af Areal af Cirkler
Skriv et program der udregner og udskriver omkredsen (2 · π · r) af tre cirkler med radius på hhv. 1, 3 og 5, og afslutter med at udskriven summen af disse.
## 7.3 Celcius til Fahrenheit 
Skriv et program, hvori
1. En temperatur angives i Celcius via en variabel.
2. Denne temperatur konverteres til Fahrenheit og gemmes i en anden variabel.
- Formel: TF = 32 + 9/5 TC
3. Konverteringen udskrives på en passende måde.
## 7.4 Epoch
Skriv et program hvori
1. Et antal sekunder siden et bestemt tidspunkt (fx 1. Januar 1970) gemmes i en variabel. Givet en enighed om udgangspunktet (1. Januar 1970), kan denne variabel bruges som et tidsstempel.
2. Konvertér dette tal til et helt antal år (lad os antage at der er 365 dage på et år) og et antal hele dage indenfor det sidste år.
- På denne måde kan vi konvertere dette tidsstempel til noget der giver mere mening for mennesker: En kombination af et årstal og en dag. Dagen har da en værdi mellem 0 og 364 (begge inklusive).
- Idéelt set ville vi også have måneder med (så vi får en dag-måned-år dato), men måneder er ikke lige lange og det vil vi helst undgå at skulle håndtere i denne opgave.
- Samlet skal de to tal altså være indenfor 24 timer af udgangspunktet.
4. Udskriv disse to tal.

Verificér at programmet virker.
## 7.5 Inkrementering af Måned
Skriv et program, hvori
1. Erklær en heltallig variabel.
2. Tildel denne variabel en værdi som repræsenterer en måned (i.e., 2 er Februar).
3. Udskriv variablens værdi.
4. Forøg værdien af denne variabel med en halv.
5. Udskriv variablens værdi.
6. Forøg værdien af denne variabel med en halv.
7. Udskriv variablens værdi.

Få dette program til at oversætte, kør det og beskriv hvad du observerer.

Forklar hvorfor programmet opfører sig som det gør.
## 7.6 Værdi vs Variabel
Hvad er forholdet mellem en værdi og en variabel?
## 7.7 Daglige Differencer
Skriv et program, der givet 7 dagstemperaturer, udregner og udskriver temperaturdifferencen mellem alle to på hinanden følgende dage (dvs. Tirsdag-Mandag, Onsdag-Tirsdag . . . Søndag-Lørdag).
Dagstemperaturerne kunne være:
- Mandag: 21.5
- Tirsdag: 23.7
- Onsdag: 19.6
- Torsdag: 22.5
- Fredag: 25.3
- Lørdag: 21.7
- Søndag: 18.9
Hvorfor regner den forkert?
## 7.8 Gennemsnitlig Alder
Betragt følgende program.
S
Udfør programmet. Hvad sker der?

Skriv nu en tekst på dansk hvor I ved hjælp af fagtermer forklarer hvad der sker. Sørg for at denne tekst er grundig nok til at en programmør kan genkonstruere ovenstående kode.
## 7.9 Printf
Undersøg hvordan følgende stykke kode fungerer ved at modificere indholdet af strengen i den sidste linje.S