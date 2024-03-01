namespace PARKOT.WindowsFormUI
{
    partial class Parkot
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
            this.dgw_Cars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Cars
            // 
            this.dgw_Cars.AllowUserToAddRows = false;
            this.dgw_Cars.AllowUserToDeleteRows = false;
            this.dgw_Cars.AllowUserToResizeColumns = false;
            this.dgw_Cars.AllowUserToResizeRows = false;
            this.dgw_Cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Cars.Location = new System.Drawing.Point(12, 258);
            this.dgw_Cars.Name = "dgw_Cars";
            this.dgw_Cars.ReadOnly = true;
            this.dgw_Cars.RowHeadersWidth = 51;
            this.dgw_Cars.RowTemplate.Height = 24;
            this.dgw_Cars.Size = new System.Drawing.Size(992, 220);
            this.dgw_Cars.TabIndex = 0;
            // 
            // Parkot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 490);
            this.Controls.Add(this.dgw_Cars);
            this.Name = "Parkot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Cars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Cars;
    }
}

