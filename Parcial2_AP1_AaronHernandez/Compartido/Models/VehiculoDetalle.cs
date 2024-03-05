using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Models
{
	public class VehiculoDetalle
	{
		[Key]
		public int Id { get; set; }
		public int VehiculoId { get; set;}
		public int AccesorioId { get; set; }
		[Required(ErrorMessage ="Este campo es requerido")]
		public float Valor { get; set; }

		public VehiculoDetalle() { }

		public VehiculoDetalle(int accesorioid, float valor)
		{
			AccesorioId = accesorioid;
			Valor = valor;
		}

		public VehiculoDetalle(int id, int accesorioid, float valor)
		{
			Id = id;
			AccesorioId = accesorioid;
			Valor = valor;
		}
	}
}
