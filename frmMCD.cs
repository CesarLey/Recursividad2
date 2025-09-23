using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmMCD : Form
    {
        public frmMCD()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblNumero1 = new Label();
            this.txtNumero1 = new TextBox();
            this.lblNumero2 = new Label();
            this.txtNumero2 = new TextBox();
            this.btnCalcular = new Button();
            this.lblResultado = new Label();
            this.txtResultado = new TextBox();
            this.btnLimpiar = new Button();
            this.btnRegresar = new Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(150, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(300, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MÁXIMO COMÚN DIVISOR (MCD)";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblNumero1
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblNumero1.Location = new Point(80, 80);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new Size(80, 20);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Número 1:";

            // txtNumero1
            this.txtNumero1.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtNumero1.Location = new Point(180, 77);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new Size(120, 26);
            this.txtNumero1.TabIndex = 2;

            // lblNumero2
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblNumero2.Location = new Point(320, 80);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new Size(80, 20);
            this.lblNumero2.TabIndex = 3;
            this.lblNumero2.Text = "Número 2:";

            // txtNumero2
            this.txtNumero2.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtNumero2.Location = new Point(420, 77);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new Size(120, 26);
            this.txtNumero2.TabIndex = 4;

            // btnCalcular
            this.btnCalcular.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new Point(80, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new Size(100, 40);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular MCD";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new Point(80, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new Size(100, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "MCD Resultado:";

            // txtResultado
            this.txtResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtResultado.Location = new Point(200, 197);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new Size(120, 26);
            this.txtResultado.TabIndex = 7;

            // btnLimpiar
            this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new Point(200, 130);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);

            // btnRegresar
            this.btnRegresar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new Point(320, 130);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(100, 40);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new EventHandler(this.btnRegresar_Click);

            // frmMCD
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 280);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmMCD";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MCD - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblNumero1;
        private TextBox txtNumero1;
        private Label lblNumero2;
        private TextBox txtNumero2;
        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnLimpiar;
        private Button btnRegresar;

        /// <summary>
        /// Método recursivo para calcular el Máximo Común Divisor usando el algoritmo de Euclides
        /// </summary>
        /// <param name="a">Primer número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>MCD de a y b</returns>
        private int MCDRecursivo(int a, int b)
        {
            // Caso base: si b es 0, entonces a es el MCD
            if (b == 0)
                return Math.Abs(a);
            
            // Caso recursivo: MCD(a, b) = MCD(b, a mod b)
            return MCDRecursivo(b, a % b);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se hayan ingresado ambos números
                if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
                {
                    MessageBox.Show("Por favor, ingrese ambos números.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrWhiteSpace(txtNumero1.Text))
                        txtNumero1.Focus();
                    else
                        txtNumero2.Focus();
                    return;
                }

                // Validar que sean números enteros
                if (!int.TryParse(txtNumero1.Text, out int numero1))
                {
                    MessageBox.Show("El primer número debe ser un entero válido.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero1.Clear();
                    txtNumero1.Focus();
                    return;
                }

                if (!int.TryParse(txtNumero2.Text, out int numero2))
                {
                    MessageBox.Show("El segundo número debe ser un entero válido.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero2.Clear();
                    txtNumero2.Focus();
                    return;
                }

                // Validar que no sean ambos cero
                if (numero1 == 0 && numero2 == 0)
                {
                    MessageBox.Show("Ambos números no pueden ser cero.", "Datos inválidos", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                    txtNumero1.Focus();
                    return;
                }

                // Calcular MCD usando recursión
                int resultado = MCDRecursivo(numero1, numero2);
                
                // Mostrar resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el MCD: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
