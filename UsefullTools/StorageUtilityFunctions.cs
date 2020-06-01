using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UsefullTools
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


        #region ODCZYT PILKÓW


        public static Account GetLastAccount()
        {
            Account lastAccount = new Account();
            string customerName;

            DirectoryInfo dirInfo = new DirectoryInfo(CustomerStorageDir);
            FileInfo[] fileInfoArray = dirInfo.GetFiles();

            if (fileInfoArray.Length == 0)
            {
                return null;
            }

            ////// foreach (var firl in fileInfoArray)  Blabla bla     .......... Zad dużo piasnia!!!!!!!!!!!!!!!!!!!!

            FileInfo lastFileInfo = fileInfoArray.OrderByDescending(f => f.LastWriteTime).First();            // LINQ = Fajne, szybkie, super, krótkie. Do odczytywania z plików idealnie, a nie jakiś foreach czy inna pętla

            string filePath = lastFileInfo.FullName;
            string fileName = Path.GetFileNameWithoutExtension(filePath);          // Dostaniemy ID konta
            
            int accountID = Convert.ToInt32(fileName);

            using(StreamReader sr = new StreamReader(filePath))                    // Wczytanie transakcji
            {
                string headerLine = sr.ReadLine();

                string[] headerParts = headerLine.Split('_');
                customerName = headerParts[1];

                string nextLine = sr.ReadLine();

                while (!string.IsNullOrEmpty(nextLine))
                {
                    string transactionLine = nextLine;

                    string[] transactioinParts = transactionLine.Split('_');        // TransactionType_TransactionAmount_TransactionDate_Location

                    string transactionType = transactioinParts[0];
                    decimal transactionAmount = Convert.ToDecimal(transactioinParts[1]);
                    DateTime transactionDate = DateTime.ParseExact(transactioinParts[2], UtilityMethods.dateTimeFormat, null);
                    string transactionLocation = transactioinParts[3];
                    


                    nextLine = sr.ReadLine(); 
                }
                
             
            }


            return null;
        }


        #endregion ODCZYT PLIKÓW

        #region ZAPIS PILKÓW


        public static bool SaveAccount(Account aAccount)
        {
            // File name        AccountID.dat
            // header line      AccountID_CustomerName
            // Kolejne linie    TransactionType_TransactionAmount_TransactionDate_Location

           
            using(StreamWriter sw = File.CreateText(TransactionStorageDir + "\\" + aAccount.AccountNumber + ".dat"))
            {
                sw.WriteLine($"{aAccount.AccountNumber}_{aAccount.CustomerName}");

                foreach(Transaction tr in aAccount.ListOfTransactions)
                {
                    string transactionLine = $"{tr.TransactionTypeString}_{tr.MoneyAmount}_{tr.TransactionDateString}_{tr.Location}";

                    sw.WriteLine(transactionLine);
                }
            }

            // File name        CustomerName.dat
            // header line      CustomerName_BirthDate_Phone
            // Kolejne linie    Ulica\nMiasto\nKodPocztowy ...

            FileInfo fileInfoObject = new FileInfo($"{CustomerStorageDir}\\{aAccount.CustomerName}.dat");

            using (StreamWriter sw = fileInfoObject.CreateText())
            {
                sw.WriteLine($"{aAccount.CustomerName}_{aAccount.BirthDateString}_{aAccount.CustomerPhoneNumber}");

                string[] addressLines = aAccount.CustomerAddress.Split(new char[] { '\r', '\n' });

                foreach(string addressLine in addressLines)
                {
                    sw.WriteLine(addressLine);
                }
            }

            return false;
        }


        #endregion ZAPIS PILKÓW

    }
}
