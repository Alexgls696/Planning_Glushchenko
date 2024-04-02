namespace Planning_Glushchenko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_text = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(582, 640);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(615, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(137, 47);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            // 
            // remove_button
            // 
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Location = new System.Drawing.Point(615, 65);
            this.remove_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(137, 47);
            this.remove_button.TabIndex = 2;
            this.remove_button.Text = "Удалить";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.info_text);
            this.panel1.Location = new System.Drawing.Point(620, 188);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.MaximumSize = new System.Drawing.Size(286, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 453);
            this.panel1.TabIndex = 3;
            // 
            // info_text
            // 
            this.info_text.AutoSize = true;
            this.info_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info_text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info_text.Location = new System.Drawing.Point(8, 9);
            this.info_text.MaximumSize = new System.Drawing.Size(251, 1333);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(49, 30);
            this.info_text.TabIndex = 0;
            this.info_text.Text = "text";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(686, 152);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(157, 32);
            this.info.TabIndex = 4;
            this.info.Text = "Инструкция";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(615, 120);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(34, 20);
            this.error_label.TabIndex = 5;
            this.error_label.Text = "text";
            this.error_label.Visible = false;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.time_label.Location = new System.Drawing.Point(759, 20);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(147, 25);
            this.time_label.TabIndex = 6;
            this.time_label.Text = "Текущее время";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(946, 667);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button add;
        private Button remove_button;
        private Panel panel1;
        private Label info_text;
        private Label info;
        private Label error_label;
        private Label time_label;
    }
}