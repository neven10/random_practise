//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artikl
    {
        public int Id { get; set; }
        public int sifraArtikl { get; set; }
        public string nazivArtikl { get; set; }
        public int FondId { get; set; }
    
        public virtual Fond Fond { get; set; }
    }
}