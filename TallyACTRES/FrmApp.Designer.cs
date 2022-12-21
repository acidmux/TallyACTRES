namespace TallyACTRES
{
    partial class FrmApp
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
            this.btnUnreserve = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnreserve
            // 
            this.btnUnreserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUnreserve.FlatAppearance.BorderSize = 0;
            this.btnUnreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnreserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnreserve.Location = new System.Drawing.Point(105, 13);
            this.btnUnreserve.Name = "btnUnreserve";
            this.btnUnreserve.Size = new System.Drawing.Size(167, 35);
            this.btnUnreserve.TabIndex = 0;
            this.btnUnreserve.Text = "Unreserve";
            this.btnUnreserve.UseVisualStyleBackColor = false;
            this.btnUnreserve.Click += new System.EventHandler(this.btnUnreserve_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(105, 54);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(167, 45);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallyACTRES.Properties.Resources._449444_7c6430fc16344f1eb9a661485a65f61b_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnUnreserve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "FrmApp";
            this.Text = "Activation Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnreserve;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

