using System.Collections.Generic;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfWeek { get; set; }
    }
}