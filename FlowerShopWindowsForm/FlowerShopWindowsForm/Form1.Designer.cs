namespace FlowerShopWindowsForm
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
            this.labelHello = new System.Windows.Forms.Label();
            this.comboBox_Flori = new System.Windows.Forms.ComboBox();
            this.label_Flori = new System.Windows.Forms.Label();
            this.label_Cantitate_Flori = new System.Windows.Forms.Label();
            this.textBox_Cantitate_Flori = new System.Windows.Forms.TextBox();
            this.label_Materiale = new System.Windows.Forms.Label();
            this.label_Cantitate_Materiale = new System.Windows.Forms.Label();
            this.comboBox_Materiale = new System.Windows.Forms.ComboBox();
            this.textBox_Cantitate_Materiale = new System.Windows.Forms.TextBox();
            this.label_Lista_Optiuni = new System.Windows.Forms.Label();
            this.label_Pret_Flori = new System.Windows.Forms.Label();
            this.label_Pret_Materiale = new System.Windows.Forms.Label();
            this.label_Pret_F = new System.Windows.Forms.Label();
            this.label_Pret_M = new System.Windows.Forms.Label();
            this.listView_Optiuni = new System.Windows.Forms.ListView();
            this.columnHeader_Obiect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Total_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Buchete = new System.Windows.Forms.Label();
            this.dataGridView_Buchete = new System.Windows.Forms.DataGridView();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add_Flower = new System.Windows.Forms.Button();
            this.button_Add_Supply = new System.Windows.Forms.Button();
            this.label_Nume_Buchet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_New_Name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buchete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelHello.Location = new System.Drawing.Point(28, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(365, 70);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Bine ai venit în Paradisul Florilor, \r\naici îți poți crea buchetul preferat!";
            // 
            // comboBox_Flori
            // 
            this.comboBox_Flori.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Flori.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Flori.FormattingEnabled = true;
            this.comboBox_Flori.Location = new System.Drawing.Point(34, 128);
            this.comboBox_Flori.Name = "comboBox_Flori";
            this.comboBox_Flori.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Flori.TabIndex = 1;
            this.comboBox_Flori.SelectedIndexChanged += new System.EventHandler(this.comboBox_Flori_SelectedIndexChanged);
            // 
            // label_Flori
            // 
            this.label_Flori.AutoSize = true;
            this.label_Flori.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Flori.ForeColor = System.Drawing.Color.Red;
            this.label_Flori.Location = new System.Drawing.Point(30, 95);
            this.label_Flori.Name = "label_Flori";
            this.label_Flori.Size = new System.Drawing.Size(43, 20);
            this.label_Flori.TabIndex = 2;
            this.label_Flori.Text = "Flori";
            // 
            // label_Cantitate_Flori
            // 
            this.label_Cantitate_Flori.AutoSize = true;
            this.label_Cantitate_Flori.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cantitate_Flori.ForeColor = System.Drawing.Color.Red;
            this.label_Cantitate_Flori.Location = new System.Drawing.Point(193, 95);
            this.label_Cantitate_Flori.Name = "label_Cantitate_Flori";
            this.label_Cantitate_Flori.Size = new System.Drawing.Size(76, 20);
            this.label_Cantitate_Flori.TabIndex = 3;
            this.label_Cantitate_Flori.Text = "Cantitate";
            // 
            // textBox_Cantitate_Flori
            // 
            this.textBox_Cantitate_Flori.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cantitate_Flori.Location = new System.Drawing.Point(197, 130);
            this.textBox_Cantitate_Flori.Name = "textBox_Cantitate_Flori";
            this.textBox_Cantitate_Flori.Size = new System.Drawing.Size(100, 21);
            this.textBox_Cantitate_Flori.TabIndex = 4;
            this.textBox_Cantitate_Flori.TextChanged += new System.EventHandler(this.textBox_Cantitate_Flori_TextChanged);
            // 
            // label_Materiale
            // 
            this.label_Materiale.AutoSize = true;
            this.label_Materiale.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Materiale.ForeColor = System.Drawing.Color.Red;
            this.label_Materiale.Location = new System.Drawing.Point(30, 173);
            this.label_Materiale.Name = "label_Materiale";
            this.label_Materiale.Size = new System.Drawing.Size(151, 20);
            this.label_Materiale.TabIndex = 5;
            this.label_Materiale.Text = "Materiale adiționale";
            // 
            // label_Cantitate_Materiale
            // 
            this.label_Cantitate_Materiale.AutoSize = true;
            this.label_Cantitate_Materiale.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cantitate_Materiale.ForeColor = System.Drawing.Color.Red;
            this.label_Cantitate_Materiale.Location = new System.Drawing.Point(193, 173);
            this.label_Cantitate_Materiale.Name = "label_Cantitate_Materiale";
            this.label_Cantitate_Materiale.Size = new System.Drawing.Size(76, 20);
            this.label_Cantitate_Materiale.TabIndex = 6;
            this.label_Cantitate_Materiale.Text = "Cantitate";
            // 
            // comboBox_Materiale
            // 
            this.comboBox_Materiale.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Materiale.FormattingEnabled = true;
            this.comboBox_Materiale.Location = new System.Drawing.Point(34, 209);
            this.comboBox_Materiale.Name = "comboBox_Materiale";
            this.comboBox_Materiale.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Materiale.TabIndex = 7;
            this.comboBox_Materiale.SelectedIndexChanged += new System.EventHandler(this.comboBox_Materiale_SelectedIndexChanged);
            // 
            // textBox_Cantitate_Materiale
            // 
            this.textBox_Cantitate_Materiale.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cantitate_Materiale.Location = new System.Drawing.Point(197, 211);
            this.textBox_Cantitate_Materiale.Name = "textBox_Cantitate_Materiale";
            this.textBox_Cantitate_Materiale.Size = new System.Drawing.Size(100, 21);
            this.textBox_Cantitate_Materiale.TabIndex = 8;
            this.textBox_Cantitate_Materiale.TextChanged += new System.EventHandler(this.textBox_Cantitate_Materiale_TextChanged);
            // 
            // label_Lista_Optiuni
            // 
            this.label_Lista_Optiuni.AutoSize = true;
            this.label_Lista_Optiuni.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lista_Optiuni.ForeColor = System.Drawing.Color.Red;
            this.label_Lista_Optiuni.Location = new System.Drawing.Point(32, 248);
            this.label_Lista_Optiuni.Name = "label_Lista_Optiuni";
            this.label_Lista_Optiuni.Size = new System.Drawing.Size(58, 20);
            this.label_Lista_Optiuni.TabIndex = 9;
            this.label_Lista_Optiuni.Text = "Ai ales:";
            // 
            // label_Pret_Flori
            // 
            this.label_Pret_Flori.AutoSize = true;
            this.label_Pret_Flori.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pret_Flori.ForeColor = System.Drawing.Color.Red;
            this.label_Pret_Flori.Location = new System.Drawing.Point(311, 95);
            this.label_Pret_Flori.Name = "label_Pret_Flori";
            this.label_Pret_Flori.Size = new System.Drawing.Size(36, 20);
            this.label_Pret_Flori.TabIndex = 10;
            this.label_Pret_Flori.Text = "Preț";
            // 
            // label_Pret_Materiale
            // 
            this.label_Pret_Materiale.AutoSize = true;
            this.label_Pret_Materiale.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pret_Materiale.ForeColor = System.Drawing.Color.Red;
            this.label_Pret_Materiale.Location = new System.Drawing.Point(314, 173);
            this.label_Pret_Materiale.Name = "label_Pret_Materiale";
            this.label_Pret_Materiale.Size = new System.Drawing.Size(36, 20);
            this.label_Pret_Materiale.TabIndex = 11;
            this.label_Pret_Materiale.Text = "Preț";
            // 
            // label_Pret_F
            // 
            this.label_Pret_F.AutoSize = true;
            this.label_Pret_F.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pret_F.Location = new System.Drawing.Point(312, 136);
            this.label_Pret_F.Name = "label_Pret_F";
            this.label_Pret_F.Size = new System.Drawing.Size(38, 15);
            this.label_Pret_F.TabIndex = 12;
            this.label_Pret_F.Text = "label1";
            // 
            // label_Pret_M
            // 
            this.label_Pret_M.AutoSize = true;
            this.label_Pret_M.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pret_M.Location = new System.Drawing.Point(315, 217);
            this.label_Pret_M.Name = "label_Pret_M";
            this.label_Pret_M.Size = new System.Drawing.Size(38, 15);
            this.label_Pret_M.TabIndex = 13;
            this.label_Pret_M.Text = "label2";
            // 
            // listView_Optiuni
            // 
            this.listView_Optiuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Obiect,
            this.columnHeader_Quantity,
            this.columnHeader_Total_Price});
            this.listView_Optiuni.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Optiuni.HideSelection = false;
            this.listView_Optiuni.Location = new System.Drawing.Point(34, 271);
            this.listView_Optiuni.Name = "listView_Optiuni";
            this.listView_Optiuni.Size = new System.Drawing.Size(333, 133);
            this.listView_Optiuni.TabIndex = 14;
            this.listView_Optiuni.UseCompatibleStateImageBehavior = false;
            this.listView_Optiuni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Obiect
            // 
            this.columnHeader_Obiect.Text = "Opțiune";
            this.columnHeader_Obiect.Width = 214;
            // 
            // columnHeader_Quantity
            // 
            this.columnHeader_Quantity.Text = "Cantitate";
            // 
            // columnHeader_Total_Price
            // 
            this.columnHeader_Total_Price.Text = "Preț";
            // 
            // label_Buchete
            // 
            this.label_Buchete.AutoSize = true;
            this.label_Buchete.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buchete.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Buchete.Location = new System.Drawing.Point(573, 21);
            this.label_Buchete.Name = "label_Buchete";
            this.label_Buchete.Size = new System.Drawing.Size(167, 32);
            this.label_Buchete.TabIndex = 15;
            this.label_Buchete.Text = "Buchete create";
            // 
            // dataGridView_Buchete
            // 
            this.dataGridView_Buchete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Buchete.Location = new System.Drawing.Point(459, 56);
            this.dataGridView_Buchete.Name = "dataGridView_Buchete";
            this.dataGridView_Buchete.RowHeadersWidth = 51;
            this.dataGridView_Buchete.RowTemplate.Height = 24;
            this.dataGridView_Buchete.Size = new System.Drawing.Size(404, 339);
            this.dataGridView_Buchete.TabIndex = 16;
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.Location = new System.Drawing.Point(131, 483);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(124, 25);
            this.button_Create.TabIndex = 17;
            this.button_Create.Text = "Creează buchet";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(617, 483);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(82, 25);
            this.button_Update.TabIndex = 18;
            this.button_Update.Text = "Actualizează";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(373, 379);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(65, 25);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Șterge";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add_Flower
            // 
            this.button_Add_Flower.Location = new System.Drawing.Point(365, 124);
            this.button_Add_Flower.Name = "button_Add_Flower";
            this.button_Add_Flower.Size = new System.Drawing.Size(70, 27);
            this.button_Add_Flower.TabIndex = 20;
            this.button_Add_Flower.Text = "Adaugă";
            this.button_Add_Flower.UseVisualStyleBackColor = true;
            this.button_Add_Flower.Click += new System.EventHandler(this.button_Add_Flower_Click);
            // 
            // button_Add_Supply
            // 
            this.button_Add_Supply.Location = new System.Drawing.Point(365, 203);
            this.button_Add_Supply.Name = "button_Add_Supply";
            this.button_Add_Supply.Size = new System.Drawing.Size(70, 29);
            this.button_Add_Supply.TabIndex = 21;
            this.button_Add_Supply.Text = "Adaugă";
            this.button_Add_Supply.UseVisualStyleBackColor = true;
            this.button_Add_Supply.Click += new System.EventHandler(this.button_Add_Supply_Click);
            // 
            // label_Nume_Buchet
            // 
            this.label_Nume_Buchet.AutoSize = true;
            this.label_Nume_Buchet.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nume_Buchet.ForeColor = System.Drawing.Color.Red;
            this.label_Nume_Buchet.Location = new System.Drawing.Point(66, 427);
            this.label_Nume_Buchet.Name = "label_Nume_Buchet";
            this.label_Nume_Buchet.Size = new System.Drawing.Size(265, 23);
            this.label_Nume_Buchet.TabIndex = 22;
            this.label_Nume_Buchet.Text = "Introduceți numele buchetului :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 24);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_New_Name
            // 
            this.label_New_Name.AutoSize = true;
            this.label_New_Name.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_New_Name.ForeColor = System.Drawing.Color.Red;
            this.label_New_Name.Location = new System.Drawing.Point(499, 410);
            this.label_New_Name.Name = "label_New_Name";
            this.label_New_Name.Size = new System.Drawing.Size(328, 40);
            this.label_New_Name.TabIndex = 24;
            this.label_New_Name.Text = "Dacă doriți sa modificați numele buchetului, \r\nselectați-l și introduceți noul nu" +
    "me :\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(459, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 24);
            this.textBox2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FlowerShopWindowsForm.Properties.Resources.fototapet_lalele_galbene;
            this.ClientSize = new System.Drawing.Size(877, 529);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_New_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Nume_Buchet);
            this.Controls.Add(this.button_Add_Supply);
            this.Controls.Add(this.button_Add_Flower);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.dataGridView_Buchete);
            this.Controls.Add(this.label_Buchete);
            this.Controls.Add(this.listView_Optiuni);
            this.Controls.Add(this.label_Pret_M);
            this.Controls.Add(this.label_Pret_F);
            this.Controls.Add(this.label_Pret_Materiale);
            this.Controls.Add(this.label_Pret_Flori);
            this.Controls.Add(this.label_Lista_Optiuni);
            this.Controls.Add(this.textBox_Cantitate_Materiale);
            this.Controls.Add(this.comboBox_Materiale);
            this.Controls.Add(this.label_Cantitate_Materiale);
            this.Controls.Add(this.label_Materiale);
            this.Controls.Add(this.textBox_Cantitate_Flori);
            this.Controls.Add(this.label_Cantitate_Flori);
            this.Controls.Add(this.label_Flori);
            this.Controls.Add(this.comboBox_Flori);
            this.Controls.Add(this.labelHello);
            this.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "FlowerShop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Buchete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.ComboBox comboBox_Flori;
        private System.Windows.Forms.Label label_Flori;
        private System.Windows.Forms.Label label_Cantitate_Flori;
        private System.Windows.Forms.TextBox textBox_Cantitate_Flori;
        private System.Windows.Forms.Label label_Materiale;
        private System.Windows.Forms.Label label_Cantitate_Materiale;
        private System.Windows.Forms.ComboBox comboBox_Materiale;
        private System.Windows.Forms.TextBox textBox_Cantitate_Materiale;
        private System.Windows.Forms.Label label_Lista_Optiuni;
        private System.Windows.Forms.Label label_Pret_Flori;
        private System.Windows.Forms.Label label_Pret_Materiale;
        private System.Windows.Forms.Label label_Pret_F;
        private System.Windows.Forms.Label label_Pret_M;
        private System.Windows.Forms.ListView listView_Optiuni;
        private System.Windows.Forms.Label label_Buchete;
        private System.Windows.Forms.DataGridView dataGridView_Buchete;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add_Flower;
        private System.Windows.Forms.Button button_Add_Supply;
        private System.Windows.Forms.ColumnHeader columnHeader_Obiect;
        private System.Windows.Forms.ColumnHeader columnHeader_Quantity;
        private System.Windows.Forms.ColumnHeader columnHeader_Total_Price;
        private System.Windows.Forms.Label label_Nume_Buchet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_New_Name;
        private System.Windows.Forms.TextBox textBox2;
    }
}

