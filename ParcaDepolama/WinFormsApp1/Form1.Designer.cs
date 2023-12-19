namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            parcaİsmi = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnParcaEkle = new Button();
            parcaSahibi = new TextBox();
            parcaFiyati = new TextBox();
            label4 = new Label();
            parcaTuru = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            btnParcaGuncelle = new Button();
            gParcaSahibi = new TextBox();
            gParcaFiyati = new TextBox();
            label5 = new Label();
            gParcaTuru = new TextBox();
            label6 = new Label();
            label7 = new Label();
            gParcaİsmi = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnParcaSil = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Parça İsmi";
            // 
            // parcaİsmi
            // 
            parcaİsmi.Location = new Point(5, 27);
            parcaİsmi.Name = "parcaİsmi";
            parcaİsmi.Size = new Size(75, 23);
            parcaİsmi.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(186, 184);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(325, 118);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnParcaEkle);
            tabPage1.Controls.Add(parcaSahibi);
            tabPage1.Controls.Add(parcaFiyati);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(parcaTuru);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(parcaİsmi);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(317, 90);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parça Ekleme Menüsü";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnParcaEkle
            // 
            btnParcaEkle.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnParcaEkle.Location = new Point(5, 56);
            btnParcaEkle.Name = "btnParcaEkle";
            btnParcaEkle.Size = new Size(308, 28);
            btnParcaEkle.TabIndex = 7;
            btnParcaEkle.Text = "Yeni Parça Ekle";
            btnParcaEkle.UseVisualStyleBackColor = true;
            btnParcaEkle.Click += btnParcaEkle_Click;
            // 
            // parcaSahibi
            // 
            parcaSahibi.Location = new Point(216, 27);
            parcaSahibi.Name = "parcaSahibi";
            parcaSahibi.Size = new Size(97, 23);
            parcaSahibi.TabIndex = 5;
            // 
            // parcaFiyati
            // 
            parcaFiyati.Location = new Point(167, 27);
            parcaFiyati.Name = "parcaFiyati";
            parcaFiyati.Size = new Size(45, 23);
            parcaFiyati.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(241, 3);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 4;
            label4.Text = "Sahibi";
            // 
            // parcaTuru
            // 
            parcaTuru.Location = new Point(84, 27);
            parcaTuru.Name = "parcaTuru";
            parcaTuru.Size = new Size(79, 23);
            parcaTuru.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(169, 3);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 4;
            label3.Text = "Fiyatı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 3);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 2;
            label2.Text = "Parça Türü";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnParcaGuncelle);
            tabPage2.Controls.Add(gParcaSahibi);
            tabPage2.Controls.Add(gParcaFiyati);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(gParcaTuru);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(gParcaİsmi);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(317, 90);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Parça Güncelleme Menüsü";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnParcaGuncelle
            // 
            btnParcaGuncelle.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnParcaGuncelle.Location = new Point(4, 56);
            btnParcaGuncelle.Name = "btnParcaGuncelle";
            btnParcaGuncelle.Size = new Size(308, 28);
            btnParcaGuncelle.TabIndex = 14;
            btnParcaGuncelle.Text = "Seçili Parçayı Güncelle";
            btnParcaGuncelle.UseVisualStyleBackColor = true;
            btnParcaGuncelle.Click += btnParcaGuncelle_Click;
            // 
            // gParcaSahibi
            // 
            gParcaSahibi.Location = new Point(215, 28);
            gParcaSahibi.Name = "gParcaSahibi";
            gParcaSahibi.Size = new Size(97, 23);
            gParcaSahibi.TabIndex = 12;
            // 
            // gParcaFiyati
            // 
            gParcaFiyati.Location = new Point(166, 28);
            gParcaFiyati.Name = "gParcaFiyati";
            gParcaFiyati.Size = new Size(45, 23);
            gParcaFiyati.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(240, 4);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 10;
            label5.Text = "Sahibi";
            // 
            // gParcaTuru
            // 
            gParcaTuru.Location = new Point(83, 28);
            gParcaTuru.Name = "gParcaTuru";
            gParcaTuru.Size = new Size(79, 23);
            gParcaTuru.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(168, 4);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 11;
            label6.Text = "Fiyatı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(85, 4);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 8;
            label7.Text = "Parça Türü";
            // 
            // gParcaİsmi
            // 
            gParcaİsmi.Location = new Point(4, 28);
            gParcaİsmi.Name = "gParcaİsmi";
            gParcaİsmi.Size = new Size(75, 23);
            gParcaİsmi.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 4);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 6;
            label8.Text = "Parça İsmi";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(7, 184);
            button1.Name = "button1";
            button1.Size = new Size(173, 35);
            button1.TabIndex = 4;
            button1.Text = "Parça Ekleme Menüsü";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(7, 225);
            button2.Name = "button2";
            button2.Size = new Size(173, 33);
            button2.TabIndex = 5;
            button2.Text = "Parça Güncelleme Menüsü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnParcaSil
            // 
            btnParcaSil.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnParcaSil.Location = new Point(7, 264);
            btnParcaSil.Name = "btnParcaSil";
            btnParcaSil.Size = new Size(173, 34);
            btnParcaSil.TabIndex = 6;
            btnParcaSil.Text = "Seçili Parçayı Sil";
            btnParcaSil.UseVisualStyleBackColor = true;
            btnParcaSil.Click += btnParcaSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(504, 170);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 307);
            Controls.Add(dataGridView1);
            Controls.Add(btnParcaSil);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox parcaİsmi;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox parcaTuru;
        private Label label2;
        private TabPage tabPage2;
        private TextBox parcaSahibi;
        private TextBox parcaFiyati;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button btnParcaSil;
        private TextBox gParcaSahibi;
        private TextBox gParcaFiyati;
        private Label label5;
        private TextBox gParcaTuru;
        private Label label6;
        private Label label7;
        private TextBox gParcaİsmi;
        private Label label8;
        private Button btnParcaEkle;
        private Button btnParcaGuncelle;
        private DataGridView dataGridView1;
    }
}