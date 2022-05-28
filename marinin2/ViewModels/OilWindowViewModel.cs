using marinin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marinin2.ViewModels
{
    public class OilWindowViewModel : ViewModel
    {
        private List<Oil> _oils;

        public OilWindowViewModel()
        {
            using(var DbContext = new DatabaseEntities())
            {
                _oils = DbContext.Oils
                    .Include(nameof(ACEA))
                    .Include(nameof(API))
                    .Include(nameof(Composition))
                    .Include(nameof(Manufacturer))
                    .Include(nameof(OEM))
                    .Include(nameof(OilType))
                    .Include(nameof(Viscosity))
                    .ToList();
            }
        }

        public List<Oil> Oils
        {
            get => _oils;
            set => Set(ref _oils, value, nameof(Oils));
        }
    }
}
