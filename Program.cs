using System;
using System.Runtime.CompilerServices;

class Program {

    static void main () {

        // chci aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            Console.Clear();


           Console.WriteLine ();
           Console.WriteLine ();
           Console.WriteLine ();
           Console.WriteLine ();
           Console.WriteLine ();


            // vstup uživatele - špatná varianta 
            //Console.Write("Vlož první číslo řady: ");
            //int first = int.Parse(Console.ReadLine());


            // vstup uživatele lepší varianta 
            Console.Write("Vlož první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celéčíslo): ");
            }

            Console.Write("Vlož poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady (celéčíslo): ");
            }

            Console.Write("Vlož diferenci řady (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu diferenci řady (celéčíslo): ");
            }
            
            // Výpis uživatelského vstupu 
            Console.WriteLine();
            Console.WriteLine("=================");
            Console.WriteLine("první číslo řady: {0}", first);
            Console.WriteLine("poslední číslo řady", last);
            Console.WriteLine("diferenci řady", step);
            Console.WriteLine();
            Console.WriteLine();

            // logika pro výpis řady TO-DO
            int current = first;
            while(current <= last) {
                Console.WriteLine(current);
                current = current + step;

            }

            // opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();








        }



    }


}