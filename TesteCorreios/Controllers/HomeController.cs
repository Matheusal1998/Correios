using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using TesteCorreios.Models;
using System.Xml;

namespace TesteCorreios.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()

        {

            return View();
        }
        public ActionResult ResultadoBusca(string obj)
        {
            var cliente = new ServiceReference1.ServiceClient();
            ServiceReference1.sroxml xml = new ServiceReference1.sroxml();
            xml = cliente.buscaEventos("ECT", "SRO", "L", "T", "101", "OJ012070825BR");
            Objeto objeto = new Objeto();
            Evento e = new Evento();
            foreach (var item in xml.objeto)
            {
                objeto.nome = item.nome;
                objeto.categoria = item.categoria;
                objeto.numero = item.numero;
                objeto.sigla = item.sigla;

                foreach (var item1 in item.evento)
                {
                    e.cidade = item1.cidade;
                    e.codigo = item1.codigo;
                    e.Data = item1.data;
                    e.Descricao = item1.descricao;
                    e.Hora = item1.hora;
                    e.local = item1.local;
                    e.Status = item1.status;
                    e.Tipo = item1.tipo;
                    e.uf = item1.uf;


                    objeto.eventos.Add(e);
                }
            }


            ViewBag.Rastreio = e;
            ViewBag.teste = 1;
            return View(objeto);
        }

    }
}