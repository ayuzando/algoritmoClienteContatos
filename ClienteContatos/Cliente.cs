using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClienteContatos
{
    class Cliente
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public DateTime dataNascCliente { get; set; }
        public List<Contato> ListaContatos;

        public Cliente()
        {
            ListaContatos = new List<Contato>();
        }

        /// <summary>
        /// Método para adicionar contato na lista ListaContatos 
        /// <para>O primeiro passo é verificar se a lista está vazia e se estiver, 
        /// adiciono o contato na lista. Caso o contato tenha a regra violada 
        /// (número de telefone e tipo de relacionamento iguais). </para>
        /// <para>Caso seja adicionado, ele é ordenado por ordem crescente na lista</para>
        /// </summary>
        /// <param name="contato"></param>
        public void AdicionaContato(Contato contato)
        {

            if (ListaContatos.Count == 0)
            {
                ListaContatos.Add(contato);
                return;
            }

            if (IsContatoInvalido(contato))
            {
                throw new Exception("Contato inválido!");   
            }
            ListaContatos.Add(contato);
            ListaContatos = ListaContatos.OrderBy(i => i.CodigoContato).ToList();
        }

        /// <summary>
        /// Método para fazer a validação do contato fazendo as comparações de telefone e tipo de relação
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        private bool IsContatoInvalido(Contato contato)
        {
            foreach (Contato item in ListaContatos)
            {
                if (item.Telefone == contato.Telefone && item.TipoRelacao == contato.TipoRelacao)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
