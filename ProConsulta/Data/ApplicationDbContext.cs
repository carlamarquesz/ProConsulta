using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;
using System.Reflection;

namespace ProConsulta.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Agendamento> Agendamentos { get; set; } = null!;
		public DbSet<Paciente> Pacientes { get; set; } = null!;
		public DbSet<Atendente> Atendentes { get; set; } = null!;

		public DbSet<Especialidade> Especialidades { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(builder); 
			
		}
	}
}
