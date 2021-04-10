using System;
using System.Threading;
using System.IO;

namespace String_last_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Данные считаны из файла Inlet.in]");
            Str_file();
            Thread.Sleep(1500);
            Console.WriteLine("[Данные записаны в файл Outlet.out]");
            Console.ReadKey();

        }



        static void Str_file()
        {
            string[] text;
            string res = null;
            using (StreamReader streamreader = new StreamReader("Inlet.in"))
            {
                text = streamreader.ReadToEnd().Trim().Split(' ','\r');
            }
          
            
            for (int i = 0; i < text.Length; i++)
            {
                char[] array = text[i].ToCharArray();
                for (int j = 0; j <= array.Length-2; j++)
                {
                    if (array[j] == array[array.Length-1])
                    {
                        array[j] = '_';
                       
                    }
                    
                   
                }
                res += new string(array) + " ";
            }
            File.WriteAllText(("Outlet.out"), res);
  
        }
    }
}
//by Alex Kotyukov