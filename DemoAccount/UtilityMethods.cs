using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAccount
{
    // A class to hold common funcions
    public static class UtilityMethods
    {
        // Text input
        public static string ReadTextInput(string aMassage)
        {
            string returnValue;

            Console.WriteLine(aMassage);
            returnValue = Console.ReadLine();

            return returnValue;
        }

        // Inna opcja przekazywania zmiennych od funkcji. Jeśli wsztawimy słowo "ref" podając parametr funkcji,
                //fukcja będzie mogła wpływać bezpośrednio na zmienną którą podaliśmy.
        public static void ReadTextInput(string aMessage, ref string aReturn)
        {
            aReturn = ReadTextInput(aMessage);
        }

        // Numeric input
        public static int ReadNumericInput(string aMassage)
        {
            int returnValue;

            Console.WriteLine(aMassage);
            returnValue = Convert.ToInt32(Console.ReadLine());

            return returnValue; 
        }

        public static void ReadNumericInput(string aMessage, ref int aReturn)
        {
            aReturn = ReadNumericInput(aMessage);
        }

        // Press Any Key to continue
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press Any Key To Continue...");

            Console.ReadKey();
        }

        public static void OnlyMoneyAllowed(object sender, KeyPressEventArgs e)            // Skopiowane z neta ale już wiem jak to działą
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
