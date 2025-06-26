// Écrire un programme qui vérifie si un nombre donné est supérieur à 10.
/*int nombre;

Console.WriteLine("Saisissez un nombre :");
nombre = Convert.ToInt32(Console.ReadLine());

if (nombre > 10)
{
    Console.WriteLine("supérieur");
}
else
{
    Console.WriteLine("inférieur");
}
;*/
// Vérifier si un nombre donné est positif, négatif ou nul.


/*int nombre;
Console.WriteLine("saisissez un nombre :");
nombre = Convert.ToInt32(Console.ReadLine());
if (0 < nombre * -1)
{
    Console.WriteLine("négatif");
}
else if (0 < nombre)
{
    Console.WriteLine("positif");
}
else
{
    Console.WriteLine("Nul");
};*/

// Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18.

/*int nombre;
Console.WriteLine("Saisissez votre âge :");
nombre = Convert.ToInt32(Console.ReadLine());
if (nombre < 18) 
{
    Console.WriteLine("vous êtes mineur");
}
else
{
    Console.WriteLine("Vous êtes majeur");
};*/

// Écrire un programme qui vérifie si une chaîne de caractères est vide ou non.

/*String mots;
Console.WriteLine("saisissez une chaine de caractères :");
mots = Console.ReadLine();

if (mots == "")
{ 
    Console.WriteLine("La chaîne de caractères est vide.");
}
else
{
        Console.WriteLine("La chaîne de caractères n'est pas vide.");
};*/

//  Vérifier si un nombre est pair ou impair.
/*
int number;
Console.WriteLine("Indiquez votre age");
number = Convert.ToInt32(Console.ReadLine());

if ( 0 >number*-1)
{
    Console.WriteLine("C'est un nombre impair");
}
else
{
    Console.WriteLine("C'est un nombre pair");
}*/


// 11. Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.

/*int number;
Console.WriteLine("écrivez un nombre:");
number = Convert.ToInt32(Console.ReadLine());

if (number > 10 && number < 20)
{
    Console.WriteLine("Le nombre est compris entre 10 et 20");
        }
else
{
    Console.WriteLine("Le nombre n'est pas compris entre 10 et 20");
};*/

// 12. Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).

/*int nombre;
Console.WriteLine("Mettez votre âge");
nombre = Convert.ToInt32(Console.ReadLine());

if (nombre > 18)
{
    Console.WriteLine("Vous êtes majeur");
}
else if (nombre < 12 )
{
    Console.WriteLine("Vous êtes un enfant");
}
else
{
    Console.WriteLine("Vous êtes un adolescent");
}*/

// 13. Créer un programme qui vérifie si une année est bissextile ou non.

/*int nombre;
Console.WriteLine("Choissisez une année");
nombre = Convert.ToInt32(Console.ReadLine());

if ( 0 == nombre % 4 && nombre %100 != 0)
{
    Console.WriteLine("C'est une année bissextile");
}
else
{
    Console.WriteLine("Ce n'est pas une année bissextile");
};*/

// 14. Vérifier si un nombre est positif et multiple de 5.

/*int nombre;
Console.WriteLine("écrivez un nombre:");
nombre = Convert.ToInt32(Console.ReadLine());

 if (nombre > 0 && nombre % 5 == 0)
{
    Console.WriteLine("Le nombre est positif et multupliable par 5");
}
else if (nombre % 5 == 0)
{
    Console.WriteLine("Le nombre est multipliable par 5");
}
else
{
    Console.WriteLine("Soit il n'est pas positif ou multipliable par 5");
};
*/

// 15. Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.

/*string mot;
Console.WriteLine("écrivez un mot");
mot = Console.ReadLine();
for (int i = 0; i < mot.Length ; i++)
{
    if (mot[i] == 'a')
    {
        Console.WriteLine("Il y a un a ");
    }
    else
    {
        Console.WriteLine("Il n'y a pas de a");
    }
};
*/
// 21. Afficher les nombres de 1 à 10 avec une boucle `for`.

/*for (int i = 1; 10>= i; i++)
{
    Console.WriteLine(i);
};*/

//22. Afficher les nombres pairs entre 1 et 20.

/*for(int i = 1; i <= 20; i++)
{
    if (i %2 == 0) {
        Console.WriteLine(i);
    }
};*/

// 23. Utiliser une boucle pour afficher chaque élément d'un tableau.

/*string element;
Console.WriteLine("choissisez des nombres");
element = Console.ReadLine();

for (int i = 0; i < element.Length; i++)
{
    Console.WriteLine(i);
};*/

