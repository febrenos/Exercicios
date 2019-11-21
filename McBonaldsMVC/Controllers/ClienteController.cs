using System;
using McBonaldsMVC.Repositories;
using MCBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace McBonaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository clienterepository = new ClienteRepository();
        private PedidoCliente pedidosCliente = new ClienteRepository();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form) //armazena informaçoes
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("========================");
                System.Console.WriteLine(form ["email"]);
                System.Console.WriteLine(form ["senha"]);
                System.Console.WriteLine("========================");

                var usuario = form["email"];
                var senha = form["senha"];
                var cliente = clienterepository.ObterPor(usuario);

                if(cliente != null) //se for diferente de null, nulo
                {
                    if(cliente.Senha.Equals(senha)) //se a senha é igual a anterior
                    {
                        HttpContext.Session.SetString("SESSION_CLIENTE_EMAIL",usuario);
                        return RedirectToAction("Historico","Cliente");
                    }
                    else // o usuário errou a senha vem pra ca
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado")); // na virgula mostra um novo parametro... coloquei la em cima pq tava errado
                }
                return View("sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View ("Error");
            }
        }

        public IActionResult Historico()
        {
            var emailCliente = HttpContext.Session.GetString("SESSION_CLIENTE_EMAIL");
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                PedidosController = pedidosCliente
            });
        }
    }
}