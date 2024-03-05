using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Models
{
	public class Vehiculos
	{
		[Key]
		public int VehiculoId { get; set; }

		[Required(ErrorMessage ="Este campo es requerido")]
		public string? Descripcion { get; set; }

		[Required(ErrorMessage = "Este campo es requerido")]
		public DateTime Fecha { get; set; }

		[Required(ErrorMessage = "Este campo es requerido")]
		[Range(0.01, float.MaxValue, ErrorMessage = "Debe ser mayor a 0.01")]
		public float Costo { get; set;}
		public float Gasto { get; set; }

	}
}
