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
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            HiddenTabPageDetails();
        }

        private void HiddenTabPageDetails()
        {
            tabControl.TabPages.Remove(tabPageDetails);
        }

        private void showTabPageList()
        {
            tabControl.TabPages.Remove(tabPageDetails);
            tabControl.TabPages.Add(tabPageList);
        }
        private void showTabPageDetails()
        {
            tabControl.TabPages.Remove(tabPageList);
            tabControl.TabPages.Add(tabPageDetails);
        }

        private void PrepareFor(EventHandler eventHandler, string pageTitle)
        {
            eventHandler.Invoke(this, EventArgs.Empty);
            showTabPageDetails();
            tabPageDetails.Text = pageTitle;
        }

        private void AssociateAndRaiseViewEvents()
        {
            txtSearchText.Click += delegate { InvokeSearchEvent(); };
            txtSearchText.KeyDown += SearchOnPressEnterKey;

            btnClose.Click += delegate { Close(); };

            btnAddPet.Click += delegate
            {

                PrepareFor(AddNewEvent, "Add Pet");
            };
            btnEditPet.Click += delegate { PrepareFor(EditEvent, "Editar Pet"); };
            btnDeletePet.Click += delegate
            {
                var result = MessageBox.Show("Tem certeza que deseja deletar o pet?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) { DeleteEvent.Invoke(this, EventArgs.Empty); }
                MessageBox.Show(Message);
            };
            btnSavePet.Click += delegate
            {
                SaveEvent.Invoke(this, EventArgs.Empty);
                Console.WriteLine(IsSuccessful);

                if (IsSuccessful) showTabPageList();
                MessageBox.Show(Message);
            };
            btnCancelPet.Click += delegate
            {
                CancelEvent.Invoke(this, EventArgs.Empty);
                showTabPageList();
            };

        }

        private void SearchOnPressEnterKey(object _, KeyEventArgs pressedKey)
        {
            bool pressEnterKey = pressedKey.KeyCode == Keys.Enter;
            if (pressEnterKey) InvokeSearchEvent();
        }
        private void InvokeSearchEvent()
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
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

        private static void fitWindow(PetView instance)
        {
            bool windowMinimized = instance.WindowState == FormWindowState.Minimized;
            void normalizeWindow() => instance.WindowState = FormWindowState.Normal;
            if (windowMinimized) normalizeWindow();
            instance.BringToFront();
        }

        private static PetView instance;
        public static PetView GetInstance(Form parentContainer)
        {
            void styleView(PetView instance)
            {
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            bool notExistInstance = instance == null || instance.IsDisposed;
            if (notExistInstance)
            {
                instance = new PetView();
                styleView(instance);
            }
            else fitWindow(instance);

            return instance;
        }

        private void tabPageDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePet_Click(object sender, EventArgs e)
        {
        }
    }
}
