namespace WinFormsApp2
{
    partial class Form3
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
            listView1 = new ListView();
            Nome = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Nome, columnHeader2 });
            listView1.ForeColor = SystemColors.WindowText;
            listView1.Location = new Point(38, 46);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(312, 345);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Esse";
            Nome.Width = 450;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView2.Location = new Point(463, 46);
            listView2.Margin = new Padding(2, 2, 2, 2);
            listView2.Name = "listView2";
            listView2.Scrollable = false;
            listView2.Size = new Size(312, 345);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Pega Esse";
            columnHeader1.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 2;
            label1.Text = "Esse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(577, 11);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 3;
            label2.Text = "Tirou esse";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Animal_Crossing_iPhone_wallpaper_Matt_MacPherson_iDownloadblog_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 458);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView2;
        private ColumnHeader Nome;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView1;
        private Label label1;
        private Label label2;
    }
}