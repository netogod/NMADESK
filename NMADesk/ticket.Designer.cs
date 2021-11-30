namespace NMADesk
{
    partial class ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticket));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMenuMain = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMenuMain
            // 
            this.btnMenuMain.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMenuMain.FlatAppearance.BorderSize = 0;
            this.btnMenuMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(204)))));
            this.btnMenuMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMain.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMain.ForeColor = System.Drawing.Color.White;
            this.btnMenuMain.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnMenuMain.IconColor = System.Drawing.Color.White;
            this.btnMenuMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuMain.IconSize = 30;
            this.btnMenuMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMain.Location = new System.Drawing.Point(13, 220);
            this.btnMenuMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuMain.Name = "btnMenuMain";
            this.btnMenuMain.Rotation = 0D;
            this.btnMenuMain.Size = new System.Drawing.Size(237, 55);
            this.btnMenuMain.TabIndex = 2;
            this.btnMenuMain.Text = "Menu Principal";
            this.btnMenuMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuMain.UseVisualStyleBackColor = false;
            this.btnMenuMain.Click += new System.EventHandler(this.btnMenuMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1199, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenuMain);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ticket";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnMenuMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}