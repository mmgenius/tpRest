namespace ClientRest
{
    partial class AddService
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(127, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(177, 20);
            this.textBoxId.TabIndex = 2;
           
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(127, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 3;
          
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(183, 63);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUser.TabIndex = 4;
          
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 19);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(92, 13);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Identifiant Service";
   
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Location = new System.Drawing.Point(12, 45);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(68, 13);
            this.labelnom.TabIndex = 6;
            this.labelnom.Text = "Nom Service";
        
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(12, 71);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(53, 13);
            this.labeluser.TabIndex = 7;
            this.labeluser.Text = "Utilisateur";
           
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 153);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(334, 192);
            this.MinimumSize = new System.Drawing.Size(334, 192);
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label labeluser;
    }
}