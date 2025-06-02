using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithEmployees.Models
{
    public interface Irole
    {
        void AddRoles(params string[] roles);
        string GetRoles();
    }
}
