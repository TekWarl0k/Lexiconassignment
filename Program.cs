using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string OriginalText = "The quick fox Jumped Over the DOG"; //Skapar en variabel som innehåller en sträng som ska ändras.
            string ChangedText; //Strängen som den ändrade texten ska sparas i.

            ChangedText = OriginalText.ToLower(); //Ändrar alla bokstäver till småbokstäver i strängen och sparar den i den nya variabeln.

            ChangedText = ChangedText.Remove(0,1); //Indexerar plats noll och tar bort en bokstav.

            ChangedText = ChangedText.Insert(0,"T"); //Indexerar plats noll och stoppar in en bokstav. 

            ChangedText = ChangedText.Replace("quick", "brown"); //Byter ut en sträng "quick" och byter ut den emot "brown".

            int indexOfDog = ChangedText.IndexOf("dog"); //Indexerar på vilken plats strängen "dog" börjar och sparar den i en int variabel.
            ChangedText = ChangedText.Insert(indexOfDog, "Lazy "); //Använder värdet sparat i int variabeln för att få reda på vart dog är och stoppar in strängen "Lazy " innan.

            Console.WriteLine(OriginalText); //Skriver ut sträng.
            Console.WriteLine(ChangedText);
            Console.ReadKey();
        }
    }
}
