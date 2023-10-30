

using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

Game Wow = new Game();
Wow.name = "World of Warcraf";
Wow.data = 2004;
Wow.janr = "MMORPG";



ConsoleKeyInfo key;
do
{
    string txt = "Wolrd of Warcraft \n 2004 \n MMPRPG";
    File.WriteAllText("D:\\Рабочий стол\\Игры.txt" , txt);
    key= Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
    {
        break;
    }
    
    



    
        
        
    



    Console.WriteLine("Введите путь до  файла (вместе с именем)");
    Console.WriteLine("_________________________________________");
     string name = Console.ReadLine();
    if (name.EndsWith(".txt"))
    {
        Console.Clear();
        Console.WriteLine("Сохранить в одном из 3 форматов - F1. Закрыть программу Ecsape");
        Console.WriteLine("________________________________________________________________");
        string text = File.ReadAllText("D:\\Рабочий стол\\Игры.txt");
        Console.Write(text);
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            Console.Clear();
           
            break;
        }

        if (key.Key == ConsoleKey.F1)
        {
            Console.Clear();
            Console.WriteLine("Введите путь до  файла (вместе с именем) куда вы хотите сохранить текст");
            string name_2 = Console.ReadLine();
            if (name_2.EndsWith(".json"))
            {
                string json = JsonConvert.SerializeObject(Wow);
                File.WriteAllText("D:\\Рабочий стол\\Игры.json", json);
                Console.Clear();




            }
            else if (name_2.EndsWith(".xml"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Game));
                using (FileStream sr = new FileStream("D:\\Рабочий стол\\Игры.xml", FileMode.OpenOrCreate))
                {   
                    xml.Serialize(sr, Wow);
                    Console.Clear();
                }

            }
        }

    }
    else if (name.EndsWith(".json"))
    {
        Console.Clear();
        Console.WriteLine("Сохранить в одном из 3 форматов - F1. Закрыть программу Ecsape");
        Console.WriteLine("________________________________________________________________");
        string text = File.ReadAllText("D:\\Рабочий стол\\Игры.json");
        
        Console.WriteLine(text);
        
        
        
        
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        { 
            Console.Clear(); 
            break;
        }
        if (key.Key == ConsoleKey.F1)
        {
            Console.Clear();
            Console.WriteLine("Введите путь до  файла (вместе с именем) куда вы хотите сохранить текст");
            string name_2 = Console.ReadLine();
            if (name_2.EndsWith(".xml"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Game));
                using (FileStream sr = new FileStream("D:\\Рабочий стол\\Игры.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(sr, Wow);
                    Console.Clear();
                }


            }
            else if (name_2.EndsWith(".txt"))
            {
               string text_dva = Convert.ToString(Wow);
               File.WriteAllText("D:\\Рабочий стол\\Игры.txt", text_dva);


            }
        }
    }
    else if (name.EndsWith(".xml"))
    {
        
        
            Console.Clear();
            Console.WriteLine("Сохранить в одном из 3 форматов - F1. Закрыть программу Ecsape");
            Console.WriteLine("________________________________________________________________");
            string text = File.ReadAllText("D:\\Рабочий стол\\Игры.xml");

            Console.Write(text);
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
        if (key.Key == ConsoleKey.F1)
        {
            Console.Clear();
            Console.WriteLine("Введите путь до  файла (вместе с именем) куда вы хотите сохранить текст");
            string name_2 = Console.ReadLine();
            if (name_2.EndsWith(".json"))
            {
                string json = JsonConvert.SerializeObject(Wow);
                File.WriteAllText("D:\\Рабочий стол\\Игры.json", json);
                Console.Clear();


            }
            else if (name_2.EndsWith(".txt"))
            {
                string text_dva = Convert.ToString(Wow);
                File.WriteAllText("D:\\Рабочий стол\\Игры.txt", text_dva);


            }

        }
    }        
        
} while (key.Key == ConsoleKey.Escape);