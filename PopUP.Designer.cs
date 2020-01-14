namespace SFDXUI
{
    partial class PopUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUP));
            this.Create = new ePOSOne.btnProduct.Class1();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new ePOSOne.btnProduct.Class1();
            this.Directory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_Directory = new ePOSOne.btnProduct.Class1();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.Black;
            this.Create.BorderColor = System.Drawing.Color.Orange;
            this.Create.ButtonColor = System.Drawing.Color.Black;
            this.Create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(525, 12);
            this.Create.Name = "Create";
            this.Create.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.Create.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.Create.OnHoverTextColor = System.Drawing.Color.Black;
            this.Create.Size = new System.Drawing.Size(186, 82);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.TextColor = System.Drawing.Color.White;
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // projectNameText
            // 
            this.projectNameText.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameText.Location = new System.Drawing.Point(12, 54);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(496, 47);
            this.projectNameText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project Name";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Black;
            this.Cancel.BorderColor = System.Drawing.Color.Orange;
            this.Cancel.ButtonColor = System.Drawing.Color.Black;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(740, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.Cancel.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.Cancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.Cancel.Size = new System.Drawing.Size(186, 82);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.TextColor = System.Drawing.Color.White;
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // Directory
            // 
            this.Directory.AutoSize = true;
            this.Directory.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory.ForeColor = System.Drawing.Color.White;
            this.Directory.Location = new System.Drawing.Point(102, 117);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(236, 48);
            this.Directory.TabIndex = 6;
            this.Directory.Text = "Directory";
            this.Directory.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "D:/code/test";
            // 
            // Change_Directory
            // 
            this.Change_Directory.BackColor = System.Drawing.Color.Black;
            this.Change_Directory.BorderColor = System.Drawing.Color.Orange;
            this.Change_Directory.ButtonColor = System.Drawing.Color.Black;
            this.Change_Directory.FlatAppearance.BorderSize = 0;
            this.Change_Directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Directory.Font = new System.Drawing.Font("Unispace", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Directory.Location = new System.Drawing.Point(525, 117);
            this.Change_Directory.Name = "Change_Directory";
            this.Change_Directory.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.Change_Directory.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.Change_Directory.OnHoverTextColor = System.Drawing.Color.Black;
            this.Change_Directory.Size = new System.Drawing.Size(401, 86);
            this.Change_Directory.TabIndex = 8;
            this.Change_Directory.Text = "Change Directory";
            this.Change_Directory.TextColor = System.Drawing.Color.White;
            this.Change_Directory.UseVisualStyleBackColor = false;
            this.Change_Directory.Click += new System.EventHandler(this.Change_Directory_Click);
            // 
            // PopUP
            // 
            this.AcceptButton = this.Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(936, 239);
            this.ControlBox = false;
            this.Controls.Add(this.Change_Directory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.Create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUP";
            this.ShowInTaskbar = false;
            this.Text = "Create Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Class1 Create;
        private System.Windows.Forms.TextBox projectNameText;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Class1 Cancel;
        private System.Windows.Forms.Label Directory;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Class1 Change_Directory;
    }
}