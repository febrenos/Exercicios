using System;
using System.Collections.Generic;
using System.IO;

namespace Todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todoList = new List<TodoItem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName; // =\t "dá um tab"    \s" da um br (pula a linha)"    \n pula a linha    \\"indica que vai vir um texto"   \palavra\ "serve para ajudar o cs a achar as aspas"

            try{
                string[] todoFile = File.ReadAllLines(filePath);
                
                foreach(var line in todoFile)
                {
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"", "");
                    string nota = itens[1].Replace("\"", "");

                    TodoItem todoItem = new TodoItem(titulo, nota);
                    todoList.Add(todoItem);
                }

            } catch (IOException ioe) {
                System.Console.WriteLine("Erro ao acessar o arquivo");
                System.Console.WriteLine(ioe.Message);
            }
            int opcao = 0;
            do{
                Console.Clear();
                System.Console.WriteLine("TODO LIST");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine("Digite uma opcao:");
                System.Console.WriteLine("1 - Adicionar Item");
                System.Console.WriteLine("2 - remover Item");
                System.Console.WriteLine("3 - Sair do programa");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                    AddItem(todoList);
                        break;
                    case 2:
                    RemoveItem(todoList);
                        break;
                    case 3:
                        System.Console.WriteLine("Tchau!");
                        Saveitem (todoList ,filePath);
                        break;
                    default:
                        System.Console.WriteLine("opcao inválida");
                        Console.ReadLine();
                        break;
                }

            } while(opcao != 3);
        }
        public static void ListaItens(List<TodoItem> todoList)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Todo list");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2}Título{"",12} Notas");
            foreach (TodoItem item in todoList);
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count ++;
            }
        }

        public static void AddItem(List<TodoItem> todolist)
        {
            Console.Clear();
            System.Console.WriteLine("Novo Item: ");
            System.Console.WriteLine();
            System.Console.WriteLine("Título: ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo, nota);

            todolist.Add(item);
        }

        public static void RemoveItem(List<TodoItem> todoList)
        {
            int index = 0;
            do{
                Console.Clear();
                System.Console.WriteLine("Remove item");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o ID ou x para terminar");
                System.Console.Write("ID:");
                string id = Console.ReadLine();

                if (id.ToLower() == "x")
                {
                    break;
                }
                else {
                    index = int.Parse(id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1))
                {
                    System.Console.WriteLine("ID Inválido");
                    System.Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                } else{
                    todoList.RemoveAt(index);
                }

            } while(true);

        static void SaveItem(List<TodoItem> lista, string filePath)
        { 
            List<string> linhas = new List<string>();
            linhas.Add("tile,note");
            foreach(TodoItem item in lista){
        }
            string titulo = "\"" + AddItem.Title + "\"";
            string nota = "\"" + AddItem.Note + "\"";
            linhas.Add(titulo + "," + nota){
        }
        string tryAgain = "";
        {
        do
        {
            try
            {
                File.WriteAllLines(filePath, linhas);
            }
            catch (IOxcepition e)
            {
                Console.WriteLine("Erro na gravação do arquivo.");
                Console.WriteLine(e.Messege);
                do
                {
                    Console.WriteLine("Deseja tentar novamente (S/N)?")
                    tryAgain = Console.ReadLine().Tolower();

                }  While (tryAgain == "s" || tryAgain == "n");
            }
        } While (tryAgain !="n");
    }
}
