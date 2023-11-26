using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Back
{
    public class Department
    {
        public int? IdDepartment { get; set; }
        public string? Name { get; set; }
        public string? access { get; set; }
        public string? nivel {  get; set; }   

        public virtual ICollection<Estoque>? estoque { get;}

    }
}
