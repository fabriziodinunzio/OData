using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleItemOrder lista1 = new MultipleItemOrder();
            IOrder itemLista11 = new ItemOrder(50, "Item1");
            IOrder itemLista12 = new ItemOrder(100, "Item2");
            lista1.Add(itemLista11);
            lista1.Add(itemLista12);


            MultipleItemOrder lista2 = new MultipleItemOrder();
            IOrder itemLista21 = new ItemOrder(100, "Item21");
            IOrder itemLista22 = new ItemOrder(200, "Item22");
            lista2.Add(itemLista21);
            lista2.Add(itemLista22);

            MultipleItemOrder listaTotale = new MultipleItemOrder();
            listaTotale.Add(lista1);
            listaTotale.Add(lista2);

            Console.WriteLine("{0}", listaTotale.Price);
            Console.WriteLine("{0}", listaTotale.Description);
            Console.ReadLine();

        }
    }

    public interface IOrder
    {
        int Price { get;}
        string Description { get;}
    }

    public class ItemOrder : IOrder
    {
        public int Price { get; }

        public string Description { get; }

        public ItemOrder(int price, string description)
        {
            Price = price;
            Description = description;
        }
    }

    public class MultipleItemOrder : IOrder 
    {
        private List<IOrder> orders = new List<IOrder>();

        public int Price
        { 
            get
            {
                return orders.Sum(o => o.Price);
            }
        }

        public string Description 
        { 
            get
            {
                return string.Join("\n", orders.ConvertAll(order => order.Description));
            }
        }

        public void Add(IOrder order)
        {
            orders.Add(order);
        }

    }
}
