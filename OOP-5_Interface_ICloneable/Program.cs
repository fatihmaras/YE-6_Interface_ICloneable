using OOP_5_Interface_ICloneable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5_Interface_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var book1 = new Book()
            {
                Id = 1,
                Title = "Suç ve Ceza",
                Price = 25.5,
            };

            var book2 = (Book)book1.Clone();    // Clone methdou bir object döner , o yüzden Book'a dönüşüm yaptık.
            book2.Title = "Sefiller";
            book2.Id = 2;

            Console.WriteLine(book1.Id + " " + book1.Title);
            Console.WriteLine(book2.Id + " " + book2.Title);

            Console.ReadLine();
        }
    }
}






