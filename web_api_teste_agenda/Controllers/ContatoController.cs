using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api_teste_agenda.Models;

namespace web_api_teste_agenda.Controllers
{
    public class ContatoController : ApiController
    {
        // mostrar os contatos
        [HttpGet]
        public List<Contato> MostrarContato()
        {
            return Contato.listaContatos;
        }

        // adicionar contato
        [HttpPost]
        public string AdicContato(string nome_Desejado, string telefone_Desejado)
        {
            // cria contato e joga na lista
            Contato novoContato = new Contato();
            novoContato.Nome = nome_Desejado;
            novoContato.Telefone = telefone_Desejado;
            Contato.listaContatos.Add(novoContato);

            return "Contato adicionado!";
        }

        // deletar contato
        [HttpDelete]
        public void DelContato(string nome_Procurado)
        {
            foreach(var contato in Contato.listaContatos)
            {
                if(contato.Nome == nome_Procurado)
                {
                    Contato.listaContatos.Remove(contato);
                    return;
                }                
            }
        }

        // atualizar contato
        [HttpPut]
        public void Atualizar(int id_Desejada)
        {
            foreach(var contato in Contato.listaContatos)
            {
                if (contato.Id == id_Desejada)
                {
                    //int indiceDesseContato=
                }
            }
        }
        
    }
}
