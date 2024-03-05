﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Models
{
	public class Accesorios
	{
		[Key]
		public int AccesorioId { get; set; }

		[Required(ErrorMessage ="Este campo es obligatorio")]
		public string? Descripcion { get; set; }
	}
}
