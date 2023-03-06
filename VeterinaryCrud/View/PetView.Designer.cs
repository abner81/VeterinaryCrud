namespace VeterinaryCrud.View
{
    partial class PetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            tabControl = new TabControl();
            tabPageList = new TabPage();
            dataGridView = new DataGridView();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label6 = new Label();
            txtSearchText = new TextBox();
            tabPageDetails = new TabPage();
            label4 = new Label();
            txtPetId = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            txtPetType = new TextBox();
            label3 = new Label();
            txtPetColor = new TextBox();
            label2 = new Label();
            txtPetName = new TextBox();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPageDetails.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 66);
            panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageList);
            tabControl.Controls.Add(tabPageDetails);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 66);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(784, 375);
            tabControl.TabIndex = 2;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridView);
            tabPageList.Controls.Add(button6);
            tabPageList.Controls.Add(button5);
            tabPageList.Controls.Add(button4);
            tabPageList.Controls.Add(button3);
            tabPageList.Controls.Add(label6);
            tabPageList.Controls.Add(txtSearchText);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(776, 347);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "Lista";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 61);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 82;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(661, 283);
            dataGridView.TabIndex = 16;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(681, 133);
            button6.Name = "button6";
            button6.Size = new Size(70, 30);
            button6.TabIndex = 15;
            button6.Text = "Excluir";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(681, 97);
            button5.Name = "button5";
            button5.Size = new Size(70, 30);
            button5.TabIndex = 14;
            button5.Text = "Editar";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(681, 61);
            button4.Name = "button4";
            button4.Size = new Size(70, 30);
            button4.TabIndex = 13;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(605, 26);
            button3.Name = "button3";
            button3.Size = new Size(70, 30);
            button3.TabIndex = 12;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 9);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 11;
            label6.Text = "Buscar Pet";
            // 
            // txtSearchText
            // 
            txtSearchText.Location = new Point(13, 33);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.Size = new Size(587, 23);
            txtSearchText.TabIndex = 10;
            // 
            // tabPageDetails
            // 
            tabPageDetails.Controls.Add(label4);
            tabPageDetails.Controls.Add(txtPetId);
            tabPageDetails.Controls.Add(button2);
            tabPageDetails.Controls.Add(button1);
            tabPageDetails.Controls.Add(label5);
            tabPageDetails.Controls.Add(txtPetType);
            tabPageDetails.Controls.Add(label3);
            tabPageDetails.Controls.Add(txtPetColor);
            tabPageDetails.Controls.Add(label2);
            tabPageDetails.Controls.Add(txtPetName);
            tabPageDetails.Location = new Point(4, 24);
            tabPageDetails.Name = "tabPageDetails";
            tabPageDetails.Padding = new Padding(3);
            tabPageDetails.Size = new Size(776, 347);
            tabPageDetails.TabIndex = 1;
            tabPageDetails.Text = "Detalhes";
            tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 46);
            label4.Name = "label4";
            label4.Size = new Size(23, 19);
            label4.TabIndex = 9;
            label4.Text = "ID";
            label4.Click += label4_Click;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(33, 68);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(161, 23);
            txtPetId.TabIndex = 8;
            txtPetId.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(128, 258);
            button2.Name = "button2";
            button2.Size = new Size(80, 35);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(33, 258);
            button1.Name = "button1";
            button1.Size = new Size(80, 35);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(270, 112);
            label5.Name = "label5";
            label5.Size = new Size(35, 19);
            label5.TabIndex = 5;
            label5.Text = "Tipo";
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(270, 134);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(161, 23);
            txtPetType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 174);
            label3.Name = "label3";
            label3.Size = new Size(31, 19);
            label3.TabIndex = 3;
            label3.Text = "Cor";
            // 
            // txtPetColor
            // 
            txtPetColor.Location = new Point(33, 196);
            txtPetColor.Name = "txtPetColor";
            txtPetColor.Size = new Size(398, 23);
            txtPetColor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(33, 134);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(161, 23);
            txtPetName.TabIndex = 0;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPageDetails.ResumeLayout(false);
            tabPageDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl;
        private TabPage tabPageList;
        private TabPage tabPageDetails;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox txtPetType;
        private Label label3;
        private TextBox txtPetColor;
        private Label label2;
        private TextBox txtPetName;
        private Label label4;
        private TextBox txtPetId;
        private Label label6;
        private TextBox txtSearchText;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView;
    }
}