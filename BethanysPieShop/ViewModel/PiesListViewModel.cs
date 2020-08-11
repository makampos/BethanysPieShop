using System.Collections.Generic;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModel
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}