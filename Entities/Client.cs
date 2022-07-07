using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s9exep.Entities
{
    internal class Client
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DataDeAniversario { get; set; }

        public Client(string nome, string email, DateTime dataDeAniversario)
        {
            Nome = nome;
            Email = email;
            DataDeAniversario = dataDeAniversario;
        }
        public override string ToString()
        {
            return Nome
                + ", ("
                + DataDeAniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
