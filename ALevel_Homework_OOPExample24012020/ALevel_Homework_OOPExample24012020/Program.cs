
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var banks = GenerateBanks();
            var users = GenerateUsers(banks);


            //var nameLength = users.Where(user => (user.FirstName.Length + user.LastName.Length) >= 12).ToList();

            var nameLength = from nameLengthTwelve in users
                             where nameLengthTwelve.FirstName.Length + nameLengthTwelve.LastName.Length >= 12
                             select nameLengthTwelve.FirstName +" "+ nameLengthTwelve.LastName;

            foreach (var names in nameLength)    
                    Console.WriteLine(names);

           // var allTransactionToList = users.Where(userTr => userTr.Transactions != null).ToList();

            var allTransactionToList = from allTransation in users
                                       where allTransation.Transactions != null
                                       select allTransation.Transactions;

            foreach (var transaction in allTransactionToList)
            {
                foreach (var allTransactions in transaction) // foreach (var allTransactions in transaction.Transactions)
                    Console.WriteLine(allTransactions.Value);
            }
            var allBankUser = users.Where(us => us.Transactions.Where(trInUAH => trInUAH.Currency == Currency.UAH).Count() != 0);

            //var allBankUser =
            //    users.Select(c =>
            //    new
            //    {
            //        BankName = c.Bank.Name,
            //        UserFirstName = c.FirstName,
            //        UserSecondName = c.LastName,
            //        UserTransactionInUAH = c.Transactions.Where(trInUAH => trInUAH.Currency == Currency.UAH).Count()
            //    }
            //    );

            //var allBankUser =
            //    from user in users
            //    where user.Transactions.Where(trInUAH => trInUAH.Currency == Currency.UAH).Count() != 0
            //    select user;

            var usersByBanks = users.GroupBy(x => x.Bank.Name);

            //var usersByBanks =
            //    from bank in allBankUser
            //    group bank by bank.Bank.Name;

            foreach (var descendingByName in usersByBanks)
            {
                Console.WriteLine($"Bank name: {descendingByName.Key}");
                foreach (var userByBank in descendingByName.OrderByDescending(x =>x.LastName))
                {
                    Console.WriteLine($"User name: {userByBank.LastName} {userByBank.FirstName} \t Transactions in UAH: {userByBank.Transactions.Where(trInUAH => trInUAH.Currency == Currency.UAH).Count()}");
                }
            }

           //var bestsBank = banks.Max(x => x.Transactions.Count);

            var bestsBank = (from bank in banks
                            orderby bank.Transactions.Count descending
                            select bank.Transactions.Count).FirstOrDefault();

            // var adminUser = users.Where(usType => usType.Type == UserType.Admin);

            var adminUser =
                from i in users
                where i.Type == UserType.Admin
                select i;

            //var adminUserInBestBank = adminUser.Where(usBank => usBank.Bank.Transactions.Count == bestsBank);

            var adminUserInBestBank =
                from commonUser in adminUser
                where commonUser.Bank.Transactions.Count == bestsBank
                select commonUser;

            foreach (var adminUsers in adminUserInBestBank)
            {
                    Console.WriteLine($"Username: {adminUsers.FirstName} {adminUsers.LastName}\t type: {adminUsers.Type}\t bank: {adminUsers.Bank.Name}");
            }

            var customUser = users.Where(usType => usType.Type != UserType.Admin);


            var transactionCountPerCurrency =
                users.Select(transaction =>
               new
               {
                   TransactionsinUSD = transaction.Transactions.Where(usr => usr.Currency == Currency.USD).Count(),
                   TransactionsinEUR = transaction.Transactions.Where(usr => usr.Currency == Currency.EUR).Count(),
                   TransactionsinUAH = transaction.Transactions.Where(usr => usr.Currency == Currency.UAH).Count(),
               }
                    );
           
           var maxInUAH = transactionCountPerCurrency.Max(tr => tr.TransactionsinUAH);
           var notAdminMaxUAHCurrency = customUser.Where(tr => tr.Transactions.Where(trUAH => trUAH.Currency == Currency.UAH).Count()== maxInUAH);

            var maxInUSD = transactionCountPerCurrency.Max(tr => tr.TransactionsinUSD);
            var notAdminMaxUSDCurrency = customUser.Where(tr => tr.Transactions.Where(trUSD => trUSD.Currency == Currency.USD).Count() == maxInUSD);

            var maxInEUR = transactionCountPerCurrency.Max(tr => tr.TransactionsinEUR);
            var notAdminMaxEURCurrency = customUser.Where(tr => tr.Transactions.Where(trEUR => trEUR.Currency == Currency.EUR).Count() == maxInEUR);

            foreach (var maxTrInDifCurrencyUAH in notAdminMaxUAHCurrency)
            {
                Console.WriteLine($"Max transactions in UAH:\t {maxTrInDifCurrencyUAH.FirstName}  {maxTrInDifCurrencyUAH.LastName}");
            }

            foreach (var maxTrInDifCurrencyUSD in notAdminMaxUSDCurrency)
            {
                Console.WriteLine($"Max transactions in USD:\t{maxTrInDifCurrencyUSD.FirstName}  {maxTrInDifCurrencyUSD.LastName}");
            }

            foreach (var maxTrInDifCurrencyEUR in notAdminMaxEURCurrency)
            {
                Console.WriteLine($"Max transactions in EUR:\t{maxTrInDifCurrencyEUR.FirstName}  {maxTrInDifCurrencyEUR.LastName}");
            }

           //var premUser = users.Where(usType => usType.Type == UserType.Pemium);
           //var premUserBank = banks.Max(x => premUser.Max(y=>y.Bank.Name));
           //var premUserBankTransaction = banks.Where(x => x.Name == premUserBank);

            var premUserBank =
               (from premUser in users.Where(us => us.Type == UserType.Pemium)
                from bank in banks.Where(bnk => bnk.Name == premUser.Bank.Name)
                orderby bank.Name.Count() descending
                select bank.Name).FirstOrDefault();

            var premUserBankTransaction =
                from bank in banks
                where bank.Name == premUserBank
                select bank.Transactions;

            foreach (var premsUserBankTransaction in premUserBankTransaction)
            {
                Console.WriteLine("Transactions of the premium users' favourite bank:");
                foreach (var premiumUserBankTransaction in premsUserBankTransaction) //foreach (var premiumUserBankTransaction in premsUserBankTransaction.Transactions)
                    Console.WriteLine($"Transaction: \t {premiumUserBankTransaction.Value}");
            }

            Console.WriteLine(users);
            //1) Сделать выборку всех Пользователей, имя + фамилия которых длиннее чем 12 символов.

            //2) Сделать выборку всех транзакций (в результате должен получится список из 1000 транзакций)

            //3) Вывести Банк: и всех его пользователей (Имя + фамилия + количество транзакий в гривне) отсортированных по Фамилии по убиванию. в таком виде :
            //   Имя банка 
            //   ***************
            //   Игорь Сердюк 
            //   Николай Басков

            //4) Сделать выборку всех Пользователей типа Admin, у которых счет в банке, в котором больше всего транзакций

            //5) Найти Пользователей(НЕ АДМИНОВ), которые произвели больше всего транзакций в определенной из валют (UAH,USD,EUR) 
            //то есть найти трёх пользователей: 1й который произвел больше всего транзакций в гривне, второй пользователь, который произвел больше всего транзакций в USD 
            //и третьего в EUR

            //6) Сделать выборку транзакций банка, у которого больше всего Pemium пользователей



        }

        public class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<Transaction> Transactions { get; set; }
            public UserType Type { get; set; }
            public Bank Bank { get; set; }
        }

        public class Transaction
        {
            public decimal Value { get; set; }

            public Currency Currency { get; set; }
        }

        public static List<Transaction> GetTenTransactions()
        {
            var result = new List<Transaction>();
            var sign = random.Next(0, 1);
            var signValue = sign == 0 ? -1 : 1;
            for (var i = 0; i < 10; i++)
            {
                result.Add(new Transaction
                {
                    Value = (decimal)random.NextDouble() * signValue * 100m,
                    Currency = GetRandomCurrency(),
                });
            }

            return result;
        }

        public class Bank
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public List<Transaction> Transactions { get; set; }
        }

        public enum UserType
        {
            Default = 1,
            Pemium = 2,
            Admin = 3
        }

        public static UserType GetRandomUserType()
        {
            int userTypeInt = random.Next(1, 4);

            return (UserType)userTypeInt;
        }

        public enum Currency
        {
            USD = 1,
            UAH = 2,
            EUR = 3
        }

        public static Currency GetRandomCurrency()
        {
            int userTypeInt = random.Next(1, 4);

            return (Currency)userTypeInt;
        }

        public static List<Bank> GenerateBanks()
        {
            var banksCount = random.Next(BANKS_MIN, BANKS_MAX);
            var result = new List<Bank>();

            for (int i = 0; i < banksCount; i++)
            {
                result.Add(new Bank
                {
                    Id = i + 1,
                    Name = RandomString(random.Next(NAME_MIN_LENGTH, NAME_MAX_LENGTH)),
                    Transactions = new List<Transaction>()
                });
            }

            return result;
        }

        public static List<User> GenerateUsers(List<Bank> banks)
        {
            var result = new List<User>();
            int bankId = 0;
            Bank bank = null;
            List<Transaction> transactions = null;
            for (int i = 0; i < 100; i++)
            {
                bankId = random.Next(0, banks.Count);
                bank = banks[bankId];
                transactions = GetTenTransactions();
                result.Add(new User
                {
                    Bank = bank,
                    FirstName = RandomString(random.Next(NAME_MIN_LENGTH, NAME_MAX_LENGTH)),
                    Id = i + 1,
                    LastName = RandomString(random.Next(NAME_MIN_LENGTH, NAME_MAX_LENGTH)),
                    Type = GetRandomUserType(),
                    Transactions = transactions
                });
                bank.Transactions.AddRange(transactions);
            }

            return result;
        }

        private const int BANKS_MIN = 2;
        private const int BANKS_MAX = 5;

        private const int NAME_MAX_LENGTH = 10;
        private const int NAME_MIN_LENGTH = 4;

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
