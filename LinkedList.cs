using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsList.Logic
{
    public class Linkedlist<T>
    {
        private Node<T> _first;
        private Node<T> _last;


        public Linkedlist()
        {
            _first = null;
            _last = null;
            Count = 0;

        }
        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $" - {pointer.Date}\n";
                pointer = pointer.Next;
            }
            return output;
        }

        public void Add(T item)
        {
            var node = new Node<T>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Previous = _last;
                _last!.Next = node;
                _last = node;
            }
            Count++;
        }
        public Linkedlist<Cars> GetBrand(string brand)
        {
            var ListBrand = new Linkedlist<Cars>();
            var pointer = _first;
            while (pointer != null)
            {
                Cars cars = (Cars)Convert.ChangeType(pointer.Date, typeof(Cars))!;
               
                if (cars!.Brand!.Equals(brand))
                {

                    ListBrand.Add(cars);

                }
                
                pointer = pointer.Next;
            }
            return ListBrand;
        }

        public Linkedlist<Cars> GetYear(int lower, int upper)
        {
            var Year = new Linkedlist<Cars>();
            var pointer = _first;
            while (pointer != null)
            {
                Cars cars = (Cars)Convert.ChangeType(pointer.Date, typeof(Cars));

                if (cars.Year > lower && cars.Year <= upper)
                {
                    Year.Add(cars);
                }
                pointer = pointer.Next;
            }
            return Year;
        }

        public Linkedlist<Cars> GetPrice(decimal min, decimal max)
        {
            var Price = new Linkedlist<Cars>();

            var pointer = _first;

            while (pointer != null)
            {
                Cars cars = (Cars)Convert.ChangeType(pointer.Date, typeof(Cars))!;
                if (cars.Price > min && cars.Price <= max)
                {
                    
                    Price.Add(cars);
                }

                pointer = pointer.Next;
            }
            return Price;
        }
        public Cars[] GetMinMaxPrice(Linkedlist<Cars> list)
        {
            var MinMax = new Cars[2];

            var count = _first;

            Cars min = (Cars)Convert.ChangeType(count!.Date, typeof(Cars));

            Cars max = (Cars)Convert.ChangeType(count.Date, typeof(Cars));

            count = count.Next;
            while (count != null)
            {
                Cars cars = (Cars)Convert.ChangeType(count.Date, typeof(Cars))!;
                if (cars.Price > max.Price)
                {
                    max = cars;
                }
                else if (cars.Price < min.Price)
                {
                    min = cars;
                }
                count = count.Next;
            }
            MinMax[0] = min;
            MinMax[1] = max;
            return MinMax;
        }



    }
}
