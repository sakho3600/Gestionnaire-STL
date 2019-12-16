namespace GestionnaireSTL
{
    partial class Espace_Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerLeParcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherVéhiculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterVéhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierVéhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerVéhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTarifsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterTarifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierTarifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerTarifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(157, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espace Administrateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenue, veuillez choisir une action";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLeParcToolStripMenuItem,
            this.gérerLesComptesToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerLeParcToolStripMenuItem
            // 
            this.gérerLeParcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherVéhiculesToolStripMenuItem,
            this.ajouterVéhiculeToolStripMenuItem,
            this.modifierVéhiculeToolStripMenuItem,
            this.supprimerVéhiculeToolStripMenuItem});
            this.gérerLeParcToolStripMenuItem.Name = "gérerLeParcToolStripMenuItem";
            this.gérerLeParcToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.gérerLeParcToolStripMenuItem.Text = "Gérer le parc";
            this.gérerLeParcToolStripMenuItem.Click += new System.EventHandler(this.gérerLeParcToolStripMenuItem_Click);
            // 
            // afficherVéhiculesToolStripMenuItem
            // 
            this.afficherVéhiculesToolStripMenuItem.Name = "afficherVéhiculesToolStripMenuItem";
            this.afficherVéhiculesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.afficherVéhiculesToolStripMenuItem.Text = "Afficher véhicules";
            this.afficherVéhiculesToolStripMenuItem.Click += new System.EventHandler(this.afficherVéhiculesToolStripMenuItem_Click);
            // 
            // ajouterVéhiculeToolStripMenuItem
            // 
            this.ajouterVéhiculeToolStripMenuItem.Name = "ajouterVéhiculeToolStripMenuItem";
            this.ajouterVéhiculeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ajouterVéhiculeToolStripMenuItem.Text = "Ajouter véhicule";
            this.ajouterVéhiculeToolStripMenuItem.Click += new System.EventHandler(this.ajouterVéhiculeToolStripMenuItem_Click);
            // 
            // modifierVéhiculeToolStripMenuItem
            // 
            this.modifierVéhiculeToolStripMenuItem.Name = "modifierVéhiculeToolStripMenuItem";
            this.modifierVéhiculeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modifierVéhiculeToolStripMenuItem.Text = "Modifier véhicule";
            this.modifierVéhiculeToolStripMenuItem.Click += new System.EventHandler(this.modifierVéhiculeToolStripMenuItem_Click);
            // 
            // supprimerVéhiculeToolStripMenuItem
            // 
            this.supprimerVéhiculeToolStripMenuItem.Name = "supprimerVéhiculeToolStripMenuItem";
            this.supprimerVéhiculeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.supprimerVéhiculeToolStripMenuItem.Text = "Supprimer véhicule";
            this.supprimerVéhiculeToolStripMenuItem.Click += new System.EventHandler(this.supprimerVéhiculeToolStripMenuItem_Click);
            // 
            // gérerLesComptesToolStripMenuItem
            // 
            this.gérerLesComptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageComptesToolStripMenuItem,
            this.ajouterCompteToolStripMenuItem,
            this.modifierCompteToolStripMenuItem,
            this.supprimerCompteToolStripMenuItem});
            this.gérerLesComptesToolStripMenuItem.Name = "gérerLesComptesToolStripMenuItem";
            this.gérerLesComptesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.gérerLesComptesToolStripMenuItem.Text = "Gérer les comptes";
            // 
            // affichageComptesToolStripMenuItem
            // 
            this.affichageComptesToolStripMenuItem.Name = "affichageComptesToolStripMenuItem";
            this.affichageComptesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.affichageComptesToolStripMenuItem.Text = "Affichage comptes";
            this.affichageComptesToolStripMenuItem.Click += new System.EventHandler(this.affichageComptesToolStripMenuItem_Click);
            // 
            // ajouterCompteToolStripMenuItem
            // 
            this.ajouterCompteToolStripMenuItem.Name = "ajouterCompteToolStripMenuItem";
            this.ajouterCompteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterCompteToolStripMenuItem.Text = "Ajouter compte";
            this.ajouterCompteToolStripMenuItem.Click += new System.EventHandler(this.ajouterCompteToolStripMenuItem_Click);
            // 
            // modifierCompteToolStripMenuItem
            // 
            this.modifierCompteToolStripMenuItem.Name = "modifierCompteToolStripMenuItem";
            this.modifierCompteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.modifierCompteToolStripMenuItem.Text = "Modifier compte";
            this.modifierCompteToolStripMenuItem.Click += new System.EventHandler(this.modifierCompteToolStripMenuItem_Click);
            // 
            // supprimerCompteToolStripMenuItem
            // 
            this.supprimerCompteToolStripMenuItem.Name = "supprimerCompteToolStripMenuItem";
            this.supprimerCompteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.supprimerCompteToolStripMenuItem.Text = "Supprimer compte";
            this.supprimerCompteToolStripMenuItem.Click += new System.EventHandler(this.supprimerCompteToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherTarifsToolStripMenuItem,
            this.ajouterTarifToolStripMenuItem,
            this.modifierTarifToolStripMenuItem,
            this.supprimerTarifToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.gérerToolStripMenuItem.Text = "Gérer les tarifs";
            // 
            // afficherTarifsToolStripMenuItem
            // 
            this.afficherTarifsToolStripMenuItem.Name = "afficherTarifsToolStripMenuItem";
            this.afficherTarifsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.afficherTarifsToolStripMenuItem.Text = "Afficher tarifs";
            this.afficherTarifsToolStripMenuItem.Click += new System.EventHandler(this.afficherTarifsToolStripMenuItem_Click);
            // 
            // ajouterTarifToolStripMenuItem
            // 
            this.ajouterTarifToolStripMenuItem.Name = "ajouterTarifToolStripMenuItem";
            this.ajouterTarifToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ajouterTarifToolStripMenuItem.Text = "Ajouter tarif";
            this.ajouterTarifToolStripMenuItem.Click += new System.EventHandler(this.ajouterTarifToolStripMenuItem_Click);
            // 
            // modifierTarifToolStripMenuItem
            // 
            this.modifierTarifToolStripMenuItem.Name = "modifierTarifToolStripMenuItem";
            this.modifierTarifToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modifierTarifToolStripMenuItem.Text = "Modifier tarif";
            this.modifierTarifToolStripMenuItem.Click += new System.EventHandler(this.modifierTarifToolStripMenuItem_Click);
            // 
            // supprimerTarifToolStripMenuItem
            // 
            this.supprimerTarifToolStripMenuItem.Name = "supprimerTarifToolStripMenuItem";
            this.supprimerTarifToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.supprimerTarifToolStripMenuItem.Text = "Supprimer tarif";
            this.supprimerTarifToolStripMenuItem.Click += new System.EventHandler(this.supprimerTarifToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Espace_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Espace_Admin";
            this.Text = "Espace Admin";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerLeParcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterVéhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierVéhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerVéhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterTarifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierTarifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerTarifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTarifsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherVéhiculesToolStripMenuItem;
    }
}