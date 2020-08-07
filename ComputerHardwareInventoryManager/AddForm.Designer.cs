namespace ComputerHardwareInventoryManager
{
    partial class AddForm
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
            this.subButt = new System.Windows.Forms.Button();
            this.exitButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.manufacturerTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subButt
            // 
            this.subButt.Location = new System.Drawing.Point(15, 246);
            this.subButt.Name = "subButt";
            this.subButt.Size = new System.Drawing.Size(75, 23);
            this.subButt.TabIndex = 0;
            this.subButt.Text = "Submit";
            this.subButt.UseVisualStyleBackColor = true;
            this.subButt.Click += new System.EventHandler(this.subButt_Click);
            // 
            // exitButt
            // 
            this.exitButt.Location = new System.Drawing.Point(212, 246);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(75, 23);
            this.exitButt.TabIndex = 1;
            this.exitButt.Text = "Cancel";
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // manufacturerTxt
            // 
            this.manufacturerTxt.Location = new System.Drawing.Point(148, 19);
            this.manufacturerTxt.Name = "manufacturerTxt";
            this.manufacturerTxt.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTxt.TabIndex = 7;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(148, 58);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 8;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(148, 105);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(100, 20);
            this.descriptionTxt.TabIndex = 9;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(148, 148);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 10;
            // 
            // AddForm
            // 
            this.AcceptButton = this.subButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButt;
            this.ClientSize = new System.Drawing.Size(299, 281);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.manufacturerTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButt);
            this.Controls.Add(this.subButt);
            this.Name = "AddForm";
            this.Text = "Hardware Product";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subButt;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manufacturerTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox priceTxt;
    }
}