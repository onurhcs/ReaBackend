using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class ListUpdateDTO
    {
        public string taskName { get; set; }

        public Status status { get; set; }
    }
}
