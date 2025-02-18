using System.ComponentModel.DataAnnotations;

namespace Liamell_Cruz_p1_Ap1.Models;

public class Aportes

{
    [Key]

    public int AporteId { get; set; }

    [Required(ErrorMessage ="Campo Obligatorio")]
    public DateOnly Fecha{ get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [RegularExpression(@"^[a-zA-z\s]+$", ErrorMessage = "Solo se permiten letras")]
    public string Persona { get; set; }

    [RegularExpression(@"^[a-zA-z\s]+$", ErrorMessage = "Solo se permiten letras")]
    public string Observacion { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    public double Monto { get; set; }




}
