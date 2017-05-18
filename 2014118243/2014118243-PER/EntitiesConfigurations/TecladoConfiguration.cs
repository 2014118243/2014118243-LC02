using _2014118243_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118243_ENT.EntitiesConfigurations
{
	public class TecladoConfiguration : EntityTypeConfiguration<Tag>
	{
		public TecladoConfiguration()
		{
			//Table Configurations
			ToTable("Tags");

			HasKey(c => c.TagId);
		}
	}
}
