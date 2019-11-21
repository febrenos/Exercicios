using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository()
        {
            if (!File.Exists(PATH)){
                File.Create(PATH).Close();

            }
        }
        public bool Inserir(Pedido pedido)
        {
            var linha = new string[] {PrepararPedidosCSV(pedido)};
            File.AppendAllLines(PATH, linha);

            return true;
        }
        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach(var pedido in pedidos)
            {
                if(pedido.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }
        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();
                pedido.Cliente = new Cliente(); // para tirara o valor nulo do cliente
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_endereco", linha);
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_nome", linha));
                pedido.Shake.Nome = ExtrairValorDoCampo("shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_nome", linha));
                pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("shake_nome", linha));
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("shake_nome", linha));

                pedidos.Add(pedido);
            }
            return pedidos;

        }
        private string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave); //IndexOf serve para
            var indiceTerminal = linha.IndexOf(";" , indiceChave);
            var valor = "";

            if(indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"campo{nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }

        private string PrepararPedidosCSV(Pedido pedido)
        {
            Cliente c = pedido.Cliente;      //c = cliente
            Hamburguer h = pedido.Hamburguer;//h = hamburguer
            Shake s = pedido.Shake;          //s = shake

            return $"cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome+{h.Nome};hamburguer_precp={h.Preco};shake_nome{s.Nome};shake_preco={s.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}"; 
        }
    }
}