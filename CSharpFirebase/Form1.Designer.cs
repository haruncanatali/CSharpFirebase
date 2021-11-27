
namespace CSharpFirebase
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SurnameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GradeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.baglantiTestBtn = new System.Windows.Forms.Button();
            this.sinifCbx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.soyadTxt = new DevExpress.XtraEditors.TextEdit();
            this.adTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinifCbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(689, 264);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.NameCol,
            this.SurnameCol,
            this.GradeCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.Visible = true;
            this.IdCol.VisibleIndex = 0;
            // 
            // NameCol
            // 
            this.NameCol.Caption = "Ad";
            this.NameCol.FieldName = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.Visible = true;
            this.NameCol.VisibleIndex = 1;
            // 
            // SurnameCol
            // 
            this.SurnameCol.Caption = "Soyad";
            this.SurnameCol.FieldName = "Surname";
            this.SurnameCol.Name = "SurnameCol";
            this.SurnameCol.Visible = true;
            this.SurnameCol.VisibleIndex = 2;
            // 
            // GradeCol
            // 
            this.GradeCol.Caption = "Sınıf";
            this.GradeCol.FieldName = "Grade";
            this.GradeCol.Name = "GradeCol";
            this.GradeCol.Visible = true;
            this.GradeCol.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baglantiTestBtn);
            this.groupBox2.Controls.Add(this.sinifCbx);
            this.groupBox2.Controls.Add(this.simpleButton4);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.soyadTxt);
            this.groupBox2.Controls.Add(this.adTxt);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veritabanı İşlemleri";
            // 
            // baglantiTestBtn
            // 
            this.baglantiTestBtn.Location = new System.Drawing.Point(299, 148);
            this.baglantiTestBtn.Name = "baglantiTestBtn";
            this.baglantiTestBtn.Size = new System.Drawing.Size(103, 23);
            this.baglantiTestBtn.TabIndex = 9;
            this.baglantiTestBtn.Text = "Bağlantı Test Et";
            this.baglantiTestBtn.UseVisualStyleBackColor = true;
            this.baglantiTestBtn.Click += new System.EventHandler(this.Baglanti_Test_Btn_Click);
            // 
            // sinifCbx
            // 
            this.sinifCbx.EditValue = "1.Sınıf";
            this.sinifCbx.Location = new System.Drawing.Point(78, 114);
            this.sinifCbx.Name = "sinifCbx";
            this.sinifCbx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sinifCbx.Properties.DropDownRows = 4;
            this.sinifCbx.Properties.Items.AddRange(new object[] {
            "1.Sınıf",
            "2.Sınıf",
            "3.Sınıf",
            "4.Sınıf"});
            this.sinifCbx.Size = new System.Drawing.Size(158, 20);
            this.sinifCbx.TabIndex = 3;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(570, 87);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(103, 45);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Temizle";
            this.simpleButton4.Click += new System.EventHandler(this.VT_Buttons_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(461, 87);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 45);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.VT_Buttons_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(461, 38);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 45);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Ekle";
            this.simpleButton2.Click += new System.EventHandler(this.VT_Buttons_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(570, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 45);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Güncelle";
            this.simpleButton1.Click += new System.EventHandler(this.VT_Buttons_Click);
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(78, 84);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(158, 20);
            this.soyadTxt.TabIndex = 2;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(78, 52);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(158, 20);
            this.adTxt.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Soyad :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Sınıf :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# Firebase CRUD";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinifCbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit adTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit soyadTxt;
        private DevExpress.XtraEditors.ComboBoxEdit sinifCbx;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn NameCol;
        private DevExpress.XtraGrid.Columns.GridColumn SurnameCol;
        private DevExpress.XtraGrid.Columns.GridColumn GradeCol;
        private System.Windows.Forms.Button baglantiTestBtn;
    }
}

