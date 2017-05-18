using _2014118243_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118243_ENT.EntitiesConfigurations
{
	public class RanuraDepositoConfiguration : EntityTypeConfiguration<Caption>
	{
		public RanuraDepositoConfiguration()
		{
			//Table Configurations
			ToTable("Captions");

			HasKey(c => c.CaptionId);

			Property(c => c.Translation).IsMaxLength();
		}
	}
}
