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
    
    public partial class odgovor
    {
        public odgovor()
        {
            this.test = new HashSet<test>();
        }
    
        public int id { get; set; }
        public string tekst { get; set; }
        public Nullable<bool> tocno { get; set; }
        public int pitanje_id { get; set; }
    
        public virtual pitanje pitanje { get; set; }
        public virtual ICollection<test> test { get; set; }
    }
}
