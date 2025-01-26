namespace Note_Taker
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Notebx = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BackgroundImage = global::Note_Taker.Properties.Resources._226929_yellow_background;
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Notebx);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 754);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.BackColor = System.Drawing.Color.ForestGreen;
            this.save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.FloralWhite;
            this.save.Location = new System.Drawing.Point(363, 632);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(297, 45);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // no
            // 
            this.no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(94, 47);
            this.no.Multiline = true;
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(841, 35);
            this.no.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "No :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Note :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notebx
            // 
            this.Notebx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Notebx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notebx.Location = new System.Drawing.Point(94, 193);
            this.Notebx.Multiline = true;
            this.Notebx.Name = "Notebx";
            this.Notebx.Size = new System.Drawing.Size(841, 394);
            this.Notebx.TabIndex = 14;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(94, 121);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(841, 35);
            this.Title.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 754);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Notebx;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label label3;
    }
}