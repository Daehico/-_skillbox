using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterEnity
{
    class Subscriber
    {
        public int Id { get; set; }

        public IList<Users> Username { get; set; }

        public IList <Users> Subscribers { get; set; }
    }
}
