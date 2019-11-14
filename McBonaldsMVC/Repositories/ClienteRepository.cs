using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv"; //é onde ele irá gravar os dados ;) // a constate PATH deve estar em maiusculo pois é regra e se for da espaço deve-se usar "_"
        
        public ClienteRepository() //Construtor
        {
            if(File.Exists(PATH)) // Vai no arquivo e ve se ele existe
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente )                      // booleano para ver se está certo, irá inserir o PATH que sao os dados do cliente
        {
            //string registroCliente = $"{cliente.Nome, cliente.Endereco}";    //string[] dados = new string[] {cliente.Nome, cliente.Endereço}; esse nao pode
            var linha = new string[] { PrepararRegistroCSV(cliente) };         //O método vira o próprio vetor
            File.AppendAllLines(PATH, linha);
            return true;                                //Cliente c = new Cliente(); Criará outro vazio ja esse nao ele vai escrevendo os dados e no prox cliente ele pula uma linha 
        }                                                                    // colocou a string dentro do método


        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }
    }
}