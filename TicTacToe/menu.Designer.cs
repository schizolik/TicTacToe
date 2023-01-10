namespace TicTacToe
{
    partial class menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3x3 = new System.Windows.Forms.Button();
            this.button4x4 = new System.Windows.Forms.Button();
            this.buttonImpossible3x3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3x3
            // 
            this.button3x3.Location = new System.Drawing.Point(144, 139);
            this.button3x3.Name = "button3x3";
            this.button3x3.Size = new System.Drawing.Size(106, 58);
            this.button3x3.TabIndex = 0;
            this.button3x3.Text = "3x3";
            this.button3x3.UseVisualStyleBackColor = true;
            this.button3x3.Click += new System.EventHandler(this.button3x3_Click);
            // 
            // button4x4
            // 
            this.button4x4.Location = new System.Drawing.Point(256, 139);
            this.button4x4.Name = "button4x4";
            this.button4x4.Size = new System.Drawing.Size(106, 59);
            this.button4x4.TabIndex = 1;
            this.button4x4.Text = "4x4";
            this.button4x4.UseVisualStyleBackColor = true;
            this.button4x4.Click += new System.EventHandler(this.button4x4_Click);
            // 
            // buttonImpossible3x3
            // 
            this.buttonImpossible3x3.Location = new System.Drawing.Point(368, 140);
            this.buttonImpossible3x3.Name = "buttonImpossible3x3";
            this.buttonImpossible3x3.Size = new System.Drawing.Size(106, 59);
            this.buttonImpossible3x3.TabIndex = 2;
            this.buttonImpossible3x3.Text = "impossible";
            this.buttonImpossible3x3.UseVisualStyleBackColor = true;
            this.buttonImpossible3x3.Click += new System.EventHandler(this.buttonImpossible3x3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(274, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImpossible3x3);
            this.Controls.Add(this.button4x4);
            this.Controls.Add(this.button3x3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3x3;
        private System.Windows.Forms.Button button4x4;
        private System.Windows.Forms.Button buttonImpossible3x3;
        private System.Windows.Forms.Label label1;
    }
}

