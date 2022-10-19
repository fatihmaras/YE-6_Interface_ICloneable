using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5_Interface_ICloneable
{
            public class Book : ICloneable
        {
            public int Id { get; set; }
            public string Title { get; set; }

            public double Price { get; set; }


            //  2 tür clone vardır
            //1.  deep copy  --- yeni bir kitap nesnesi oluşturmak lazım 
            //2.  shallow copy
            public object Clone()
            {
                return this.MemberwiseClone();

                /*

              // Deep copy option 1

                 public object Clone()
            {
                return new Book()
              {
                  Id = this.Id,
                  Title = this.Title,
                  Price = this.Price,
              };
            }


             // Deep copy option 2

             public object Clone()
            {
              var book = new Book();
              book.Id = this.Id;
              book.Title = this.Title;
              book.Price = this.Price;
              return book;
             }
              */
            }
        }
    }

