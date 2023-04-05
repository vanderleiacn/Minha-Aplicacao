namespace MinhaAplicacao
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
            this.rdSuco = new System.Windows.Forms.RadioButton();
            this.rdTv = new System.Windows.Forms.RadioButton();
            this.rdBatom = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdSuco
            // 
            this.rdSuco.AutoSize = true;
            this.rdSuco.Checked = true;
            this.rdSuco.Location = new System.Drawing.Point(68, 58);
            this.rdSuco.Name = "rdSuco";
            this.rdSuco.Size = new System.Drawing.Size(71, 24);
            this.rdSuco.TabIndex = 0;
            this.rdSuco.TabStop = true;
            this.rdSuco.Text = "Suco";
            this.rdSuco.UseVisualStyleBackColor = true;
            // 
            // rdTv
            // 
            this.rdTv.AutoSize = true;
            this.rdTv.Location = new System.Drawing.Point(68, 108);
            this.rdTv.Name = "rdTv";
            this.rdTv.Size = new System.Drawing.Size(50, 24);
            this.rdTv.TabIndex = 1;
            this.rdTv.Text = "Tv";
            this.rdTv.UseVisualStyleBackColor = true;
            // 
            // rdBatom
            // 
            this.rdBatom.AutoSize = true;
            this.rdBatom.Location = new System.Drawing.Point(68, 159);
            this.rdBatom.Name = "rdBatom";
            this.rdBatom.Size = new System.Drawing.Size(81, 24);
            this.rdBatom.TabIndex = 2;
            this.rdBatom.Text = "Batom";
            this.rdBatom.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(109, 307);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 38);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(68, 214);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(169, 26);
            this.txtPreco.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 428);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rdBatom);
            this.Controls.Add(this.rdTv);
            this.Controls.Add(this.rdSuco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdSuco;
        private System.Windows.Forms.RadioButton rdTv;
        private System.Windows.Forms.RadioButton rdBatom;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPreco;
    }
}

