using marinin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marinin2.ViewModels
{
    public class CustomerWindowViewModel : ViewModel
    {
        private List<Customer> _customers;

        public CustomerWindowViewModel()
        {
            using (var DbContext = new DatabaseEntities())
            {
                _customers = DbContext.Customers
                    .Include(nameof(Employee))
                    .ToList();
            }
        }

        public List<Customer> Customers
        {
            get => _customers;
            set => Set(ref _customers, value, nameof(Customers));
        }
    }
}
