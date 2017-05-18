
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2014118243_ENT;
namespace _2014118243_ENT.EntitiesConfigurations
{
	public class PantallaConfiguration : EntityTypeConfiguration<PantallaConfiguration>
	{
		public PantallaConfiguration()
		{
			//Table Configurations
			ToTable("Covers");

			HasKey(c => c);

		}
	}
}
