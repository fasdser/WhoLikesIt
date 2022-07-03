using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoLikesIt
{
    internal class Program
    {

        // You probably know the "like" system from Facebook and other pages.People can "like" blog posts, pictures or other items.
        // We want to create the text that should be displayed next to such an item.
        // Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

        // Вы, вероятно, знаете систему «лайков» на Facebook и других страницах. Люди могут «лайкать» сообщения в блогах, изображения или другие элементы.
        // Мы хотим создать текст, который должен отображаться рядом с таким элементом.
        // Реализовать функцию, которая принимает массив, содержащий имена людей, которым понравился элемент.
        // Он должен возвращать отображаемый текст, как показано в примерах:

        //[]                                -->  "no one likes this"
        //["Peter"]                         -->  "Peter likes this"
        //["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
        //["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
        //["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
        //Note: For 4 or more names, the number in "and 2 others" simply increases.
        static void Main(string[] args)
        {
            string[] array = new string[34] {"Peter", "Pop","Pig","Pier","P1", "P2", "P3", "P4", "asd", "asdasd", "asdasd", "Piaser", "fghfgh", "Powerwep", "sdafasf", "hfghfgh", "qweqwe", "gdfgdfg", "hfghfg", "asdfsd", "asdasdq", "asdqwe", "hfghfgh", "qweqwe", "qwe", "ew", "Pittg", "Pitttter", "qwer1", "rqwe1", "qwe2", "rewr3", "qwe333", "rewr3333" };
            Likes(array);
            Console.WriteLine(Likes(array));
            Console.ReadKey();
        }

        public static string Likes(string[] name)
        {
           
           

            if (name.Length == 0)
            {                 
                return "no one likes this";

            }
            else if (name.Length == 1)
            {
                 
                return $"{name[0]} likes this"; 
            }
            else if (name.Length == 2)
            {                
                return $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {                
                return $"{name[0]},{name[1]} and {name[2]} like this";
            }
            else 
            {               
                {
                    return $"{name[0]},{name[1]} and {name.Length - 2} others like this";
                }
            }
                
            
           
        }

        //public static string Likes(string[] name)
        //{
        //    switch (name.Length)
        //    {
        //        case 0: return "no one likes this";
        //        case 1: return $"{name[0]} likes this";
        //        case 2: return $"{name[0]} and {name[1]} like this";
        //        case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
        //        default:
        //            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        //    }
        //}
    }
}
