using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblNumero = new Label();
            this.txtNumero = new TextBox();
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
            this.lblTitulo.Size = new Size(200, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CÁLCULO DE FACTORIAL";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblNumero.Location = new Point(80, 80);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new Size(120, 20);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Ingrese número:";

            // txtNumero
            this.txtNumero.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtNumero.Location = new Point(220, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new Size(150, 26);
            this.txtNumero.TabIndex = 2;

            // btnCalcular
            this.btnCalcular.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new Point(80, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new Size(100, 40);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new Point(80, 180);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new Size(80, 20);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";

            // txtResultado
            this.txtResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtResultado.Location = new Point(220, 177);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new Size(200, 26);
            this.txtResultado.TabIndex = 5;

            // btnLimpiar
            this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new Point(200, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 40);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);

            // btnRegresar
            this.btnRegresar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new Point(320, 120);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(100, 40);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new EventHandler(this.btnRegresar_Click);

            // frmFactorial
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 250);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFactorial";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Factorial - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnLimpiar;
        private Button btnRegresar;

        /// <summary>
        /// Método recursivo para calcular el factorial de un número
        /// </summary>
        /// <param name="n">Número para calcular factorial</param>
        /// <returns>Factorial del número</returns>
        private long CalcularFactorialRecursivo(int n)
        {
            // Caso base: factorial de 0 y 1 es 1
            if (n <= 1)
                return 1;
            
            // Caso recursivo: n! = n * (n-1)!
            return n * CalcularFactorialRecursivo(n - 1);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un número
                if (string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    return;
                }

                // Validar que sea un número entero
                if (!int.TryParse(txtNumero.Text, out int numero))
                {
                    MessageBox.Show("Por favor, ingrese solo números enteros.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.Focus();
                    return;
                }

                // Validar que el número sea positivo
                if (numero < 0)
                {
                    MessageBox.Show("El factorial solo se puede calcular para números positivos.", 
                        "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.Focus();
                    return;
                }

                // Validar que el número no sea muy grande para evitar desbordamiento
                if (numero > 20)
                {
                    MessageBox.Show("Para evitar desbordamiento, ingrese un número menor o igual a 20.", 
                        "Número muy grande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Clear();
                    txtNumero.Focus();
                    return;
                }

                // Calcular factorial usando recursión
                long resultado = CalcularFactorialRecursivo(numero);
                
                // Mostrar resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el factorial: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtResultado.Clear();
            txtNumero.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
