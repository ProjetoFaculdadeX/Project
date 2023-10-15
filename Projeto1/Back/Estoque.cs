using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Back
{
    public class Estoque
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Unit { get; set; }
        public string? Department { get; set; }
        public DateTime Date_Created { get; set; }
        public string? Lote {  get; set; }
        public DateTime Date_Updated { get; set;}

    }
}
