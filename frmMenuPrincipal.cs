using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.btnFactorial = new Button();
            this.btnFibonacci = new Button();
            this.btnMCD = new Button();
            this.btnCambioMonedas = new Button();
            this.btnTorresHanoi = new Button();
            this.btnPalindromo = new Button();
            this.btnPermutaciones = new Button();
            this.btnSalir = new Button();
            this.pnlContainer = new Panel(); // Panel para agrupar controles
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(150, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(350, 26);
            this.lblTitulo.TabIndex = 9; // Ajustar TabIndex
            this.lblTitulo.Text = "Actividad 2 - Recursividad";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // btnFactorial
            this.btnFactorial.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnFactorial.Location = new Point(80, 80);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new Size(200, 40);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "1. Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new EventHandler(this.btnFactorial_Click);

            // btnFibonacci
            this.btnFibonacci.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnFibonacci.Location = new Point(320, 80);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new Size(200, 40);
            this.btnFibonacci.TabIndex = 2;
            this.btnFibonacci.Text = "2. Serie de Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new EventHandler(this.btnFibonacci_Click);

            // btnMCD
            this.btnMCD.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnMCD.Location = new Point(80, 140);
            this.btnMCD.Name = "btnMCD";
            this.btnMCD.Size = new Size(200, 40);
            this.btnMCD.TabIndex = 3;
            this.btnMCD.Text = "3. Máximo Común Divisor";
            this.btnMCD.UseVisualStyleBackColor = true;
            this.btnMCD.Click += new EventHandler(this.btnMCD_Click);

            // btnCambioMonedas
            this.btnCambioMonedas.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnCambioMonedas.Location = new Point(320, 140);
            this.btnCambioMonedas.Name = "btnCambioMonedas";
            this.btnCambioMonedas.Size = new Size(200, 40);
            this.btnCambioMonedas.TabIndex = 4;
            this.btnCambioMonedas.Text = "4. Cambio de Monedas";
            this.btnCambioMonedas.UseVisualStyleBackColor = true;
            this.btnCambioMonedas.Click += new EventHandler(this.btnCambioMonedas_Click);

            // btnTorresHanoi
            this.btnTorresHanoi.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnTorresHanoi.Location = new Point(80, 200);
            this.btnTorresHanoi.Name = "btnTorresHanoi";
            this.btnTorresHanoi.Size = new Size(200, 40);
            this.btnTorresHanoi.TabIndex = 5;
            this.btnTorresHanoi.Text = "5. Torres de Hanói";
            this.btnTorresHanoi.UseVisualStyleBackColor = true;
            this.btnTorresHanoi.Click += new EventHandler(this.btnTorresHanoi_Click);

            // btnPalindromo
            this.btnPalindromo.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnPalindromo.Location = new Point(320, 200);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new Size(200, 40);
            this.btnPalindromo.TabIndex = 6;
            this.btnPalindromo.Text = "6. Verificar Palíndromo";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new EventHandler(this.btnPalindromo_Click);

            // btnPermutaciones
            this.btnPermutaciones.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnPermutaciones.Location = new Point(80, 260);
            this.btnPermutaciones.Name = "btnPermutaciones";
            this.btnPermutaciones.Size = new Size(200, 40);
            this.btnPermutaciones.TabIndex = 7;
            this.btnPermutaciones.Text = "7. Permutaciones";
            this.btnPermutaciones.UseVisualStyleBackColor = true;
            this.btnPermutaciones.Click += new EventHandler(this.btnPermutaciones_Click);

            // btnSalir
            this.btnSalir.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new Point(320, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new Size(200, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "8. Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new EventHandler(this.btnSalir_Click);

            // pnlContainer (Panel para centrar)
            this.pnlContainer.SuspendLayout();
            this.pnlContainer.Controls.Add(this.btnFactorial);
            this.pnlContainer.Controls.Add(this.btnFibonacci);
            this.pnlContainer.Controls.Add(this.btnMCD);
            this.pnlContainer.Controls.Add(this.btnCambioMonedas);
            this.pnlContainer.Controls.Add(this.btnTorresHanoi);
            this.pnlContainer.Controls.Add(this.btnPalindromo);
            this.pnlContainer.Controls.Add(this.btnPermutaciones);
            this.pnlContainer.Controls.Add(this.btnSalir);
            this.pnlContainer.Location = new Point(0, 60);
            this.pnlContainer.Size = new Size(600, 320); // Aumentar altura del panel
            this.pnlContainer.ResumeLayout(false);

            // frmMenuPrincipal
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 410); // Aumentar altura del formulario
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitulo);
            this.MinimumSize = new Size(620, 400); // Tamaño mínimo para que no se corte
            this.Name = "frmMenuPrincipal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Práctica de Recursividad";
            this.Resize += new EventHandler(this.frmMenuPrincipal_Resize); // Añadir evento Resize
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Button btnFactorial;
        private Button btnFibonacci;
        private Button btnMCD;
        private Button btnCambioMonedas;
        private Button btnTorresHanoi;
        private Button btnPalindromo;
        private Button btnPermutaciones;
        private Button btnSalir;
        private Panel pnlContainer;

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            frmFactorial frm = new frmFactorial();
            frm.ShowDialog();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            frmFibonacci frm = new frmFibonacci();
            frm.ShowDialog();
        }

        private void btnMCD_Click(object sender, EventArgs e)
        {
            frmMCD frm = new frmMCD();
            frm.ShowDialog();
        }

        private void btnCambioMonedas_Click(object sender, EventArgs e)
        {
            frmCambioMonedas frm = new frmCambioMonedas();
            frm.ShowDialog();
        }

        private void btnTorresHanoi_Click(object sender, EventArgs e)
        {
            frmTorresHanoi frm = new frmTorresHanoi();
            frm.ShowDialog();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            frmPalindromo frm = new frmPalindromo();
            frm.ShowDialog();
        }

        private void btnPermutaciones_Click(object sender, EventArgs e)
        {
            frmPermutaciones frm = new frmPermutaciones();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenuPrincipal_Resize(object sender, EventArgs e)
        {
            // Centrar el título y el panel de botones horizontalmente
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            pnlContainer.Left = (this.ClientSize.Width - pnlContainer.Width) / 2;
            pnlContainer.Top = lblTitulo.Bottom + 20;
        }
    }
}
