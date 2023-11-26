using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Back
{
    public class Users
    {
        public int IdUser { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int IdDepartment { get; set; }
        public DateTime DataCreat { get; set; }
        public DateTime DataModified { get; set; }
        public string? ativo { get; set; }
        public int? Passworderror { get; set; }              
        
    }
}
