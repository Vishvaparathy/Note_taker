namespace Note_Taker
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Notebox = new System.Windows.Forms.TextBox();
            this.Titlebx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BackgroundImage = global::Note_Taker.Properties.Resources.old_dirty_grunge_note_paper_background;
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Notebox);
            this.panel1.Controls.Add(this.Titlebx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 751);
            this.panel1.TabIndex = 1;
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.BackColor = System.Drawing.Color.ForestGreen;
            this.save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.FloralWhite;
            this.save.Location = new System.Drawing.Point(372, 635);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(297, 45);
            this.save.TabIndex = 19;
            this.save.Text = "Load";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 136);
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
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notebox
            // 
            this.Notebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Notebox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notebox.Location = new System.Drawing.Point(94, 176);
            this.Notebox.Multiline = true;
            this.Notebox.Name = "Notebox";
            this.Notebox.Size = new System.Drawing.Size(851, 423);
            this.Notebox.TabIndex = 14;
            this.Notebox.TextChanged += new System.EventHandler(this.Notebx_TextChanged);
            // 
            // Titlebx
            // 
            this.Titlebx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titlebx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlebx.Location = new System.Drawing.Point(94, 77);
            this.Titlebx.Multiline = true;
            this.Titlebx.Name = "Titlebx";
            this.Titlebx.Size = new System.Drawing.Size(851, 35);
            this.Titlebx.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Note_Taker.Properties.Resources.Tree;
            this.ClientSize = new System.Drawing.Size(1032, 751);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Notebox;
        private System.Windows.Forms.TextBox Titlebx;
    }
}