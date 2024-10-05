using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using VRP.Data;
using VRP.Models;
using VRP.Data;

namespace VRP.ViewModels
{
    public class CustomerVM
    {
        public Customer? Customer { get; set; }
        public List<Customer>? Customers { get; set; }
    }
}
