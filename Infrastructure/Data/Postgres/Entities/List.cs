using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class List :Entity<int>
    {
        public string taskName { get; set; }

        public Status status { get; set; }
    }
}

public enum Status
{
    Created,
    Complated,
    Deleted,
}
