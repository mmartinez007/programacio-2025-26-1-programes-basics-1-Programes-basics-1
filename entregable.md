## EXERCICI 1

![ex 1](fotos/ex%201.png)

Demana nom i cognom i imprimeix "Em dic Cognom, Nom Cognom".

```csharp
Console.WriteLine("Entra el nom");
// Mostra al usuari el missatge per demanar el nom.

var nom = Console.ReadLine();
// Llegeix la línia que escriu l'usuari i la guarda a `nom`.

Console.WriteLine("Entra el cognom");
// Mostra el missatge per demanar el cognom.

var cognom = Console.ReadLine();
// Llegeix la línia que escriu l'usuari i la guarda a `cognom`.

Console.WriteLine($"Em dic {cognom} , {nom} {cognom} ");
// Imprimeix la frase final amb el cognom i el nom en format "Em dic Cognom, Nom Cognom".
```

---

## EXERCICI 2

![ex 2](fotos/ex%202.png)

Demana carrer, número, codi postal i població i mostra-ho en una sola línia.

```csharp
Console.WriteLine("Carrer");
// Posa el text per demanar el carrer a l'usuari.

var carrer = Console.ReadLine();
// Guarda la resposta (carrer) en la variable `carrer`.

Console.WriteLine("Número");
// Posa el text per demanar el número del carrer.

var Número = Console.ReadLine();
// Guarda la resposta (número) en la variable `Número`.

Console.WriteLine("Codi Postal");
// Demana el codi postal.

var Codi_Postal = Console.ReadLine();
// Guarda el codi postal introduït.

Console.WriteLine("Població");
// Demana la població.

var Població = Console.ReadLine();
// Guarda la població introduïda.

Console.WriteLine($"Dades: Carrer - {carrer} , Número - {Número} , Codi Postal - {Codi_Postal} , Població - {Població } ");
// Mostra totes les dades en una sola línia formatada.
```

---

## EXERCICI 3

![ex 3](fotos/ex%203.png)

Demana producte, preu i estoc i imprimeix aquestes dades.

```csharp
Console.WriteLine("Producte");
// Mostra un missatge per demanar el nom del producte.

var producte = Console.ReadLine();
// Guarda el nom del producte.

Console.WriteLine("Preu");
// Demana el preu.

var preu = Console.ReadLine();
// Guarda el preu introduït.

Console.WriteLine("Està en estoc?");
// Demana si està en estoc.

var estoc = Console.ReadLine();
// Guarda la resposta d'estoc.

Console.WriteLine($"Dades del producte : Producte - {producte} , Preu - {preu} , Estoc? {estoc} ");
// Imprimeix la informació del producte en una línia.
```

---

## EXERCICI 4

![ex 4](fotos/ex%204.png)

Converteix euros a pessetes (1€ = 166.386) i mostra el resultat.

```csharp
Console.WriteLine("Preu del article en €?");
// Demana a l'usuari el preu en euros.

var euros = Console.ReadLine();
// Llegeix i guarda el text del preu.

int euros1 = Convert.ToInt16(euros);
// Converteix la cadena a un enter curt (int16).

int pessetes1 = 166386;
// Defineix la constant de conversió (pessetes * 1000 per evitar decimals).

int multiplicació = euros1 * pessetes1;
// Calcula el valor en (pessetes multiplicades per 1000 segons el codi).

Console.WriteLine($"Són {multiplicació} pessetes");
// Mostra el resultat de la conversió.
```

---

## EXERCICI 5

![ex 5](fotos/ex%205.png)

Demana nom i any de naixement, calcula l'edat (2025) i saluda mostrant l'edat.

