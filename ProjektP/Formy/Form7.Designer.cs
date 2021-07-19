
namespace ProjektP.Formy
{
    partial class Form7
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
            this.textBoxLogin1 = new System.Windows.Forms.TextBox();
            this.TextBoxHaslo1 = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxImie = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxNazwisko = new System.Windows.Forms.MaskedTextBox();
            this.labelLogin1 = new System.Windows.Forms.Label();
            this.labelHaslo1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin1
            // 
            this.textBoxLogin1.Location = new System.Drawing.Point(183, 235);
            this.textBoxLogin1.Name = "textBoxLogin1";
            this.textBoxLogin1.Size = new System.Drawing.Size(144, 22);
            this.textBoxLogin1.TabIndex = 0;
            // 
            // TextBoxHaslo1
            // 
            this.TextBoxHaslo1.Location = new System.Drawing.Point(183, 316);
            this.TextBoxHaslo1.Name = "TextBoxHaslo1";
            this.TextBoxHaslo1.Size = new System.Drawing.Size(144, 22);
            this.TextBoxHaslo1.TabIndex = 1;
            // 
            // TextBoxImie
            // 
            this.TextBoxImie.Location = new System.Drawing.Point(183, 399);
            this.TextBoxImie.Name = "TextBoxImie";
            this.TextBoxImie.Size = new System.Drawing.Size(141, 22);
            this.TextBoxImie.TabIndex = 2;
            // 
            // TextBoxNazwisko
            // 
            this.TextBoxNazwisko.Location = new System.Drawing.Point(183, 480);
            this.TextBoxNazwisko.Name = "TextBoxNazwisko";
            this.TextBoxNazwisko.Size = new System.Drawing.Size(144, 22);
            this.TextBoxNazwisko.TabIndex = 3;
            // 
            // labelLogin1
            // 
            this.labelLogin1.AutoSize = true;
            this.labelLogin1.Location = new System.Drawing.Point(46, 240);
            this.labelLogin1.Name = "labelLogin1";
            this.labelLogin1.Size = new System.Drawing.Size(43, 17);
            this.labelLogin1.TabIndex = 4;
            this.labelLogin1.Text = "Login";
            // 
            // labelHaslo1
            // 
            this.labelHaslo1.AutoSize = true;
            this.labelHaslo1.Location = new System.Drawing.Point(46, 316);
            this.labelHaslo1.Name = "labelHaslo1";
            this.labelHaslo1.Size = new System.Drawing.Size(44, 17);
            this.labelHaslo1.TabIndex = 5;
            this.labelHaslo1.Text = "Hasło";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(453, 543);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 31);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(46, 404);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(33, 17);
            this.labelImie.TabIndex = 7;
            this.labelImie.Text = "Imie";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(45, 483);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(67, 17);
            this.labelNazwisko.TabIndex = 8;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 643);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHaslo1);
            this.Controls.Add(this.labelLogin1);
            this.Controls.Add(this.TextBoxNazwisko);
            this.Controls.Add(this.TextBoxImie);
            this.Controls.Add(this.TextBoxHaslo1);
            this.Controls.Add(this.textBoxLogin1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin1;
        private System.Windows.Forms.MaskedTextBox TextBoxHaslo1;
        private System.Windows.Forms.MaskedTextBox TextBoxImie;
        private System.Windows.Forms.MaskedTextBox TextBoxNazwisko;
        private System.Windows.Forms.Label labelLogin1;
        private System.Windows.Forms.Label labelHaslo1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
    }
}