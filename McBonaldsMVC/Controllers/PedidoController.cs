using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidosController : Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository ();
        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();

            return View();
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            pedido.Shake = shake;
            shake.Nome = form["shake"];
            shake.Preco = 0.0;

            Hamburguer hamburguer = new Hamburguer();
            pedido.Hamburguer = hamburguer;
            hamburguer.Nome = form["hamburguer"];
            hamburguer.Preco = 0.0;


            // pedido.Shake = shake;
            
            // Shake shake = new Shake();
            // Hamburguer hamburguer = new Hamburguer(form["hamburguer"]);
            
            Cliente cliente = new Cliente();
                cliente.Nome = form["nome"];
                cliente.Endereco = form["endereco"];
                cliente.Telefone = form["telefone"];
                cliente.Email = form["email"];
            
            pedido.cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.Precototal = 0.0;

            if(pedidoRepository.Inserir(pedido)){
                return View("sucesso");

            } else {
                return View("Erro");
            }

        }
    }
}