```csharp
Console.WriteLine("Nom");
// Demana el nom de l'usuari.

var nom = Console.ReadLine();
// Guarda el nom.

Console.WriteLine("Any de naixement");
// Demana l'any de naixement.

var edat = Console.ReadLine();
// Llegeix l'any com a text.

int any_naixement = Convert.ToInt16(edat);
// Converteix l'any a número enter.

int any_actual = 2025;
// Defineix l'any actual (fixe).

int resta = any_actual - any_naixement;
// Calcula l'edat restant (edat).

Console.WriteLine($"Hola {nom}! Ja tens {resta} anys?");
// Mostra el missatge amb el càlcul d'edat.
```

---

## EXERCICI 6

![ex 6](fotos/ex%206.png)

Demana el costat d'un quadrat i calcula el perímetre (4 × costat).

```csharp
Console.WriteLine("Costat del cuadrat");
// Demana a l'usuari el valor del costat del quadrat.

var costat = Console.ReadLine();
// Llegeix la resposta de l'usuari i la guarda en `costat`.

int costat1 = Convert.ToInt16(costat);
// Converteix la cadena a un enter (costat en números).

int cuadrat = 4;
// Defineix el nombre de costats d'un quadrat (4).

int suma_costats = costat1 * cuadrat;
// Calcula el perímetre multiplicant el costat per 4.

Console.WriteLine($"El perímetre és : {suma_costats}");
// Mostra el perímetre calculat.
```

---

## EXERCICI 7

![ex 7](fotos/ex%207.png)

Calcula la mitjana de tres notes.

```csharp
Console.WriteLine("Nota 1");
// Demana la primera nota.

var nota1 = Console.ReadLine();
// Llegeix la primera nota.

int nota11 = Convert.ToInt16(nota1);
// Converteix la primera nota a enter.

Console.WriteLine("Nota 2");
// Demana la segona nota.

var nota2 = Console.ReadLine();
// Llegeix la segona nota.

int nota22 = Convert.ToInt16(nota2);
// Converteix la segona nota a enter.

Console.WriteLine("Nota 3");
// Demana la tercera nota.

var nota3 = Console.ReadLine();
// Llegeix la tercera nota.

int nota33 = Convert.ToInt16(nota3);
// Converteix la tercera nota a enter.

int suma = (nota11 + nota22 + nota33) / 3;
// Calcula la mitjana (suma de les tres dividida per 3).

Console.WriteLine($"La mitjana és: {suma}");
// Mostra la mitjana.
```

---

## EXERCICI 8

![ex 8](fotos/ex%208.png)

Converteix minuts a hores i minuts restants.

```csharp
Console.WriteLine("Cuants munits?");
// Demana el nombre total de minuts.

var minuts = Console.ReadLine();
// Llegeix la quantitat de minuts.

int minutsint = Convert.ToInt32(minuts);
// Converteix a enter.

int hores = minutsint / 60;
// Calcula les hores completes.

int minutsrestans = minutsint % 60;
// Calcula els minuts restants.

Console.WriteLine($"Són {hores} hores i {minutsrestans} minuts");
// Mostra el resultat en hores i minuts.
```

---

## EXERCICI 9

![ex 9](fotos/ex%209.png)

Converteix metres a peus (aprox.), mostra el resultat.

```csharp
Console.WriteLine("Metres");
// Demana una distància en metres.

var metres = Console.ReadLine();
// Llegeix la distància en metres.

int metresInt = Convert.ToInt16(metres);
// Converteix la cadena a enter.

int peus = metresInt * 328084;
// Calcula peus amb un factor (multiplicat per 328084 en codi per evitar decimals).

Console.WriteLine($"Peus : {peus}");
// Mostra el resultat.
```

---

## EXERCICI 10

![ex 10](fotos/ex%2010.png)

Combina nom i any de naixement per generar una contrasenya simple.

```csharp
Console.WriteLine("Nom");
// Demana el nom.

var nom = Console.ReadLine();
// Llegeix el nom.

Console.WriteLine("Any_Naixement");
// Demana l'any de naixement.

var any_naixement = Console.ReadLine();
// Llegeix l'any de naixement.

Console.WriteLine($"La teva passwd és : {nom}{any_naixement}");
// Mostra la combinació nom+any com a "contrasenya".
```

