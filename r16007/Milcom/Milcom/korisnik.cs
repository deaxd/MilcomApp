//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Milcom
{
    using System;
    using System.Collections.Generic;
    
    public partial class korisnik
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int tip_korisnik_id { get; set; }
        public Nullable<int> polaznik_oib { get; set; }
    
        public virtual polaznik polaznik { get; set; }
        public virtual tip_korisnik tip_korisnik { get; set; }
    }
}
