namespace Condicinales
{
    partial class frmcondicionales
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
            this.btnedad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnedad
            // 
            this.btnedad.Location = new System.Drawing.Point(313, 66);
            this.btnedad.Name = "btnedad";
            this.btnedad.Size = new System.Drawing.Size(75, 23);
            this.btnedad.TabIndex = 0;
            this.btnedad.Text = "Calcular";
            this.btnedad.UseVisualStyleBackColor = true;
            this.btnedad.Click += new System.EventHandler(this.btnedad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar edad";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(50, 124);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(55, 13);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "Resultado";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(152, 69);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 3;
            // 
            // frmcondicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnedad);
            this.Name = "frmcondicionales";
            this.Text = "frmcondicionales";
            this.Load += new System.EventHandler(this.frmcondicionales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtedad;
    }
}