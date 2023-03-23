namespace Criando_minha_autenticacao
{
    partial class Principal
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
            btn_Logoff = new Button();
            SuspendLayout();
            // 
            // btn_Logoff
            // 
            btn_Logoff.Location = new Point(427, 28);
            btn_Logoff.Name = "btn_Logoff";
            btn_Logoff.Size = new Size(79, 32);
            btn_Logoff.TabIndex = 0;
            btn_Logoff.Text = "Logoff";
            btn_Logoff.UseVisualStyleBackColor = true;
            btn_Logoff.Click += btn_Logoff_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(btn_Logoff);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Logoff;
    }
}