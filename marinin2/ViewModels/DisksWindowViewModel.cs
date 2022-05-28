using marinin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marinin2.ViewModels
{
    public class DisksWindowViewModel : ViewModel
    {
        private List<Disk> _disks;

        public DisksWindowViewModel()
        {
            using (var DbContext = new DatabaseEntities())
            {
                _disks = DbContext.Disks
                    .Include(nameof(DepartureET))
                    .Include(nameof(DiameterOfTheCenteralHole))
                    .Include(nameof(DisksDiameter))
                    .Include(nameof(DisksWidth))
                    .Include(nameof(NumberOfMountingHole))
                    .ToList();
            }
        }

        public List<Disk> Disks
        {
            get => _disks;
            set => Set(ref _disks, value, nameof(Disks));
        }
    }
}
