using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1.Models
{
    public class DBFileContext:DbContext
    {
        public DBFileContext() : base("name=DBEntityFileWork")
        {
             
        }
        public DbSet<file> tbFile { get; set; }
        public DbSet<loaiFile> tbloaifile { get; set; }
    }
}
