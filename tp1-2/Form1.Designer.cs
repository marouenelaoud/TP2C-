namespace tp1_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.ComboBox();
            this.grpsit = new System.Windows.Forms.GroupBox();
            this.radcel = new System.Windows.Forms.RadioButton();
            this.radmar = new System.Windows.Forms.RadioButton();
            this.raddiv = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdvalid = new System.Windows.Forms.Button();
            this.cmdinit = new System.Windows.Forms.Button();
            this.cmdquit = new System.Windows.Forms.Button();
            this.nbenf = new System.Windows.Forms.NumericUpDown();
            this.grpsit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbenf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre nom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Votre prénom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(178, 49);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(176, 22);
            this.txtnom.TabIndex = 2;
            this.txtnom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(178, 103);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(176, 22);
            this.txtpre.TabIndex = 3;
            this.txtpre.TextChanged += new System.EventHandler(this.txtpre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date de naissance :";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(178, 156);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexe:";
            // 
            // sexe
            // 
            this.sexe.FormattingEnabled = true;
            this.sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.sexe.Location = new System.Drawing.Point(178, 203);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(121, 24);
            this.sexe.TabIndex = 7;
            // 
            // grpsit
            // 
            this.grpsit.Controls.Add(this.raddiv);
            this.grpsit.Controls.Add(this.radmar);
            this.grpsit.Controls.Add(this.radcel);
            this.grpsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpsit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpsit.Location = new System.Drawing.Point(145, 246);
            this.grpsit.Name = "grpsit";
            this.grpsit.Size = new System.Drawing.Size(154, 154);
            this.grpsit.TabIndex = 8;
            this.grpsit.TabStop = false;
            this.grpsit.Text = "Situation familiale";
            // 
            // radcel
            // 
            this.radcel.AutoSize = true;
            this.radcel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radcel.Location = new System.Drawing.Point(30, 31);
            this.radcel.Name = "radcel";
            this.radcel.Size = new System.Drawing.Size(104, 20);
            this.radcel.TabIndex = 0;
            this.radcel.TabStop = true;
            this.radcel.Text = "Célibataire";
            this.radcel.UseVisualStyleBackColor = true;
            // 
            // radmar
            // 
            this.radmar.AutoSize = true;
            this.radmar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radmar.Location = new System.Drawing.Point(30, 70);
            this.radmar.Name = "radmar";
            this.radmar.Size = new System.Drawing.Size(86, 20);
            this.radmar.TabIndex = 1;
            this.radmar.TabStop = true;
            this.radmar.Text = "Marié(e)";
            this.radmar.UseVisualStyleBackColor = true;
            // 
            // raddiv
            // 
            this.raddiv.AutoSize = true;
            this.raddiv.ForeColor = System.Drawing.SystemColors.InfoText;
            this.raddiv.Location = new System.Drawing.Point(30, 109);
            this.raddiv.Name = "raddiv";
            this.raddiv.Size = new System.Drawing.Size(101, 20);
            this.raddiv.TabIndex = 9;
            this.raddiv.TabStop = true;
            this.raddiv.Text = "Divorcé(e)";
            this.raddiv.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nbenf);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(62, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 64);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enfants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre d\'enfants";
            // 
            // cmdvalid
            // 
            this.cmdvalid.BackColor = System.Drawing.Color.Lime;
            this.cmdvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdvalid.Location = new System.Drawing.Point(401, 180);
            this.cmdvalid.Name = "cmdvalid";
            this.cmdvalid.Size = new System.Drawing.Size(104, 27);
            this.cmdvalid.TabIndex = 10;
            this.cmdvalid.Text = "Valider";
            this.cmdvalid.UseVisualStyleBackColor = false;
            this.cmdvalid.Click += new System.EventHandler(this.cmdvalid_Click);
            // 
            // cmdinit
            // 
            this.cmdinit.BackColor = System.Drawing.Color.Yellow;
            this.cmdinit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinit.Location = new System.Drawing.Point(401, 225);
            this.cmdinit.Name = "cmdinit";
            this.cmdinit.Size = new System.Drawing.Size(104, 28);
            this.cmdinit.TabIndex = 11;
            this.cmdinit.Text = "Initialiser";
            this.cmdinit.UseVisualStyleBackColor = false;
            this.cmdinit.Click += new System.EventHandler(this.cmdinit_Click);
            // 
            // cmdquit
            // 
            this.cmdquit.BackColor = System.Drawing.Color.Red;
            this.cmdquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdquit.Location = new System.Drawing.Point(401, 277);
            this.cmdquit.Name = "cmdquit";
            this.cmdquit.Size = new System.Drawing.Size(104, 29);
            this.cmdquit.TabIndex = 12;
            this.cmdquit.Text = "Quitter";
            this.cmdquit.UseVisualStyleBackColor = false;
            this.cmdquit.Click += new System.EventHandler(this.cmdquit_Click);
            // 
            // nbenf
            // 
            this.nbenf.Location = new System.Drawing.Point(180, 27);
            this.nbenf.Name = "nbenf";
            this.nbenf.Size = new System.Drawing.Size(130, 22);
            this.nbenf.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 535);
            this.Controls.Add(this.cmdquit);
            this.Controls.Add(this.cmdinit);
            this.Controls.Add(this.cmdvalid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpsit);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Informations personnelles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpsit.ResumeLayout(false);
            this.grpsit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbenf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexe;
        private System.Windows.Forms.GroupBox grpsit;
        private System.Windows.Forms.RadioButton raddiv;
        private System.Windows.Forms.RadioButton radmar;
        private System.Windows.Forms.RadioButton radcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdvalid;
        private System.Windows.Forms.Button cmdinit;
        private System.Windows.Forms.Button cmdquit;
        private System.Windows.Forms.NumericUpDown nbenf;
    }
}

