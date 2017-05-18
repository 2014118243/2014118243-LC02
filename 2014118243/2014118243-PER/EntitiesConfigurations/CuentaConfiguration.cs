using _2014118243_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2014118243;

namespace _2014118243_ENT.EntitiesConfigurations
{
	public class CuentaConfigurations : EntityTypeConfiguration<Pantalla>
	{
		public CuentaConfigurations()
		{
			//Table Configurations
			ToTable("Pantalla");

			HasKey(a =>2);


		}

     
    }
}
