using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblTerminos = new Label();
            this.txtTerminos = new TextBox();
            this.btnGenerar = new Button();
            this.lblSerie = new Label();
            this.lvSerie = new ListView(); // Cambiado de TextBox a ListView
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
            this.lblTitulo.Text = "SERIE DE FIBONACCI";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblTerminos
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblTerminos.Location = new Point(80, 80);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new Size(150, 20);
            this.lblTerminos.TabIndex = 1;
            this.lblTerminos.Text = "Número de términos:";

            // txtTerminos
            this.txtTerminos.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtTerminos.Location = new Point(250, 77);
            this.txtTerminos.Name = "txtTerminos";
            this.txtTerminos.Size = new Size(100, 26);
            this.txtTerminos.TabIndex = 2;

            // btnGenerar
            this.btnGenerar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnGenerar.Location = new Point(80, 120);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new Size(100, 40);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new EventHandler(this.btnGenerar_Click);

            // lblSerie
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblSerie.Location = new Point(80, 180);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new Size(100, 20);
            this.lblSerie.TabIndex = 4;
            this.lblSerie.Text = "Serie Fibonacci:";

            // lvSerie (ListView para resultados)
            this.lvSerie.Columns.AddRange(new ColumnHeader[] { new ColumnHeader { Text = "Término", Width = 150 }, new ColumnHeader { Text = "Valor", Width = 190 } });
            this.lvSerie.Font = new Font("Microsoft Sans Serif", 10F);
            this.lvSerie.Location = new Point(80, 210);
            this.lvSerie.Name = "lvSerie";
            this.lvSerie.Size = new Size(350, 120);
            this.lvSerie.TabIndex = 5;
            this.lvSerie.View = View.Details;
            this.lvSerie.GridLines = true;
            this.lvSerie.FullRowSelect = true;
            this.lvSerie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Anclaje

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

            // frmFibonacci
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 380);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lvSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtTerminos);
            this.Controls.Add(this.lblTerminos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFibonacci";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Fibonacci - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblTerminos;
        private TextBox txtTerminos;
        private Button btnGenerar;
        private Label lblSerie;
        private ListView lvSerie;
        private Button btnLimpiar;
        private Button btnRegresar;

        /// <summary>
        /// Método recursivo para calcular el n-ésimo término de la serie de Fibonacci
        /// </summary>
        /// <param name="n">Posición en la serie</param>
        /// <returns>Valor del término en la posición n</returns>
        private long FibonacciRecursivo(int n)
        {
            // Casos base
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            
            // Caso recursivo: F(n) = F(n-1) + F(n-2)
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un número
                if (string.IsNullOrWhiteSpace(txtTerminos.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTerminos.Focus();
                    return;
                }

                // Validar que sea un número entero
                if (!int.TryParse(txtTerminos.Text, out int terminos))
                {
                    MessageBox.Show("Por favor, ingrese solo números enteros.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTerminos.Clear();
                    txtTerminos.Focus();
                    return;
                }

                // Validar que el número sea positivo
                if (terminos <= 0)
                {
                    MessageBox.Show("El número de términos debe ser mayor a 0.", 
                        "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTerminos.Clear();
                    txtTerminos.Focus();
                    return;
                }

                // Validar que el número no sea muy grande para evitar problemas de rendimiento
                if (terminos > 40)
                {
                    MessageBox.Show("Para evitar problemas de rendimiento, ingrese un número menor o igual a 40.", 
                        "Número muy grande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTerminos.Clear();
                    txtTerminos.Focus();
                    return;
                }

                // Limpiar la lista antes de generar nuevos resultados
                lvSerie.Items.Clear();

                // Generar serie de Fibonacci
                for (int i = 0; i < terminos; i++)
                {
                    long valor = FibonacciRecursivo(i);
                    // Crear un nuevo item para la lista
                    ListViewItem item = new ListViewItem($"F({i})");
                    // Añadir el valor en la segunda columna
                    item.SubItems.Add(valor.ToString());
                    lvSerie.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la serie: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTerminos.Clear();
            lvSerie.Items.Clear();
            txtTerminos.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
