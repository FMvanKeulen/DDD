using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Configuration
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Se não estiver configurado no projeto IU pega definição do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(GetStringConnectionConfig());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source=DESKTOP-HVNTI80\\DESENVOLVIMENTO;Initial Catalog=DDD_2020_AULA;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }
    }
}
