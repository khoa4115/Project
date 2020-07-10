using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Table("LoaiFile")]
    public class loaiFile
    {
        [Key]
        
        public string loaifile { get; set; }
        public int id { get; set; }
        
    }
}
