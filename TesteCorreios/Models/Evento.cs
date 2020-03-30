using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteCorreios.Models
{
    public class Evento
    {
        public string Tipo { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Descricao { get; set; }
        public string local { get; set; }
        public string codigo { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
    }
}