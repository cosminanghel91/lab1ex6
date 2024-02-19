/*
* Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar.
* Daca numarul este par, programul va afisa "par", iar in caz contrar "impar"
*/

Console.WriteLine("Introduceti numarul pe care doriti sa il verificam daca este par sau impar");
int numar = int.Parse(Console.ReadLine());


if (numar % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}