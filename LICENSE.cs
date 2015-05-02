using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в справочник! Введите с клавиатуры:\n1 - чтобы добавить контакт\n2 - чтобы удалить контакт\n3 - чтобы показать все контакты\n4 - чтобы показать количество контактов\n5 - выйти из программы");

            Collection<string> NewContact = new Collection<string>();
            NewContact.Add("contact");
            NewContact.Remove("contact");

            int ans = Convert.ToInt32(Console.ReadLine());


            switch (ans)
            {
                case 1:
                    {
                        
                        Console.Write("Введите имя контакта...   ");
                        string contact = Console.ReadLine();
                        Console.WriteLine("Вы только что добавили  " + (contact) + "  в список контактов");
                        Console.ReadLine();
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Вы удаляете контакт из списка");
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }
    }
}
