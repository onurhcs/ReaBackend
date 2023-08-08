using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Comment : Entity<int>
    {
        public string CommentHeader { get; set; }
        public int User_Id { get; set; }

        public string CommentText { get; set; }
        public int StarRating { get; set; }
        public int Taste { get; set; }
        public int Follower { get; set; }

        public User User { get; set; }
    }
}
