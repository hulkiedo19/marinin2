using marinin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marinin2.ViewModels
{
    public class AccumulatorWindowViewModel : ViewModel
    {
        private List<Accumulator> _accumulators;

        public AccumulatorWindowViewModel()
        {
            using (var DbContext = new DatabaseEntities())
            {
                _accumulators = DbContext.Accumulators
                    .Include(nameof(BatteryCapacity))
                    .Include(nameof(AccumulatorLength))
                    .Include(nameof(AccumulatorHeight))
                    .Include(nameof(AccumulatorSery))
                    .Include(nameof(AccumulatorManufacturer))
                    .Include(nameof(AccumulatorWidth))
                    .Include(nameof(Voltage))
                    .ToList();
            }
        }

        public List<Accumulator> Accumulators
        {
            get => _accumulators;
            set => Set(ref _accumulators, value, nameof(Accumulator));
        }
    }
}