// 24. Demander à l'utilisateur un nombre de 1 à 10 et afficher la table de multiplication.

/*int nombre;
Console.WriteLine("Saisissez un nombre entre 1 et 10");
nombre = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i * nombre);
};*/

// 31. Utiliser une boucle `while` pour afficher les nombres de 1 à 10.

/*int i =1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
};*/

// 32. Utiliser une boucle `while` pour calculer la somme des nombres de 1 à 100.

/*int i = 1;
int somme = 0;
while (i <= 100)
{
    somme = somme + i;
    i++;
};
Console.WriteLine(somme);*/

// 33. Demander à l'utilisateur un nombre et continuer à demander tant que ce nombre est négatif.

/*int nombre;
Console.WriteLine("écrivez un nombre");
nombre = Convert.ToInt32(Console.ReadLine());
if (nombre > 0)
{
    Console.WriteLine("Le nombre est positif");
}
else
{
    while (nombre < 0)
    {
        Console.WriteLine("écrivez un nombre");
        nombre = Convert.ToInt32(Console.ReadLine());
        
    }
    if (nombre > 0)
    {
        Console.WriteLine("Le nombre est positif");
    }
};*/

// Autre méthode:
/*
int nombre;
do
{
    Console.WriteLine("écrivez un nombre positif");
    nombre = Convert.ToInt32(Console.ReadLine());

} while (nombre < 0);
Console.WriteLine("Le nombre est positif");*/

// Exercice 5: Gestion des notes


/*
int[] notes = new int[5];
const int nbNotes = 5;
for (int i = 0; i < nbNotes; i++)
{
    do
    {
        Console.WriteLine($"/t- Merci de saisir la note {i + 1} (sur /20)");
        notes[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    } while (notes[i] < 0 || notes[i] > 20);

    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine($"La moyenne est de {notes.Average()}");
    Console.WriteLine($"La note la plus élévé est {notes.Max()}");
    Console.WriteLine($"La note la moin élevé est {notes.Min()}");

};
*/
/*Console.WriteLine("---Le nombre mystère---");
int nombre;   // initia de la variable nombre
Console.WriteLine("Veuillez saisir un nombre:");
nombre = Convert.ToInt32(Console.ReadLine());   // je converti la saissie nombre (string) en nombre entier (int)
Random nombreAléatoire = new Random( );         
int nbAléatoire = nombreAléatoire.Next(1,50);
int i = 0;                                     // je déclare une variable i (int)
int nbCoups = 0;                               // je déclare une variable nbCoups (pour compter le nombre de tentative )
while ( i < 1)                                 // 
{
    if (nombre > nbAléatoire)                  // si nombre est plus grand que le nombre aléatoire, j'affiche une erreur et passe a la condition suivante 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLe nombre mystère est plus petit");
        Console.WriteLine("Veuillez saisir un nombre:");
        nombre = Convert.ToInt32(Console.ReadLine());
        nbCoups++;
    }
    else if (nombre < nbAléatoire)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLe nombre mystère est plus grand");
        Console.WriteLine("Veuillez saisir un nombre:");
        nombre = Convert.ToInt32(Console.ReadLine());
        nbCoups++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bien joué!! Tu as trouvé !");
        Console.WriteLine($"Vous avez trouvé en {nbCoups} coups. ");
        i++;
        break;
    }
}*/

/*int[] notes = { 10, 12, 15, 8 };
if (notes.Length==0)
{
    Console.WriteLine("le tableau est vide");
} else
{
    Console.WriteLine($"la moyenne est{notes.Average()}");
};
*/

/*int[] valeurs = { 10, 14, 18, 14 };
Console.WriteLine($"La valeur minimale est {valeurs.Min()}");
Console.WriteLine($"La valeur maximale est {valeurs.Max()}");
Console.WriteLine($"La valeur minimale est {valeurs.Average()}");*/


/*
List<string> prénoms = new List<string>();
prénoms.Add("Nicolas");
prénoms.Add("Jean");
prénoms.Add("Thomas");
prénoms.Sort();
Console.WriteLine(String.Join(" - ", prénoms));
*/

