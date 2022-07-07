using System;


namespace s9exep.Entities
{
    internal class Product
    {
        public string Nome { get; set; }
        public Double Preco { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
