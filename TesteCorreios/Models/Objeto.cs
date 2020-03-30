using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteCorreios.Models
{
    public class Objeto
    {
        
        public string numero { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }

        public virtual List<Evento> eventos { get; set; }
    }
}