/*Dictionary<string, string> capitales = new Dictionary<string, string>();
string userInput = "";
string recherche = "";
do
{
    Console.WriteLine("---Saisissez un pays, sinon tapez fin---");
    userInput = Console.ReadLine();

    if (userInput != "fin")
    {
        Console.WriteLine("Donnez la capitale");
        capitales.Add(userInput, Console.ReadLine());
    }
}
while (userInput != "fin");

Console.WriteLine("Rechercher la capitale avec un pays");
recherche = Console.ReadLine();
if (capitales.ContainsKey(recherche))
{
    Console.WriteLine(capitales[recherche]);
};
*/

/*
using System;

Dictionary<string, string> capitales = new Dictionary<string, string>();
string userInput = "";
string recherche = "";
string couples = "";


while (1 > 0)
{
    Console.WriteLine("Tapez sur A pour aller sur saisir un pays et une capitale");
    Console.WriteLine("Tapez sur B pour rechercher une capitale avec un pays");
    userInput = Console.ReadLine();
    Console.Clear();


    switch (userInput)
    {
        case "A":
            if (userInput == "A")
                Console.WriteLine("---Saisissez un pays, sinon tapez fin---");
            couples = Console.ReadLine();
            Console.WriteLine("Donnez la capitale");
            capitales.Add(userInput, Console.ReadLine());
            break;

        case "B":
            if (userInput == "B")
                Console.WriteLine("Rechercher la capitale avec un pays");
            recherche = Console.ReadLine();
            if (capitales.ContainsKey(recherche))
            {
                Console.WriteLine(capitales[recherche]);
            }
            break;
    }
}
;
*/

//  Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin".


/*string mdp = "Nico";
string user = "";
Console.WriteLine("écrivez votre mdp");
user = Console.ReadLine();

if ( mdp == user)
{
    Console.WriteLine("Vous êtes l'admin");
}
else
{
    Console.WriteLine("Vous n'êtes pas l'admin");
};*/


//Afficher les nombres de 10 à 1 en ordre décroissant avec une boucle.

/*int nombre = 10;
for(int i = 1; i <= nombre; i++)
{
    Console.WriteLine(i);
};
*/

//41. Utiliser une boucle pour afficher les nombres de 1 à 20, mais arrêter dès que vous atteignez 10.

/*int nombre = 20;
for(int i = 1; i <= nombre; i++)
{
    if ( i == 10)
    {
        Console.WriteLine(i);
    }
}*/

//Exercice 4 du cours sur les collections

/*int compteur = 0;
int[] valeurs = { 1, 2, 3, 4, 5 };
List<string> prenoms = new List<string>();
prenoms.Add("Nico");
prenoms.Add("Thomas");
prenoms.Add("Caro");
prenoms.Add("Jim");

var paires = new Dictionary<string, string>
{
    ["France"] = "Paris",
    ["Espagne"] = "Madrid",
    ["Allemagne"] = "Berlin"

};

foreach (int n in valeurs)
{
    Console.Write($" {n}");
    compteur++;
};
Console.WriteLine();
int compteurPrenom = 0;
foreach (string prenom in prenoms)
{
    Console.WriteLine($" {compteurPrenom} : {prenom}");
    compteurPrenom++;
    compteur++;
};

foreach(var pays in paires)
{
    Console.WriteLine($"{pays.Key} : {pays.Value}");
    compteur++;
};
Console.WriteLine(compteur);*/

//Exercice 1 : Premiers pas avec les fonctions
/*
class Program
{
    static void AfficherSeparateur()
    {
        Console.WriteLine(new string('-', 30));
    }

    static void Main(string[] args)
    {
        AfficherSeparateur();
    }
};*/

// Fonction qui affiche une salutation personnalisée
/*static void Saluer(string prenom, int age)
{
    Console.WriteLine($"Bonjour {prenom}, vous avez {age} ans.");
}

// Appel de la fonction
Saluer("Alice", 30);*/
/*
// Fonction qui affiche un message plusieurs fois, avec un paramètre optionnel pour le nombre de répétitions

static void RepeterMessage(string message, int repetitions = 1)
{
    for (int i = 0; i < repetitions; i++)
    {
        Console.WriteLine(message);
    }
}

// Appels de la fonction
RepeterMessage("Bonjour");       // utilise la valeur par défaut repetitions=1
RepeterMessage("Salut", 3);      // spécifie repetitions=3*/



// Exercice 2 : Fonction avec paramètres et retour
/*internal class Program
{
    static int Additionner(int a, int b)
    {
        int resultat = a + b;
        return resultat;
    }

    static bool EstPair(int nombre)
    {
        return (nombre % 2 == 0);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Saisissez la 1ère valeur");

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Saisissez la 2nd valeur");

        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($" résulat :{Additionner(a, b)}");
        Console.WriteLine($"Le résultat est pair:{EstPair(Additionner(a, b))}");
    }

};*/

