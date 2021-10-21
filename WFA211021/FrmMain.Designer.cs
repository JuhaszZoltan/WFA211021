
namespace WFA211021
{
    partial class FrmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tsmiTenyeszto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParkereso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBejelentes = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTenyeszto,
            this.tsmiParkereso,
            this.tsmiBejelentes});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 73);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMain.Location = new System.Drawing.Point(28, 100);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(730, 273);
            this.dgvMain.TabIndex = 1;
            // 
            // tsmiTenyeszto
            // 
            this.tsmiTenyeszto.Image = global::WFA211021.Properties.Resources.wizard;
            this.tsmiTenyeszto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTenyeszto.Name = "tsmiTenyeszto";
            this.tsmiTenyeszto.Size = new System.Drawing.Size(70, 69);
            this.tsmiTenyeszto.Text = "Tenyésztő";
            this.tsmiTenyeszto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiParkereso
            // 
            this.tsmiParkereso.Image = global::WFA211021.Properties.Resources.love;
            this.tsmiParkereso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiParkereso.Name = "tsmiParkereso";
            this.tsmiParkereso.Size = new System.Drawing.Size(70, 69);
            this.tsmiParkereso.Text = "Párkereső";
            this.tsmiParkereso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiBejelentes
            // 
            this.tsmiBejelentes.Image = global::WFA211021.Properties.Resources.unicorn;
            this.tsmiBejelentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiBejelentes.Name = "tsmiBejelentes";
            this.tsmiBejelentes.Size = new System.Drawing.Size(72, 69);
            this.tsmiBejelentes.Text = "Bejelentés";
            this.tsmiBejelentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fajta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tulajdonos";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Város";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Súly";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nem";
            this.Column6.Name = "Column6";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.Text = "Unikornis Ménes Manager 2021";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiTenyeszto;
        private System.Windows.Forms.ToolStripMenuItem tsmiParkereso;
        private System.Windows.Forms.ToolStripMenuItem tsmiBejelentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

