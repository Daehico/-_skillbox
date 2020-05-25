using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterEnity
{
    class Users
    {
        public Users()
        {
            this.Tweet = new List<Tweets>();
            this.Username = new List<Subscriber>();
        }

        public int Id { get; set; }

       [Required]
       [MaxLength(50)]
       public string UserName { get; set; }

        public IList<Tweets> Tweet { get; set; }

        public IList<Subscriber> Username { get; set; }

        public IList<Subscriber> Subscribers { get; set; }
    }
}
