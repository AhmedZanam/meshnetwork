namespace Mesh_Network
{
    partial class MessageText
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
            this.btnSenden = new System.Windows.Forms.Button();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbEmpfanger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(136, 107);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 23);
            this.btnSenden.TabIndex = 0;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Location = new System.Drawing.Point(217, 107);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(75, 23);
            this.btnAbbruch.TabIndex = 1;
            this.btnAbbruch.Text = "Abbruch";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            this.btnAbbruch.Click += new System.EventHandler(this.btnAbbruch_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 21);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(280, 20);
            this.tbText.TabIndex = 2;
            // 
            // tbEmpfanger
            // 
            this.tbEmpfanger.Location = new System.Drawing.Point(12, 68);
            this.tbEmpfanger.Name = "tbEmpfanger";
            this.tbEmpfanger.Size = new System.Drawing.Size(280, 20);
            this.tbEmpfanger.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empfanger";
            // 
            // MessageText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmpfanger);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.btnSenden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageText";
            this.Text = "Text senden";
            this.Load += new System.EventHandler(this.MessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.Button btnAbbruch;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbEmpfanger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}