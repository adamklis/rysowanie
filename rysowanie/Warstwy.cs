//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rysowanie
{
    using System;
    using System.Collections.Generic;
    
    public partial class Warstwy
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public Nullable<float> Miazszosc { get; set; }
        public Nullable<float> WspFiltracji { get; set; }
        public Nullable<int> Kolor_A { get; set; }
        public Nullable<int> Kolor_R { get; set; }
        public Nullable<int> Kolor_G { get; set; }
        public Nullable<int> Kolor_B { get; set; }
        public byte[] Image { get; set; }
    }
}
