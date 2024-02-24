using Presupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Presupuesto.Models
{
    public class TipoCuentas
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo Nombre es requerido!")]
        [StringLength(maximumLength:50,MinimumLength =3, ErrorMessage ="la longitud del campo {0} debe estar entre {2} y {1}")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }
    }
}
