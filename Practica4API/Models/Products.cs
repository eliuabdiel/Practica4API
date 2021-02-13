using System;
using System.Collections.Generic;

namespace Practica4API.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float? Precio { get; set; }
        public string ImgSrc { get; set; }
    }
}
