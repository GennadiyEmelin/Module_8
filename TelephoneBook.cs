using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program2
{
    public void Work2()
    {
        #region Work 2
        Dictionary<string, string> phone = new Dictionary<string, string>();

        string? phoneNumber = Console.ReadLine();
        string? fio = Console.ReadLine();

        phone.Add(phoneNumber, fio);
        
        while(true)
        {
            if(phoneNumber != null ) 
            {
                phoneNumber = Console.ReadLine();
                if (phoneNumber == null)
                {
                    break;
                }
                fio = Console.ReadLine();
                phone.Add(phoneNumber, fio);
            }
            else
            {
                break;
            }
        }

        foreach (KeyValuePair<string, string> pair in phone)
        {
            Console.WriteLine("Номер телефона: " + pair.Key + "ФИО" + pair.Value);
        }
        #endregion
    }
}
