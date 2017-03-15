namespace ExportDataToOfficeApp
{
    partial class NewCarDialog
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
            this.btnSubmitCarDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textColor = new System.Windows.Forms.TextBox();
            this.textMake = new System.Windows.Forms.TextBox();
            this.textPetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmitCarDialog
            // 
            this.btnSubmitCarDialog.Location = new System.Drawing.Point(59, 191);
            this.btnSubmitCarDialog.Name = "btnSubmitCarDialog";
            this.btnSubmitCarDialog.Size = new System.Drawing.Size(146, 36);
            this.btnSubmitCarDialog.TabIndex = 0;
            this.btnSubmitCarDialog.Text = "Submit";
            this.btnSubmitCarDialog.UseVisualStyleBackColor = true;
            this.btnSubmitCarDialog.Click += new System.EventHandler(this.BtnSubmitCarDialog_Click);
            this.btnSubmitCarDialog.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(25, 37);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(220, 20);
            this.textColor.TabIndex = 2;
            // 
            // textMake
            // 
            this.textMake.Location = new System.Drawing.Point(26, 91);
            this.textMake.Name = "textMade";
            this.textMake.Size = new System.Drawing.Size(219, 20);
            this.textMake.TabIndex = 3;
            // 
            // textPetName
            // 
            this.textPetName.Location = new System.Drawing.Point(25, 148);
            this.textPetName.Name = "textPetName";
            this.textPetName.Size = new System.Drawing.Size(218, 20);
            this.textPetName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Made";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PetName";
            // 
            // NewCarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPetName);
            this.Controls.Add(this.textMake);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitCarDialog);
            this.Name = "NewCarDialog";
            this.Text = "NewCarDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitCarDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.TextBox textMake;
        private System.Windows.Forms.TextBox textPetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}