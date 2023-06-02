using DevDay23.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay23.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }
        public DbSet<Aluno> ALUNO { get; set; }
    }
}