---

## EXERCICI 11

![ex 11](fotos/ex%2011.png)

Crea una adreça de correu a partir d'usuari i domini.

```csharp
Console.WriteLine("Nom d'usuari");
// Demana el nom d'usuari.

var nom = Console.ReadLine();
// Llegeix el nom d'usuari.

Console.WriteLine("Domini");
// Demana el domini del correu.

var domini = Console.ReadLine();
// Llegeix el domini.

Console.WriteLine($"La teva adreça és : {nom}@{domini}");
// Mostra la direcció electrònica completa.
```

---

## EXERCICI 12

![ex 12](fotos/ex%2012.png)

Calcula suma, resta, multiplicació i divisió de dos nombres.

```csharp
Console.WriteLine("Primer num");
// Demana el primer número.

var num = Console.ReadLine();
// Llegeix el primer número.

int numInt = Convert.ToInt16(num);
// Converteix a enter.

Console.WriteLine("Segon num");
// Demana el segon número.

var num2 = Console.ReadLine();
// Llegeix el segon número.

int numInt2 = Convert.ToInt16(num2);
// Converteix a enter.

int suma = numInt + numInt2;
// Calcula la suma.

int resta = numInt - numInt2;
// Calcula la resta.

int multiplicació = numInt * numInt2;
// Calcula la multiplicació.

int divisió = numInt / numInt2;
// Calcula la divisió entera.

Console.WriteLine($"Suma : {suma} , Resta : {resta} , Multiplicació : {multiplicació} , Divisió : {divisió}");
// Mostra els quatre resultats.
```

---

## EXERCICI 13

![ex 13](fotos/ex%2013.png)

Reformatar una data sense separadors (24092024 -> 24/09/2024).

```csharp
Console.WriteLine("Data sense formatar");
// Demana la data sense separadors.

string data = Console.ReadLine();
// Llegeix la cadena de data.

string DataString = (data);
// Assigna la cadena a una variable (igual).

Console.WriteLine(DataString.Substring(0, 2) + "/" + DataString.Substring(2, 2) + "/" + DataString.Substring(4, 4));
// Mostra la data formatada separant dia/mes/any amb substring.
```

---

## EXERCICI 14

![ex 14](fotos/ex%2014.png)

Mostra la primera, la del mig i l'última lletra d'una paraula.

```csharp
Console.WriteLine("Paraula per analitzar");
// Demana una paraula.

var paraula = Console.ReadLine();
// Llegeix la paraula.

Console.WriteLine($"La primera lletra és: " + paraula[0]);
// Mostra la primera lletra.

Console.WriteLine($"La lletra del mig és: " + paraula[paraula.Length / 2]);
// Mostra la lletra central.

Console.WriteLine($"La ultima lletra és: " + paraula[paraula.Length - 1]);
// Mostra l'última lletra.
```

---

## EXERCICI 15

![ex 15](fotos/ex%2015.png)

Capitalitza la primera lletra del nom i del cognom i imprimeix-los.

```csharp
Console.WriteLine("Nom");
// Demana el nom.

var nom = Console.ReadLine();
// Llegeix el nom.

Console.WriteLine("Cognom");
// Demana el cognom.

var cognom = Console.ReadLine();
// Llegeix el cognom.

var inicial = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower();
// Capitalitza la primera lletra del nom.

var inicialcognom = cognom.Substring(0, 1).ToUpper() + cognom.Substring(1).ToLower();
// Capitalitza la primera lletra del cognom.

Console.WriteLine($"Nom : {inicial} {inicialcognom}" );
// Mostra el nom i cognom formatats.
```

---

## EXERCICI 16

![ex 16](fotos/ex%2016.png)

Calcula la nota final combinant pràctiques i examen (ponderacions).

