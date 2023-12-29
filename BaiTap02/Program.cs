using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class BaiTap02
    {
        static void Main(string[] args)
        {
            Account my = new Account("65111", "NKM", 1200);

            Console.Write("Enter ID:");
            string id = Console.ReadLine();

            Console.Write("Enter Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Bal:");
            int balance = int.Parse(Console.ReadLine());

            Account yours = new Account(id, name, balance);

            Console.WriteLine("Thong tin tai khoan:");
            Console.WriteLine("My account:[ ID:{0}, Name:{1}, Balance:{2}]", my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My account:[ ID:{0}, Name:{1}, Balance:{2}]", yours.getId(), yours.getName(), yours.getBalance());

            my.debit(700);
            my.transferTo(yours, 200);
            Console.WriteLine("=====Thong tin tai khoan sau khi giao dich=====");
            Console.WriteLine("My account:[ ID:{0}, Name:{1}, Balance:{2}]", my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My account:[ ID:{0}, Name:{1}, Balance:{2}]", yours.getId(), yours.getName(), yours.getBalance());
            Console.ReadLine();



        }
    }
}
