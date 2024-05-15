namespace PARCIAL1
{
    partial class Felipe_Mendiondo
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
            components = new System.ComponentModel.Container();
            lblMedicos = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            lblPacientes = new Label();
            rtbInfoMedico = new RichTextBox();
            btnAtender = new Button();
            btnSalir = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(43, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 0;
            lblMedicos.Text = "Personal Medico";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 27);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(205, 139);
            lstMedicos.TabIndex = 1;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(320, 27);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(205, 139);
            lstPacientes.TabIndex = 2;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(413, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 3;
            lblPacientes.Text = "Pacientes";
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 203);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(513, 235);
            rtbInfoMedico.TabIndex = 4;
            rtbInfoMedico.Text = "";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(623, 27);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(110, 48);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(623, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 50);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Felipe_Mendiondo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lblPacientes);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblMedicos);
            Name = "Felipe_Mendiondo";
            Text = "Atencion de Pacientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedicos;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Label lblPacientes;
        private RichTextBox rtbInfoMedico;
        private Button btnAtender;
        private Button btnSalir;
        private NotifyIcon notifyIcon1;
    }
}
