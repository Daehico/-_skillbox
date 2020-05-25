using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterEnity
{
    class Tweets
    {
        public int Id { get; set; }

        [Required]
        public string TextOfTweet { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

    }
}
