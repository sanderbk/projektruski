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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 117);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
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
            this.dataGridView2.Location = new System.Drawing.Point(17, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(500, 117);
            this.dataGridView2.TabIndex = 4;
            // 
            // VerwijderKlant
            // 
            this.VerwijderKlant.Location = new System.Drawing.Point(255, 168);
            this.VerwijderKlant.Name = "VerwijderKlant";
            this.VerwijderKlant.Size = new System.Drawing.Size(75, 23);
            this.VerwijderKlant.TabIndex = 5;
            this.VerwijderKlant.Text = "Remove";
            this.VerwijderKlant.UseVisualStyleBackColor = true;
            this.VerwijderKlant.Click += new System.EventHandler(this.VerwijderKlant_Click);
            // 
            // BewerkKlant
            // 
            this.BewerkKlant.Location = new System.Drawing.Point(174, 168);
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
            this.label2.Location = new System.Drawing.Point(24, 205);
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
            this.dataGridView3.Location = new System.Drawing.Point(17, 420);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(500, 117);
            this.dataGridView3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Medicatie";
            // 
            // BewerkArts
            // 
            this.BewerkArts.Location = new System.Drawing.Point(179, 356);
            this.BewerkArts.Name = "BewerkArts";
            this.BewerkArts.Size = new System.Drawing.Size(75, 23);
            this.BewerkArts.TabIndex = 13;
            this.BewerkArts.Text = "Edit";
            this.BewerkArts.UseVisualStyleBackColor = true;
            // 
            // VerwijderArts
            // 
            this.VerwijderArts.Location = new System.Drawing.Point(260, 356);
            this.VerwijderArts.Name = "VerwijderArts";
            this.VerwijderArts.Size = new System.Drawing.Size(75, 23);
            this.VerwijderArts.TabIndex = 12;
            this.VerwijderArts.Text = "Remove";
            this.VerwijderArts.UseVisualStyleBackColor = true;
            // 
            // FilterArts
            // 
            this.FilterArts.Location = new System.Drawing.Point(98, 356);
            this.FilterArts.Name = "FilterArts";
            this.FilterArts.Size = new System.Drawing.Size(75, 23);
            this.FilterArts.TabIndex = 11;
            this.FilterArts.Text = "Filter";
            this.FilterArts.UseVisualStyleBackColor = true;
            // 
            // MaakArts
            // 
            this.MaakArts.Location = new System.Drawing.Point(17, 356);
            this.MaakArts.Name = "MaakArts";
            this.MaakArts.Size = new System.Drawing.Size(75, 23);
            this.MaakArts.TabIndex = 10;
            this.MaakArts.Text = "Add";
            this.MaakArts.UseVisualStyleBackColor = true;
            // 
            // BewerkMedicatie
            // 
            this.BewerkMedicatie.Location = new System.Drawing.Point(179, 543);
            this.BewerkMedicatie.Name = "BewerkMedicatie";
            this.BewerkMedicatie.Size = new System.Drawing.Size(75, 23);
            this.BewerkMedicatie.TabIndex = 17;
            this.BewerkMedicatie.Text = "Edit";
            this.BewerkMedicatie.UseVisualStyleBackColor = true;
            // 
            // VerwijderMedicatie
            // 
            this.VerwijderMedicatie.Location = new System.Drawing.Point(260, 543);
            this.VerwijderMedicatie.Name = "VerwijderMedicatie";
            this.VerwijderMedicatie.Size = new System.Drawing.Size(75, 23);
            this.VerwijderMedicatie.TabIndex = 16;
            this.VerwijderMedicatie.Text = "Remove";
            this.VerwijderMedicatie.UseVisualStyleBackColor = true;
            // 
            // FilterMedicatie
            // 
            this.FilterMedicatie.Location = new System.Drawing.Point(98, 543);
            this.FilterMedicatie.Name = "FilterMedicatie";
            this.FilterMedicatie.Size = new System.Drawing.Size(75, 23);
            this.FilterMedicatie.TabIndex = 15;
            this.FilterMedicatie.Text = "Filter";
            this.FilterMedicatie.UseVisualStyleBackColor = true;
            // 
            // MaakMedicatie
            // 
            this.MaakMedicatie.Location = new System.Drawing.Point(17, 543);
            this.MaakMedicatie.Name = "MaakMedicatie";
            this.MaakMedicatie.Size = new System.Drawing.Size(75, 23);
            this.MaakMedicatie.TabIndex = 14;
            this.MaakMedicatie.Text = "Add";
            this.MaakMedicatie.UseVisualStyleBackColor = true;
            // 
            // MaakKlant
            // 
            this.MaakKlant.Location = new System.Drawing.Point(12, 168);
            this.MaakKlant.Name = "MaakKlant";
            this.MaakKlant.Size = new System.Drawing.Size(75, 23);
            this.MaakKlant.TabIndex = 18;
            this.MaakKlant.Text = "Add";
            this.MaakKlant.UseVisualStyleBackColor = true;
            this.MaakKlant.Click += new System.EventHandler(this.MaakKlant_Click);
            // 
            // FilterKlant
            // 
            this.FilterKlant.Location = new System.Drawing.Point(93, 168);
            this.FilterKlant.Name = "FilterKlant";
            this.FilterKlant.Size = new System.Drawing.Size(75, 23);
            this.FilterKlant.TabIndex = 19;
            this.FilterKlant.Text = "Filter";
            this.FilterKlant.UseVisualStyleBackColor = true;
            this.FilterKlant.Click += new System.EventHandler(this.FilterKlant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 581);
            this.Controls.Add(this.FilterKlant);
            this.Controls.Add(this.MaakKlant);
            this.Controls.Add(this.BewerkMedicatie);
            this.Controls.Add(this.VerwijderMedicatie);
            this.Controls.Add(this.FilterMedicatie);
            this.Controls.Add(this.MaakMedicatie);
            this.Controls.Add(this.BewerkArts);
            this.Controls.Add(this.VerwijderArts);
            this.Controls.Add(this.FilterArts);
            this.Controls.Add(this.MaakArts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BewerkKlant);
            this.Controls.Add(this.VerwijderKlant);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Gezondheidszorg Database applicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

