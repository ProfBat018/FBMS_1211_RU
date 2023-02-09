using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodWPF
{
    public class Drink : IProduct
    {
        public string? Name { get; set; }
        public float Price { get; set; }
        public float Volume { get; set; }

        public string Show()
        {
            return $"Name: {Name} Price: {Price}";
        }

        public override string ToString()
        {
            return Show();
        }
    }

    public class Snacks : IProduct
    {
        public string? Name { get; set; }
        public float Price { get; set; }
        public float Weight{ get; set; }
        public string Show()
        {
            throw new NotImplementedException();
        }
    }


    public interface IProduct
    {
        public string? Name { get; set; }
        public float Price { get; set; }

        public string Show();
    }
}
