namespace Kontrolka
{
    partial class CommunicationControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.portNasluchuj = new System.Windows.Forms.TextBox();
            this.adresWyslij = new System.Windows.Forms.TextBox();
            this.portWyslij = new System.Windows.Forms.TextBox();
            this.nasluchuj = new System.Windows.Forms.Button();
            this.wyslij = new System.Windows.Forms.Button();
            this.klientText = new System.Windows.Forms.RichTextBox();
            this.serwerText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // portNasluchuj
            // 
            this.portNasluchuj.Location = new System.Drawing.Point(37, 32);
            this.portNasluchuj.Name = "portNasluchuj";
            this.portNasluchuj.Size = new System.Drawing.Size(136, 20);
            this.portNasluchuj.TabIndex = 0;
            // 
            // adresWyslij
            // 
            this.adresWyslij.Location = new System.Drawing.Point(361, 32);
            this.adresWyslij.Name = "adresWyslij";
            this.adresWyslij.Size = new System.Drawing.Size(123, 20);
            this.adresWyslij.TabIndex = 1;
            // 
            // portWyslij
            // 
            this.portWyslij.Location = new System.Drawing.Point(361, 58);
            this.portWyslij.Name = "portWyslij";
            this.portWyslij.Size = new System.Drawing.Size(123, 20);
            this.portWyslij.TabIndex = 2;
            // 
            // nasluchuj
            // 
            this.nasluchuj.Location = new System.Drawing.Point(198, 31);
            this.nasluchuj.Name = "nasluchuj";
            this.nasluchuj.Size = new System.Drawing.Size(75, 23);
            this.nasluchuj.TabIndex = 3;
            this.nasluchuj.Text = "Nasłuchuj";
            this.nasluchuj.UseVisualStyleBackColor = true;
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(512, 31);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(81, 23);
            this.wyslij.TabIndex = 4;
            this.wyslij.Text = "Wyślij";
            this.wyslij.UseVisualStyleBackColor = true;
            // 
            // klientText
            // 
            this.klientText.Location = new System.Drawing.Point(37, 85);
            this.klientText.Name = "klientText";
            this.klientText.Size = new System.Drawing.Size(236, 290);
            this.klientText.TabIndex = 5;
            this.klientText.Text = "";
            // 
            // serwerText
            // 
            this.serwerText.Location = new System.Drawing.Point(361, 85);
            this.serwerText.Name = "serwerText";
            this.serwerText.Size = new System.Drawing.Size(232, 290);
            this.serwerText.TabIndex = 6;
            this.serwerText.Text = "";
            // 
            // CommunicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serwerText);
            this.Controls.Add(this.klientText);
            this.Controls.Add(this.wyslij);
            this.Controls.Add(this.nasluchuj);
            this.Controls.Add(this.portWyslij);
            this.Controls.Add(this.adresWyslij);
            this.Controls.Add(this.portNasluchuj);
            this.Name = "CommunicationControl";
            this.Size = new System.Drawing.Size(633, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portNasluchuj;
        private System.Windows.Forms.TextBox adresWyslij;
        private System.Windows.Forms.TextBox portWyslij;
        private System.Windows.Forms.Button nasluchuj;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.RichTextBox klientText;
        private System.Windows.Forms.RichTextBox serwerText;
    }
}