```csharp
Console.WriteLine("La meva nota de practiques");
// Demana la nota de pràctiques.

var examen = Console.ReadLine();
// Llegeix la nota de pràctiques (variable amb nom confús).

int nota1 = Convert.ToInt32(examen);
// Converteix-la a enter.

Console.WriteLine("La meva nota d'examen");
// Demana la nota d'examen.

var practiques = Console.ReadLine();
// Llegeix la nota d'examen (variable amb nom confús).

int nota2 = Convert.ToInt32(practiques);
// Converteix-la a enter.

double res = nota1 * 0.4 + nota2 * 0.6;
// Calcula la nota ponderada (40% i 60%).

double res2 = Math.Truncate(res);
// Talla la nota a la part sencera (no arrodoneix).

Console.WriteLine("La meva nota és: " + (nota1 * 0.3 + nota2 * 0.7) + " o sigui un " + res2);
// Mostra un càlcul alternatiu (confús) i la part sencera.
```

---

## EXERCICI 17

![ex 17](fotos/ex%2017.png)

Extreu i mostra la part decimal d'un nombre real.

```csharp
string num = "23.45";
// Defineix una cadena amb un nombre (fix).

string decimals = num.Substring(2);
// Extreu la part a partir del tercer caràcter (decimals).

Console.WriteLine($"Numero lleig : {num}");
// Mostra el nombre original.

Console.WriteLine($"Numero meravellós : {0}{decimals}" );
// Mostra "0" seguit dels decimals per donar el format 0,45.
```

---

## EXERCICI 18

![ex 18](fotos/ex%2018.png)

A partir d'una hora i un increment d'hores, calcula l'hora futura (mòdul 12).

```csharp
Console.WriteLine("Hora actual");
// Demana l'hora actual.

var hora = Console.ReadLine();
// Llegeix l'hora.

int horaactual = Convert.ToInt32(hora);
// Converteix a enter.

Console.WriteLine("Hores a incrementar");
// Demana les hores a sumar.

var hores = Console.ReadLine();
// Llegeix les hores a incrementar.

int horesincrementar = Convert.ToInt32(hores);
// Converteix a enter.

Console.WriteLine("D'aquí a " + horesincrementar + " hores seran les " + (horaactual + horesincrementar)    % 12);
// Mostra l'hora futura calculada amb mòdul 12.
```

---

## EXERCICI 19

![ex 19](fotos/ex%2019.png)

Demana una paraula i imprimeix la seva longitud (nombre de caràcters).

```csharp
Console.WriteLine("Diguem una paraula");
// Demana una paraula a l'usuari.

var paraula = Console.ReadLine();
// Llegeix la paraula.

Console.WriteLine($"La paraula és: " + paraula + " i té " + paraula.Length + " caràcters.");
// Mostra la paraula i el seu nombre de caràcters.
```

---

## EXERCICI 20

![ex 20](fotos/ex%2020.png)

Inverteix un número de tres xifres i mostra el resultat.

```csharp
Console.WriteLine("Numero:");
// Demana un nombre de tres xifres.

var num = Console.ReadLine();
// Llegeix el nombre com a cadena.

string Dig1 = num.Substring(0, 1);
// Extreu la primera xifra.

string Dig2 = num.Substring(1, 1);
// Extreu la segona xifra.

string Dig3 = num.Substring(2);
// Extreu la tercera xifra (i la resta).

Console.WriteLine("El número invertit és: " + (Dig3) + (Dig2) + (Dig1));
// Mostra el número amb les xifres invertides.
```

---
## EXERCICI 1

1. ![ex 1](fotos/ex%201.png)

   Demana nom i cognom i imprimeix "Em dic Cognom, Nom Cognom".

	Console.WriteLine("Entra el nom");
	// Mostra al usuari el missatge per demanar el nom.

	var nom = Console.ReadLine();
	// Llegeix la línia que escriu l'usuari i la guarda a `nom`.
