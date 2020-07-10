using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class AddLoaiFile
    {
        public static bool AddLoai(loaiFile loai)
        {
            using (var _context = new DBFileContext())
            {
                _context.tbloaifile.AddOrUpdate(loai);
                _context.SaveChanges();
                return false;
            }
        }
        public static List<loaiFile> getAllLoai()
        {
            using (var _context = new DBFileContext())
            {
                var loaiFile = (from u in _context.tbloaifile.AsEnumerable()
                                select new
                                {
                                    id = u.id,
                                    loai = u.loaifile
                                }).Select(x => new loaiFile
                                {
                                    id = x.id,
                                    loaifile = x.loai
                                });
                return loaiFile.ToList();
            }
        }
        public static bool Deletetheloai(loaiFile tloai)
        {

            using (var _context = new DBFileContext())
            {
                //xoa list thể loại sách
                var dbloaiF = (from u in _context.tbloaifile
                               where u.loaifile == tloai.loaifile
                               select u).SingleOrDefault();

                foreach (var u in dbloaiF.loaifile)
                {
                    if (u.ToString() == tloai.loaifile)
                    {
                        tloai.loaifile.Remove(u);
                        break;
                    }
                }
                _context.tbloaifile.Remove(dbloaiF);
                _context.SaveChanges();
                return true;

            }
        }
    }
}
