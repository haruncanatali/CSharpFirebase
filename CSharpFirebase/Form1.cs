using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CSharpFirebase
{
    public partial class Form1 : Form
    {
        private string id = "-1";
        private FirebaseConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new FirebaseConnection();
            connection.ConnectionTest();
            Listele();
        }

        private void VT_Buttons_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    Ekle();
                    break;
                case "Güncelle":
                    Guncelle();
                    break;
                case "Sil":
                    SilFonk();
                    break;
                case "Temizle":
                    TemizleFonk();
                    break;
            }
            Listele();
        }

        private async void SilFonk()
        {
            if (id != "-1")
            {
                try
                {
                    connection.DeleteStudent(id);
                    XtraMessageBox.Show("Silme işlemi başarılı oldu");
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show("Hata! Mesaj:" + e.Message);
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen listeden öğrenci seçiniz.");
            }
        }

        private async void Guncelle()
        {
            if (id != "-1")
            {
                try
                {
                    if (adTxt.Text.Length > 0 && soyadTxt.Text.Length > 0 && sinifCbx.Text.Length > 0)
                    {
                        connection.UpdateStudent(new Student
                        {
                            Id = id,
                            Grade = sinifCbx.Text,
                            Name = adTxt.Text,
                            Surname = soyadTxt.Text
                        });
                        XtraMessageBox.Show("Güncelleme başarılı oldu.");
                    }
                    else
                    {
                        XtraMessageBox.Show("Lütfen bilgileri eksiksiz girin.");
                    }
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show("Başarısız! Hata:" + e.Message);
                }
            }
            else
            {
                XtraMessageBox.Show("Listeden öğrenci seçiniz.");
            }
        }

        private async void Listele()
        {
            gridControl1.DataSource = await connection.ListStudent();
            TemizleFonk();
        }

        private async void Ekle()
        {
            try
            {
                if (adTxt.Text.Length > 0 && soyadTxt.Text.Length > 0 && sinifCbx.Text.Length > 0)
                {
                    connection.AddStudent(new Student
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = adTxt.Text,
                        Surname = soyadTxt.Text,
                        Grade = sinifCbx.Text
                    });
                    XtraMessageBox.Show("Ekleme başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Lütfen bilgileri eksiksiz girin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başarısız! Hata:" + ex.Message);
            }
        }

        private void TemizleFonk()
        {
            id = "-1";
            adTxt.Text = "";
            soyadTxt.Text = "";
            sinifCbx.Text = "";
        }

        private void Baglanti_Test_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connection.ConnectionTest("test"));
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            id = gridView1.GetFocusedRowCellValue("Id").ToString();
            adTxt.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            soyadTxt.Text = gridView1.GetFocusedRowCellValue("Surname").ToString();
            sinifCbx.Text = gridView1.GetFocusedRowCellValue("Grade").ToString();
        }
    }
}
