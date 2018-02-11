using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    /*
     * A console Menu app using arrowkeys for navegation
     * by Mateus Grunheidt Lacerda
     * mateulacerda@hotmail.com
     * v2 
     * aprimore the design of the menu with Console.SetCursorPosition
     * and
     * aprimore the print of the menu with a loop and add a var for the menu choices 
     * Code more dynamic and succint
     * Codigo mais dinamico e sucinto
     * desenho dinamico do menu
     */

    class Program
    {
        static void Main(string[] args)
        {
            String seta = " -> ";
            string aux = "    ";
            int ItemCount = 3; // esta variavel contem o numero de itens no menu
                               // This variable holds the number of menu items.
            int MenuChoice = 0; // esta variavel marca a posição do cursos
                                // This variable holds the position of the cursor.
            ConsoleKeyInfo keyInfo; // this funcition capture the key
                                    // for entering the key (up arrow,down arrow,etc...)

            string[] MenuOption = new string[ItemCount];
            MenuOption[0] = "Menu option #1";
            MenuOption[1] = "Menu option #2";
            MenuOption[2] = "Menu option #3";
            menu();
            Console.CursorVisible = false; // this function remove the blinking cursor
                                           // esta função remove o cursos piscante
            while (true)
            {
                keyInfo = Console.ReadKey(); // captura the key from keyboard
                // nota futura usar try catch para um loop infinito procura as keys chave                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        uparrow();
                        menu();
                        break;
                    case ConsoleKey.DownArrow:                        
                        downarrow();
                        menu();
                        break;
                    case ConsoleKey.LeftArrow: break;
                    case ConsoleKey.RightArrow: break;
                    default: return;
                }
            }
            void menu()
            {
                Console.Clear();
                for (int i = 0; i < ItemCount; i++)
                {
                    Console.SetCursorPosition(35, 7 + i);
                    if (i == MenuChoice) Console.Write(" -> ");
                    else Console.Write("    ");                    
                    Console.WriteLine(MenuOption[i]);
                }
                
            }
            void uparrow()
            {
                if (MenuChoice != 0) MenuChoice--;
                else MenuChoice = ItemCount;
            }
            void downarrow()
            {
                if (MenuChoice != ItemCount) MenuChoice++;
                else MenuChoice = 0;
            }
        }
    }
}
