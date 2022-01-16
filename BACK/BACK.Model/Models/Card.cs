using System;
using System.Collections.Generic;
using System.Text;

namespace BACK.Model.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Lista { get; set; }
    }
}
