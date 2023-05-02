using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<int> Naplnlist()
        {
            List<int> temp = new List<int>();

            while (true)
            {
                string vstup = Console.ReadLine();
                if (vstup == "n") 
                {
                    break;
                }

                temp.Add(int.Parse(vstup));
            }
            return temp;
        }


        static void VypisList(List<int> cisla)
        {
            //tmp = cisla;
            for (int i = 0; i < cisla.Count; i++)
            {

                Console.WriteLine(Convert.ToInt32(cisla[i]));
            }
        }

        static void Main(string[] args)
        {
            List<int> cisla = new List<int>();
            cisla = Naplnlist();
            VypisList(cisla);
        }
    }
}



//ahoooooooj tadz je fila skole je super