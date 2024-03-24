using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        #region Work 1

        List<int> list = new List<int>();
        var rand = new Random();
        for (int i = 0; i < 100; i++)
        {
            list.Add(rand.Next(0, 100));
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.ReadLine();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 25 & list[i] < 50)
            {
                list.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        #endregion
    }
}

