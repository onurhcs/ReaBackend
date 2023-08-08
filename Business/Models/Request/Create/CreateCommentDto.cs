using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateCommentDto
    {
        public string CommentHeader { get; set; } = default!;

        public int User_Id { get; set; }
        public string CommentText { get; set; } = default!;
        public int StarRating { get; set; } = default!;
        public int Taste { get; set; }
        public int Follower { get; set; }


    }
}
