namespace Server_Client
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
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoTextBox = new System.Windows.Forms.Label();
            this.ShutDownBtuu = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StaerServerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CliearButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PortTextBox);
            this.panel1.Controls.Add(this.ServerIPTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LoTextBox);
            this.panel1.Controls.Add(this.ShutDownBtuu);
            this.panel1.Controls.Add(this.RestartButton);
            this.panel1.Controls.Add(this.StaerServerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 152);
            this.panel1.TabIndex = 0;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(124, 79);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(39, 20);
            this.PortTextBox.TabIndex = 7;
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(124, 38);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.ReadOnly = true;
            this.ServerIPTextBox.Size = new System.Drawing.Size(83, 20);
            this.ServerIPTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(78, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(41, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Server IP";
            // 
            // LoTextBox
            // 
            this.LoTextBox.AutoSize = true;
            this.LoTextBox.Location = new System.Drawing.Point(519, 71);
            this.LoTextBox.Name = "LoTextBox";
            this.LoTextBox.Size = new System.Drawing.Size(0, 13);
            this.LoTextBox.TabIndex = 3;
            // 
            // ShutDownBtuu
            // 
            this.ShutDownBtuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ShutDownBtuu.Location = new System.Drawing.Point(677, 102);
            this.ShutDownBtuu.Name = "ShutDownBtuu";
            this.ShutDownBtuu.Size = new System.Drawing.Size(198, 39);
            this.ShutDownBtuu.TabIndex = 2;
            this.ShutDownBtuu.Text = "Shutdown ";
            this.ShutDownBtuu.UseVisualStyleBackColor = true;
            this.ShutDownBtuu.Click += new System.EventHandler(this.ShutDownBtuu_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RestartButton.Location = new System.Drawing.Point(677, 57);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(198, 39);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StaerServerButton
            // 
            this.StaerServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StaerServerButton.Location = new System.Drawing.Point(677, 12);
            this.StaerServerButton.Name = "StaerServerButton";
            this.StaerServerButton.Size = new System.Drawing.Size(198, 39);
            this.StaerServerButton.TabIndex = 0;
            this.StaerServerButton.Text = "Start Server";
            this.StaerServerButton.UseVisualStyleBackColor = true;
            this.StaerServerButton.Click += new System.EventHandler(this.StaerServerButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 475);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 472);
            this.listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.CliearButton);
            this.panel3.Controls.Add(this.SendButton);
            this.panel3.Controls.Add(this.SendTextBox);
            this.panel3.Controls.Add(this.ChatTextBox);
            this.panel3.Location = new System.Drawing.Point(200, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 475);
            this.panel3.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitButton.Location = new System.Drawing.Point(561, 438);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 25);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CliearButton
            // 
            this.CliearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CliearButton.Location = new System.Drawing.Point(3, 407);
            this.CliearButton.Name = "CliearButton";
            this.CliearButton.Size = new System.Drawing.Size(123, 25);
            this.CliearButton.TabIndex = 4;
            this.CliearButton.Text = "Clear";
            this.CliearButton.UseVisualStyleBackColor = true;
            this.CliearButton.Click += new System.EventHandler(this.CliearButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendButton.Location = new System.Drawing.Point(249, 424);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(198, 39);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendTextBox.Location = new System.Drawing.Point(3, 381);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(684, 20);
            this.SendTextBox.TabIndex = 1;
            this.SendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatTextBox.Location = new System.Drawing.Point(3, 3);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.Size = new System.Drawing.Size(684, 372);
            this.ChatTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(209, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chat";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LoTextBox;
        private System.Windows.Forms.Button ShutDownBtuu;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button StaerServerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CliearButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}