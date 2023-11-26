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
        public int? Unit { get; set; }
        public int? IdDepartment { get; set; }
        public DateTime Date_Created { get; set; }
        public string? Lote {  get; set; }
        public DateTime Date_Updated { get; set;}

        public virtual Department? Department { get; set; }  

        public virtual ICollection<Solicitacao>? Solicitacao { get; set; }
    }
}
