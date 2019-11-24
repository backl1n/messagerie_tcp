namespace client_messagerie_tcp
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
            this.inscription = new System.Windows.Forms.Button();
            this.connection = new System.Windows.Forms.Button();
            this.adresse_mail = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inscription
            // 
            this.inscription.Location = new System.Drawing.Point(19, 144);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(133, 31);
            this.inscription.TabIndex = 0;
            this.inscription.Text = "s\'incrire";
            this.inscription.UseVisualStyleBackColor = true;
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(341, 147);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(128, 27);
            this.connection.TabIndex = 1;
            this.connection.Text = "se connecter";
            this.connection.UseVisualStyleBackColor = true;
            // 
            // adresse_mail
            // 
            this.adresse_mail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adresse_mail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.adresse_mail.Location = new System.Drawing.Point(23, 44);
            this.adresse_mail.Name = "adresse_mail";
            this.adresse_mail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adresse_mail.Size = new System.Drawing.Size(424, 20);
            this.adresse_mail.TabIndex = 2;
            this.adresse_mail.Text = "adresse mail";
            this.adresse_mail.WordWrap = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(19, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(425, 20);
            this.password.TabIndex = 3;
            this.password.TabStop = false;
            this.password.Text = "password";
            this.password.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 183);
            this.Controls.Add(this.password);
            this.Controls.Add(this.adresse_mail);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.inscription);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.TextBox adresse_mail;
        private System.Windows.Forms.TextBox password;
    }
}