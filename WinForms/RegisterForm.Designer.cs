
namespace Register
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.confirm_label = new System.Windows.Forms.Label();
            this.show_pass_checkBox = new System.Windows.Forms.CheckBox();
            this.show_confirm_checkBox = new System.Windows.Forms.CheckBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.confirm_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.register_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 455);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.Controls.Add(this.username_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.password_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.confirm_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.show_pass_checkBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.show_confirm_checkBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.password_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.confirm_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.username_textBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_label.Location = new System.Drawing.Point(3, 41);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(220, 30);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(3, 113);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(220, 113);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm_label
            // 
            this.confirm_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_label.AutoSize = true;
            this.confirm_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_label.Location = new System.Drawing.Point(3, 280);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(220, 30);
            this.confirm_label.TabIndex = 3;
            this.confirm_label.Text = "Confirm Password";
            this.confirm_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_pass_checkBox
            // 
            this.show_pass_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.show_pass_checkBox.AutoSize = true;
            this.show_pass_checkBox.Location = new System.Drawing.Point(455, 160);
            this.show_pass_checkBox.Name = "show_pass_checkBox";
            this.show_pass_checkBox.Size = new System.Drawing.Size(197, 19);
            this.show_pass_checkBox.TabIndex = 4;
            this.show_pass_checkBox.Text = "Show Password";
            this.show_pass_checkBox.UseVisualStyleBackColor = true;
            this.show_pass_checkBox.CheckedChanged += new System.EventHandler(this.show_pass_checkBox_CheckedChanged);
            // 
            // show_confirm_checkBox
            // 
            this.show_confirm_checkBox.AutoSize = true;
            this.show_confirm_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_confirm_checkBox.Location = new System.Drawing.Point(455, 229);
            this.show_confirm_checkBox.Name = "show_confirm_checkBox";
            this.show_confirm_checkBox.Size = new System.Drawing.Size(197, 133);
            this.show_confirm_checkBox.TabIndex = 5;
            this.show_confirm_checkBox.Text = "Show Password";
            this.show_confirm_checkBox.UseVisualStyleBackColor = true;
            this.show_confirm_checkBox.CheckedChanged += new System.EventHandler(this.show_confirm_checkBox_CheckedChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textBox.Location = new System.Drawing.Point(229, 158);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(220, 23);
            this.password_textBox.TabIndex = 6;
            // 
            // confirm_textBox
            // 
            this.confirm_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_textBox.Location = new System.Drawing.Point(229, 284);
            this.confirm_textBox.Name = "confirm_textBox";
            this.confirm_textBox.Size = new System.Drawing.Size(220, 23);
            this.confirm_textBox.TabIndex = 7;
            // 
            // username_textBox
            // 
            this.username_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textBox.Location = new System.Drawing.Point(229, 45);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(220, 23);
            this.username_textBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.register_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 90);
            this.panel2.TabIndex = 1;
            // 
            // register_button
            // 
            this.register_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register_button.Location = new System.Drawing.Point(0, 0);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(655, 90);
            this.register_button.TabIndex = 0;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 455);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label confirm_label;
        private System.Windows.Forms.CheckBox show_pass_checkBox;
        private System.Windows.Forms.CheckBox show_confirm_checkBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox confirm_textBox;
        private System.Windows.Forms.TextBox username_textBox;
    }
}