namespace Impresiones
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtArchivo = new TextBox();
            cboPrioridad = new ComboBox();
            cmdImprimir = new Button();
            lstAlta = new ListBox();
            lstMedia = new ListBox();
            lstBaja = new ListBox();
            cmdEjecutar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Archivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Prioridad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 2;
            label3.Text = "Prioridad Alta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 233);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 3;
            label4.Text = "Prioridad Media";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 355);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 4;
            label5.Text = "Prioridad Baja";
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(118, 8);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(374, 34);
            txtArchivo.TabIndex = 5;
            // 
            // cboPrioridad
            // 
            cboPrioridad.FormattingEnabled = true;
            cboPrioridad.Items.AddRange(new object[] { "ALTA", "MEDIA", "BAJA" });
            cboPrioridad.Location = new Point(118, 56);
            cboPrioridad.Name = "cboPrioridad";
            cboPrioridad.Size = new Size(191, 36);
            cboPrioridad.TabIndex = 6;
            // 
            // cmdImprimir
            // 
            cmdImprimir.BackColor = Color.FromArgb(0, 64, 0);
            cmdImprimir.ForeColor = SystemColors.ButtonFace;
            cmdImprimir.Location = new Point(327, 52);
            cmdImprimir.Name = "cmdImprimir";
            cmdImprimir.Size = new Size(165, 46);
            cmdImprimir.TabIndex = 7;
            cmdImprimir.Text = "Imprimir";
            cmdImprimir.UseVisualStyleBackColor = false;
            cmdImprimir.Click += cmdImprimir_Click;
            // 
            // lstAlta
            // 
            lstAlta.FormattingEnabled = true;
            lstAlta.ItemHeight = 28;
            lstAlta.Location = new Point(12, 142);
            lstAlta.Name = "lstAlta";
            lstAlta.Size = new Size(480, 88);
            lstAlta.TabIndex = 8;
            // 
            // lstMedia
            // 
            lstMedia.FormattingEnabled = true;
            lstMedia.ItemHeight = 28;
            lstMedia.Location = new Point(12, 264);
            lstMedia.Name = "lstMedia";
            lstMedia.Size = new Size(480, 88);
            lstMedia.TabIndex = 9;
            // 
            // lstBaja
            // 
            lstBaja.FormattingEnabled = true;
            lstBaja.ItemHeight = 28;
            lstBaja.Location = new Point(12, 386);
            lstBaja.Name = "lstBaja";
            lstBaja.Size = new Size(480, 88);
            lstBaja.TabIndex = 10;
            // 
            // cmdEjecutar
            // 
            cmdEjecutar.BackColor = Color.FromArgb(0, 64, 0);
            cmdEjecutar.ForeColor = SystemColors.ButtonFace;
            cmdEjecutar.Location = new Point(327, 480);
            cmdEjecutar.Name = "cmdEjecutar";
            cmdEjecutar.Size = new Size(165, 46);
            cmdEjecutar.TabIndex = 11;
            cmdEjecutar.Text = "Ejecutar";
            cmdEjecutar.UseVisualStyleBackColor = false;
            cmdEjecutar.Click += cmdEjecutar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(504, 539);
            Controls.Add(cmdEjecutar);
            Controls.Add(lstBaja);
            Controls.Add(lstMedia);
            Controls.Add(lstAlta);
            Controls.Add(cmdImprimir);
            Controls.Add(cboPrioridad);
            Controls.Add(txtArchivo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestiòn de impresiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtArchivo;
        private ComboBox cboPrioridad;
        private Button cmdImprimir;
        private ListBox lstAlta;
        private ListBox lstMedia;
        private ListBox lstBaja;
        private Button cmdEjecutar;
        private System.Windows.Forms.Timer timer1;
    }
}