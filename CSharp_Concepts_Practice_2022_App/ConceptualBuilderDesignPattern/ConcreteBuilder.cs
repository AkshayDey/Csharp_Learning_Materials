using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualBuilderDesignPattern
{
    public class ConcreteBuilder: IBuilder
    {
        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.

        public ConcreteBuilder()
        {
            Reset();
        }

        // All production steps work with the same product instance
        public void BuildPartA()
        {
            _product.Add("PartOne");
        }

        public void BuildPartB()
        {
            _product.Add("PartTwo");
        }

        public void BuildPartC()
        {
            _product.Add("PartThree");
        }

        public void Reset()
        {
            _product = new Product();
        }

        public Product GetProduct()
        {
            Product result = _product;

            this.Reset();

            return result;
        }



    }
}
