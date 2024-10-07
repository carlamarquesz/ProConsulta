using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
	public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento>
	{
		public void Configure(EntityTypeBuilder<Agendamento> builder)
		{
			builder.ToTable("Agendamentos");
			builder.HasKey(p => p.Id); 
			builder.Property(p => p.Observacao)
				.IsRequired(false)
				.HasColumnType("varchar(200)");

			builder.Property(p => p.PacienteId)
					.IsRequired();
			builder.Property(p => p.MedicoId)
				.IsRequired();
		}
	}
}
