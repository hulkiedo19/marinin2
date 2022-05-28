using marinin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marinin2.ViewModels
{
    public class TiresWindowViewModel : ViewModel
    {
        private List<Tire> _tires;

        public TiresWindowViewModel()
        {
            using(var DbContext = new DatabaseEntities())
            {
                _tires = DbContext.Tires
                    .Include(nameof(LoadIndex))
                    .Include(nameof(SpeedIndex))
                    .Include(nameof(TiresDiameter))
                    .Include(nameof(TiresHeight))
                    .Include(nameof(TiresRadiu))
                    .Include(nameof(TiresWidth))
                    .ToList();
            }
        }

        public List<Tire> Tires
        {
            get => _tires;
            set => Set(ref _tires, value, nameof(Tires));
        }
    }
}
