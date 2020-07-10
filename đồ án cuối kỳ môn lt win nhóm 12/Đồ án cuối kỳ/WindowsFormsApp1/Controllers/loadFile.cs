using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Data.Entity.Migrations;

namespace WindowsFormsApp1.Controllers
{
    public class loadFile
    {
        public static bool AddFile(file File)
        {
            using (var _context = new DBFileContext())
            {
                _context.tbFile.AddOrUpdate(File);
                _context.SaveChanges();
                return false;
            }
        }
        public static List<file> getAllFile()
        {
            using (var _context = new DBFileContext())
            {
                var pdf = (from u in _context.tbFile.AsEnumerable()
                           select new
                           {
                               name = u.namefile,
                               path = u.path,
                               size = u.kichthuoc,
                               note = u.note,
                               kt=u.kt,
                               theloai=u.theloai
                           }).Select(x => new file
                           {
                               namefile = x.name,
                               path = x.path,
                               kichthuoc = x.size,
                               note = x.note,
                               kt=x.kt,
                               theloai=x.theloai
                           });
                return pdf.ToList();
            }
        }
        public static string GetNote(file f)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    var note = (from u in _context.tbFile.AsEnumerable()
                                where u.namefile == f.namefile
                                select u.note).Single();
                    return note.ToString();
                }
            }
            catch
            {
                return" ";
            }
        }
        public static string GetKt(file f)
        {
            using (var _context = new DBFileContext())
            {
                var note = (from u in _context.tbFile.AsEnumerable()
                            where u.namefile == f.namefile
                            select u.kt).Single();
                if (note is null)
                    return "unread";
                else
                return note.ToString();
            }
        }
        public static string getTheloai(file f)
        {
            using (var _context = new DBFileContext())
            {
                var note = (from u in _context.tbFile.AsEnumerable()
                            where u.namefile == f.namefile
                            select u.theloai).Single();
                if (note is null)
                    return "chua co the loai";
                else
                    return note.ToString();
            }
        }
        public static bool DeleteFile(file File)
        {
            try
            {
                using (var _context = new DBFileContext())
                {
                    //xoa list file
                    var dbfile = (from u in _context.tbFile
                                  where u.namefile == File.namefile
                                  select u).SingleOrDefault();

                    foreach (var u in dbfile.namefile)
                    {
                        if (u.ToString() == File.namefile)
                        {
                            File.namefile.Remove(u);
                            break;
                        }
                    }

                    _context.tbFile.Remove(dbfile);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<file> getListFile(string filenamesearch)
        {
            using (var _context = new DBFileContext())
            {
                var File = (from u in _context.tbFile.AsEnumerable()
                            where u.namefile.Contains(filenamesearch)
                            select u)
                            .Select(x => new file
                            {
                                namefile = x.namefile,
                                path = x.path,
                                kichthuoc = x.kichthuoc,
                                note = x.note,
                                kt = x.kt,
                                theloai = x.theloai
                            }).ToList();
                return File;
            }

        }
    }
}
