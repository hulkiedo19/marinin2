using marinin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marinin2.ViewModels
{
    public class AdminWindowViewModel : ViewModel
    {
        private List<Admin> _admins;

        public AdminWindowViewModel()
        {
            using (var DbContext = new DatabaseEntities())
            {
                _admins = DbContext.Admins
                    .Include(nameof(Employee))
                    .ToList();
            }
        }

        public List<Admin> Admins
        {
            get => _admins;
            set => Set(ref _admins, value, nameof(Admin));
        }
    }
}
