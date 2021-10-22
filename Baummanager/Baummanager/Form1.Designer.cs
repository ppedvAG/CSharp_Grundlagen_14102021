
namespace Baummanager
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ladenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.jsonRadioButton = new System.Windows.Forms.RadioButton();
            this.excelRadioButton = new System.Windows.Forms.RadioButton();
            this.demoRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.baumDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baumDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.GreenYellow;
            this.flowLayoutPanel1.Controls.Add(this.ladenButton);
            this.flowLayoutPanel1.Controls.Add(this.speichernButton);
            this.flowLayoutPanel1.Controls.Add(this.jsonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.excelRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.demoRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(852, 104);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ladenButton
            // 
            this.ladenButton.AutoSize = true;
            this.ladenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ladenButton.Location = new System.Drawing.Point(3, 3);
            this.ladenButton.Name = "ladenButton";
            this.ladenButton.Size = new System.Drawing.Size(88, 42);
            this.ladenButton.TabIndex = 0;
            this.ladenButton.Text = "Laden";
            this.ladenButton.UseVisualStyleBackColor = true;
            this.ladenButton.Click += new System.EventHandler(this.ladenButton_Click);
            // 
            // speichernButton
            // 
            this.speichernButton.AutoSize = true;
            this.speichernButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speichernButton.Location = new System.Drawing.Point(97, 3);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(130, 42);
            this.speichernButton.TabIndex = 1;
            this.speichernButton.Text = "Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // jsonRadioButton
            // 
            this.jsonRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jsonRadioButton.AutoSize = true;
            this.jsonRadioButton.Location = new System.Drawing.Point(233, 8);
            this.jsonRadioButton.Name = "jsonRadioButton";
            this.jsonRadioButton.Size = new System.Drawing.Size(103, 36);
            this.jsonRadioButton.TabIndex = 2;
            this.jsonRadioButton.Text = "JSON";
            this.jsonRadioButton.UseVisualStyleBackColor = true;
            this.jsonRadioButton.CheckedChanged += new System.EventHandler(this.jsonRadioButton_CheckedChanged);
            // 
            // excelRadioButton
            // 
            this.excelRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.excelRadioButton.AutoSize = true;
            this.excelRadioButton.Location = new System.Drawing.Point(342, 8);
            this.excelRadioButton.Name = "excelRadioButton";
            this.excelRadioButton.Size = new System.Drawing.Size(109, 36);
            this.excelRadioButton.TabIndex = 3;
            this.excelRadioButton.Text = "EXCEL";
            this.excelRadioButton.UseVisualStyleBackColor = true;
            this.excelRadioButton.CheckedChanged += new System.EventHandler(this.excelRadioButton_CheckedChanged);
            // 
            // demoRadioButton
            // 
            this.demoRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.demoRadioButton.AutoSize = true;
            this.demoRadioButton.Checked = true;
            this.demoRadioButton.Location = new System.Drawing.Point(457, 8);
            this.demoRadioButton.Name = "demoRadioButton";
            this.demoRadioButton.Size = new System.Drawing.Size(171, 36);
            this.demoRadioButton.TabIndex = 4;
            this.demoRadioButton.TabStop = true;
            this.demoRadioButton.Text = "Demodaten";
            this.demoRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Linq ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baumDataGridView
            // 
            this.baumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baumDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baumDataGridView.Location = new System.Drawing.Point(0, 104);
            this.baumDataGridView.Name = "baumDataGridView";
            this.baumDataGridView.RowHeadersWidth = 82;
            this.baumDataGridView.RowTemplate.Height = 41;
            this.baumDataGridView.Size = new System.Drawing.Size(852, 437);
            this.baumDataGridView.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Linq  Lambda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 541);
            this.Controls.Add(this.baumDataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baumDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ladenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.RadioButton jsonRadioButton;
        private System.Windows.Forms.RadioButton excelRadioButton;
        private System.Windows.Forms.DataGridView baumDataGridView;
        private System.Windows.Forms.RadioButton demoRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