## EXERCICI 1

1. ![ex 1](fotos/ex%201.png)

   Demana nom i cognom i imprimeix "Em dic Cognom, Nom Cognom".

	Console.WriteLine("Entra el nom");
	// Mostra al usuari el missatge per demanar el nom.

	var nom = Console.ReadLine();
	// Llegeix la línia que escriu l'usuari i la guarda a `nom`.

	Console.WriteLine("Entra el cognom");
	// Mostra el missatge per demanar el cognom.

	var cognom = Console.ReadLine();
	// Llegeix la línia que escriu l'usuari i la guarda a `cognom`.

	Console.WriteLine($"Em dic {cognom} , {nom} {cognom} ");
	// Imprimeix la frase final amb el cognom i el nom en format "Em dic Cognom, Nom Cognom".

---

## EXERCICI 2

2. ![ex 2](fotos/ex%202.png)

   Demana carrer, número, codi postal i població i mostra-ho en una sola línia.

	Console.WriteLine("Carrer");
	// Posa el text per demanar el carrer a l'usuari.

	var carrer = Console.ReadLine();
	// Guarda la resposta (carrer) en la variable `carrer`.

	Console.WriteLine("Número");
	// Posa el text per demanar el número del carrer.

	var Número = Console.ReadLine();
	// Guarda la resposta (número) en la variable `Número`.

	Console.WriteLine("Codi Postal");
	// Demana el codi postal.

	var Codi_Postal = Console.ReadLine();
	// Guarda el codi postal introduït.

	Console.WriteLine("Població");
	// Demana la població.

	var Població = Console.ReadLine();
	// Guarda la població introduïda.

	Console.WriteLine($"Dades: Carrer - {carrer} , Número - {Número} , Codi Postal - {Codi_Postal} , Població - {Població } ");
	// Mostra totes les dades en una sola línia formatada.

---

## EXERCICI 3

3. ![ex 3](fotos/ex%203.png)

   Demana producte, preu i estoc i imprimeix aquestes dades.

	Console.WriteLine("Producte");
	// Mostra un missatge per demanar el nom del producte.

	var producte = Console.ReadLine();
	// Guarda el nom del producte.

	Console.WriteLine("Preu");
	// Demana el preu.

	var preu = Console.ReadLine();
	// Guarda el preu introduït.

	Console.WriteLine("Està en estoc?");
	// Demana si està en estoc.

	var estoc = Console.ReadLine();
	// Guarda la resposta d'estoc.

	Console.WriteLine($"Dades del producte : Producte - {producte} , Preu - {preu} , Estoc? {estoc} ");
	// Imprimeix la informació del producte en una línia.

---

## EXERCICI 4

4. ![ex 4](fotos/ex%204.png)

   Converteix euros a pessetes (1€ = 166.386) i mostra el resultat.

	Console.WriteLine("Preu del article en €?");
	// Demana a l'usuari el preu en euros.

	var euros = Console.ReadLine();
	// Llegeix i guarda el text del preu.

	int euros1 = Convert.ToInt16(euros);
	// Converteix la cadena a un enter curt (int16).

	int pessetes1 = 166386;
	// Defineix la constant de conversió (pessetes * 1000 per evitar decimals).

	int multiplicació = euros1 * pessetes1;
	// Calcula el valor en (pessetes multiplicades per 1000 segons el codi).

	Console.WriteLine($"Són {multiplicació} pessetes");
	// Mostra el resultat de la conversió.

---

## EXERCICI 5

