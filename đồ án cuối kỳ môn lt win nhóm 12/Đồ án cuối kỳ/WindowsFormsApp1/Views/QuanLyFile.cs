using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Views
{
    public partial class QuanLyFile : Form
    {
        OpenFileDialog open;
        OpenFileDialog openFile = new OpenFileDialog();
        public int kt = 0;
        public int ktthem_xoa_sach = 1;//1 là thêm 0 là xóa ra khỏi thể loại sách
        public int ktthem_xoa_loaisach = 1;// 1 là thêm 0 là xóa loại sách
        public QuanLyFile()
        {
            InitializeComponent();
            txtSearch.Text = ".pdf";
            lstLoadingFile.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstLoadingFile.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstLoadingFile.Columns[0].Width = 200;
            lstLoadingFile.Columns[1].Width = 600;
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;         //cho phép tiến trình báo cáo tiến độ của công việc
            backgroundWorker1.WorkerSupportsCancellation = true;    //cho phép dừng tiến trình trong khi đang thực thi

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;   //đoạn mã thực hiện công việc sẽ được đặt ở đây. Sự kiện này xảy ra khi bắt đầu tiến trình
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;     //xảy ra khi tiến độ của tiến trình có sự thay đổi hoặc khi ta gọi hàm 
                                                                                        //ReportProgress() của lớp BackgroundWorker
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;//xảy ra khi tiến trình hoàn tất hoặc bị hủy bỏ
            txtFolderPath.Text = "D:";
            displayTasks();
            read();
            laydanhsachtheloai();
        }
        private void displayTasks()
        {
            List<file> lstFile = loadFile.getAllFile();
            lstLoadingFile.Visible = true;
            foreach (file File in lstFile)
            {
                string path = File.path.ToString().Trim() + "\\" + File.namefile;
                var icon = Icon.ExtractAssociatedIcon(path);
                string key = Path.GetExtension(path);//Trả về phần mở rộng khi biết đường dẫn
                imageList1.Images.Add(key, icon.ToBitmap());
                ListViewItem fIle = new ListViewItem(File.namefile.ToString(), key);
                fIle.SubItems.Add(new ListViewItem.ListViewSubItem(fIle, File.path.ToString()));
                fIle.SubItems.Add(new ListViewItem.ListViewSubItem(fIle, File.kichthuoc.ToString()));
                this.lstLoadingFile.Items.Add(fIle);
            }

        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        public void AddToListView(string file)
        {


            FileInfo finfo = new FileInfo(file);
            lstLoadingFile.Invoke((Action)(() =>
            {
                var icon = Icon.ExtractAssociatedIcon(file);
                string key = Path.GetExtension(file);//Trả về phần mở rộng khi biết đường dẫn
                imageList1.Images.Add(key, icon.ToBitmap());
                file pdf = new file();
                pdf.namefile = finfo.Name;
                pdf.path = finfo.DirectoryName;
                pdf.kichthuoc = (Math.Ceiling(finfo.Length / 1024f)).ToString() + " KB";
                ListViewItem item = new ListViewItem(pdf.namefile, key);
                item.SubItems.Add(pdf.path);                 //trả về đường dẫn
                item.SubItems.Add(pdf.kichthuoc);       //.ToString("0 KB"));// trả về kích thước
                lstLoadingFile.BeginUpdate();
                lstLoadingFile.Items.Add(item);
                lstLoadingFile.EndUpdate();
                //pdf.note = txtghichu.Text;
                //pdf.kt = "Unread";
                loadFile.AddFile(pdf);
            }));

        }

        public void ScanDirectory(string directory, string searchPattern)
        {
            try
            {
                foreach (var file in Directory.GetFiles(directory))
                {
                    if (backgroundWorker1.CancellationPending)// cờ báo dừng tiến trình
                    {
                        return;
                    }

                    lblProgress.Invoke((Action)(() => lblProgress.Text = file));
                    if (file.Contains(searchPattern))
                    {
                        AddToListView(file);
                    }
                }


                foreach (var dir in Directory.GetDirectories(directory))
                {
                    ScanDirectory(dir, searchPattern);
                }
            }
            catch
            {
                return;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            string[] dirs = Directory.GetDirectories(txtFolderPath.Text);
            float length = dirs.Length;
            progressBar1.Invoke((Action)(() => progressBar1.Maximum = dirs.Length));
            ScanDirectory(txtFolderPath.Text, txtSearch.Text);
            for (int i = 0; i < dirs.Length; i++)
            {
                backgroundWorker1.ReportProgress((int)(i / length * 100));
                ScanDirectory(dirs[i], txtSearch.Text);
            }
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker1.CancellationPending)
            {
                progressBar1.PerformStep();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            lblProgress.Text = String.Format("Tìm thấy {0} tập tin.", lstLoadingFile.Items.Count);
            if (progressBar1.Value < progressBar1.Maximum)
            {
                lblProgress.Text = "Dừng tìm kiếm. " + lblProgress.Text;
            }
            //btnLoadingfile.Text = "Stop";
            kt = 1;
        }

        private void lstLoadingFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            lstRead.Visible = false;
            lstUnread.Visible = false;
            panel1.Visible = false;
            string linkfile = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim() + "\\" + lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
            openFile.FileName = linkfile;
            lstLoadingFile.Visible = false;
            axAcroPDF1.Visible = true;
            axAcroPDF1.src = openFile.FileName;
            file pdf = new file();
            pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
            pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
            pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
            pdf.note = txtghichu.Text;
            pdf.kt = "read";
            loadFile.AddFile(pdf);
            txtghichu.Text = loadFile.GetNote(pdf);
            read();
        }
        private void lstLoadingFile_MouseClick(object sender, MouseEventArgs e)
        {

            FileInfo info = new FileInfo(lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim() +
                "\\" + lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim());
            string ghichu = info.Name
                + "\n" + info.DirectoryName
                + "\n" + info.LastAccessTime
                + "\n" + lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim()
                + "";
            file pdf = new file();
            List<file> lstFile = loadFile.getAllFile();
            foreach (file File in lstFile)
            {
                if (File.namefile == lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim())
                {
                    pdf.theloai = File.theloai;
                    pdf.kt = File.kt;
                    pdf.note = File.note;
                }
            }

            pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
            pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
            pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
            if (pdf.note == "" || pdf.note is null)
                pdf.note = ghichu;
            //pdf.theloai = comb;
            loadFile.AddFile(pdf);

            if (comboBox1.Text == "")
            {
                btnsachvaotheloai.Text = "";
            }
            else
            {
                if (pdf.theloai is null)
                {
                    ktthem_xoa_sach = 1;
                    btnsachvaotheloai.Text = "Add";
                }
                else
                if (pdf.theloai == comboBox1.Text)
                {
                    ktthem_xoa_sach = 0;
                    btnsachvaotheloai.Text = "X";
                }
            }
            txtghichu.Text = loadFile.GetNote(pdf);
            read();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
                axAcroPDF1.Visible = false;
                lstLoadingFile.Visible = true;
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                }
                else
                {
                    progressBar1.Value = progressBar1.Minimum;
                    lstLoadingFile.Items.Clear();
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }
        public void read()
        {
            lstRead.Items.Clear();
            lstUnread.Items.Clear();
            List<file> lstFile = loadFile.getAllFile();
            foreach (file File in lstFile)
            {

                string kt1 = loadFile.GetKt(File);
                if (kt1 == "read")
                    lstRead.Items.Add(File.namefile);
                else lstUnread.Items.Add(File.namefile);

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLoadingFile.Items.Clear();
            List<file> lstFile = loadFile.getAllFile();
            foreach (file File in lstFile)
            {
                string tl = loadFile.getTheloai(File);
                if (tl == comboBox1.Text)
                {
                    string path = File.path.ToString().Trim() + "\\" + File.namefile;
                    var icon = Icon.ExtractAssociatedIcon(path);
                    string key = Path.GetExtension(path);//Trả về phần mở rộng khi biết đường dẫn
                    imageList1.Images.Add(key, icon.ToBitmap());
                    ListViewItem fIle = new ListViewItem(File.namefile.ToString(), key);
                    fIle.SubItems.Add(new ListViewItem.ListViewSubItem(fIle, File.path.ToString()));
                    fIle.SubItems.Add(new ListViewItem.ListViewSubItem(fIle, File.kichthuoc.ToString()));
                    this.lstLoadingFile.Items.Add(fIle);
                }
            }
        }
        public int id = 0;
        public void laydanhsachtheloai()
        {
            List<loaiFile> lstloai = AddLoaiFile.getAllLoai();
            foreach (loaiFile loaiFile in lstloai)
            {
                string tl = loaiFile.loaifile;
                comboBox1.Items.Add(tl);
            }
        }
        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            try
            {
                file pdf = new file();
                List<file> lstFile = loadFile.getAllFile();
                foreach (file File in lstFile)
                {
                    if (File.namefile == lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim())
                    {
                        pdf.theloai = File.theloai;
                        pdf.kt = File.kt;
                    }
                }
                pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                pdf.note = txtghichu.Text;
                loadFile.AddFile(pdf);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch { }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            label4.Visible = false;
            label3.Visible = false;
            lstRead.Visible = false;
            lstUnread.Visible = false;
            panel1.Visible = false;
            lstLoadingFile.Visible = false;
            open.InitialDirectory = "D:\\007\\read";
            open.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.Visible = true;
                txtFolderPath.Text = open.FileName;
                axAcroPDF1.src = open.FileName;
                string name = open.FileName;
                AddToListView(name);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fileController.initializeDB();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            lstLoadingFile.Visible = true;
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                lstLoadingFile.Items.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label3.Visible = true;
            lstRead.Visible = true;
            lstUnread.Visible = true;
            panel1.Visible = true;
            lstLoadingFile.Items.Clear();
            displayTasks();
            read();
            laydanhsachtheloai();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = true;
            label4.Visible = false;
            label3.Visible = false;
            lstRead.Visible = false;
            lstUnread.Visible = false;
            panel1.Visible = false;
            lstLoadingFile.Visible = false;
        }

        private void btnsachvaotheloai_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thể loại sách!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (ktthem_xoa_sach == 1)
                {
                    file pdf = new file();
                    pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                    pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                    pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                    pdf.note = txtghichu.Text;
                    pdf.theloai = comboBox1.Text;
                    loadFile.AddFile(pdf);
                    MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    file pdf = new file();
                    pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                    pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                    pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                    pdf.note = txtghichu.Text;
                    pdf.theloai = null;
                    loadFile.AddFile(pdf);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    lstLoadingFile.SelectedItems[0].Remove();
                }
            }

            catch { }
        }

        private void btnAddtheloai_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtaddtheloai.Text != "")
                {
                    id += 1;
                    comboBox1.Items.Add(txtaddtheloai.Text);
                    loaiFile loai = new loaiFile();
                    loai.id = id;
                    loai.loaifile = txtaddtheloai.Text;
                    AddLoaiFile.AddLoai(loai);
                    MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else {
                        MessageBox.Show("Bạn chưa điền thể loại sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }
            catch
            { }
        }

        private void btnViews_Click(object sender, EventArgs e)
        {
            if (lstLoadingFile.Visible == true)
            {

                axAcroPDF1.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
                lstRead.Visible = false;
                lstUnread.Visible = false;
                panel1.Visible = false;
                lstLoadingFile.Visible = false;
            }
            else if (axAcroPDF1.Visible == true)
            {

                lstLoadingFile.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                lstRead.Visible = true;
                lstUnread.Visible = true;
                panel1.Visible = true;
                lstLoadingFile.Items.Clear();
                displayTasks();
                read();
                laydanhsachtheloai();
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            try
            {
                file pdf = new file();
                pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                pdf.note = txtghichu.Text;
                pdf.theloai = comboBox1.Text;
                loadFile.DeleteFile(pdf);
                lstLoadingFile.SelectedItems[0].Remove();
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lstLoadingFile.Items.Clear();
            List<file> searchFiles = loadFile.getListFile(this.txtSearchName.Text.ToString().Trim());        //this.listUsers.Where(x => x.usersname.Contains(this.txtSearchUserName.Text)).ToList();
            file pdf = new file();
            List<file> lstFile = loadFile.getAllFile();
            foreach (file File in lstFile)
            {
                for (int i = 0; i < searchFiles.Count; i++)
                    if (File.namefile == searchFiles[i].namefile.ToString().Trim())
                    {
                        string path = File.path.ToString().Trim() + "\\" + File.namefile;
                        var icon = Icon.ExtractAssociatedIcon(path);
                        string key = Path.GetExtension(path);//Trả về phần mở rộng khi biết đường dẫn
                        imageList1.Images.Add(key, icon.ToBitmap());
                        ListViewItem fIle = new ListViewItem(File.namefile.ToString(), key);
                        fIle.SubItems.Add(new ListViewItem.ListViewSubItem(fIle, File.path.ToString()));
                        fIle.SubItems.Add(new ListViewItem.ListViewSubItem(fIle, File.kichthuoc.ToString()));
                        this.lstLoadingFile.Items.Add(fIle);

                    }
            }
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            label4.Visible = false;
            label3.Visible = false;
            lstRead.Visible = false;
            lstUnread.Visible = false;
            panel1.Visible = false;
            lstLoadingFile.Visible = false;
            open.InitialDirectory = "D:\\007\\read";
            open.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.Visible = true;
                txtFolderPath.Text = open.FileName;
                axAcroPDF1.src = open.FileName;
                axAcroPDF1.Visible = false;
                lstLoadingFile.Visible = true;
                }
            }

        private void lưuThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileController.initializeDB();
        }   

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            label4.Visible = false;
            label3.Visible = false;
            lstRead.Visible = false;
            lstUnread.Visible = false;
            panel1.Visible = false;
            lstLoadingFile.Visible = false;
            open.InitialDirectory = "D:\\007\\read";
            open.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = open.FileName;
                axAcroPDF1.src = open.FileName;
                axAcroPDF1.Visible = true;
            }
        }

        private void loadingFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            lstLoadingFile.Visible = true;
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                lstLoadingFile.Items.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void xóaFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                file pdf = new file();
                pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                pdf.note = txtghichu.Text;
                pdf.theloai = comboBox1.Text;
                loadFile.DeleteFile(pdf);
                lstLoadingFile.SelectedItems[0].Remove();
            }
            catch { }
        }

        private void xóaThểLoạiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                loaiFile loai = new loaiFile();
                loai.loaifile = comboBox1.Text;
                loai.id = id;
                AddLoaiFile.Deletetheloai(loai);
                comboBox1.Items.Clear();
                laydanhsachtheloai();
            }
            catch { }
        }

        private void thêmThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtaddtheloai.Text != "")
                {
                    id += 1;
                    comboBox1.Items.Add(txtaddtheloai.Text);
                    loaiFile loai = new loaiFile();
                    loai.id = id;
                    loai.loaifile = txtaddtheloai.Text;
                    AddLoaiFile.AddLoai(loai);
                    MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else {
                    MessageBox.Show("Bạn chưa điền thể loại sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            { }
        }

        private void thêmSáchVàoPhânLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thể loại sách!", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                if (ktthem_xoa_sach == 1)
                {
                    file pdf = new file();
                    pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                    pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                    pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                    pdf.note = txtghichu.Text;
                    pdf.theloai = comboBox1.Text;
                    loadFile.AddFile(pdf);
                    MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    file pdf = new file();
                    pdf.namefile = lstLoadingFile.SelectedItems[0].SubItems[0].Text.Trim();
                    pdf.path = lstLoadingFile.SelectedItems[0].SubItems[1].Text.Trim();
                    pdf.kichthuoc = lstLoadingFile.SelectedItems[0].SubItems[2].Text.Trim();
                    pdf.note = txtghichu.Text;
                    pdf.theloai = null;
                    loadFile.AddFile(pdf);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    lstLoadingFile.SelectedItems[0].Remove();
                }
            }

            catch { }
        }

        private void thưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label3.Visible = true;
            lstRead.Visible = true;
            lstUnread.Visible = true;
            panel1.Visible = true;
            lstLoadingFile.Items.Clear();
            displayTasks();
            read();
            laydanhsachtheloai();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = true;
            label4.Visible = false;
            label3.Visible = false;
            lstRead.Visible = false;
            lstUnread.Visible = false;
            panel1.Visible = false;
            lstLoadingFile.Visible = false;
        }

        private void thôngTinThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form info = new Information();
            info.Show();
        }

        private void addFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string name = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                name = open.FileName;
                AddToListView(name);
            }

        }
    }
}
