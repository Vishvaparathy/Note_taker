namespace Note_Taker
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BackgroundImage = global::Note_Taker.Properties.Resources.Picture6;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.create);
            this.panel1.Location = new System.Drawing.Point(47, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 530);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(233, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search previous notes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create.BackColor = System.Drawing.Color.Yellow;
            this.create.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Brown;
            this.create.Location = new System.Drawing.Point(233, 93);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(319, 100);
            this.create.TabIndex = 0;
            this.create.Text = "Create a New Note";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Note_Taker.Properties.Resources.Nature;
            this.ClientSize = new System.Drawing.Size(879, 606);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button create;
    }
}