using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controllers
{
    public class fileController
    {
        public static void initializeDB()
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    var loaifile = new loaiFile { loaifile = "khoahoc", id = 1 };
                    _context.tbloaifile.Add(loaifile);
                    var loaifile1 = new loaiFile { loaifile = "toanhoc", id = 2 };
                    _context.tbloaifile.Add(loaifile1);
                    var loaifile2 = new loaiFile { loaifile = "vanhoc", id = 3 };
                    _context.tbloaifile.Add(loaifile2);
                    var loaifile3 = new loaiFile { loaifile = "truyentranh", id = 4 };
                    _context.tbloaifile.Add(loaifile3);
                    _context.SaveChanges();
                }
                MessageBox.Show("Lưu thành công!");
            }
            catch { }
        }
    }
}
