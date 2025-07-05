using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_SoftDel_List.Models
{
    public class Vegtables
    {
      
            public int Id { get; set; }
            public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