5. ![ex 5](fotos/ex%205.png)

   Demana nom i any de naixement, calcula l'edat (2025) i saluda mostrant l'edat.

	Console.WriteLine("Nom");
	// Demana el nom de l'usuari.

	var nom = Console.ReadLine();
	// Guarda el nom.

	Console.WriteLine("Any de naixement");
	// Demana l'any de naixement.

	var edat = Console.ReadLine();
	// Llegeix l'any com a text.

	int any_naixement = Convert.ToInt16(edat);
	// Converteix l'any a número enter.

	int any_actual = 2025;
	// Defineix l'any actual (fixe).

	int resta = any_actual - any_naixement;
	// Calcula l'edat restant (edat).

	Console.WriteLine($"Hola {nom}! Ja tens {resta} anys?");
	// Mostra el missatge amb el càlcul d'edat.

---

## EXERCICI 6

6. ![ex 6](fotos/ex%206.png)

   Demana el costat d'un quadrat i calcula el perímetre (4 × costat).

	Console.WriteLine("Costat del cuadrat");
	// Demana a l'usuari el valor del costat del quadrat.

	var costat = Console.ReadLine();
	// Llegeix la resposta de l'usuari i la guarda en `costat`.

	int costat1 = Convert.ToInt16(costat);
	// Converteix la cadena a un enter (costat en números).

	int cuadrat = 4;
	// Defineix el nombre de costats d'un quadrat (4).

	int suma_costats = costat1 * cuadrat;
	// Calcula el perímetre multiplicant el costat per 4.

	Console.WriteLine($"El perímetre és : {suma_costats}");
	// Mostra el perímetre calculat.

---

## EXERCICI 7

7. ![ex 7](fotos/ex%207.png)

   Calcula la mitjana de tres notes.

	Console.WriteLine("Nota 1");
	// Demana la primera nota.

	var nota1 = Console.ReadLine();
	// Llegeix la primera nota.

	int nota11 = Convert.ToInt16(nota1);
	// Converteix la primera nota a enter.

	Console.WriteLine("Nota 2");
	// Demana la segona nota.

	var nota2 = Console.ReadLine();
	// Llegeix la segona nota.

	int nota22 = Convert.ToInt16(nota2);
	// Converteix la segona nota a enter.

	Console.WriteLine("Nota 3");
	// Demana la tercera nota.

	var nota3 = Console.ReadLine();
	// Llegeix la tercera nota.

	int nota33 = Convert.ToInt16(nota3);
	// Converteix la tercera nota a enter.

	int suma = (nota11 + nota22 + nota33) / 3;
	// Calcula la mitjana (suma de les tres dividida per 3).

	Console.WriteLine($"La mitjana és: {suma}");
	// Mostra la mitjana.

---

## EXERCICI 8

8. ![ex 8](fotos/ex%208.png)

   Converteix minuts a hores i minuts restants.

	Console.WriteLine("Cuants munits?");
	// Demana el nombre total de minuts.

	var minuts = Console.ReadLine();
	// Llegeix la quantitat de minuts.

	int minutsint = Convert.ToInt32(minuts);
	// Converteix a enter.

	int hores = minutsint / 60;
	// Calcula les hores completes.

	int minutsrestans = minutsint % 60;
	// Calcula els minuts restants.

	Console.WriteLine($"Són {hores} hores i {minutsrestans} minuts");
	// Mostra el resultat en hores i minuts.

---

## EXERCICI 9

9. ![ex 9](fotos/ex%209.png)

   Converteix metres a peus (aprox.), mostra el resultat.

	Console.WriteLine("Metres");
	// Demana una distància en metres.

	var metres = Console.ReadLine();
	// Llegeix la distància en metres.

	int metresInt = Convert.ToInt16(metres);
	// Converteix la cadena a enter.

	int peus = metresInt * 328084;
	// Calcula peus amb un factor (multiplicat per 328084 en codi per evitar decimals).

	Console.WriteLine($"Peus : {peus}");
	// Mostra el resultat.

---

## EXERCICI 10

10. ![ex 10](fotos/ex%2010.png)

