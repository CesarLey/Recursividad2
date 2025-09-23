using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmTorresHanoi : Form
    {
        public frmTorresHanoi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblDiscos = new Label();
            this.txtDiscos = new TextBox();
            this.btnResolver = new Button();
            this.lblMovimientos = new Label();
            this.txtMovimientos = new TextBox();
            this.btnLimpiar = new Button();
            this.btnRegresar = new Button();
            this.lblInformacion = new Label();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(150, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(200, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TORRES DE HANÓI";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblInformacion
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblInformacion.Location = new Point(50, 60);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new Size(450, 17);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Mueva todos los discos de la torre origen a la torre destino.";

            // lblDiscos
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblDiscos.Location = new Point(80, 100);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new Size(120, 20);
            this.lblDiscos.TabIndex = 2;
            this.lblDiscos.Text = "Número de discos:";

            // txtDiscos
            this.txtDiscos.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtDiscos.Location = new Point(220, 97);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new Size(100, 26);
            this.txtDiscos.TabIndex = 3;

            // btnResolver
            this.btnResolver.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnResolver.Location = new Point(80, 140);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new Size(120, 40);
            this.btnResolver.TabIndex = 4;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new EventHandler(this.btnResolver_Click);

            // lblMovimientos
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblMovimientos.Location = new Point(80, 200);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new Size(150, 20);
            this.lblMovimientos.TabIndex = 5;
            this.lblMovimientos.Text = "Secuencia de movimientos:";

            // txtMovimientos
            this.txtMovimientos.Font = new Font("Microsoft Sans Serif", 10F);
            this.txtMovimientos.Location = new Point(80, 230);
            this.txtMovimientos.Multiline = true;
            this.txtMovimientos.Name = "txtMovimientos";
            this.txtMovimientos.ReadOnly = true;
            this.txtMovimientos.ScrollBars = ScrollBars.Vertical;
            this.txtMovimientos.Size = new Size(400, 200);
            this.txtMovimientos.TabIndex = 6;

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

            // frmTorresHanoi
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(520, 460);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMovimientos);
            this.Controls.Add(this.lblMovimientos);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtDiscos);
            this.Controls.Add(this.lblDiscos);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmTorresHanoi";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanói - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblInformacion;
        private Label lblDiscos;
        private TextBox txtDiscos;
        private Button btnResolver;
        private Label lblMovimientos;
        private TextBox txtMovimientos;
        private Button btnLimpiar;
        private Button btnRegresar;

        private int contadorMovimientos = 0;

        /// <summary>
        /// Método recursivo para resolver el problema de las Torres de Hanói
        /// </summary>
        /// <param name="discos">Número de discos a mover</param>
        /// <param name="origen">Torre origen (A, B, C)</param>
        /// <param name="destino">Torre destino (A, B, C)</param>
        /// <param name="auxiliar">Torre auxiliar (A, B, C)</param>
        /// <param name="resultado">StringBuilder para almacenar los movimientos</param>
        private void ResolverHanoiRecursivo(int discos, char origen, char destino, char auxiliar, System.Text.StringBuilder resultado)
        {
            // Caso base: si solo hay un disco, lo movemos directamente
            if (discos == 1)
            {
                contadorMovimientos++;
                resultado.AppendLine($"Movimiento {contadorMovimientos}: Mover disco de {origen} a {destino}");
            }
            else
            {
                // Paso 1: Mover n-1 discos de origen a auxiliar
                ResolverHanoiRecursivo(discos - 1, origen, auxiliar, destino, resultado);
                
                // Paso 2: Mover el disco más grande de origen a destino
                contadorMovimientos++;
                resultado.AppendLine($"Movimiento {contadorMovimientos}: Mover disco de {origen} a {destino}");
                
                // Paso 3: Mover n-1 discos de auxiliar a destino
                ResolverHanoiRecursivo(discos - 1, auxiliar, destino, origen, resultado);
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un número
                if (string.IsNullOrWhiteSpace(txtDiscos.Text))
                {
                    MessageBox.Show("Por favor, ingrese el número de discos.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscos.Focus();
                    return;
                }

                // Validar que sea un número entero
                if (!int.TryParse(txtDiscos.Text, out int discos))
                {
                    MessageBox.Show("Por favor, ingrese solo números enteros.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscos.Clear();
                    txtDiscos.Focus();
                    return;
                }

                // Validar que el número sea positivo
                if (discos <= 0)
                {
                    MessageBox.Show("El número de discos debe ser mayor a 0.", 
                        "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscos.Clear();
                    txtDiscos.Focus();
                    return;
                }

                // Validar que el número no sea muy grande para evitar problemas de rendimiento
                if (discos > 10)
                {
                    MessageBox.Show("Para evitar problemas de rendimiento, ingrese un número menor o igual a 10.", 
                        "Número muy grande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscos.Clear();
                    txtDiscos.Focus();
                    return;
                }

                // Reiniciar contador de movimientos
                contadorMovimientos = 0;
                
                // Crear StringBuilder para almacenar los movimientos
                System.Text.StringBuilder resultado = new System.Text.StringBuilder();
                
                resultado.AppendLine($"=== SOLUCIÓN PARA {discos} DISCO(S) ===");
                resultado.AppendLine($"Torre origen: A, Torre destino: C, Torre auxiliar: B");
                resultado.AppendLine();
                
                // Resolver el problema usando recursión
                ResolverHanoiRecursivo(discos, 'A', 'C', 'B', resultado);
                
                // Calcular número mínimo de movimientos (2^n - 1)
                int movimientosMinimos = (int)Math.Pow(2, discos) - 1;
                
                resultado.AppendLine();
                resultado.AppendLine($"=== RESUMEN ===");
                resultado.AppendLine($"Total de movimientos realizados: {contadorMovimientos}");
                resultado.AppendLine($"Número mínimo de movimientos: {movimientosMinimos}");
                resultado.AppendLine($"¿Solución óptima? {(contadorMovimientos == movimientosMinimos ? "SÍ" : "NO")}");
                
                // Mostrar resultado
                txtMovimientos.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al resolver las Torres de Hanói: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDiscos.Clear();
            txtMovimientos.Clear();
            contadorMovimientos = 0;
            txtDiscos.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
