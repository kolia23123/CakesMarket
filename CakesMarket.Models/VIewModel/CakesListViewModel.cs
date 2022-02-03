using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CakesMarket.Models.ViewModel
{
    public class CakesListViewModel
    {
        public IEnumerable<CakeViewModel> Cakes { get; set; }

        public CakesListViewModel()
        {
            this.Cakes = Enumerable.Empty<CakeViewModel>();
        }
    }
}
