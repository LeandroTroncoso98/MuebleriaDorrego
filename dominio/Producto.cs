using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string UrlImagen { get; set; }
        [DisplayName("Tipo de madera")]
        public Madera Madera { get; set; }
        public Categoria Categoria { get; set; }

    }
}