// 19. Créer un programme qui vérifie si une chaîne de caractères est un palindrome.

/*string mot = "kayak";
string motinverse = new string(mot.Reverse().ToArray());

if (mot == motinverse)
    Console.WriteLine($"Ce mot {mot} est un palindrome");
else
    Console.WriteLine($"Ce mot {mot} n'est pas un palindrome");*/

/*// 52. Créer un programme qui affiche un rectangle de caractères "X" de taille donnée par l'utilisateur.
Exemple, 4 donne : 
XXXX
XXXX
XXXX
XXXX*/
/*
int nombre = 4;
for (int i = 0; i<nombre; i++)
{
    Console.WriteLine(new string('x', 4));
}*/

//42. Créer une boucle qui demande un nombre et s'arrête si le nombre est 0.

/*int nombre;
Console.WriteLine("Saisissez un nombre");
nombre = Convert.ToInt32(Console.ReadLine());
for (int i = 0; nombre > i; i++)
{
    if (nombre == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Saisissez un nombre");
        nombre = Convert.ToInt32(Console.ReadLine());
    }
};*/

// 47. Utiliser `break` pour quitter une boucle infinie après 5 itérations.

/*int i = 1;
int nombre = 2;
int count = 0;
while(i < nombre)
{
    Console.WriteLine(nombre);
    if (count == 4)
    {
        break;
    }
    else;
    {
        count++;
       
    }
};*/
// 44. Écrire une boucle qui affiche les nombres de 1 à 20, mais saute les multiples de 3.

/*int nombre = 20;
for ( int i = 1; i <=20; i++)
{
    int divisible = 3;
    if ( i % divisible  == 0)
    {
        continue;
    }
    Console.WriteLine(i);
};*/

//37.Créer une boucle `while` qui décrémente un nombre à partir de 10 jusqu'à 0.

/*int nombreS = 10;
int nombreI =0;
if (nombreS != nombreI)
{
    while (nombreS >= nombreI)
    {
        Console.WriteLine(nombreS);
        nombreS--;
    }
};*/

// 39. Afficher les nombres pairs de 2 à 200 si ils sont divisible par 3 avec une boucle `while`.

/*int nombreS = 200;
int nombres = 2;
int divisible = 3;
int pair = 2;

while(nombres <= nombreS)
{
    if (nombres % divisible  == 0 && nombres % pair == 0 )
    {
        Console.WriteLine(nombres);
    }
    nombres++;
};*/

// 76. Utiliser une boucle pour vérifier si un nombre est parfait (la somme de ses diviseurs est égale à lui-même).

/* Console.WriteLine("Nombre ?");

 int number = Convert.ToInt32(Console.ReadLine());
 int sum = 0;

 for (int i = number - 1; i > 0; i--)
     if (number % i == 0)
         sum += i;

 if (sum == number)
     Console.WriteLine("le nombre est parfait");
 else
     Console.WriteLine("le nombre n'est pas parfait");
*/

// 56. Utiliser des boucles imbriquées pour calculer et afficher le produit scalaire de deux tableaux. 

/*double[] tab_0 = { 5, 89, 79, 4, 56 };
double[] tab_1 = { 8, 9.4, 12, 78, 7.7 };
double somme = 0;
for (int i = 0; i < tab_0.Length; i++)
{
    somme += (tab_1[i] * tab_0[i]);
    Console.WriteLine(somme);
}*/

//53.Utiliser des boucles imbriquées pour afficher une pyramide de nombres.

/*string ligne = "";
string pyramide = "";
int chiffre = 1;
string userInput = "";
int userInputInInt = 0;

do
{
    Console.WriteLine("Entrez une taille de pyramide");
    userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out userInputInInt));


for (int i = 0; i < userInputInInt; i++)
{
    for (int j = 0; j < i; j++)
    {
        ligne += $"{chiffre} ";
        chiffre++;
    }
    pyramide += $"{ligne}\n";
    ligne = "";
}

Console.WriteLine(pyramide);*/

// 67. Écrire une boucle qui fusionne deux listes en une seule.


/*List<object> liste1 = new List<object> { 5, 89, 79, 4, false };
List<object> liste2 = new List<object> { 8, 9, 12, "azed", 7.7, 9 };

foreach (var item in liste2)
    liste1.Add(item);

Console.WriteLine(string.Join('-', liste1));*/