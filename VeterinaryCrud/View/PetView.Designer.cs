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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            tabControl = new TabControl();
            tabPageList = new TabPage();
            dataGridView = new DataGridView();
            btnDeletePet = new Button();
            btnEditPet = new Button();
            btnAddPet = new Button();
            button3 = new Button();
            label6 = new Label();
            txtSearchText = new TextBox();
            tabPageDetails = new TabPage();
            label4 = new Label();
            txtPetId = new TextBox();
            btnCancelPet = new Button();
            btnSavePet = new Button();
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
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 66);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(743, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 23);
            btnClose.TabIndex = 17;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
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
            tabPageList.Controls.Add(btnDeletePet);
            tabPageList.Controls.Add(btnEditPet);
            tabPageList.Controls.Add(btnAddPet);
            tabPageList.Controls.Add(button3);
            tabPageList.Controls.Add(label6);
            tabPageList.Controls.Add(txtSearchText);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3, 3, 3, 3);
            tabPageList.Size = new Size(776, 347);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "Lista";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.GridColor = SystemColors.ControlLight;
            dataGridView.Location = new Point(13, 61);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 82;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(661, 283);
            dataGridView.TabIndex = 16;
            // 
            // btnDeletePet
            // 
            btnDeletePet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeletePet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletePet.Location = new Point(681, 133);
            btnDeletePet.Name = "btnDeletePet";
            btnDeletePet.Size = new Size(70, 30);
            btnDeletePet.TabIndex = 15;
            btnDeletePet.Text = "Excluir";
            btnDeletePet.TextAlign = ContentAlignment.TopCenter;
            btnDeletePet.UseVisualStyleBackColor = true;
            btnDeletePet.Click += button6_Click;
            // 
            // btnEditPet
            // 
            btnEditPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditPet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditPet.Location = new Point(681, 97);
            btnEditPet.Name = "btnEditPet";
            btnEditPet.Size = new Size(70, 30);
            btnEditPet.TabIndex = 14;
            btnEditPet.Text = "Editar";
            btnEditPet.TextAlign = ContentAlignment.TopCenter;
            btnEditPet.UseVisualStyleBackColor = true;
            btnEditPet.Click += button5_Click;
            // 
            // btnAddPet
            // 
            btnAddPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPet.Location = new Point(681, 61);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(70, 30);
            btnAddPet.TabIndex = 13;
            btnAddPet.Text = "Add";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            txtSearchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchText.Location = new Point(13, 33);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.Size = new Size(587, 23);
            txtSearchText.TabIndex = 10;
            // 
            // tabPageDetails
            // 
            tabPageDetails.Controls.Add(label4);
            tabPageDetails.Controls.Add(txtPetId);
            tabPageDetails.Controls.Add(btnCancelPet);
            tabPageDetails.Controls.Add(btnSavePet);
            tabPageDetails.Controls.Add(label5);
            tabPageDetails.Controls.Add(txtPetType);
            tabPageDetails.Controls.Add(label3);
            tabPageDetails.Controls.Add(txtPetColor);
            tabPageDetails.Controls.Add(label2);
            tabPageDetails.Controls.Add(txtPetName);
            tabPageDetails.Location = new Point(4, 24);
            tabPageDetails.Name = "tabPageDetails";
            tabPageDetails.Padding = new Padding(3, 3, 3, 3);
            tabPageDetails.Size = new Size(776, 347);
            tabPageDetails.TabIndex = 1;
            tabPageDetails.Text = "Detalhes";
            tabPageDetails.UseVisualStyleBackColor = true;
            tabPageDetails.Click += tabPageDetails_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 21);
            label4.Name = "label4";
            label4.Size = new Size(23, 19);
            label4.TabIndex = 9;
            label4.Text = "ID";
            label4.Click += label4_Click;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(19, 43);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(161, 23);
            txtPetId.TabIndex = 8;
            txtPetId.TextChanged += textBox3_TextChanged;
            // 
            // btnCancelPet
            // 
            btnCancelPet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelPet.Location = new Point(114, 222);
            btnCancelPet.Name = "btnCancelPet";
            btnCancelPet.Size = new Size(80, 35);
            btnCancelPet.TabIndex = 7;
            btnCancelPet.Text = "Cancelar";
            btnCancelPet.UseVisualStyleBackColor = true;
            btnCancelPet.Click += button2_Click;
            // 
            // btnSavePet
            // 
            btnSavePet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePet.Location = new Point(19, 222);
            btnSavePet.Name = "btnSavePet";
            btnSavePet.Size = new Size(80, 35);
            btnSavePet.TabIndex = 6;
            btnSavePet.Text = "Salvar";
            btnSavePet.UseVisualStyleBackColor = true;
            btnSavePet.Click += btnSavePet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(256, 87);
            label5.Name = "label5";
            label5.Size = new Size(35, 19);
            label5.TabIndex = 5;
            label5.Text = "Tipo";
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(256, 109);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(161, 23);
            txtPetType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 149);
            label3.Name = "label3";
            label3.Size = new Size(31, 19);
            label3.TabIndex = 3;
            label3.Text = "Cor";
            // 
            // txtPetColor
            // 
            txtPetColor.Location = new Point(19, 171);
            txtPetColor.Name = "txtPetColor";
            txtPetColor.Size = new Size(398, 23);
            txtPetColor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(19, 109);
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
        private Button btnCancelPet;
        private Button btnSavePet;
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
        private Button btnDeletePet;
        private Button btnEditPet;
        private Button btnAddPet;
        private Button button3;
        private DataGridView dataGridView;
        private Button btnClose;
    }
}