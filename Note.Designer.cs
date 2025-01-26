namespace Note_Taker
{
    partial class Note
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
            this.newbut = new System.Windows.Forms.Button();
            this.savebut = new System.Windows.Forms.Button();
            this.delbut = new System.Windows.Forms.Button();
            this.Loadbut = new System.Windows.Forms.Button();
            this.PreviousNotes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Notebx = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // newbut
            // 
            this.newbut.BackColor = System.Drawing.Color.LightSalmon;
            this.newbut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbut.ForeColor = System.Drawing.Color.DarkBlue;
            this.newbut.Location = new System.Drawing.Point(50, 656);
            this.newbut.Name = "newbut";
            this.newbut.Size = new System.Drawing.Size(223, 59);
            this.newbut.TabIndex = 17;
            this.newbut.Text = "New Note";
            this.newbut.UseVisualStyleBackColor = false;
            this.newbut.Click += new System.EventHandler(this.newbut_Click_1);
            // 
            // savebut
            // 
            this.savebut.BackColor = System.Drawing.Color.LightSalmon;
            this.savebut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebut.ForeColor = System.Drawing.Color.DarkBlue;
            this.savebut.Location = new System.Drawing.Point(301, 656);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(230, 59);
            this.savebut.TabIndex = 16;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = false;
            this.savebut.Click += new System.EventHandler(this.savebut_Click_1);
            // 
            // delbut
            // 
            this.delbut.BackColor = System.Drawing.Color.LightSalmon;
            this.delbut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbut.ForeColor = System.Drawing.Color.DarkBlue;
            this.delbut.Location = new System.Drawing.Point(301, 575);
            this.delbut.Name = "delbut";
            this.delbut.Size = new System.Drawing.Size(230, 59);
            this.delbut.TabIndex = 15;
            this.delbut.Text = "Delete";
            this.delbut.UseVisualStyleBackColor = false;
            this.delbut.Click += new System.EventHandler(this.delbut_Click_1);
            // 
            // Loadbut
            // 
            this.Loadbut.BackColor = System.Drawing.Color.LightSalmon;
            this.Loadbut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbut.ForeColor = System.Drawing.Color.DarkBlue;
            this.Loadbut.Location = new System.Drawing.Point(50, 575);
            this.Loadbut.Name = "Loadbut";
            this.Loadbut.Size = new System.Drawing.Size(223, 59);
            this.Loadbut.TabIndex = 14;
            this.Loadbut.Text = "Load";
            this.Loadbut.UseVisualStyleBackColor = false;
            this.Loadbut.Click += new System.EventHandler(this.Loadbut_Click);
            // 
            // PreviousNotes
            // 
            this.PreviousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PreviousNotes.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.PreviousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousNotes.Location = new System.Drawing.Point(50, 28);
            this.PreviousNotes.Name = "PreviousNotes";
            this.PreviousNotes.RowHeadersWidth = 51;
            this.PreviousNotes.RowTemplate.Height = 24;
            this.PreviousNotes.Size = new System.Drawing.Size(481, 506);
            this.PreviousNotes.TabIndex = 13;
            this.PreviousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PreviousNotes_CellDoubleClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Note :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notebx
            // 
            this.Notebx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notebx.Location = new System.Drawing.Point(541, 138);
            this.Notebx.Multiline = true;
            this.Notebx.Name = "Notebx";
            this.Notebx.Size = new System.Drawing.Size(567, 577);
            this.Notebx.TabIndex = 10;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(541, 57);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(567, 34);
            this.Title.TabIndex = 9;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 742);
            this.Controls.Add(this.newbut);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.delbut);
            this.Controls.Add(this.Loadbut);
            this.Controls.Add(this.PreviousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Notebx);
            this.Controls.Add(this.Title);
            this.Name = "Note";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Note_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Button delbut;
        private System.Windows.Forms.Button Loadbut;
        private System.Windows.Forms.DataGridView PreviousNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Notebx;
        private System.Windows.Forms.TextBox Title;
    }
}