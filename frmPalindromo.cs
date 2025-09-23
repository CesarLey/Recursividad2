using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmPalindromo : Form
    {
        public frmPalindromo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblTexto = new Label();
            this.txtTexto = new TextBox();
            this.btnVerificar = new Button();
            this.lblResultado = new Label();
            this.txtResultado = new TextBox();
            this.btnLimpiar = new Button();
            this.btnRegresar = new Button();
            this.lblInformacion = new Label();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(150, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(250, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VERIFICADOR DE PALÍNDROMO";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblInformacion
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblInformacion.Location = new Point(50, 60);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new Size(450, 17);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Un palíndromo es una palabra o frase que se lee igual de izquierda a derecha.";

            // lblTexto
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblTexto.Location = new Point(80, 100);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new Size(120, 20);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Ingrese texto:";

            // txtTexto
            this.txtTexto.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtTexto.Location = new Point(220, 97);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new Size(200, 26);
            this.txtTexto.TabIndex = 3;

            // btnVerificar
            this.btnVerificar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnVerificar.Location = new Point(80, 140);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new Size(120, 40);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new EventHandler(this.btnVerificar_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new Point(80, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new Size(100, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";

            // txtResultado
            this.txtResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtResultado.Location = new Point(80, 230);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = ScrollBars.Vertical;
            this.txtResultado.Size = new Size(350, 100);
            this.txtResultado.TabIndex = 6;

            // btnLimpiar
            this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new Point(220, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 40);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);

            // btnRegresar
            this.btnRegresar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new Point(340, 140);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(100, 40);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new EventHandler(this.btnRegresar_Click);

            // frmPalindromo
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 360);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPalindromo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Palíndromo - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblInformacion;
        private Label lblTexto;
        private TextBox txtTexto;
        private Button btnVerificar;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnLimpiar;
        private Button btnRegresar;

        /// <summary>
        /// Método recursivo para verificar si una cadena es palíndromo
        /// </summary>
        /// <param name="texto">Texto a verificar</param>
        /// <param name="inicio">Posición inicial</param>
        /// <param name="fin">Posición final</param>
        /// <returns>True si es palíndromo, False en caso contrario</returns>
        private bool EsPalindromoRecursivo(string texto, int inicio, int fin)
        {
            // Caso base: si inicio >= fin, hemos verificado toda la cadena
            if (inicio >= fin)
                return true;
            
            // Si los caracteres en las posiciones inicio y fin no coinciden
            if (texto[inicio] != texto[fin])
                return false;
            
            // Llamada recursiva para verificar el siguiente par de caracteres
            return EsPalindromoRecursivo(texto, inicio + 1, fin - 1);
        }

        /// <summary>
        /// Método auxiliar para limpiar y normalizar el texto
        /// </summary>
        /// <param name="texto">Texto original</param>
        /// <returns>Texto normalizado (sin espacios, en minúsculas)</returns>
        private string NormalizarTexto(string texto)
        {
            string textoNormalizado = texto.ToLower();
            string resultado = "";
            
            foreach (char c in textoNormalizado)
            {
                if (char.IsLetterOrDigit(c))
                {
                    resultado += c;
                }
            }
            
            return resultado;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado texto
                if (string.IsNullOrWhiteSpace(txtTexto.Text))
                {
                    MessageBox.Show("Por favor, ingrese un texto para verificar.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTexto.Focus();
                    return;
                }

                string textoOriginal = txtTexto.Text.Trim();
                string textoNormalizado = NormalizarTexto(textoOriginal);
                
                // Validar que el texto normalizado no esté vacío
                if (string.IsNullOrEmpty(textoNormalizado))
                {
                    MessageBox.Show("El texto debe contener al menos una letra o dígito.", "Texto inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTexto.Clear();
                    txtTexto.Focus();
                    return;
                }

                // Verificar si es palíndromo usando recursión
                bool esPalindromo = EsPalindromoRecursivo(textoNormalizado, 0, textoNormalizado.Length - 1);
                
                // Mostrar resultado
                string resultado = $"Texto original: \"{textoOriginal}\"\n";
                resultado += $"Texto normalizado: \"{textoNormalizado}\"\n";
                resultado += $"Longitud: {textoNormalizado.Length} caracteres\n\n";
                
                if (esPalindromo)
                {
                    resultado += "✅ RESULTADO: ES PALÍNDROMO\n";
                    resultado += "El texto se lee igual de izquierda a derecha y viceversa.";
                }
                else
                {
                    resultado += "❌ RESULTADO: NO ES PALÍNDROMO\n";
                    resultado += "El texto no se lee igual de izquierda a derecha y viceversa.";
                }
                
                resultado += "\n\n=== ANÁLISIS DETALLADO ===\n";
                resultado += $"Caracteres comparados: {textoNormalizado.Length / 2 + (textoNormalizado.Length % 2)}\n";
                
                // Mostrar comparación carácter por carácter
                for (int i = 0; i < textoNormalizado.Length / 2; i++)
                {
                    char izquierda = textoNormalizado[i];
                    char derecha = textoNormalizado[textoNormalizado.Length - 1 - i];
                    resultado += $"Posición {i}: '{izquierda}' vs '{derecha}' - {(izquierda == derecha ? "✓" : "✗")}\n";
                }
                
                txtResultado.Text = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el palíndromo: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtResultado.Clear();
            txtTexto.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
