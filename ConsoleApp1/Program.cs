using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<User> usersList = new List<User>();
            //usersList.Add(new User() { Login = "John_Wick", Name = "Вася", IsPremium = false });
            //usersList.Add(new User() { Login = "SoulDestroyer", Name = "Константин", IsPremium = true });
            //usersList.Add(new User() { Login = "PavelSmolyaninov", Name = "Павел", IsPremium = true });
            //usersList.Add(new User() { Login = "Sergey78", Name = "Сергей", IsPremium = false });
            //usersList.Add(new User() { Login = "Venya", Name = "Вениамин", IsPremium = true });
            ///
            ///но так быстрее:
            ///
            List<User> usersList = new List<User>()
            {
                new User() { Login = "John_Wick", Name = "Вася", IsPremium = false },
                new User() { Login = "SoulDestroyer", Name = "Константин", IsPremium = true },
                new User() { Login = "PavelSmolyaninov", Name = "Павел", IsPremium = true },
                new User() { Login = "Sergey78", Name = "Сергей", IsPremium = false },
                new User() { Login = "Venya", Name = "Вениамин", IsPremium = true },
            };

            SomeAction(usersList);

            Console.ReadKey();
        }
        static void SomeAction(List<User> usersList)
        {
            IAds ads = new ShowAdvertisement();
            foreach (User user in usersList)
            {
                if (user.IsPremium == false)
                {
                    Console.WriteLine($"Ну, привет, {user.Name},  {user.Login}. Не желаешь немного рекламы:");
                    ads.ShowAds();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\tДобро пожаловать, {user.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }
    }
}




