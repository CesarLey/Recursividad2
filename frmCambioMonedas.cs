using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recursividad2
{
    public partial class frmCambioMonedas : Form
    {
        private readonly decimal[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50m, 0.20m, 0.10m, 0.01m };
        private readonly string[] nombresMonedas = {
            "100 pesos", "50 pesos", "20 pesos", "10 pesos", "5 pesos",
            "1 peso", "50 centavos", "20 centavos", "10 centavos", "1 centavo"
        };

        public frmCambioMonedas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblMontoPagar = new Label();
            this.txtMontoPagar = new TextBox();
            this.lblMontoRecibido = new Label();
            this.txtMontoRecibido = new TextBox();
            this.btnCalcular = new Button();
            this.lblResultado = new Label();
            this.lvResultado = new ListView(); // Cambiado de TextBox a ListView
            this.btnLimpiar = new Button();
            this.btnRegresar = new Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(150, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(250, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULADORA DE CAMBIO";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // lblMontoPagar
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblMontoPagar.Location = new Point(80, 80);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Size = new Size(150, 20);
            this.lblMontoPagar.TabIndex = 1;
            this.lblMontoPagar.Text = "Monto a pagar ($):";

            // txtMontoPagar
            this.txtMontoPagar.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtMontoPagar.Location = new Point(250, 77);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new Size(120, 26);
            this.txtMontoPagar.TabIndex = 2;

            // lblMontoRecibido
            this.lblMontoRecibido.AutoSize = true;
            this.lblMontoRecibido.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblMontoRecibido.Location = new Point(80, 120);
            this.lblMontoRecibido.Name = "lblMontoRecibido";
            this.lblMontoRecibido.Size = new Size(170, 20);
            this.lblMontoRecibido.TabIndex = 3;
            this.lblMontoRecibido.Text = "Monto recibido ($):";

            // txtMontoRecibido
            this.txtMontoRecibido.Font = new Font("Microsoft Sans Serif", 12F);
            this.txtMontoRecibido.Location = new Point(250, 117);
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new Size(120, 26);
            this.txtMontoRecibido.TabIndex = 4;

            // btnCalcular
            this.btnCalcular.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new Point(80, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new Size(120, 40);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Cambio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new Point(80, 220);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new Size(100, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Cambio:";

            // lvResultado (ListView para el desglose)
            this.lvResultado.Columns.AddRange(new ColumnHeader[] { new ColumnHeader { Text = "Cantidad", Width = 100 }, new ColumnHeader { Text = "Denominación", Width = 290 } });
            this.lvResultado.Font = new Font("Microsoft Sans Serif", 10F);
            this.lvResultado.Location = new Point(80, 250);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new Size(400, 150);
            this.lvResultado.TabIndex = 7;
            this.lvResultado.View = View.Details;
            this.lvResultado.GridLines = true;
            this.lvResultado.FullRowSelect = true;
            this.lvResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Anclaje


            // btnLimpiar
            this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new Point(220, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);

            // btnRegresar
            this.btnRegresar.Font = new Font("Microsoft Sans Serif", 12F);
            this.btnRegresar.Location = new Point(340, 160);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(100, 40);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new EventHandler(this.btnRegresar_Click);

            // frmCambioMonedas
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(520, 430);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lvResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.lblMontoRecibido);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.lblMontoPagar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCambioMonedas";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cambio de Monedas - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitulo;
        private Label lblMontoPagar;
        private TextBox txtMontoPagar;
        private Label lblMontoRecibido;
        private TextBox txtMontoRecibido;
        private Button btnCalcular;
        private Label lblResultado;
        private ListView lvResultado;
        private Button btnLimpiar;
        private Button btnRegresar;

        /// <summary>
        /// Método recursivo para calcular el cambio mínimo usando el algoritmo voraz
        /// </summary>
        /// <param name="cambio">Cantidad de cambio a devolver</param>
        /// <param name="indice">Índice actual en el array de denominaciones</param>
        /// <param name="monedas">Array para contar las monedas de cada denominación</param>
        private void CalcularCambioRecursivo(decimal cambio, int indice, int[] monedas)
        {
            // Caso base: si el cambio es 0 o hemos recorrido todas las denominaciones
            if (cambio <= 0 || indice >= denominaciones.Length)
                return;

            // Calcular cuántas monedas de esta denominación necesitamos
            int cantidad = (int)(cambio / denominaciones[indice]);

            // Guardar la cantidad de monedas de esta denominación
            monedas[indice] = cantidad;

            // Calcular el cambio restante
            decimal cambioRestante = cambio - (cantidad * denominaciones[indice]);

            // Llamada recursiva para la siguiente denominación
            CalcularCambioRecursivo(cambioRestante, indice + 1, monedas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se hayan ingresado ambos montos
                if (string.IsNullOrWhiteSpace(txtMontoPagar.Text) || string.IsNullOrWhiteSpace(txtMontoRecibido.Text))
                {
                    MessageBox.Show("Por favor, ingrese ambos montos.", "Datos faltantes", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrWhiteSpace(txtMontoPagar.Text))
                        txtMontoPagar.Focus();
                    else
                        txtMontoRecibido.Focus();
                    return;
                }

                // Validar que sean números decimales válidos
                if (!decimal.TryParse(txtMontoPagar.Text, out decimal montoPagar))
                {
                    MessageBox.Show("El monto a pagar debe ser un número válido.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMontoPagar.Clear();
                    txtMontoPagar.Focus();
                    return;
                }

                if (!decimal.TryParse(txtMontoRecibido.Text, out decimal montoRecibido))
                {
                    MessageBox.Show("El monto recibido debe ser un número válido.", "Dato inválido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMontoRecibido.Clear();
                    txtMontoRecibido.Focus();
                    return;
                }

                // Validar que los montos sean positivos
                if (montoPagar < 0 || montoRecibido < 0)
                {
                    MessageBox.Show("Los montos deben ser números positivos.", "Datos inválidos", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el monto recibido sea mayor o igual al monto a pagar
                if (montoRecibido < montoPagar)
                {
                    MessageBox.Show("El monto recibido debe ser mayor o igual al monto a pagar.", 
                        "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el cambio
                decimal cambio = montoRecibido - montoPagar;
                
                // Array para almacenar la cantidad de cada tipo de moneda
                int[] monedas = new int[denominaciones.Length];
                
                // Calcular cambio usando recursión
                CalcularCambioRecursivo(cambio, 0, monedas);
                
                // Limpiar la lista y mostrar información general
                lvResultado.Items.Clear();
                lvResultado.Items.Add(new ListViewItem(new string[] { "Monto a pagar:", $"${montoPagar:F2}" }));
                lvResultado.Items.Add(new ListViewItem(new string[] { "Monto recibido:", $"${montoRecibido:F2}" }));
                lvResultado.Items.Add(new ListViewItem(new string[] { "Cambio total:", $"${cambio:F2}" }));
                lvResultado.Items.Add(new ListViewItem("")); // Espacio en blanco
                lvResultado.Items.Add(new ListViewItem(new string[] { "Desglose del cambio:", "" }));

                // Mostrar desglose en la lista
                for (int i = 0; i < denominaciones.Length; i++)
                {
                    if (monedas[i] > 0)
                    {
                        lvResultado.Items.Add(new ListViewItem(new string[] { monedas[i].ToString(), nombresMonedas[i] }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el cambio: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMontoPagar.Clear();
            txtMontoRecibido.Clear();
            lvResultado.Items.Clear();
            txtMontoPagar.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
