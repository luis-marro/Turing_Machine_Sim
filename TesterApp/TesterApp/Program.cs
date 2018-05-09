using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing_Machines;

namespace TesterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciones la maquina a utilizar");
            Console.WriteLine("1. Suma Unaria");
            Console.WriteLine("2. Resta Unaria");
            Console.WriteLine("3. Multiplicacion Unaria");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cadena");
            if (choice == 1)
            {
                string input = Console.ReadLine(); 
                TuringMachineSum sum = new TuringMachineSum();
                if (sum.evaluateInput(input.ToCharArray()))
                {
                    // write the tape 
                    for(int i = 0; i < sum.tape.Count; i++)
                        Console.Write(sum.tape[i] + " "); 
                    Console.WriteLine(); 
                    // write the movements 
                    for(int i = 0; i < sum.headMovements.Count; i++)
                        Console.Write(sum.headMovements[i] + " ");
                    Console.WriteLine(); 
                    for (int i = 0; i < sum.history.Count; i++)
                        Console.Write(sum.history[i] + " ");
                }
            }
            if (choice == 2)
            {
                string input = Console.ReadLine(); 
                TuringMachineSub sub = new TuringMachineSub();
                if (sub.evaluateInput(input.ToCharArray()))
                {
                    // write the tape 
                    for (int i = 0; i < sub.tape.Count; i++)
                        Console.Write(sub.tape[i] + " ");
                    Console.WriteLine();
                    // write the movements 
                    for (int i = 0; i < sub.headMovements.Count; i++)
                        Console.Write(sub.headMovements[i] + " ");
                    Console.WriteLine();
                    for (int i = 0; i < sub.history.Count; i++)
                        Console.Write(sub.history[i] + " ");
                }
            }
            if (choice == 3)
            {
                string input = Console.ReadLine();
                TuringMachineMult mult = new TuringMachineMult();
                if (mult.evaluateInput(input.ToCharArray()))
                {
                    // write the tape 
                    for (int i = 0; i < mult.tape.Count; i++)
                        Console.Write(mult.tape[i] + " ");
                    Console.WriteLine();
                    // write the movements 
                    for (int i = 0; i < mult.headMovements.Count; i++)
                        Console.Write(mult.headMovements[i] + " ");
                    Console.WriteLine();
                    for (int i = 0; i < mult.history.Count; i++)
                        Console.Write(mult.history[i] + " ");
                }
            }

            Console.ReadKey(); 
        }
    }
}
