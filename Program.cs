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
    if (mot == "a")
    {
        Console.WriteLine("Il y a un a ");
    }
    else
    {
        Console.WriteLine("Il n'y a pas de a");
    }
};*/