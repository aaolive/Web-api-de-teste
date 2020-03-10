using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api_teste_agenda.Models
{
    public class Contato
    {
        //propiedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        // variavel para lista de contato inicializada
        public static List<Contato> listaContatos = new List<Contato>()
        {
            new Contato
            {
                Id = 1, Nome="Anderson",Telefone="33658998"
            },
            new Contato
            {
                Id = 2, Nome="Andrei", Telefone="556553333"
            }
        };
    }
}