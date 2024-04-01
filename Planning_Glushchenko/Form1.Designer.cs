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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            add = new Button();
            remove_button = new Button();
            panel1 = new Panel();
            info_text = new Label();
            info = new Label();
            error_label = new Label();
            time_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 80;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(682, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // add
            // 
            add.FlatStyle = FlatStyle.Flat;
            add.Location = new Point(698, 9);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Size = new Size(120, 35);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove_button
            // 
            remove_button.FlatStyle = FlatStyle.Flat;
            remove_button.Location = new Point(698, 49);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(120, 35);
            remove_button.TabIndex = 2;
            remove_button.Text = "Удалить";
            remove_button.UseVisualStyleBackColor = true;
            remove_button.Click += remove_button_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(info_text);
            panel1.Location = new Point(701, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 340);
            panel1.TabIndex = 3;
            // 
            // info_text
            // 
            info_text.AutoSize = true;
            info_text.BorderStyle = BorderStyle.FixedSingle;
            info_text.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            info_text.Location = new Point(7, 7);
            info_text.MaximumSize = new Size(225, 0);
            info_text.Name = "info_text";
            info_text.Size = new Size(223, 527);
            info_text.TabIndex = 0;
            info_text.Text = resources.GetString("info_text.Text");
            // 
            // info
            // 
            info.AutoSize = true;
            info.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            info.Location = new Point(767, 108);
            info.Name = "info";
            info.Size = new Size(125, 25);
            info.TabIndex = 4;
            info.Text = "Инструкция";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(698, 90);
            error_label.Name = "error_label";
            error_label.Size = new Size(27, 15);
            error_label.TabIndex = 5;
            error_label.Text = "text";
            error_label.Visible = false;
            // 
            // time_label
            // 
            time_label.AutoSize = true;
            time_label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            time_label.Location = new Point(824, 15);
            time_label.Name = "time_label";
            time_label.Size = new Size(117, 20);
            time_label.TabIndex = 6;
            time_label.Text = "Текущее время";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(963, 500);
            Controls.Add(time_label);
            Controls.Add(error_label);
            Controls.Add(info);
            Controls.Add(panel1);
            Controls.Add(remove_button);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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