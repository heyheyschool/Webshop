using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class WishListViewModel
    {
        public List<Movie> favItems;
        public SelectList items;

        public WishListViewModel()
    {
            favItems = new List<Movie>();
    }

    }
}


