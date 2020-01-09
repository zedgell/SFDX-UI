namespace SFDXUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Logout = new ePOSOne.btnProduct.Class1();
            this.Login = new ePOSOne.btnProduct.Class1();
            this.FolderSelect = new ePOSOne.btnProduct.Class1();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(337, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = global::SFDXUI.Properties.Settings.Default.Test;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Black;
            this.Logout.BorderColor = System.Drawing.Color.Orange;
            this.Logout.ButtonColor = System.Drawing.Color.Black;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(602, 12);
            this.Logout.Name = "Logout";
            this.Logout.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.Logout.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.Logout.OnHoverTextColor = System.Drawing.Color.Black;
            this.Logout.Size = new System.Drawing.Size(186, 81);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.TextColor = System.Drawing.Color.White;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Class11_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.BorderColor = System.Drawing.Color.Orange;
            this.Login.ButtonColor = System.Drawing.Color.Black;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(12, 12);
            this.Login.Name = "Login";
            this.Login.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.Login.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.Login.OnHoverTextColor = System.Drawing.Color.Black;
            this.Login.Size = new System.Drawing.Size(186, 81);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.TextColor = System.Drawing.Color.White;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // FolderSelect
            // 
            this.FolderSelect.BackColor = System.Drawing.Color.Black;
            this.FolderSelect.BorderColor = System.Drawing.Color.Orange;
            this.FolderSelect.ButtonColor = System.Drawing.Color.Black;
            this.FolderSelect.FlatAppearance.BorderSize = 0;
            this.FolderSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderSelect.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSelect.Location = new System.Drawing.Point(302, 12);
            this.FolderSelect.Name = "FolderSelect";
            this.FolderSelect.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.FolderSelect.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.FolderSelect.OnHoverTextColor = System.Drawing.Color.Black;
            this.FolderSelect.Size = new System.Drawing.Size(186, 81);
            this.FolderSelect.TabIndex = 4;
            this.FolderSelect.Text = "Select Folder";
            this.FolderSelect.TextColor = System.Drawing.Color.White;
            this.FolderSelect.UseVisualStyleBackColor = false;
            this.FolderSelect.Click += new System.EventHandler(this.FolderSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.FolderSelect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SFDX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ePOSOne.btnProduct.Class1 Login;
        private ePOSOne.btnProduct.Class1 Logout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ePOSOne.btnProduct.Class1 FolderSelect;
    }
}

