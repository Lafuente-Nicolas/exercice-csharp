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

int[] notes = { 10, 12, 15, 8 };
if (notes.Length <=0)
{
    Console.WriteLine("le tableau est vide");
} else
{
    Console.WriteLine($"la moyenne est{notes.Average()}");
};
