namespace ComputerHardwareInventoryManager
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
            this.addbutt = new System.Windows.Forms.Button();
            this.deletebutt = new System.Windows.Forms.Button();
            this.editbutt = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbutt
            // 
            this.addbutt.Location = new System.Drawing.Point(13, 415);
            this.addbutt.Name = "addbutt";
            this.addbutt.Size = new System.Drawing.Size(75, 23);
            this.addbutt.TabIndex = 0;
            this.addbutt.Text = "Add Item";
            this.addbutt.UseVisualStyleBackColor = true;
            this.addbutt.Click += new System.EventHandler(this.addbutt_Click);
            // 
            // deletebutt
            // 
            this.deletebutt.Location = new System.Drawing.Point(713, 415);
            this.deletebutt.Name = "deletebutt";
            this.deletebutt.Size = new System.Drawing.Size(75, 23);
            this.deletebutt.TabIndex = 1;
            this.deletebutt.Text = "Delete Item";
            this.deletebutt.UseVisualStyleBackColor = true;
            this.deletebutt.Click += new System.EventHandler(this.deletebutt_Click);
            // 
            // editbutt
            // 
            this.editbutt.Location = new System.Drawing.Point(375, 415);
            this.editbutt.Name = "editbutt";
            this.editbutt.Size = new System.Drawing.Size(75, 23);
            this.editbutt.TabIndex = 2;
            this.editbutt.Text = "Edit Item";
            this.editbutt.UseVisualStyleBackColor = true;
            this.editbutt.Click += new System.EventHandler(this.editbutt_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(775, 289);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(334, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(116, 13);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Inventory Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.editbutt);
            this.Controls.Add(this.deletebutt);
            this.Controls.Add(this.addbutt);
            this.Name = "Form1";
            this.Text = "Computer Hardware DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutt;
        private System.Windows.Forms.Button deletebutt;
        private System.Windows.Forms.Button editbutt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblHeader;
    }
}

