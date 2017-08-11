using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class WishList
    {
        public int ID { get; set; }

        public List<Movie> favItems { get; set; }
    }
}
