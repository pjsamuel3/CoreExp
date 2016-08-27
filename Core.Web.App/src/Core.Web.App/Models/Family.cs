using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Web.App.Models
{
    public class Family
    {
        public IEnumerable<Administrator> Administrators { get; set; }
        public IEnumerable<Contributer> Contributers { get; set; }
        public IEnumerable<Earner> Earners { get; set; }
    }
}
