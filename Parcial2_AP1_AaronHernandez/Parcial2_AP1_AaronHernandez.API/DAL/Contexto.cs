using Compartido.Models;
using Microsoft.EntityFrameworkCore;

namespace Parcial2_AP1_AaronHernandez.API.DAL
{
	public class Contexto : DbContext
	{
		public DbSet<Vehiculos>? Vehiculos { get; set; }
		public DbSet<Accesorios>? Accesorios { get; set; }
		public DbSet<VehiculoDetalle>? VehiculoDetalle { get; set; }

		public Contexto(DbContextOptions<Contexto> options) : base(options){ }	
	}
}
