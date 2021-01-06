
namespace BreezeStore
{
    partial class Store
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
            this.components = new System.ComponentModel.Container();
            this.pbDress = new System.Windows.Forms.PictureBox();
            this.pbShoes = new System.Windows.Forms.PictureBox();
            this.pbMakeup = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbSlideShow = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStoreName = new System.Windows.Forms.Label();
            this.pbBreeze = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMakeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideShow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreeze)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDress
            // 
            this.pbDress.Location = new System.Drawing.Point(27, 249);
            this.pbDress.Name = "pbDress";
            this.pbDress.Size = new System.Drawing.Size(115, 87);
            this.pbDress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDress.TabIndex = 1;
            this.pbDress.TabStop = false;
            this.pbDress.Click += new System.EventHandler(this.pbDress_Click);
            // 
            // pbShoes
            // 
            this.pbShoes.Location = new System.Drawing.Point(390, 249);
            this.pbShoes.Name = "pbShoes";
            this.pbShoes.Size = new System.Drawing.Size(115, 87);
            this.pbShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShoes.TabIndex = 2;
            this.pbShoes.TabStop = false;
            this.pbShoes.Click += new System.EventHandler(this.pbShoes_Click);
            // 
            // pbMakeup
            // 
            this.pbMakeup.Location = new System.Drawing.Point(216, 367);
            this.pbMakeup.Name = "pbMakeup";
            this.pbMakeup.Size = new System.Drawing.Size(115, 87);
            this.pbMakeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMakeup.TabIndex = 3;
            this.pbMakeup.TabStop = false;
            this.pbMakeup.Click += new System.EventHandler(this.pbMakeup_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000000;
            // 
            // pbSlideShow
            // 
            this.pbSlideShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlideShow.Location = new System.Drawing.Point(-1, 29);
            this.pbSlideShow.Name = "pbSlideShow";
            this.pbSlideShow.Size = new System.Drawing.Size(571, 181);
            this.pbSlideShow.TabIndex = 4;
            this.pbSlideShow.TabStop = false;
            this.pbSlideShow.Click += new System.EventHandler(this.pbSlideShow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pbBreeze);
            this.panel1.Controls.Add(this.labelStoreName);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 30);
            this.panel1.TabIndex = 5;
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStoreName.Location = new System.Drawing.Point(203, 1);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(70, 24);
            this.labelStoreName.TabIndex = 0;
            this.labelStoreName.Text = "Breeze";
            // 
            // pbBreeze
            // 
            this.pbBreeze.Location = new System.Drawing.Point(270, 0);
            this.pbBreeze.Name = "pbBreeze";
            this.pbBreeze.Size = new System.Drawing.Size(37, 30);
            this.pbBreeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBreeze.TabIndex = 1;
            this.pbBreeze.TabStop = false;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(570, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSlideShow);
            this.Controls.Add(this.pbMakeup);
            this.Controls.Add(this.pbShoes);
            this.Controls.Add(this.pbDress);
            this.Name = "Store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMakeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlideShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreeze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDress;
        private System.Windows.Forms.PictureBox pbShoes;
        private System.Windows.Forms.PictureBox pbMakeup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbSlideShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBreeze;
        private System.Windows.Forms.Label labelStoreName;
    }
}