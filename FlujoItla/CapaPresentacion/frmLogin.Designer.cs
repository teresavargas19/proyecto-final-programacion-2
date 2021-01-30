namespace CapaPresentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelP = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labelU = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(386, 468);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(173, 22);
            this.txtPass.TabIndex = 21;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(193, 468);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(88, 17);
            this.labelP.TabIndex = 20;
            this.labelP.Text = "PASSWORD";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(389, 407);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(173, 22);
            this.txtUser.TabIndex = 19;
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(196, 407);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(46, 17);
            this.labelU.TabIndex = 18;
            this.labelU.Text = "USER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-19, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 7;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = null;
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 50D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(399, 616);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(240, 56);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Textcolor = System.Drawing.Color.White;
            this.btnSalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIngresar.BorderRadius = 7;
            this.BtnIngresar.ButtonText = "Ingresar";
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnIngresar.Iconimage = null;
            this.BtnIngresar.Iconimage_right = null;
            this.BtnIngresar.Iconimage_right_Selected = null;
            this.BtnIngresar.Iconimage_Selected = null;
            this.BtnIngresar.IconMarginLeft = 0;
            this.BtnIngresar.IconMarginRight = 0;
            this.BtnIngresar.IconRightVisible = true;
            this.BtnIngresar.IconRightZoom = 0D;
            this.BtnIngresar.IconVisible = true;
            this.BtnIngresar.IconZoom = 50D;
            this.BtnIngresar.IsTab = false;
            this.BtnIngresar.Location = new System.Drawing.Point(75, 616);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnIngresar.selected = false;
            this.BtnIngresar.Size = new System.Drawing.Size(246, 54);
            this.BtnIngresar.TabIndex = 75;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIngresar.Textcolor = System.Drawing.Color.White;
            this.BtnIngresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private Bunifu.Framework.UI.BunifuFlatButton BtnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}