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
            this.FolderSelect = new ePOSOne.btnProduct.Class1();
            this.DevHub = new ePOSOne.btnProduct.Class1();
            this.Login = new ePOSOne.btnProduct.Class1();
            this.CreateProject = new ePOSOne.btnProduct.Class1();
            this.SuspendLayout();
            // 
            // FolderSelect
            // 
            this.FolderSelect.BackColor = System.Drawing.Color.Black;
            this.FolderSelect.BorderColor = System.Drawing.Color.Orange;
            this.FolderSelect.ButtonColor = System.Drawing.Color.Black;
            this.FolderSelect.FlatAppearance.BorderSize = 0;
            this.FolderSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderSelect.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSelect.Location = new System.Drawing.Point(309, 12);
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
            // DevHub
            // 
            this.DevHub.BackColor = System.Drawing.Color.Black;
            this.DevHub.BorderColor = System.Drawing.Color.Orange;
            this.DevHub.ButtonColor = System.Drawing.Color.Black;
            this.DevHub.FlatAppearance.BorderSize = 0;
            this.DevHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevHub.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevHub.Location = new System.Drawing.Point(600, 12);
            this.DevHub.Name = "DevHub";
            this.DevHub.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.DevHub.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.DevHub.OnHoverTextColor = System.Drawing.Color.Black;
            this.DevHub.Size = new System.Drawing.Size(186, 81);
            this.DevHub.TabIndex = 2;
            this.DevHub.Text = "Dev Hub";
            this.DevHub.TextColor = System.Drawing.Color.White;
            this.DevHub.UseVisualStyleBackColor = false;
            this.DevHub.Click += new System.EventHandler(this.Class11_Click);
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
            // CreateProject
            // 
            this.CreateProject.BackColor = System.Drawing.Color.Black;
            this.CreateProject.BorderColor = System.Drawing.Color.Orange;
            this.CreateProject.ButtonColor = System.Drawing.Color.Black;
            this.CreateProject.FlatAppearance.BorderSize = 0;
            this.CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProject.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.Location = new System.Drawing.Point(12, 363);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.CreateProject.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.CreateProject.OnHoverTextColor = System.Drawing.Color.Black;
            this.CreateProject.Size = new System.Drawing.Size(186, 81);
            this.CreateProject.TabIndex = 5;
            this.CreateProject.Text = "Create Project";
            this.CreateProject.TextColor = System.Drawing.Color.White;
            this.CreateProject.UseVisualStyleBackColor = false;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(798, 456);
            this.Controls.Add(this.CreateProject);
            this.Controls.Add(this.FolderSelect);
            this.Controls.Add(this.DevHub);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SFDX";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ePOSOne.btnProduct.Class1 Login;
        private ePOSOne.btnProduct.Class1 DevHub;
        private ePOSOne.btnProduct.Class1 FolderSelect;
        private ePOSOne.btnProduct.Class1 CreateProject;
    }
}

