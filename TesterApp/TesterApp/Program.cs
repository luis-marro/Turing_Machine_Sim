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
                }
            }

            Console.ReadKey(); 
        }
    }
}
