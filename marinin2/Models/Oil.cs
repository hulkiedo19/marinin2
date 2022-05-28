//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace marinin2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oil
    {
        public int Id { get; set; }
        public int OilTypeId { get; set; }
        public int ManufacturerId { get; set; }
        public int ViscosityId { get; set; }
        public int CompositionId { get; set; }
        public int ACEA_Id { get; set; }
        public int API_Id { get; set; }
        public int OEM_Id { get; set; }
    
        public virtual ACEA ACEA { get; set; }
        public virtual API API { get; set; }
        public virtual Composition Composition { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual OEM OEM { get; set; }
        public virtual OilType OilType { get; set; }
        public virtual Viscosity Viscosity { get; set; }
    }
}