namespace Komunikator
{
    partial class Formatka
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
            this.communicationControl1 = new Kontrolka.CommunicationControl();
            this.SuspendLayout();
            // 
            // communicationControl1
            // 
            this.communicationControl1.Location = new System.Drawing.Point(12, 12);
            this.communicationControl1.Name = "communicationControl1";
            this.communicationControl1.Size = new System.Drawing.Size(633, 410);
            this.communicationControl1.TabIndex = 0;
            // 
            // Formatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.communicationControl1);
            this.Name = "Formatka";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrolka.CommunicationControl communicationControl1;

    }
}

