namespace FormEscrito
{
    partial class CP_FormEscrito
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
            IngresarBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MarcaBox = new TextBox();
            ModeloBox = new TextBox();
            AnioBox = new TextBox();
            ServicioBox = new ComboBox();
            dgvVenta = new DataGridView();
            VenderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // IngresarBtn
            // 
            IngresarBtn.Location = new Point(539, 280);
            IngresarBtn.Name = "IngresarBtn";
            IngresarBtn.Size = new Size(75, 23);
            IngresarBtn.TabIndex = 0;
            IngresarBtn.Text = "Ingresar";
            IngresarBtn.UseVisualStyleBackColor = true;
            IngresarBtn.Click += IngresarBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(620, 280);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(701, 280);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(375, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(413, 235);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 6;
            label3.Text = "M2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 142);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Precio";
            // 
            // MarcaBox
            // 
            MarcaBox.Location = new Point(75, 141);
            MarcaBox.Name = "MarcaBox";
            MarcaBox.Size = new Size(121, 23);
            MarcaBox.TabIndex = 10;
            // 
            // ModeloBox
            // 
            ModeloBox.Location = new Point(75, 85);
            ModeloBox.Name = "ModeloBox";
            ModeloBox.Size = new Size(121, 23);
            ModeloBox.TabIndex = 11;
            // 
            // AnioBox
            // 
            AnioBox.Location = new Point(75, 112);
            AnioBox.Name = "AnioBox";
            AnioBox.Size = new Size(121, 23);
            AnioBox.TabIndex = 12;
            // 
            // ServicioBox
            // 
            ServicioBox.FormattingEnabled = true;
            ServicioBox.Items.AddRange(new object[] { "Casa", "Apartamento", "Terreno" });
            ServicioBox.Location = new Point(75, 56);
            ServicioBox.Name = "ServicioBox";
            ServicioBox.Size = new Size(121, 23);
            ServicioBox.TabIndex = 13;
            ServicioBox.SelectedIndexChanged += ServicioBox_SelectedIndexChanged;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(797, 39);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowTemplate.Height = 25;
            dgvVenta.Size = new Size(413, 235);
            dgvVenta.TabIndex = 14;
            // 
            // VenderBtn
            // 
            VenderBtn.Location = new Point(782, 280);
            VenderBtn.Name = "VenderBtn";
            VenderBtn.Size = new Size(75, 23);
            VenderBtn.TabIndex = 15;
            VenderBtn.Text = "Vender";
            VenderBtn.UseVisualStyleBackColor = true;
            VenderBtn.Click += VenderBtn_Click;
            // 
            // CP_FormEscrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 314);
            Controls.Add(VenderBtn);
            Controls.Add(dgvVenta);
            Controls.Add(ServicioBox);
            Controls.Add(AnioBox);
            Controls.Add(ModeloBox);
            Controls.Add(MarcaBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(IngresarBtn);
            Name = "CP_FormEscrito";
            Text = "FormEscrito";
            Load += CP_FormEscrito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IngresarBtn;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox MarcaBox;
        private TextBox ModeloBox;
        private TextBox AnioBox;
        private ComboBox ServicioBox;
        private DataGridView dgvVenta;
        private Button VenderBtn;
    }
}
