using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace VeterinaryCrud.View
{
    public partial class PetView : Form, IPetView
    {
        public string Id { get { return txtPetId.Text; } set { txtPetId.Text = value; } }
        public new string Name { get { return txtPetName.Text; } set { txtPetName.Text = value; } }
        public string Type { get { return txtPetType.Text; } set { txtPetType.Text = value; } }
        public string Color { get { return txtPetColor.Text; } set { txtPetColor.Text = value; } }
        public string SearchValue { get { return txtSearchText.Text; } set { txtSearchText.Text = value; } }
        public string IsEdit { get; set; }
        public string IsSuccessful { get; set; }
        public string Message { get; set; }

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            this.HiddenTabPageDetails();
        }

        private void HiddenTabPageDetails()
        {
            tabControl.TabPages.Remove(tabPageDetails);
        }

        private void InvokeSearchEvent()
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }

        private void AssociateAndRaiseViewEvents()
        {
            txtSearchText.Click += delegate { InvokeSearchEvent(); };
            txtSearchText.KeyDown += (_, pressedKey) =>
            {
                bool pressEnterKey = pressedKey.KeyCode == Keys.Enter;
                if (pressEnterKey) InvokeSearchEvent();
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView.DataSource = petList;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
