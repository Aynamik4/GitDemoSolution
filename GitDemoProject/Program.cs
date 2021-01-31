// 1. Compiler errors.
// 2. Run-time errors.
// 3. Logical errors (intermittant).

using System;

namespace GitDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vänligen mata in en nämnare: ");
            string keyboardInput = Console.ReadLine();
            int nämnare = 0;

            try
            {
                nämnare = int.Parse(keyboardInput);
                int kvot = 20 / nämnare;
                Console.WriteLine($"{20} / {nämnare} = {kvot}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Du kan inte dividera med talet 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktig inmatning!");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Talet måste vara ett tal mellan {int.MinValue} och {int.MaxValue}");
            }
            catch(Exception)
            {
                Console.WriteLine("Det har uppstått ett oväntat fel.");
            }
            finally
            {
                Console.WriteLine("Denna kodrad kommer ALLTID att köra oavsett om vi får ett exception eller inte.");
            }

            Console.WriteLine("Nu fortsätter programmet att köra!");
        }
    }
}
