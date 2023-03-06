using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinaryCrud.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            void showPetPage(object sender, EventArgs e) { ShowPetView?.Invoke(this, EventArgs.Empty); }
            btnPets.Click += showPetPage;
        }



        public event EventHandler ShowPetView;
        public event EventHandler ShowVetView;
        public event EventHandler ShowOwnerView;
    }
}