Combina nom i any de naixement per generar una contrasenya simple.

	Console.WriteLine("Nom");
	// Demana el nom.

	var nom = Console.ReadLine();
	// Llegeix el nom.

	Console.WriteLine("Any_Naixement");
	// Demana l'any de naixement.

	var any_naixement = Console.ReadLine();
	// Llegeix l'any de naixement.

	Console.WriteLine($"La teva passwd és : {nom}{any_naixement}");
	// Mostra la combinació nom+any com a "contrasenya".

---

## EXERCICI 11

11. ![ex 11](fotos/ex%2011.png)

Crea una adreça de correu a partir d'usuari i domini.

	Console.WriteLine("Nom d'usuari");
	// Demana el nom d'usuari.

	var nom = Console.ReadLine();
	// Llegeix el nom d'usuari.

	Console.WriteLine("Domini");
	// Demana el domini del correu.

	var domini = Console.ReadLine();
	// Llegeix el domini.

	Console.WriteLine($"La teva adreça és : {nom}@{domini}");
	// Mostra la direcció electrònica completa.

---

## EXERCICI 12

12. ![ex 12](fotos/ex%2012.png)

Calcula suma, resta, multiplicació i divisió de dos nombres.

	Console.WriteLine("Primer num");
	// Demana el primer número.

	var num = Console.ReadLine();
	// Llegeix el primer número.

	int numInt = Convert.ToInt16(num);
	// Converteix a enter.

	Console.WriteLine("Segon num");
	// Demana el segon número.

	var num2 = Console.ReadLine();
	// Llegeix el segon número.

	int numInt2 = Convert.ToInt16(num2);
	// Converteix a enter.

	int suma = numInt + numInt2;
	// Calcula la suma.

	int resta = numInt - numInt2;
	// Calcula la resta.

	int multiplicació = numInt * numInt2;
	// Calcula la multiplicació.

	int divisió = numInt / numInt2;
	// Calcula la divisió entera.

	Console.WriteLine($"Suma : {suma} , Resta : {resta} , Multiplicació : {multiplicació} , Divisió : {divisió}");
	// Mostra els quatre resultats.

---

## EXERCICI 13

13. ![ex 13](fotos/ex%2013.png)

Reformatar una data sense separadors (24092024 -> 24/09/2024).

	Console.WriteLine("Data sense formatar");
	// Demana la data sense separadors.

	string data = Console.ReadLine();
	// Llegeix la cadena de data.

	string DataString = (data);
	// Assigna la cadena a una variable (igual).

	Console.WriteLine(DataString.Substring(0, 2) + "/" + DataString.Substring(2, 2) + "/" + DataString.Substring(4, 4));
	// Mostra la data formatada separant dia/mes/any amb substring.

---

## EXERCICI 14

14. ![ex 14](fotos/ex%2014.png)

Mostra la primera, la del mig i l'última lletra d'una paraula.

	Console.WriteLine("Paraula per analitzar");
	// Demana una paraula.

	var paraula = Console.ReadLine();
	// Llegeix la paraula.

	Console.WriteLine($"La primera lletra és: " + paraula[0]);
	// Mostra la primera lletra.

	Console.WriteLine($"La lletra del mig és: " + paraula[paraula.Length / 2]);
	// Mostra la lletra central.

	Console.WriteLine($"La ultima lletra és: " + paraula[paraula.Length - 1]);
	// Mostra l'última lletra.

---

## EXERCICI 15

15. ![ex 15](fotos/ex%2015.png)

Capitalitza la primera lletra del nom i del cognom i imprimeix-los.

	Console.WriteLine("Nom");
	// Demana el nom.

	var nom = Console.ReadLine();
	// Llegeix el nom.

	Console.WriteLine("Cognom");
	// Demana el cognom.

	var cognom = Console.ReadLine();
	// Llegeix el cognom.

	var inicial = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower();
	// Capitalitza la primera lletra del nom.

	var inicialcognom = cognom.Substring(0, 1).ToUpper() + cognom.Substring(1).ToLower();
	// Capitalitza la primera lletra del cognom.

	Console.WriteLine($"Nom : {inicial} {inicialcognom}" );
	// Mostra el nom i cognom formatats.

