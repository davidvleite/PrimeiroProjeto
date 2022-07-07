using System;
using System.Globalization;


namespace s9exep.Entities
{
    internal class OrderItem
    {

        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Product Produto { get; set; }
        public OrderItem(int quantidade, double preco, Product product)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = product;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
