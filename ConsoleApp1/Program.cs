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
            IAds ads = new ShowAdvertisement();
            List<User> usersList = new List<User>();
            usersList.Add(new User() { Login = "John_Wick", Name = "Вася", IsPremium = false });
            usersList.Add(new User() { Login = "SoulDestroyer", Name = "Константин", IsPremium = true });
            usersList.Add(new User() { Login = "PavelSmolyaninov", Name = "Павел", IsPremium = true });
            usersList.Add(new User() { Login = "Sergey78", Name = "Сергей", IsPremium = false });
            usersList.Add(new User() { Login = "Venya", Name = "Вениамин", IsPremium = true });

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
                    Console.WriteLine($"\tДобро пожаловать {user.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            Console.ReadKey();
        }
    }
}




