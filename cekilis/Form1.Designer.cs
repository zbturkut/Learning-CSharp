namespace cekilis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ADAYLAR = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.yenicekilis = new System.Windows.Forms.Button();
            this.cekilisibaslat = new System.Windows.Forms.Button();
            this.nmiktar = new System.Windows.Forms.NumericUpDown();
            this.katilansayisi = new System.Windows.Forms.Label();
            this.lblcekilissayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇEKİLİŞ PROGRAMI";
            // 
            // ADAYLAR
            // 
            this.ADAYLAR.Location = new System.Drawing.Point(413, 99);
            this.ADAYLAR.Name = "ADAYLAR";
            this.ADAYLAR.Size = new System.Drawing.Size(329, 321);
            this.ADAYLAR.TabIndex = 1;
            this.ADAYLAR.Text = "";
            this.ADAYLAR.TextChanged += new System.EventHandler(this.ADAYLAR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(410, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÇEKİLİŞ LİSTESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(410, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Her satıra bir isim gelicek şekilde doldurun.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtglist
            // 
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Location = new System.Drawing.Point(26, 94);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersWidth = 51;
            this.dtglist.RowTemplate.Height = 24;
            this.dtglist.Size = new System.Drawing.Size(353, 321);
            this.dtglist.TabIndex = 4;
            this.dtglist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellContentClick);
            // 
            // yenicekilis
            // 
            this.yenicekilis.Location = new System.Drawing.Point(227, 70);
            this.yenicekilis.Name = "yenicekilis";
            this.yenicekilis.Size = new System.Drawing.Size(95, 23);
            this.yenicekilis.TabIndex = 5;
            this.yenicekilis.Text = "yeni çekiliş";
            this.yenicekilis.UseVisualStyleBackColor = true;
            this.yenicekilis.Click += new System.EventHandler(this.yenicekilis_Click);
            // 
            // cekilisibaslat
            // 
            this.cekilisibaslat.Location = new System.Drawing.Point(108, 70);
            this.cekilisibaslat.Name = "cekilisibaslat";
            this.cekilisibaslat.Size = new System.Drawing.Size(113, 23);
            this.cekilisibaslat.TabIndex = 6;
            this.cekilisibaslat.Text = "çekilişi başlat";
            this.cekilisibaslat.UseVisualStyleBackColor = true;
            this.cekilisibaslat.Click += new System.EventHandler(this.cekilisibaslat_Click);
            // 
            // nmiktar
            // 
            this.nmiktar.Location = new System.Drawing.Point(26, 71);
            this.nmiktar.Name = "nmiktar";
            this.nmiktar.Size = new System.Drawing.Size(76, 22);
            this.nmiktar.TabIndex = 7;
            this.nmiktar.ValueChanged += new System.EventHandler(this.nmiktar_ValueChanged);
            // 
            // katilansayisi
            // 
            this.katilansayisi.AutoSize = true;
            this.katilansayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katilansayisi.Location = new System.Drawing.Point(294, 51);
            this.katilansayisi.Name = "katilansayisi";
            this.katilansayisi.Size = new System.Drawing.Size(85, 16);
            this.katilansayisi.TabIndex = 8;
            this.katilansayisi.Text = "Katılan sayısı";
            // 
            // lblcekilissayi
            // 
            this.lblcekilissayi.AutoSize = true;
            this.lblcekilissayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcekilissayi.Location = new System.Drawing.Point(328, 71);
            this.lblcekilissayi.Name = "lblcekilissayi";
            this.lblcekilissayi.Size = new System.Drawing.Size(19, 20);
            this.lblcekilissayi.TabIndex = 9;
            this.lblcekilissayi.Text = "0";
            this.lblcekilissayi.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 454);
            this.Controls.Add(this.lblcekilissayi);
            this.Controls.Add(this.katilansayisi);
            this.Controls.Add(this.nmiktar);
            this.Controls.Add(this.cekilisibaslat);
            this.Controls.Add(this.yenicekilis);
            this.Controls.Add(this.dtglist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADAYLAR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ADAYLAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtglist;
        private System.Windows.Forms.Button yenicekilis;
        private System.Windows.Forms.Button cekilisibaslat;
        private System.Windows.Forms.NumericUpDown nmiktar;
        private System.Windows.Forms.Label katilansayisi;
        private System.Windows.Forms.Label lblcekilissayi;
    }
}

