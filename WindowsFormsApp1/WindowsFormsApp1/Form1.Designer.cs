namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.VerwijderKlant = new System.Windows.Forms.Button();
            this.BewerkKlant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BewerkArts = new System.Windows.Forms.Button();
            this.VerwijderArts = new System.Windows.Forms.Button();
            this.FilterArts = new System.Windows.Forms.Button();
            this.MaakArts = new System.Windows.Forms.Button();
            this.BewerkMedicatie = new System.Windows.Forms.Button();
            this.VerwijderMedicatie = new System.Windows.Forms.Button();
            this.FilterMedicatie = new System.Windows.Forms.Button();
            this.MaakMedicatie = new System.Windows.Forms.Button();
            this.MaakKlant = new System.Windows.Forms.Button();
            this.FilterKlant = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Klantentab = new System.Windows.Forms.TabPage();
            this.Artsentab = new System.Windows.Forms.TabPage();
            this.Medicatietab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Klantentab.SuspendLayout();
            this.Artsentab.SuspendLayout();
            this.Medicatietab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klanten";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(500, 238);
            this.dataGridView2.TabIndex = 4;
            // 
            // VerwijderKlant
            // 
            this.VerwijderKlant.Location = new System.Drawing.Point(173, 271);
            this.VerwijderKlant.Name = "VerwijderKlant";
            this.VerwijderKlant.Size = new System.Drawing.Size(75, 23);
            this.VerwijderKlant.TabIndex = 5;
            this.VerwijderKlant.Text = "Remove";
            this.VerwijderKlant.UseVisualStyleBackColor = true;
            this.VerwijderKlant.Click += new System.EventHandler(this.VerwijderKlant_Click);
            // 
            // BewerkKlant
            // 
            this.BewerkKlant.Location = new System.Drawing.Point(92, 271);
            this.BewerkKlant.Name = "BewerkKlant";
            this.BewerkKlant.Size = new System.Drawing.Size(75, 23);
            this.BewerkKlant.TabIndex = 6;
            this.BewerkKlant.Text = "Edit";
            this.BewerkKlant.UseVisualStyleBackColor = true;
            this.BewerkKlant.Click += new System.EventHandler(this.BewerkKlant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artsen";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(500, 239);
            this.dataGridView3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Medicatie";
            // 
            // BewerkArts
            // 
            this.BewerkArts.Location = new System.Drawing.Point(168, 293);
            this.BewerkArts.Name = "BewerkArts";
            this.BewerkArts.Size = new System.Drawing.Size(75, 23);
            this.BewerkArts.TabIndex = 13;
            this.BewerkArts.Text = "Edit";
            this.BewerkArts.UseVisualStyleBackColor = true;
            this.BewerkArts.Click += new System.EventHandler(this.BewerkArts_Click);
            // 
            // VerwijderArts
            // 
            this.VerwijderArts.Location = new System.Drawing.Point(249, 293);
            this.VerwijderArts.Name = "VerwijderArts";
            this.VerwijderArts.Size = new System.Drawing.Size(75, 23);
            this.VerwijderArts.TabIndex = 12;
            this.VerwijderArts.Text = "Remove";
            this.VerwijderArts.UseVisualStyleBackColor = true;
            this.VerwijderArts.Click += new System.EventHandler(this.VerwijderArts_Click);
            // 
            // FilterArts
            // 
            this.FilterArts.Location = new System.Drawing.Point(87, 293);
            this.FilterArts.Name = "FilterArts";
            this.FilterArts.Size = new System.Drawing.Size(75, 23);
            this.FilterArts.TabIndex = 11;
            this.FilterArts.Text = "Filter";
            this.FilterArts.UseVisualStyleBackColor = true;
            this.FilterArts.Click += new System.EventHandler(this.FilterArts_Click);
            // 
            // MaakArts
            // 
            this.MaakArts.Location = new System.Drawing.Point(6, 293);
            this.MaakArts.Name = "MaakArts";
            this.MaakArts.Size = new System.Drawing.Size(75, 23);
            this.MaakArts.TabIndex = 10;
            this.MaakArts.Text = "Add";
            this.MaakArts.UseVisualStyleBackColor = true;
            this.MaakArts.Click += new System.EventHandler(this.MaakArts_Click);
            // 
            // BewerkMedicatie
            // 
            this.BewerkMedicatie.Location = new System.Drawing.Point(168, 280);
            this.BewerkMedicatie.Name = "BewerkMedicatie";
            this.BewerkMedicatie.Size = new System.Drawing.Size(75, 23);
            this.BewerkMedicatie.TabIndex = 17;
            this.BewerkMedicatie.Text = "Edit";
            this.BewerkMedicatie.UseVisualStyleBackColor = true;
            this.BewerkMedicatie.Click += new System.EventHandler(this.BewerkMedicatie_Click);
            // 
            // VerwijderMedicatie
            // 
            this.VerwijderMedicatie.Location = new System.Drawing.Point(249, 280);
            this.VerwijderMedicatie.Name = "VerwijderMedicatie";
            this.VerwijderMedicatie.Size = new System.Drawing.Size(75, 23);
            this.VerwijderMedicatie.TabIndex = 16;
            this.VerwijderMedicatie.Text = "Remove";
            this.VerwijderMedicatie.UseVisualStyleBackColor = true;
            this.VerwijderMedicatie.Click += new System.EventHandler(this.VerwijderMedicatie_Click);
            // 
            // FilterMedicatie
            // 
            this.FilterMedicatie.Location = new System.Drawing.Point(87, 280);
            this.FilterMedicatie.Name = "FilterMedicatie";
            this.FilterMedicatie.Size = new System.Drawing.Size(75, 23);
            this.FilterMedicatie.TabIndex = 15;
            this.FilterMedicatie.Text = "Filter";
            this.FilterMedicatie.UseVisualStyleBackColor = true;
            this.FilterMedicatie.Click += new System.EventHandler(this.FilterMedicatie_Click);
            // 
            // MaakMedicatie
            // 
            this.MaakMedicatie.Location = new System.Drawing.Point(6, 280);
            this.MaakMedicatie.Name = "MaakMedicatie";
            this.MaakMedicatie.Size = new System.Drawing.Size(75, 23);
            this.MaakMedicatie.TabIndex = 14;
            this.MaakMedicatie.Text = "Add";
            this.MaakMedicatie.UseVisualStyleBackColor = true;
            this.MaakMedicatie.Click += new System.EventHandler(this.MaakMedicatie_Click);
            // 
            // MaakKlant
            // 
            this.MaakKlant.Location = new System.Drawing.Point(531, 176);
            this.MaakKlant.Name = "MaakKlant";
            this.MaakKlant.Size = new System.Drawing.Size(75, 23);
            this.MaakKlant.TabIndex = 18;
            this.MaakKlant.Text = "Add";
            this.MaakKlant.UseVisualStyleBackColor = true;
            this.MaakKlant.Click += new System.EventHandler(this.MaakKlant_Click);
            // 
            // FilterKlant
            // 
            this.FilterKlant.Location = new System.Drawing.Point(11, 271);
            this.FilterKlant.Name = "FilterKlant";
            this.FilterKlant.Size = new System.Drawing.Size(75, 23);
            this.FilterKlant.TabIndex = 19;
            this.FilterKlant.Text = "Filter";
            this.FilterKlant.UseVisualStyleBackColor = true;
            this.FilterKlant.Click += new System.EventHandler(this.FilterKlant_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Verzekeringsid";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(609, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(609, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(609, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Achternaam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Plaats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Voornaam";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Klantentab);
            this.tabControl1.Controls.Add(this.Artsentab);
            this.tabControl1.Controls.Add(this.Medicatietab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 715);
            this.tabControl1.TabIndex = 30;
            // 
            // Klantentab
            // 
            this.Klantentab.Controls.Add(this.dataGridView1);
            this.Klantentab.Controls.Add(this.label8);
            this.Klantentab.Controls.Add(this.label1);
            this.Klantentab.Controls.Add(this.label7);
            this.Klantentab.Controls.Add(this.VerwijderKlant);
            this.Klantentab.Controls.Add(this.label6);
            this.Klantentab.Controls.Add(this.BewerkKlant);
            this.Klantentab.Controls.Add(this.label5);
            this.Klantentab.Controls.Add(this.textBox5);
            this.Klantentab.Controls.Add(this.MaakKlant);
            this.Klantentab.Controls.Add(this.textBox4);
            this.Klantentab.Controls.Add(this.FilterKlant);
            this.Klantentab.Controls.Add(this.textBox3);
            this.Klantentab.Controls.Add(this.textBox1);
            this.Klantentab.Controls.Add(this.textBox2);
            this.Klantentab.Controls.Add(this.label4);
            this.Klantentab.Location = new System.Drawing.Point(4, 22);
            this.Klantentab.Name = "Klantentab";
            this.Klantentab.Padding = new System.Windows.Forms.Padding(3);
            this.Klantentab.Size = new System.Drawing.Size(807, 689);
            this.Klantentab.TabIndex = 0;
            this.Klantentab.Text = "Klanten";
            this.Klantentab.UseVisualStyleBackColor = true;
            this.Klantentab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Artsentab
            // 
            this.Artsentab.Controls.Add(this.dataGridView2);
            this.Artsentab.Controls.Add(this.MaakArts);
            this.Artsentab.Controls.Add(this.label2);
            this.Artsentab.Controls.Add(this.FilterArts);
            this.Artsentab.Controls.Add(this.VerwijderArts);
            this.Artsentab.Controls.Add(this.BewerkArts);
            this.Artsentab.Location = new System.Drawing.Point(4, 22);
            this.Artsentab.Name = "Artsentab";
            this.Artsentab.Padding = new System.Windows.Forms.Padding(3);
            this.Artsentab.Size = new System.Drawing.Size(807, 689);
            this.Artsentab.TabIndex = 1;
            this.Artsentab.Text = "Artsen";
            this.Artsentab.UseVisualStyleBackColor = true;
            // 
            // Medicatietab
            // 
            this.Medicatietab.Controls.Add(this.dataGridView3);
            this.Medicatietab.Controls.Add(this.BewerkMedicatie);
            this.Medicatietab.Controls.Add(this.label3);
            this.Medicatietab.Controls.Add(this.VerwijderMedicatie);
            this.Medicatietab.Controls.Add(this.MaakMedicatie);
            this.Medicatietab.Controls.Add(this.FilterMedicatie);
            this.Medicatietab.Location = new System.Drawing.Point(4, 22);
            this.Medicatietab.Name = "Medicatietab";
            this.Medicatietab.Padding = new System.Windows.Forms.Padding(3);
            this.Medicatietab.Size = new System.Drawing.Size(807, 689);
            this.Medicatietab.TabIndex = 2;
            this.Medicatietab.Text = "Medicatie";
            this.Medicatietab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 739);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gezondheidszorg Database applicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Klantentab.ResumeLayout(false);
            this.Klantentab.PerformLayout();
            this.Artsentab.ResumeLayout(false);
            this.Artsentab.PerformLayout();
            this.Medicatietab.ResumeLayout(false);
            this.Medicatietab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button VerwijderKlant;
        private System.Windows.Forms.Button BewerkKlant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BewerkArts;
        private System.Windows.Forms.Button VerwijderArts;
        private System.Windows.Forms.Button FilterArts;
        private System.Windows.Forms.Button MaakArts;
        private System.Windows.Forms.Button BewerkMedicatie;
        private System.Windows.Forms.Button VerwijderMedicatie;
        private System.Windows.Forms.Button FilterMedicatie;
        private System.Windows.Forms.Button MaakMedicatie;
        private System.Windows.Forms.Button MaakKlant;
        private System.Windows.Forms.Button FilterKlant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Klantentab;
        private System.Windows.Forms.TabPage Artsentab;
        private System.Windows.Forms.TabPage Medicatietab;
    }
}

