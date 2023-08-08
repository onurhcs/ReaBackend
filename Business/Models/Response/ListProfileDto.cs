using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class ListProfileDto
    {
        public int Id { get; set; } = default!;

        public string taskName { get; set; }

        public Status status { get; set; }
    }
}
