using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    // Metody i właściwości używane do zapisu w plikach
    public static class StorageUtilityFunctions
    {
        const string TransactionStorageDir = @"..\datebase\transactions";
        const string CustomerStorageDir = @"..\database\customer";

        static bool CheckMainDirectorys()
        {
            if (Directory.Exists(TransactionStorageDir))
            {
                if (Directory.Exists(CustomerStorageDir))
                {
                    return true;
                }
                else
                {
                    Directory.CreateDirectory(CustomerStorageDir);
                }
            }
            else
            {
                Directory.CreateDirectory(TransactionStorageDir);
            }
            return true;                        
        }

        public static Account GetLastAccount()
        {
            return null;
        }

        public static bool SaveAccount(Account aAccount)
        {
            // File name        AccountID.dat
            // Pierwsza lini    AccountID_CustomerName
            // Kolejne linie    TransactionType_TransactionAmount_TransactionDate_Location

           
            using(StreamWriter sw =
                File.CreateText(TransactionStorageDir + "\\" + aAccount.AccountNumber + ".dat"))
            {
                sw.WriteLine($"{aAccount.AccountNumber}_{aAccount.CustomerName}");

                foreach(Transaction tr in aAccount.ListOfTransactions)
                {
                    string transactionLine = $"{tr.TransactionTypeString}_{tr.MoneyAmount}_{tr.TransactionDateString}_{tr.Location}";

                    sw.WriteLine(transactionLine);
                }
            }

            // File name        CustomerName.dat
            // Pierwsza linia   CustomerName_BirthDate_Phone
            // Kolejne linie    Ulica\nMiasto\nKodPocztowy ...

            FileInfo fileInfoObject = new FileInfo($"{CustomerStorageDir}\\{aAccount.CustomerName}.dat");

            using (StreamWriter sw = fileInfoObject.CreateText())
            {
                sw.WriteLine($"{aAccount.CustomerName}_{aAccount.}")
            }



                return false;
        }

    }
}
