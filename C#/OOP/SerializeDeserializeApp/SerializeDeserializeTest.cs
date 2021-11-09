using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializeDeserializeApp.Model
{
    class SerializeDeserializeTest
    {

        static void Main(string[] args)
        {
            Account anotherAcc = DeserializeObject();
            Console.WriteLine(">>>Deserialization Complete");
            PrintDetails(anotherAcc);

            Account acc = new Account("Sohel");
            PrintDetails(acc);

            acc.Deposit(1000);
            PrintDetails(acc);

            SerializeObject(acc);
            Console.WriteLine(">>>Serialization Complete");

            Account anotherAcc1 = DeserializeObject();
            Console.WriteLine(">>>Deserialization Complete");
            PrintDetails(anotherAcc1);
        }
        public static void SerializeObject(Account account)
        {

            FileStream stream = new FileStream("d:\\Test.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, account);
            stream.Close();
        }
        public static Account DeserializeObject()
        {

            FileStream stream = new FileStream("d:\\Test.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Account account = (Account)formatter.Deserialize(stream);
            stream.Close();
            return account;
        }

        private static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Number :{0}\nName :{1}\nBalance :{2}\n"
                , account.AccountNo, account.Owner, account.Balance);
        }

    }
}
