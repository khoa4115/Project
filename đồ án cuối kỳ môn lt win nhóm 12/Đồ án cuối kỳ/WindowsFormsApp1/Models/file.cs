using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Table("QuanLyFile")]
    public class file
    {
        [Key]
        public string namefile { get; set; }
        public string path { get; set; }
        public string kichthuoc { get; set; }
        public string note { get; set; }
        public string kt { get; set; }
        public string theloai { get; set; }
        public override string ToString()
        {
            return this.namefile;
        }
    }
}
