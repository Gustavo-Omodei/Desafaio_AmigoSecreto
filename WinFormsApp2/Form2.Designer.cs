namespace WinFormsApp2
{
    partial class Form2
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
            button_Cadastrar = new Button();
            label_Nome = new Label();
            label_Email = new Label();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            button_Limpar = new Button();
            listView_Nomes = new ListView();
            Nome = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            button_verLista = new Button();
            SuspendLayout();
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(499, 40);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(156, 50);
            button_Cadastrar.TabIndex = 0;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(44, 9);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(142, 25);
            label_Nome.TabIndex = 1;
            label_Nome.Text = "Nome completo";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(44, 113);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(54, 25);
            label_Email.TabIndex = 2;
            label_Email.Text = "Email";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(44, 50);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(317, 31);
            textBox_Nome.TabIndex = 3;
            textBox_Nome.KeyPress += textBox1_KeyPress;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(44, 156);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(317, 31);
            textBox_Email.TabIndex = 4;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            // 
            // button_Limpar
            // 
            button_Limpar.Location = new Point(499, 113);
            button_Limpar.Name = "button_Limpar";
            button_Limpar.Size = new Size(156, 50);
            button_Limpar.TabIndex = 5;
            button_Limpar.Text = "Limpar";
            button_Limpar.UseVisualStyleBackColor = true;
            button_Limpar.Click += button_Limpar_Click;
            // 
            // listView_Nomes
            // 
            listView_Nomes.BackColor = SystemColors.ButtonFace;
            listView_Nomes.Columns.AddRange(new ColumnHeader[] { Nome, columnHeader2 });
            listView_Nomes.Location = new Point(44, 261);
            listView_Nomes.Name = "listView_Nomes";
            listView_Nomes.RightToLeft = RightToLeft.No;
            listView_Nomes.Size = new Size(687, 619);
            listView_Nomes.TabIndex = 6;
            listView_Nomes.UseCompatibleStateImageBehavior = false;
            listView_Nomes.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Email";
            columnHeader2.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 215);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 7;
            label1.Text = "Amigos cadastrados";
            // 
            // button_verLista
            // 
            button_verLista.Location = new Point(499, 181);
            button_verLista.Name = "button_verLista";
            button_verLista.Size = new Size(156, 50);
            button_verLista.TabIndex = 8;
            button_verLista.Text = "Ver Lista Secreta";
            button_verLista.UseVisualStyleBackColor = true;
            button_verLista.Click += button_verLista_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Animal_Crossing_iPhone_wallpaper_Matt_MacPherson_iDownloadblog_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 938);
            Controls.Add(button_verLista);
            Controls.Add(label1);
            Controls.Add(listView_Nomes);
            Controls.Add(button_Limpar);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Nome);
            Controls.Add(label_Email);
            Controls.Add(label_Nome);
            Controls.Add(button_Cadastrar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cadastrar;
        private Label label_Nome;
        private Label label_Email;
        private TextBox textBox_Nome;
        private TextBox textBox_Email;
        private Button button_Limpar;
        private ListView listView_Nomes;
        private Label label1;
        private Button button_verLista;
        private ColumnHeader Nome;
        private ColumnHeader columnHeader2;
    }
}