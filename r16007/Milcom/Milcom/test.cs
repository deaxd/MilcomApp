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
    
    public partial class test
    {
        public int rezultat_id { get; set; }
        public int pitanje_id { get; set; }
        public int odgovor_id { get; set; }
    
        public virtual odgovor odgovor { get; set; }
        public virtual pitanje pitanje { get; set; }
        public virtual rezultat rezultat { get; set; }
    }
}
