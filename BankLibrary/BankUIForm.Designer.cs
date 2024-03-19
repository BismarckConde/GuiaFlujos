namespace BankLibrary
{
    partial class BankUIForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtaccount = new TextBox();
            txtfirstName = new TextBox();
            txtlastName = new TextBox();
            txtBalance = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 120);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 178);
            label2.Name = "label2";
            label2.Size = new Size(151, 24);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 235);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 291);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 3;
            label4.Text = "Saldo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(143, 38);
            label5.Name = "label5";
            label5.Size = new Size(213, 35);
            label5.TabIndex = 4;
            label5.Text = "Registro Banco ";
            // 
            // txtaccount
            // 
            txtaccount.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtaccount.Location = new Point(237, 120);
            txtaccount.Name = "txtaccount";
            txtaccount.Size = new Size(100, 27);
            txtaccount.TabIndex = 5;
            // 
            // txtfirstName
            // 
            txtfirstName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtfirstName.Location = new Point(237, 178);
            txtfirstName.Name = "txtfirstName";
            txtfirstName.Size = new Size(100, 27);
            txtfirstName.TabIndex = 6;
            // 
            // txtlastName
            // 
            txtlastName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtlastName.Location = new Point(237, 232);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(100, 27);
            txtlastName.TabIndex = 7;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBalance.Location = new Point(237, 291);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 27);
            txtBalance.TabIndex = 8;
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 383);
            Controls.Add(txtBalance);
            Controls.Add(txtlastName);
            Controls.Add(txtfirstName);
            Controls.Add(txtaccount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BankUIForm";
            Text = "BankUIForm";
            Load += BankUIForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtaccount;
        private TextBox txtfirstName;
        private TextBox txtlastName;
        private TextBox txtBalance;
    }
}