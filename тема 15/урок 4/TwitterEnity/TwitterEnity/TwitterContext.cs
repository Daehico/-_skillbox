using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterEnity
{
    class TwitterContext: DbContext
    {
        public TwitterContext()
            : base(@"Data Source=DESKTOP-7LNKM4H\SQLEXPRESS;Initial Catalog=TwitterContext;Integrated Security=True")
        {

        }

        public DbSet<Tweets> Tweet { get; set; }
        public DbSet<HashTags> HashTag { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Trends> Trend { get; set; }
    }
}
