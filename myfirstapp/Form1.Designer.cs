
namespace myfirstapp
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblgroup = new System.Windows.Forms.Label();
            this.textboxlast = new System.Windows.Forms.TextBox();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.textboxgroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 179);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(35, 44);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(75, 20);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "first name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(35, 80);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(73, 20);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "last name";
            // 
            // lblgroup
            // 
            this.lblgroup.AutoSize = true;
            this.lblgroup.Location = new System.Drawing.Point(35, 117);
            this.lblgroup.Name = "lblgroup";
            this.lblgroup.Size = new System.Drawing.Size(50, 20);
            this.lblgroup.TabIndex = 3;
            this.lblgroup.Text = "Group";
            // 
            // textboxlast
            // 
            this.textboxlast.Location = new System.Drawing.Point(141, 80);
            this.textboxlast.Name = "textboxlast";
            this.textboxlast.Size = new System.Drawing.Size(393, 27);
            this.textboxlast.TabIndex = 4;
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(141, 44);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(393, 27);
            this.textboxname.TabIndex = 5;
            // 
            // textboxgroup
            // 
            this.textboxgroup.Location = new System.Drawing.Point(141, 117);
            this.textboxgroup.Name = "textboxgroup";
            this.textboxgroup.Size = new System.Drawing.Size(393, 27);
            this.textboxgroup.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(35, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 67);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myfirstapp.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(500, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxgroup);
            this.Controls.Add(this.textboxname);
            this.Controls.Add(this.textboxlast);
            this.Controls.Add(this.lblgroup);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblgroup;
        private System.Windows.Forms.TextBox textboxlast;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.TextBox textboxgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

