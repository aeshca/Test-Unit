using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Включения
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            while(true)
            {
                Console.WriteLine("Введите строку:");
                string str = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите символ:");
                char ch = Convert.ToChar(Console.ReadLine());
                int coutn = p.vxod(str, ch);
                Console.WriteLine("Количество: " + coutn);
                Console.ReadKey();
            }
            
        }

        public int vxod(string str, char ch)
        {
             int coutn = str.Where(x => x == ch).Count();
             return coutn;
        }
    }
}
