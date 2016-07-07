using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedEdge.Common.Models
{
    public class PersonInfo
    {
        public int PersonInfoId { get; set; }
        public string Title { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