---

## EXERCICI 16

16. ![ex 16](fotos/ex%2016.png)

Calcula la nota final combinant pràctiques i examen (ponderacions).

	Console.WriteLine("La meva nota de practiques");
	// Demana la nota de pràctiques.

	var examen = Console.ReadLine();
	// Llegeix la nota de pràctiques (variable amb nom confús).

	int nota1 = Convert.ToInt32(examen);
	// Converteix-la a enter.

	Console.WriteLine("La meva nota d'examen");
	// Demana la nota d'examen.

	var practiques = Console.ReadLine();
	// Llegeix la nota d'examen (variable amb nom confús).

	int nota2 = Convert.ToInt32(practiques);
	// Converteix-la a enter.

	double res = nota1 * 0.4 + nota2 * 0.6;
	// Calcula la nota ponderada (40% i 60%).

	double res2 = Math.Truncate(res);
	// Talla la nota a la part sencera (no arrodoneix).

	Console.WriteLine("La meva nota és: " + (nota1 * 0.3 + nota2 * 0.7) + " o sigui un " + res2);
	// Mostra un càlcul alternatiu (confús) i la part sencera.

---

## EXERCICI 17

17. ![ex 17](fotos/ex%2017.png)

Extreu i mostra la part decimal d'un nombre real.

	string num = "23.45";
	// Defineix una cadena amb un nombre (fix).

	string decimals = num.Substring(2);
	// Extreu la part a partir del tercer caràcter (decimals).

	Console.WriteLine($"Numero lleig : {num}");
	// Mostra el nombre original.

	Console.WriteLine($"Numero meravellós : {0}{decimals}" );
	// Mostra "0" seguit dels decimals per donar el format 0,45.

---

## EXERCICI 18

18. ![ex 18](fotos/ex%2018.png)

A partir d'una hora i un increment d'hores, calcula l'hora futura (mòdul 12).

	Console.WriteLine("Hora actual");
	// Demana l'hora actual.

	var hora = Console.ReadLine();
	// Llegeix l'hora.

	int horaactual = Convert.ToInt32(hora);
	// Converteix a enter.

	Console.WriteLine("Hores a incrementar");
	// Demana les hores a sumar.

	var hores = Console.ReadLine();
	// Llegeix les hores a incrementar.

	int horesincrementar = Convert.ToInt32(hores);
	// Converteix a enter.

	Console.WriteLine("D'aquí a " + horesincrementar + " hores seran les " + (horaactual + horesincrementar)    % 12);
	// Mostra l'hora futura calculada amb mòdul 12.

---

## EXERCICI 19

19. ![ex 19](fotos/ex%2019.png)

Demana una paraula i imprimeix la seva longitud (nombre de caràcters).

	Console.WriteLine("Diguem una paraula");
	// Demana una paraula a l'usuari.

	var paraula = Console.ReadLine();
	// Llegeix la paraula.

	Console.WriteLine($"La paraula és: " + paraula + " i té " + paraula.Length + " caràcters.");
	// Mostra la paraula i el seu nombre de caràcters.

---

## EXERCICI 20

20. ![ex 20](fotos/ex%2020.png)

Inverteix un número de tres xifres i mostra el resultat.

	Console.WriteLine("Numero:");
	// Demana un nombre de tres xifres.

	var num = Console.ReadLine();
	// Llegeix el nombre com a cadena.

	string Dig1 = num.Substring(0, 1);
	// Extreu la primera xifra.

	string Dig2 = num.Substring(1, 1);
	// Extreu la segona xifra.

	string Dig3 = num.Substring(2);
	// Extreu la tercera xifra (i la resta).

	Console.WriteLine("El número invertit és: " + (Dig3) + (Dig2) + (Dig1));
	// Mostra el número amb les xifres invertides.

---
	## EXERCICI 20

