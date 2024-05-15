namespace MoralesDelfino.Malena._323
{
    partial class Malena
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            btnAtender = new Button();
            btnSalir = new Button();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 12);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(279, 274);
            lstMedicos.TabIndex = 0;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(328, 12);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(294, 274);
            lstPacientes.TabIndex = 1;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(647, 25);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(107, 49);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(647, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 49);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 300);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(610, 138);
            rtbInfoMedico.TabIndex = 4;
            rtbInfoMedico.Text = "";
            // 
            // Malena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(rtbInfoMedico);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "Malena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Malena_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox rtbInfoMedico;
    }
}
