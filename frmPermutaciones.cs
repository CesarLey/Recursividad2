using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmPermutaciones : Form
    {
        public frmPermutaciones()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblTexto = new Label();
            this.txtTexto = new TextBox();
            this.btnGenerar = new Button();
            this.lblResultado = new Label();
            this.lvResultado = new ListView(); // Cambiado de TextBox a ListView
            this.btnLimpiar = new Button();
            this.btnRegresar = new Button();
            this.lblInformacion = new Label();
            this.lblContador = new Label();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(150, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(250, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GENERADOR DE PERMUTACIONES";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblInformacion
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblInformacion.Location = new Point(50, 60);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new Size(450, 17);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Genera todas las posibles permutaciones de los caracteres ingresados.";

            // lblTexto
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblTexto.Location = new Point(80, 100);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new Size(150, 20);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Ingrese caracteres:";

            // txtTexto
            this.txtTexto.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtTexto.Location = new Point(250, 97);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new Size(150, 26);
            this.txtTexto.TabIndex = 3;

            // btnGenerar
            this.btnGenerar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnGenerar.Location = new Point(80, 140);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new Size(120, 40);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new EventHandler(this.btnGenerar_Click);

            // lblContador
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblContador.Location = new Point(80, 190);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new Size(150, 20);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "Total de permutaciones:";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new Point(80, 230);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new Size(150, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Permutaciones generadas:";

            // lvResultado (ListView para las permutaciones)
            this.lvResultado.Columns.AddRange(new ColumnHeader[] { new ColumnHeader { Text = "#", Width = 60 }, new ColumnHeader { Text = "Permutación", Width = 330 } });
            this.lvResultado.Font = new Font("Microsoft Sans Serif", 10F);
            this.lvResultado.Location = new Point(80, 260);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new Size(400, 200);
            this.lvResultado.TabIndex = 7;
            this.lvResultado.View = View.Details;
            this.lvResultado.GridLines = true;
            this.lvResultado.FullRowSelect = true;
            this.lvResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // btnLimpiar
            this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new Point(220, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);

            // btnRegresar
            this.btnRegresar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new Point(340, 140);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(100, 40);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new EventHandler(this.btnRegresar_Click);

            // frmPermutaciones
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(520, 490);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lvResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPermutaciones";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Permutaciones - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblInformacion;
        private Label lblTexto;
        private TextBox txtTexto;
        private Button btnGenerar;
        private Label lblContador;
        private Label lblResultado;
        private ListView lvResultado;
        private Button btnLimpiar;
        private Button btnRegresar;

        private List<string> permutaciones = new List<string>();

        /// <summary>
        /// Método recursivo para generar todas las permutaciones de una cadena
        /// </summary>
        /// <param name="texto">Texto original</param>
        /// <param name="resultado">Cadena parcial que se está construyendo</param>
        /// <param name="usados">Array que indica qué caracteres ya se han usado</param>
        private void GenerarPermutacionesRecursivo(string texto, string resultado, bool[] usados)
        {
            // Caso base: si la cadena resultado tiene la misma longitud que la original
            if (resultado.Length == texto.Length)
            {
                permutaciones.Add(resultado);
                return;
            }

            // Recorrer todos los caracteres disponibles
            for (int i = 0; i < texto.Length; i++)
            {
                // Si el carácter en la posición i no ha sido usado
                if (!usados[i])
                {
                    // Marcar como usado
                    usados[i] = true;
                    
                    // Agregar el carácter a la cadena resultado
                    string nuevoResultado = resultado + texto[i];
                    
                    // Llamada recursiva
                    GenerarPermutacionesRecursivo(texto, nuevoResultado, usados);
                    
                    // Desmarcar para permitir otras combinaciones
                    usados[i] = false;
                }
            }
        }

        /// <summary>
        /// Método auxiliar para eliminar caracteres duplicados
        /// </summary>
        /// <param name="texto">Texto original</param>
        /// <returns>Texto sin caracteres duplicados</returns>
        private string EliminarDuplicados(string texto)
        {
            string resultado = "";
            foreach (char c in texto)
            {
                if (!resultado.Contains(c.ToString()))
                {
                    resultado += c;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Método para calcular el factorial de un número (para mostrar el número esperado de permutaciones)
        /// </summary>
        /// <param name="n">Número para calcular factorial</param>
        /// <returns>Factorial del número</returns>
        private long Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado texto
                if (string.IsNullOrWhiteSpace(txtTexto.Text))
                {
                    MessageBox.Show("Por favor, ingrese caracteres para generar permutaciones.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTexto.Focus();
                    return;
                }

                string textoOriginal = txtTexto.Text.Trim();
                string textoLimpio = EliminarDuplicados(textoOriginal);
                
                // Validar que el texto tenga al menos un carácter
                if (string.IsNullOrEmpty(textoLimpio))
                {
                    MessageBox.Show("Debe ingresar al menos un carácter válido.", "Texto inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTexto.Clear();
                    txtTexto.Focus();
                    return;
                }

                // Validar que el número de caracteres no sea muy grande para evitar problemas de rendimiento
                if (textoLimpio.Length > 8)
                {
                    MessageBox.Show("Para evitar problemas de rendimiento, ingrese máximo 8 caracteres únicos.", 
                        "Demasiados caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTexto.Clear();
                    txtTexto.Focus();
                    return;
                }

                // Limpiar lista de permutaciones anterior
                permutaciones.Clear();
                
                // Crear array para marcar caracteres usados
                bool[] usados = new bool[textoLimpio.Length];
                
                // Generar permutaciones usando recursión
                GenerarPermutacionesRecursivo(textoLimpio, "", usados);
                
                // Calcular número esperado de permutaciones
                long permutacionesEsperadas = Factorial(textoLimpio.Length);
                
                // Limpiar lista y mostrar resultados
                lvResultado.Items.Clear();

                // Añadir resumen a la lista
                lvResultado.Items.Add(new ListViewItem(new string[] { "Info", $"Texto original: \"{textoOriginal}\"" }));
                lvResultado.Items.Add(new ListViewItem(new string[] { "Info", $"Caracteres únicos: \"{textoLimpio}\"" }));
                lvResultado.Items.Add(new ListViewItem(new string[] { "Info", $"Permutaciones esperadas: {permutacionesEsperadas}" }));
                lvResultado.Items.Add(new ListViewItem(new string[] { "Info", $"Permutaciones generadas: {permutaciones.Count}" }));
                lvResultado.Items.Add(new ListViewItem("")); // Separador

                if (permutaciones.Count <= 50) // Mostrar todas si son pocas
                {
                    for (int i = 0; i < permutaciones.Count; i++)
                    {
                        lvResultado.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), permutaciones[i] }));
                    }
                }
                else // Mostrar solo las primeras 50 si son muchas
                {
                    for (int i = 0; i < 50; i++)
                    {
                        lvResultado.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), permutaciones[i] }));
                    }
                    lvResultado.Items.Add(new ListViewItem(new string[] { "...", $"y {permutaciones.Count - 50} más." }));
                }
                
                // Actualizar contador
                lblContador.Text = $"Total de permutaciones: {permutaciones.Count}";                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar permutaciones: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            lvResultado.Items.Clear();
            lblContador.Text = "Total de permutaciones: 0";
            permutaciones.Clear();
            txtTexto.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
