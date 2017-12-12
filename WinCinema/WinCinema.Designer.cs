namespace WinCinema
{
    partial class WinCinema
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinCinema));
            this.lbl_choixHoraire = new System.Windows.Forms.Label();
            this.lbl_ChoixJour = new System.Windows.Forms.Label();
            this.lbl_Tarif11h = new System.Windows.Forms.Label();
            this.lbl_TarifLundi = new System.Windows.Forms.Label();
            this.cbx_Horaire = new System.Windows.Forms.ComboBox();
            this.cbx_Jour = new System.Windows.Forms.ComboBox();
            this.ckb_TarifCE = new System.Windows.Forms.CheckBox();
            this.gpb_Tarif = new System.Windows.Forms.GroupBox();
            this.rdb_PleinTarif = new System.Windows.Forms.RadioButton();
            this.rdb_TarifEtudiant = new System.Windows.Forms.RadioButton();
            this.rdb_TarifReduit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_Majoration3D = new System.Windows.Forms.CheckBox();
            this.ckb_CouponReduc = new System.Windows.Forms.CheckBox();
            this.pbx_Ticket = new System.Windows.Forms.PictureBox();
            this.btn_CalculerTarif = new System.Windows.Forms.Button();
            this.lbl_TarifApplicable = new System.Windows.Forms.Label();
            this.gpb_Tarif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choixHoraire
            // 
            this.lbl_choixHoraire.AutoSize = true;
            this.lbl_choixHoraire.Location = new System.Drawing.Point(27, 27);
            this.lbl_choixHoraire.Name = "lbl_choixHoraire";
            this.lbl_choixHoraire.Size = new System.Drawing.Size(79, 13);
            this.lbl_choixHoraire.TabIndex = 0;
            this.lbl_choixHoraire.Text = "Choisir horaire :";
            this.lbl_choixHoraire.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ChoixJour
            // 
            this.lbl_ChoixJour.AutoSize = true;
            this.lbl_ChoixJour.Location = new System.Drawing.Point(27, 79);
            this.lbl_ChoixJour.Name = "lbl_ChoixJour";
            this.lbl_ChoixJour.Size = new System.Drawing.Size(64, 13);
            this.lbl_ChoixJour.TabIndex = 1;
            this.lbl_ChoixJour.Text = "Choisir jour :";
            // 
            // lbl_Tarif11h
            // 
            this.lbl_Tarif11h.AutoSize = true;
            this.lbl_Tarif11h.Location = new System.Drawing.Point(248, 27);
            this.lbl_Tarif11h.Name = "lbl_Tarif11h";
            this.lbl_Tarif11h.Size = new System.Drawing.Size(108, 13);
            this.lbl_Tarif11h.TabIndex = 2;
            this.lbl_Tarif11h.Text = "(5,20 Euros à 11H10)";
            // 
            // lbl_TarifLundi
            // 
            this.lbl_TarifLundi.AutoSize = true;
            this.lbl_TarifLundi.Location = new System.Drawing.Point(248, 79);
            this.lbl_TarifLundi.Name = "lbl_TarifLundi";
            this.lbl_TarifLundi.Size = new System.Drawing.Size(100, 13);
            this.lbl_TarifLundi.TabIndex = 3;
            this.lbl_TarifLundi.Text = "(5,70 Euros le lundi)";
            // 
            // cbx_Horaire
            // 
            this.cbx_Horaire.FormattingEnabled = true;
            this.cbx_Horaire.Items.AddRange(new object[] {
            "11H10",
            "14H20",
            "16H30",
            "18H30",
            "20H15",
            "22H00"});
            this.cbx_Horaire.Location = new System.Drawing.Point(151, 24);
            this.cbx_Horaire.Name = "cbx_Horaire";
            this.cbx_Horaire.Size = new System.Drawing.Size(91, 21);
            this.cbx_Horaire.TabIndex = 4;
            this.cbx_Horaire.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbx_Jour
            // 
            this.cbx_Jour.FormattingEnabled = true;
            this.cbx_Jour.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.cbx_Jour.Location = new System.Drawing.Point(121, 76);
            this.cbx_Jour.Name = "cbx_Jour";
            this.cbx_Jour.Size = new System.Drawing.Size(121, 21);
            this.cbx_Jour.TabIndex = 5;
            // 
            // ckb_TarifCE
            // 
            this.ckb_TarifCE.AutoSize = true;
            this.ckb_TarifCE.Location = new System.Drawing.Point(56, 131);
            this.ckb_TarifCE.Name = "ckb_TarifCE";
            this.ckb_TarifCE.Size = new System.Drawing.Size(163, 17);
            this.ckb_TarifCE.TabIndex = 6;
            this.ckb_TarifCE.Text = "Tarif spécial CE : 5,20 Euros ";
            this.ckb_TarifCE.UseVisualStyleBackColor = true;
            this.ckb_TarifCE.CheckedChanged += new System.EventHandler(this.ckb_TarifCE_CheckedChanged);
            // 
            // gpb_Tarif
            // 
            this.gpb_Tarif.Controls.Add(this.label2);
            this.gpb_Tarif.Controls.Add(this.label1);
            this.gpb_Tarif.Controls.Add(this.rdb_TarifReduit);
            this.gpb_Tarif.Controls.Add(this.rdb_TarifEtudiant);
            this.gpb_Tarif.Controls.Add(this.rdb_PleinTarif);
            this.gpb_Tarif.Location = new System.Drawing.Point(30, 186);
            this.gpb_Tarif.Name = "gpb_Tarif";
            this.gpb_Tarif.Size = new System.Drawing.Size(318, 142);
            this.gpb_Tarif.TabIndex = 7;
            this.gpb_Tarif.TabStop = false;
            this.gpb_Tarif.Text = "Tarif";
            // 
            // rdb_PleinTarif
            // 
            this.rdb_PleinTarif.AutoSize = true;
            this.rdb_PleinTarif.Location = new System.Drawing.Point(6, 31);
            this.rdb_PleinTarif.Name = "rdb_PleinTarif";
            this.rdb_PleinTarif.Size = new System.Drawing.Size(128, 17);
            this.rdb_PleinTarif.TabIndex = 0;
            this.rdb_PleinTarif.TabStop = true;
            this.rdb_PleinTarif.Text = "Plein tarif : 8,70 Euros";
            this.rdb_PleinTarif.UseVisualStyleBackColor = true;
            // 
            // rdb_TarifEtudiant
            // 
            this.rdb_TarifEtudiant.AutoSize = true;
            this.rdb_TarifEtudiant.Location = new System.Drawing.Point(6, 54);
            this.rdb_TarifEtudiant.Name = "rdb_TarifEtudiant";
            this.rdb_TarifEtudiant.Size = new System.Drawing.Size(176, 17);
            this.rdb_TarifEtudiant.TabIndex = 1;
            this.rdb_TarifEtudiant.TabStop = true;
            this.rdb_TarifEtudiant.Text = "Etudiant ou mineur :  5,90 Euros";
            this.rdb_TarifEtudiant.UseVisualStyleBackColor = true;
            // 
            // rdb_TarifReduit
            // 
            this.rdb_TarifReduit.AutoSize = true;
            this.rdb_TarifReduit.Location = new System.Drawing.Point(6, 77);
            this.rdb_TarifReduit.Name = "rdb_TarifReduit";
            this.rdb_TarifReduit.Size = new System.Drawing.Size(162, 17);
            this.rdb_TarifReduit.TabIndex = 2;
            this.rdb_TarifReduit.TabStop = true;
            this.rdb_TarifReduit.Text = "Tarif réduit autre : 6,90 Euros";
            this.rdb_TarifReduit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Carte Vemeil, carte famille nombreuse, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "handicapé, demandeur d\'emploi)";
            // 
            // ckb_Majoration3D
            // 
            this.ckb_Majoration3D.AutoSize = true;
            this.ckb_Majoration3D.Location = new System.Drawing.Point(36, 346);
            this.ckb_Majoration3D.Name = "ckb_Majoration3D";
            this.ckb_Majoration3D.Size = new System.Drawing.Size(170, 17);
            this.ckb_Majoration3D.TabIndex = 8;
            this.ckb_Majoration3D.Text = "Majoration film 3D : 1,50 Euros";
            this.ckb_Majoration3D.UseVisualStyleBackColor = true;
            // 
            // ckb_CouponReduc
            // 
            this.ckb_CouponReduc.AutoSize = true;
            this.ckb_CouponReduc.Location = new System.Drawing.Point(36, 388);
            this.ckb_CouponReduc.Name = "ckb_CouponReduc";
            this.ckb_CouponReduc.Size = new System.Drawing.Size(156, 17);
            this.ckb_CouponReduc.TabIndex = 9;
            this.ckb_CouponReduc.Text = "Coupon réduction : - 1 Euro";
            this.ckb_CouponReduc.UseVisualStyleBackColor = true;
            // 
            // pbx_Ticket
            // 
            this.pbx_Ticket.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Ticket.Image")));
            this.pbx_Ticket.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_Ticket.InitialImage")));
            this.pbx_Ticket.Location = new System.Drawing.Point(430, 149);
            this.pbx_Ticket.Name = "pbx_Ticket";
            this.pbx_Ticket.Size = new System.Drawing.Size(108, 103);
            this.pbx_Ticket.TabIndex = 10;
            this.pbx_Ticket.TabStop = false;
            // 
            // btn_CalculerTarif
            // 
            this.btn_CalculerTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalculerTarif.ForeColor = System.Drawing.Color.Red;
            this.btn_CalculerTarif.Location = new System.Drawing.Point(430, 281);
            this.btn_CalculerTarif.Name = "btn_CalculerTarif";
            this.btn_CalculerTarif.Size = new System.Drawing.Size(108, 50);
            this.btn_CalculerTarif.TabIndex = 11;
            this.btn_CalculerTarif.Text = "TARIF APPLICABLE";
            this.btn_CalculerTarif.UseVisualStyleBackColor = true;
            this.btn_CalculerTarif.Click += new System.EventHandler(this.btn_CalculerTarif_Click);
            // 
            // lbl_TarifApplicable
            // 
            this.lbl_TarifApplicable.AutoSize = true;
            this.lbl_TarifApplicable.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_TarifApplicable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TarifApplicable.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_TarifApplicable.Location = new System.Drawing.Point(430, 351);
            this.lbl_TarifApplicable.MinimumSize = new System.Drawing.Size(108, 30);
            this.lbl_TarifApplicable.Name = "lbl_TarifApplicable";
            this.lbl_TarifApplicable.Size = new System.Drawing.Size(108, 30);
            this.lbl_TarifApplicable.TabIndex = 12;
            this.lbl_TarifApplicable.Text = "0.00";
            this.lbl_TarifApplicable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.lbl_TarifApplicable);
            this.Controls.Add(this.btn_CalculerTarif);
            this.Controls.Add(this.pbx_Ticket);
            this.Controls.Add(this.ckb_CouponReduc);
            this.Controls.Add(this.ckb_Majoration3D);
            this.Controls.Add(this.gpb_Tarif);
            this.Controls.Add(this.ckb_TarifCE);
            this.Controls.Add(this.cbx_Jour);
            this.Controls.Add(this.cbx_Horaire);
            this.Controls.Add(this.lbl_TarifLundi);
            this.Controls.Add(this.lbl_Tarif11h);
            this.Controls.Add(this.lbl_ChoixJour);
            this.Controls.Add(this.lbl_choixHoraire);
            this.Name = "WinCinema";
            this.Text = "WinCinema";
            this.gpb_Tarif.ResumeLayout(false);
            this.gpb_Tarif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choixHoraire;
        private System.Windows.Forms.Label lbl_ChoixJour;
        private System.Windows.Forms.Label lbl_Tarif11h;
        private System.Windows.Forms.Label lbl_TarifLundi;
        private System.Windows.Forms.ComboBox cbx_Horaire;
        private System.Windows.Forms.ComboBox cbx_Jour;
        private System.Windows.Forms.CheckBox ckb_TarifCE;
        private System.Windows.Forms.GroupBox gpb_Tarif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_TarifReduit;
        private System.Windows.Forms.RadioButton rdb_TarifEtudiant;
        private System.Windows.Forms.RadioButton rdb_PleinTarif;
        private System.Windows.Forms.CheckBox ckb_Majoration3D;
        private System.Windows.Forms.CheckBox ckb_CouponReduc;
        private System.Windows.Forms.PictureBox pbx_Ticket;
        private System.Windows.Forms.Button btn_CalculerTarif;
        private System.Windows.Forms.Label lbl_TarifApplicable;
    }
}

