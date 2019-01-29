namespace polimorfismo
{
    partial class Form1
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
            this.cmd_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_Play
            // 
            this.cmd_Play.Location = new System.Drawing.Point(110, 206);
            this.cmd_Play.Name = "cmd_Play";
            this.cmd_Play.Size = new System.Drawing.Size(75, 23);
            this.cmd_Play.TabIndex = 0;
            this.cmd_Play.Text = "Executar";
            this.cmd_Play.UseVisualStyleBackColor = true;
            this.cmd_Play.Click += new System.EventHandler(this.cmd_Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmd_Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Play;
    }
}

