namespace DefaultPrinter
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
            this.ListBoxPrinters = new System.Windows.Forms.ListBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.btnSavePrinterSelection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxPrinters
            // 
            this.ListBoxPrinters.FormattingEnabled = true;
            this.ListBoxPrinters.Location = new System.Drawing.Point(12, 51);
            this.ListBoxPrinters.Name = "ListBoxPrinters";
            this.ListBoxPrinters.Size = new System.Drawing.Size(344, 121);
            this.ListBoxPrinters.TabIndex = 0;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 12);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(344, 33);
            this.TextBoxDescription.TabIndex = 1;
            this.TextBoxDescription.Text = "Bitte wählen Sie aus der Liste der installierten Drucker den neuen Standard Druck" +
    "er aus.";
            // 
            // btnSavePrinterSelection
            // 
            this.btnSavePrinterSelection.Location = new System.Drawing.Point(281, 178);
            this.btnSavePrinterSelection.Name = "btnSavePrinterSelection";
            this.btnSavePrinterSelection.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrinterSelection.TabIndex = 2;
            this.btnSavePrinterSelection.Text = "Speichern";
            this.btnSavePrinterSelection.UseVisualStyleBackColor = true;
            this.btnSavePrinterSelection.Click += new System.EventHandler(this.btnSavePrinterSelection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 207);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSavePrinterSelection);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.ListBoxPrinters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Standard Drucker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxPrinters;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button btnSavePrinterSelection;
        private System.Windows.Forms.Button btnCancel;
    }
}

