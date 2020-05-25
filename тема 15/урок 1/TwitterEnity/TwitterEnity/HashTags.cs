using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterEnity
{
    class HashTags
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string HashTag { get; set; }
    }
}
