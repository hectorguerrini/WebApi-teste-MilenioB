//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MB_CLIENTE
    {
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public Nullable<int> numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public Nullable<int> id_cidade { get; set; }
        public string cep { get; set; }
    }
}
