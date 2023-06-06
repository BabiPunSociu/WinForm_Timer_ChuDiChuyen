namespace Bai14_Trang76_Timer
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
            this.components = new System.ComponentModel.Container();
            this.lblVTH = new System.Windows.Forms.Label();
            this.tmrHenGio = new System.Windows.Forms.Timer(this.components);
            this.lblTraiSangPhai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVTH
            // 
            this.lblVTH.AutoSize = true;
            this.lblVTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTH.ForeColor = System.Drawing.Color.Red;
            this.lblVTH.Location = new System.Drawing.Point(41, 38);
            this.lblVTH.Name = "lblVTH";
            this.lblVTH.Size = new System.Drawing.Size(218, 39);
            this.lblVTH.TabIndex = 0;
            this.lblVTH.Text = "Vũ Thu Hiền";
            this.lblVTH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrHenGio
            // 
            this.tmrHenGio.Tick += new System.EventHandler(this.tmrHenGio_Tick);
            // 
            // lblTraiSangPhai
            // 
            this.lblTraiSangPhai.AutoSize = true;
            this.lblTraiSangPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraiSangPhai.ForeColor = System.Drawing.Color.Red;
            this.lblTraiSangPhai.Location = new System.Drawing.Point(41, 119);
            this.lblTraiSangPhai.Name = "lblTraiSangPhai";
            this.lblTraiSangPhai.Size = new System.Drawing.Size(218, 39);
            this.lblTraiSangPhai.TabIndex = 1;
            this.lblTraiSangPhai.Text = "Vũ Thu Hiền";
            this.lblTraiSangPhai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1153, 206);
            this.Controls.Add(this.lblTraiSangPhai);
            this.Controls.Add(this.lblVTH);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều khiển Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVTH;
        private System.Windows.Forms.Timer tmrHenGio;
        private System.Windows.Forms.Label lblTraiSangPhai;
    }
}

