
namespace Ahorcado
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dificil = new System.Windows.Forms.RadioButton();
            this.medio = new System.Windows.Forms.RadioButton();
            this.facil = new System.Windows.Forms.RadioButton();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.ModoAdmin = new System.Windows.Forms.Button();
            this.AtrasAdmin = new System.Windows.Forms.Button();
            this.AccederAdmin = new System.Windows.Forms.Button();
            this.ClaveAdmin = new System.Windows.Forms.TextBox();
            this.NombreAdmin = new System.Windows.Forms.TextBox();
            this.botonJ = new System.Windows.Forms.Button();
            this.botonH = new System.Windows.Forms.Button();
            this.botonB = new System.Windows.Forms.Button();
            this.botonC = new System.Windows.Forms.Button();
            this.botonD = new System.Windows.Forms.Button();
            this.botonF = new System.Windows.Forms.Button();
            this.botonG = new System.Windows.Forms.Button();
            this.botonU = new System.Windows.Forms.Button();
            this.botonA = new System.Windows.Forms.Button();
            this.botonE = new System.Windows.Forms.Button();
            this.botonI = new System.Windows.Forms.Button();
            this.botonO = new System.Windows.Forms.Button();
            this.botonQ = new System.Windows.Forms.Button();
            this.botonP = new System.Windows.Forms.Button();
            this.botonK = new System.Windows.Forms.Button();
            this.botonL = new System.Windows.Forms.Button();
            this.botonM = new System.Windows.Forms.Button();
            this.botonN = new System.Windows.Forms.Button();
            this.botonÑ = new System.Windows.Forms.Button();
            this.botonZ = new System.Windows.Forms.Button();
            this.botonY = new System.Windows.Forms.Button();
            this.botonS = new System.Windows.Forms.Button();
            this.botonT = new System.Windows.Forms.Button();
            this.botonV = new System.Windows.Forms.Button();
            this.botonW = new System.Windows.Forms.Button();
            this.botonX = new System.Windows.Forms.Button();
            this.botonR = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Jugar = new System.Windows.Forms.Button();
            this.Renunciar = new System.Windows.Forms.Button();
            this.logoPequeno = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.adminControl1 = new Ahorcado.AdminControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPequeno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dificil
            // 
            this.dificil.AutoSize = true;
            this.dificil.Location = new System.Drawing.Point(719, 278);
            this.dificil.Name = "dificil";
            this.dificil.Size = new System.Drawing.Size(151, 22);
            this.dificil.TabIndex = 124;
            this.dificil.Text = "Difícil (sin ayuda)";
            this.dificil.UseVisualStyleBackColor = true;
            // 
            // medio
            // 
            this.medio.AutoSize = true;
            this.medio.Checked = true;
            this.medio.Location = new System.Drawing.Point(719, 237);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(210, 22);
            this.medio.TabIndex = 123;
            this.medio.TabStop = true;
            this.medio.Text = "Medio (1 letra de ayuda)";
            this.medio.UseVisualStyleBackColor = true;
            // 
            // facil
            // 
            this.facil.AutoSize = true;
            this.facil.Location = new System.Drawing.Point(719, 196);
            this.facil.Name = "facil";
            this.facil.Size = new System.Drawing.Size(206, 22);
            this.facil.TabIndex = 122;
            this.facil.Text = "Fácil (2 letras de ayuda)";
            this.facil.UseVisualStyleBackColor = true;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(754, 506);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(49, 18);
            this.labelClave.TabIndex = 121;
            this.labelClave.Text = "Clave";
            this.labelClave.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(754, 473);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 18);
            this.labelNombre.TabIndex = 120;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Visible = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Black;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Image = global::Ahorcado.Properties.Resources.shutdown_30px;
            this.Salir.Location = new System.Drawing.Point(828, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(110, 38);
            this.Salir.TabIndex = 0;
            this.Salir.Text = " Cerrar";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // ModoAdmin
            // 
            this.ModoAdmin.BackColor = System.Drawing.Color.Black;
            this.ModoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModoAdmin.ForeColor = System.Drawing.Color.White;
            this.ModoAdmin.Image = global::Ahorcado.Properties.Resources.settings_20px;
            this.ModoAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModoAdmin.Location = new System.Drawing.Point(828, 610);
            this.ModoAdmin.Name = "ModoAdmin";
            this.ModoAdmin.Size = new System.Drawing.Size(110, 30);
            this.ModoAdmin.TabIndex = 2;
            this.ModoAdmin.Text = " Admin";
            this.ModoAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModoAdmin.UseVisualStyleBackColor = false;
            this.ModoAdmin.Click += new System.EventHandler(this.ModoAdmin_Click);
            // 
            // AtrasAdmin
            // 
            this.AtrasAdmin.BackColor = System.Drawing.Color.Black;
            this.AtrasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtrasAdmin.ForeColor = System.Drawing.Color.White;
            this.AtrasAdmin.Image = global::Ahorcado.Properties.Resources.back_to_20px;
            this.AtrasAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AtrasAdmin.Location = new System.Drawing.Point(828, 573);
            this.AtrasAdmin.Name = "AtrasAdmin";
            this.AtrasAdmin.Size = new System.Drawing.Size(110, 30);
            this.AtrasAdmin.TabIndex = 6;
            this.AtrasAdmin.Text = " Atrás";
            this.AtrasAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AtrasAdmin.UseVisualStyleBackColor = false;
            this.AtrasAdmin.Visible = false;
            this.AtrasAdmin.Click += new System.EventHandler(this.AtrasAdmin_Click);
            // 
            // AccederAdmin
            // 
            this.AccederAdmin.BackColor = System.Drawing.Color.Black;
            this.AccederAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccederAdmin.ForeColor = System.Drawing.Color.White;
            this.AccederAdmin.Image = global::Ahorcado.Properties.Resources.enter_20px;
            this.AccederAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccederAdmin.Location = new System.Drawing.Point(828, 536);
            this.AccederAdmin.Name = "AccederAdmin";
            this.AccederAdmin.Size = new System.Drawing.Size(110, 30);
            this.AccederAdmin.TabIndex = 5;
            this.AccederAdmin.Text = " Acceder";
            this.AccederAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccederAdmin.UseVisualStyleBackColor = false;
            this.AccederAdmin.Visible = false;
            this.AccederAdmin.Click += new System.EventHandler(this.AccederAdmin_Click);
            // 
            // ClaveAdmin
            // 
            this.ClaveAdmin.Location = new System.Drawing.Point(828, 503);
            this.ClaveAdmin.Name = "ClaveAdmin";
            this.ClaveAdmin.Size = new System.Drawing.Size(110, 26);
            this.ClaveAdmin.TabIndex = 4;
            this.ClaveAdmin.UseSystemPasswordChar = true;
            this.ClaveAdmin.Visible = false;
            // 
            // NombreAdmin
            // 
            this.NombreAdmin.Location = new System.Drawing.Point(828, 470);
            this.NombreAdmin.Name = "NombreAdmin";
            this.NombreAdmin.Size = new System.Drawing.Size(110, 26);
            this.NombreAdmin.TabIndex = 3;
            this.NombreAdmin.Visible = false;
            // 
            // botonJ
            // 
            this.botonJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonJ.ForeColor = System.Drawing.Color.Black;
            this.botonJ.Location = new System.Drawing.Point(599, 501);
            this.botonJ.Margin = new System.Windows.Forms.Padding(4);
            this.botonJ.Name = "botonJ";
            this.botonJ.Size = new System.Drawing.Size(40, 40);
            this.botonJ.TabIndex = 153;
            this.botonJ.Text = "J";
            this.botonJ.UseVisualStyleBackColor = false;
            this.botonJ.Visible = false;
            this.botonJ.Click += new System.EventHandler(this.botonJ_Click);
            // 
            // botonH
            // 
            this.botonH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonH.ForeColor = System.Drawing.Color.Black;
            this.botonH.Location = new System.Drawing.Point(551, 501);
            this.botonH.Margin = new System.Windows.Forms.Padding(4);
            this.botonH.Name = "botonH";
            this.botonH.Size = new System.Drawing.Size(40, 40);
            this.botonH.TabIndex = 152;
            this.botonH.Text = "H";
            this.botonH.UseVisualStyleBackColor = false;
            this.botonH.Visible = false;
            this.botonH.Click += new System.EventHandler(this.botonH_Click);
            // 
            // botonB
            // 
            this.botonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonB.ForeColor = System.Drawing.Color.Black;
            this.botonB.Location = new System.Drawing.Point(311, 501);
            this.botonB.Margin = new System.Windows.Forms.Padding(4);
            this.botonB.Name = "botonB";
            this.botonB.Size = new System.Drawing.Size(40, 40);
            this.botonB.TabIndex = 151;
            this.botonB.Text = "B";
            this.botonB.UseVisualStyleBackColor = false;
            this.botonB.Visible = false;
            this.botonB.Click += new System.EventHandler(this.botonB_Click);
            // 
            // botonC
            // 
            this.botonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonC.ForeColor = System.Drawing.Color.Black;
            this.botonC.Location = new System.Drawing.Point(359, 501);
            this.botonC.Margin = new System.Windows.Forms.Padding(4);
            this.botonC.Name = "botonC";
            this.botonC.Size = new System.Drawing.Size(40, 40);
            this.botonC.TabIndex = 150;
            this.botonC.Text = "C";
            this.botonC.UseVisualStyleBackColor = false;
            this.botonC.Visible = false;
            this.botonC.Click += new System.EventHandler(this.botonC_Click);
            // 
            // botonD
            // 
            this.botonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonD.ForeColor = System.Drawing.Color.Black;
            this.botonD.Location = new System.Drawing.Point(407, 501);
            this.botonD.Margin = new System.Windows.Forms.Padding(4);
            this.botonD.Name = "botonD";
            this.botonD.Size = new System.Drawing.Size(40, 40);
            this.botonD.TabIndex = 149;
            this.botonD.Text = "D";
            this.botonD.UseVisualStyleBackColor = false;
            this.botonD.Visible = false;
            this.botonD.Click += new System.EventHandler(this.botonD_Click);
            // 
            // botonF
            // 
            this.botonF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonF.ForeColor = System.Drawing.Color.Black;
            this.botonF.Location = new System.Drawing.Point(455, 501);
            this.botonF.Margin = new System.Windows.Forms.Padding(4);
            this.botonF.Name = "botonF";
            this.botonF.Size = new System.Drawing.Size(40, 40);
            this.botonF.TabIndex = 148;
            this.botonF.Text = "F";
            this.botonF.UseVisualStyleBackColor = false;
            this.botonF.Visible = false;
            this.botonF.Click += new System.EventHandler(this.botonF_Click);
            // 
            // botonG
            // 
            this.botonG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonG.ForeColor = System.Drawing.Color.Black;
            this.botonG.Location = new System.Drawing.Point(503, 501);
            this.botonG.Margin = new System.Windows.Forms.Padding(4);
            this.botonG.Name = "botonG";
            this.botonG.Size = new System.Drawing.Size(40, 40);
            this.botonG.TabIndex = 147;
            this.botonG.Text = "G";
            this.botonG.UseVisualStyleBackColor = false;
            this.botonG.Visible = false;
            this.botonG.Click += new System.EventHandler(this.botonG_Click);
            // 
            // botonU
            // 
            this.botonU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonU.ForeColor = System.Drawing.Color.Black;
            this.botonU.Location = new System.Drawing.Point(551, 453);
            this.botonU.Margin = new System.Windows.Forms.Padding(4);
            this.botonU.Name = "botonU";
            this.botonU.Size = new System.Drawing.Size(40, 40);
            this.botonU.TabIndex = 146;
            this.botonU.Text = "U";
            this.botonU.UseVisualStyleBackColor = false;
            this.botonU.Visible = false;
            this.botonU.Click += new System.EventHandler(this.botonU_Click);
            // 
            // botonA
            // 
            this.botonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonA.ForeColor = System.Drawing.Color.Black;
            this.botonA.Location = new System.Drawing.Point(359, 453);
            this.botonA.Margin = new System.Windows.Forms.Padding(4);
            this.botonA.Name = "botonA";
            this.botonA.Size = new System.Drawing.Size(40, 40);
            this.botonA.TabIndex = 145;
            this.botonA.Text = "A";
            this.botonA.UseVisualStyleBackColor = false;
            this.botonA.Visible = false;
            this.botonA.Click += new System.EventHandler(this.botonA_Click);
            // 
            // botonE
            // 
            this.botonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonE.ForeColor = System.Drawing.Color.Black;
            this.botonE.Location = new System.Drawing.Point(407, 453);
            this.botonE.Margin = new System.Windows.Forms.Padding(4);
            this.botonE.Name = "botonE";
            this.botonE.Size = new System.Drawing.Size(40, 40);
            this.botonE.TabIndex = 144;
            this.botonE.Text = "E";
            this.botonE.UseVisualStyleBackColor = false;
            this.botonE.Visible = false;
            this.botonE.Click += new System.EventHandler(this.botonE_Click);
            // 
            // botonI
            // 
            this.botonI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonI.ForeColor = System.Drawing.Color.Black;
            this.botonI.Location = new System.Drawing.Point(455, 453);
            this.botonI.Margin = new System.Windows.Forms.Padding(4);
            this.botonI.Name = "botonI";
            this.botonI.Size = new System.Drawing.Size(40, 40);
            this.botonI.TabIndex = 143;
            this.botonI.Text = "I";
            this.botonI.UseVisualStyleBackColor = false;
            this.botonI.Visible = false;
            this.botonI.Click += new System.EventHandler(this.botonI_Click);
            // 
            // botonO
            // 
            this.botonO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonO.ForeColor = System.Drawing.Color.Black;
            this.botonO.Location = new System.Drawing.Point(503, 453);
            this.botonO.Margin = new System.Windows.Forms.Padding(4);
            this.botonO.Name = "botonO";
            this.botonO.Size = new System.Drawing.Size(40, 40);
            this.botonO.TabIndex = 142;
            this.botonO.Text = "O";
            this.botonO.UseVisualStyleBackColor = false;
            this.botonO.Visible = false;
            this.botonO.Click += new System.EventHandler(this.botonO_Click);
            // 
            // botonQ
            // 
            this.botonQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonQ.ForeColor = System.Drawing.Color.Black;
            this.botonQ.Location = new System.Drawing.Point(599, 549);
            this.botonQ.Margin = new System.Windows.Forms.Padding(4);
            this.botonQ.Name = "botonQ";
            this.botonQ.Size = new System.Drawing.Size(40, 40);
            this.botonQ.TabIndex = 141;
            this.botonQ.Text = "Q";
            this.botonQ.UseVisualStyleBackColor = false;
            this.botonQ.Visible = false;
            this.botonQ.Click += new System.EventHandler(this.botonQ_Click);
            // 
            // botonP
            // 
            this.botonP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonP.ForeColor = System.Drawing.Color.Black;
            this.botonP.Location = new System.Drawing.Point(551, 549);
            this.botonP.Margin = new System.Windows.Forms.Padding(4);
            this.botonP.Name = "botonP";
            this.botonP.Size = new System.Drawing.Size(40, 40);
            this.botonP.TabIndex = 140;
            this.botonP.Text = "P";
            this.botonP.UseVisualStyleBackColor = false;
            this.botonP.Visible = false;
            this.botonP.Click += new System.EventHandler(this.botonP_Click);
            // 
            // botonK
            // 
            this.botonK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonK.ForeColor = System.Drawing.Color.Black;
            this.botonK.Location = new System.Drawing.Point(311, 549);
            this.botonK.Margin = new System.Windows.Forms.Padding(4);
            this.botonK.Name = "botonK";
            this.botonK.Size = new System.Drawing.Size(40, 40);
            this.botonK.TabIndex = 139;
            this.botonK.Text = "K";
            this.botonK.UseVisualStyleBackColor = false;
            this.botonK.Visible = false;
            this.botonK.Click += new System.EventHandler(this.botonK_Click);
            // 
            // botonL
            // 
            this.botonL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonL.ForeColor = System.Drawing.Color.Black;
            this.botonL.Location = new System.Drawing.Point(359, 549);
            this.botonL.Margin = new System.Windows.Forms.Padding(4);
            this.botonL.Name = "botonL";
            this.botonL.Size = new System.Drawing.Size(40, 40);
            this.botonL.TabIndex = 138;
            this.botonL.Text = "L";
            this.botonL.UseVisualStyleBackColor = false;
            this.botonL.Visible = false;
            this.botonL.Click += new System.EventHandler(this.botonL_Click);
            // 
            // botonM
            // 
            this.botonM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonM.ForeColor = System.Drawing.Color.Black;
            this.botonM.Location = new System.Drawing.Point(407, 549);
            this.botonM.Margin = new System.Windows.Forms.Padding(4);
            this.botonM.Name = "botonM";
            this.botonM.Size = new System.Drawing.Size(40, 40);
            this.botonM.TabIndex = 137;
            this.botonM.Text = "M";
            this.botonM.UseVisualStyleBackColor = false;
            this.botonM.Visible = false;
            this.botonM.Click += new System.EventHandler(this.botonM_Click);
            // 
            // botonN
            // 
            this.botonN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonN.ForeColor = System.Drawing.Color.Black;
            this.botonN.Location = new System.Drawing.Point(455, 549);
            this.botonN.Margin = new System.Windows.Forms.Padding(4);
            this.botonN.Name = "botonN";
            this.botonN.Size = new System.Drawing.Size(40, 40);
            this.botonN.TabIndex = 136;
            this.botonN.Text = "N";
            this.botonN.UseVisualStyleBackColor = false;
            this.botonN.Visible = false;
            this.botonN.Click += new System.EventHandler(this.botonN_Click);
            // 
            // botonÑ
            // 
            this.botonÑ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonÑ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonÑ.ForeColor = System.Drawing.Color.Black;
            this.botonÑ.Location = new System.Drawing.Point(503, 549);
            this.botonÑ.Margin = new System.Windows.Forms.Padding(4);
            this.botonÑ.Name = "botonÑ";
            this.botonÑ.Size = new System.Drawing.Size(40, 40);
            this.botonÑ.TabIndex = 135;
            this.botonÑ.Text = "Ñ";
            this.botonÑ.UseVisualStyleBackColor = false;
            this.botonÑ.Visible = false;
            this.botonÑ.Click += new System.EventHandler(this.botonÑ_Click);
            // 
            // botonZ
            // 
            this.botonZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonZ.ForeColor = System.Drawing.Color.Black;
            this.botonZ.Location = new System.Drawing.Point(624, 597);
            this.botonZ.Margin = new System.Windows.Forms.Padding(4);
            this.botonZ.Name = "botonZ";
            this.botonZ.Size = new System.Drawing.Size(40, 40);
            this.botonZ.TabIndex = 134;
            this.botonZ.Text = "Z";
            this.botonZ.UseVisualStyleBackColor = false;
            this.botonZ.Visible = false;
            this.botonZ.Click += new System.EventHandler(this.botonZ_Click);
            // 
            // botonY
            // 
            this.botonY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonY.ForeColor = System.Drawing.Color.Black;
            this.botonY.Location = new System.Drawing.Point(576, 597);
            this.botonY.Margin = new System.Windows.Forms.Padding(4);
            this.botonY.Name = "botonY";
            this.botonY.Size = new System.Drawing.Size(40, 40);
            this.botonY.TabIndex = 133;
            this.botonY.Text = "Y";
            this.botonY.UseVisualStyleBackColor = false;
            this.botonY.Visible = false;
            this.botonY.Click += new System.EventHandler(this.botonY_Click);
            // 
            // botonS
            // 
            this.botonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonS.ForeColor = System.Drawing.Color.Black;
            this.botonS.Location = new System.Drawing.Point(336, 597);
            this.botonS.Margin = new System.Windows.Forms.Padding(4);
            this.botonS.Name = "botonS";
            this.botonS.Size = new System.Drawing.Size(40, 40);
            this.botonS.TabIndex = 132;
            this.botonS.Text = "S";
            this.botonS.UseVisualStyleBackColor = false;
            this.botonS.Visible = false;
            this.botonS.Click += new System.EventHandler(this.botonS_Click);
            // 
            // botonT
            // 
            this.botonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonT.ForeColor = System.Drawing.Color.Black;
            this.botonT.Location = new System.Drawing.Point(384, 597);
            this.botonT.Margin = new System.Windows.Forms.Padding(4);
            this.botonT.Name = "botonT";
            this.botonT.Size = new System.Drawing.Size(40, 40);
            this.botonT.TabIndex = 131;
            this.botonT.Text = "T";
            this.botonT.UseVisualStyleBackColor = false;
            this.botonT.Visible = false;
            this.botonT.Click += new System.EventHandler(this.botonT_Click);
            // 
            // botonV
            // 
            this.botonV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonV.ForeColor = System.Drawing.Color.Black;
            this.botonV.Location = new System.Drawing.Point(432, 597);
            this.botonV.Margin = new System.Windows.Forms.Padding(4);
            this.botonV.Name = "botonV";
            this.botonV.Size = new System.Drawing.Size(40, 40);
            this.botonV.TabIndex = 130;
            this.botonV.Text = "V";
            this.botonV.UseVisualStyleBackColor = false;
            this.botonV.Visible = false;
            this.botonV.Click += new System.EventHandler(this.botonV_Click);
            // 
            // botonW
            // 
            this.botonW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonW.ForeColor = System.Drawing.Color.Black;
            this.botonW.Location = new System.Drawing.Point(480, 597);
            this.botonW.Margin = new System.Windows.Forms.Padding(4);
            this.botonW.Name = "botonW";
            this.botonW.Size = new System.Drawing.Size(40, 40);
            this.botonW.TabIndex = 129;
            this.botonW.Text = "W";
            this.botonW.UseVisualStyleBackColor = false;
            this.botonW.Visible = false;
            this.botonW.Click += new System.EventHandler(this.botonW_Click);
            // 
            // botonX
            // 
            this.botonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonX.ForeColor = System.Drawing.Color.Black;
            this.botonX.Location = new System.Drawing.Point(528, 597);
            this.botonX.Margin = new System.Windows.Forms.Padding(4);
            this.botonX.Name = "botonX";
            this.botonX.Size = new System.Drawing.Size(40, 40);
            this.botonX.TabIndex = 128;
            this.botonX.Text = "X";
            this.botonX.UseVisualStyleBackColor = false;
            this.botonX.Visible = false;
            this.botonX.Click += new System.EventHandler(this.botonX_Click);
            // 
            // botonR
            // 
            this.botonR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonR.ForeColor = System.Drawing.Color.Black;
            this.botonR.Location = new System.Drawing.Point(288, 597);
            this.botonR.Margin = new System.Windows.Forms.Padding(4);
            this.botonR.Name = "botonR";
            this.botonR.Size = new System.Drawing.Size(40, 40);
            this.botonR.TabIndex = 127;
            this.botonR.Text = "R";
            this.botonR.UseVisualStyleBackColor = false;
            this.botonR.Visible = false;
            this.botonR.Click += new System.EventHandler(this.botonR_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.Black;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.ForeColor = System.Drawing.Color.White;
            this.Atras.Image = global::Ahorcado.Properties.Resources.back_to_30px;
            this.Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Atras.Location = new System.Drawing.Point(719, 372);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(113, 38);
            this.Atras.TabIndex = 161;
            this.Atras.Text = " Atrás";
            this.Atras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Visible = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Ahorcado.Properties.Resources.ahorcado_8;
            this.pictureBox.Location = new System.Drawing.Point(20, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 360);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 157;
            this.pictureBox.TabStop = false;
            // 
            // Jugar
            // 
            this.Jugar.BackColor = System.Drawing.Color.Black;
            this.Jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jugar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugar.ForeColor = System.Drawing.Color.White;
            this.Jugar.Image = global::Ahorcado.Properties.Resources.play_30px;
            this.Jugar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Jugar.Location = new System.Drawing.Point(719, 319);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(113, 38);
            this.Jugar.TabIndex = 1;
            this.Jugar.Text = " Jugar";
            this.Jugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Jugar.UseVisualStyleBackColor = false;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Renunciar
            // 
            this.Renunciar.BackColor = System.Drawing.Color.Black;
            this.Renunciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Renunciar.ForeColor = System.Drawing.Color.White;
            this.Renunciar.Image = global::Ahorcado.Properties.Resources.sad_30px;
            this.Renunciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Renunciar.Location = new System.Drawing.Point(83, 496);
            this.Renunciar.Name = "Renunciar";
            this.Renunciar.Size = new System.Drawing.Size(121, 38);
            this.Renunciar.TabIndex = 113;
            this.Renunciar.Text = "  Rendirse";
            this.Renunciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Renunciar.UseVisualStyleBackColor = false;
            this.Renunciar.Visible = false;
            this.Renunciar.Click += new System.EventHandler(this.Renunciar_Click);
            // 
            // logoPequeno
            // 
            this.logoPequeno.Image = global::Ahorcado.Properties.Resources.Ahorcado;
            this.logoPequeno.Location = new System.Drawing.Point(735, 84);
            this.logoPequeno.Name = "logoPequeno";
            this.logoPequeno.Size = new System.Drawing.Size(175, 175);
            this.logoPequeno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPequeno.TabIndex = 160;
            this.logoPequeno.TabStop = false;
            this.logoPequeno.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = global::Ahorcado.Properties.Resources.Ahorcado;
            this.logo.Location = new System.Drawing.Point(277, 30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(400, 400);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 159;
            this.logo.TabStop = false;
            // 
            // adminControl1
            // 
            this.adminControl1.BackColor = System.Drawing.Color.White;
            this.adminControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminControl1.Location = new System.Drawing.Point(0, 0);
            this.adminControl1.Margin = new System.Windows.Forms.Padding(4);
            this.adminControl1.Name = "adminControl1";
            this.adminControl1.Size = new System.Drawing.Size(700, 650);
            this.adminControl1.TabIndex = 162;
            this.adminControl1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 650);
            this.panel1.TabIndex = 163;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 2);
            this.panel2.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(948, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 648);
            this.panel3.TabIndex = 165;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 648);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(946, 2);
            this.panel4.TabIndex = 166;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.dificil);
            this.Controls.Add(this.medio);
            this.Controls.Add(this.facil);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.ModoAdmin);
            this.Controls.Add(this.AtrasAdmin);
            this.Controls.Add(this.AccederAdmin);
            this.Controls.Add(this.ClaveAdmin);
            this.Controls.Add(this.NombreAdmin);
            this.Controls.Add(this.Renunciar);
            this.Controls.Add(this.botonJ);
            this.Controls.Add(this.botonH);
            this.Controls.Add(this.botonB);
            this.Controls.Add(this.botonC);
            this.Controls.Add(this.botonD);
            this.Controls.Add(this.botonF);
            this.Controls.Add(this.botonG);
            this.Controls.Add(this.botonU);
            this.Controls.Add(this.botonA);
            this.Controls.Add(this.botonE);
            this.Controls.Add(this.botonI);
            this.Controls.Add(this.botonO);
            this.Controls.Add(this.botonQ);
            this.Controls.Add(this.botonP);
            this.Controls.Add(this.botonK);
            this.Controls.Add(this.botonL);
            this.Controls.Add(this.botonM);
            this.Controls.Add(this.botonN);
            this.Controls.Add(this.botonÑ);
            this.Controls.Add(this.botonZ);
            this.Controls.Add(this.botonY);
            this.Controls.Add(this.botonS);
            this.Controls.Add(this.botonT);
            this.Controls.Add(this.botonV);
            this.Controls.Add(this.botonW);
            this.Controls.Add(this.botonX);
            this.Controls.Add(this.botonR);
            this.Controls.Add(this.logoPequeno);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.adminControl1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPequeno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.RadioButton dificil;
        private System.Windows.Forms.RadioButton medio;
        private System.Windows.Forms.RadioButton facil;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button ModoAdmin;
        private System.Windows.Forms.Button AtrasAdmin;
        private System.Windows.Forms.Button AccederAdmin;
        private System.Windows.Forms.TextBox ClaveAdmin;
        private System.Windows.Forms.Button Renunciar;
        private System.Windows.Forms.Button botonJ;
        private System.Windows.Forms.Button botonH;
        private System.Windows.Forms.Button botonB;
        private System.Windows.Forms.Button botonC;
        private System.Windows.Forms.Button botonD;
        private System.Windows.Forms.Button botonF;
        private System.Windows.Forms.Button botonG;
        private System.Windows.Forms.Button botonU;
        private System.Windows.Forms.Button botonA;
        private System.Windows.Forms.Button botonE;
        private System.Windows.Forms.Button botonI;
        private System.Windows.Forms.Button botonO;
        private System.Windows.Forms.Button botonQ;
        private System.Windows.Forms.Button botonP;
        private System.Windows.Forms.Button botonK;
        private System.Windows.Forms.Button botonL;
        private System.Windows.Forms.Button botonM;
        private System.Windows.Forms.Button botonN;
        private System.Windows.Forms.Button botonÑ;
        private System.Windows.Forms.Button botonZ;
        private System.Windows.Forms.Button botonY;
        private System.Windows.Forms.Button botonS;
        private System.Windows.Forms.Button botonT;
        private System.Windows.Forms.Button botonV;
        private System.Windows.Forms.Button botonW;
        private System.Windows.Forms.Button botonX;
        private System.Windows.Forms.Button botonR;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox logoPequeno;
        private System.Windows.Forms.Button Atras;
        public System.Windows.Forms.TextBox NombreAdmin;
        private AdminControl adminControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

