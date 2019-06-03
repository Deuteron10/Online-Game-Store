using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_Game_Store.Models;

namespace Online_Game_Store.ViewModels
{
    public class RandomGameViewModel
    {
        public Game Game { get; set; }
        public List<Customer> Customers { get; set; }
    }
}