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
        const string TransactionStorageDir = @"..\..\..\database\transactions";
        const string CustomerStorageDir = @"..\..\..\database\customer";

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
            DateTime birthDate;
            string phoneNumber;
            string address = null;

            DirectoryInfo dirInfo = new DirectoryInfo(TransactionStorageDir);
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

            using(StreamReader srTransaction = new StreamReader(filePath))                    // Wczytanie transakcji
            {
                string headerLine = ReadNextLine(srTransaction);

                string[] headerParts = headerLine.Split(';');
                customerName = headerParts[1];

                string nextLine;

                using (StreamReader srCustomer = File.OpenText($"{CustomerStorageDir}\\{customerName}.dat"))            // Wczytywanie konta
                {
                    nextLine = ReadNextLine(srCustomer);

                    string[] customerParts = nextLine.Split(';');                                       // CustomerName_BirthDate_Phone

                    birthDate = DateTime.ParseExact(customerParts[1], UtilityMethods.dateTimeFormat, null);
                    phoneNumber = customerParts[2];

                    nextLine = ReadNextLine(srCustomer);

                    if (!string.IsNullOrEmpty(nextLine))
                    {
                        address = nextLine;

                        while (!string.IsNullOrEmpty(nextLine))
                        {
                            address += "\n" + nextLine;
                            nextLine = ReadNextLine(srCustomer);
                            ReadNextLine(srCustomer);
                        }
                    }


                }

                lastAccount = new Account(accountID, customerName, birthDate, phoneNumber, address);

                nextLine = ReadNextLine(srTransaction);

                while (!string.IsNullOrEmpty(nextLine))                             // Wczytanie wszystkich transakcji
                {
                    string transactionLine = nextLine;

                    string[] transactioinParts = transactionLine.Split(';');        // TransactionType_TransactionAmount_TransactionDate_Location

                    string transactionType = transactioinParts[0];
                    decimal transactionAmount = Convert.ToDecimal(transactioinParts[1]);
                    DateTime transactionDate = DateTime.ParseExact(transactioinParts[2], UtilityMethods.dateTimeFormat, null);
                    string transactionLocation = transactioinParts[3];

                    switch (transactionType)
                    {
                        case "Deposit":
                            lastAccount.DepositMoney(transactionAmount, transactionDate, transactionLocation);
                            break;
                        case "Withdraw":
                            lastAccount.WithdrawMoney(transactionAmount, transactionDate, transactionLocation);
                            break;
                    }

                    

                    // lastAccount.ListOfTransactions.Add(fileTransaction);
                    // lastAccount.AddTransaction(fileTransaction);

                    nextLine = ReadNextLine(srTransaction);
                }                         
            }


            return lastAccount;
        }


        #endregion ODCZYT PLIKÓW

        #region ZAPIS PILKÓW


        public static bool SaveAccount(Account aAccount)
        {
            // File name        AccountID.dat
            // Header line      AccountID_CustomerName
            // Kolejne linie    TransactionType_TransactionAmount_TransactionDate_Location

            CheckMainDirectorys();

            using (StreamWriter sw = File.CreateText(TransactionStorageDir + "\\" + aAccount.AccountID + ".dat"))
            {
                sw.WriteLine($"{aAccount.AccountID};{aAccount.CustomerName}");

                foreach(Transaction tr in aAccount.ListOfTransactions)
                {
                    string transactionLine = $"{tr.TransactionTypeString};{tr.MoneyAmount};{tr.TransactionDateString};{tr.Location}";

                    sw.WriteLine(transactionLine);
                }
            }

            // File name        CustomerName.dat
            // Header line      CustomerName_BirthDate_Phone
            // Kolejne linie    Ulica\nMiasto\nKodPocztowy ...

            CheckMainDirectorys();

            FileInfo fileInfoObject = new FileInfo($"{CustomerStorageDir}\\{aAccount.CustomerName}.dat");

            using (StreamWriter sw = fileInfoObject.CreateText())
            {
                sw.WriteLine($"{aAccount.CustomerName};{aAccount.BirthDateString};{aAccount.CustomerPhoneNumber}");

                string[] addressLines = aAccount.CustomerAddress.Split(new char[] { '\r', '\n' });

                foreach(string addressLine in addressLines)
                {
                    sw.WriteLine(addressLine);
                }
            }

            return false;
        }


        #endregion ZAPIS PILKÓW


        static string ReadNextLine(StreamReader streamReader)
        {
            string nextLine = streamReader.ReadLine();
            return nextLine;
        }
    }
}
