
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118243_ENT.EntitiesConfigurations
{
	public class DispensadorEfectivoConfiguration : EntityTypeConfiguration<Course>
	{
		public DispensadorEfectivoConfiguration()
		{
			//Table Configurations
			ToTable("Courses");

			HasKey(c => c.CourseId);

			Property(c => c.Name).HasMaxLength(255);


			//Relations Configurations
			HasRequired(c => c.Author)
				.WithMany(c => c.Courses);

			HasOptional(c => c.Caption)
				.WithRequired(c => c.Course);

			HasRequired(c => c.Cover)
				.WithRequiredPrincipal(c => c.Course);

		

		}
	}
}
