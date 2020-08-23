namespace Server_Client
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
            this.ServerButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerButton
            // 
            this.ServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ServerButton.Location = new System.Drawing.Point(61, 68);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(264, 84);
            this.ServerButton.TabIndex = 0;
            this.ServerButton.Text = "Server";
            this.ServerButton.UseVisualStyleBackColor = true;
            this.ServerButton.UseWaitCursor = true;
            this.ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClientButton.Location = new System.Drawing.Point(461, 68);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(264, 84);
            this.ClientButton.TabIndex = 1;
            this.ClientButton.Text = "Client";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.UseWaitCursor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitButton.Location = new System.Drawing.Point(263, 265);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(264, 84);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.UseWaitCursor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.ServerButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ServerButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

