using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryCrud.Repository;
using VeterinaryCrud.View;

namespace VeterinaryCrud.Presenter
{
    public class MainPresenter
    {
        private MainView mainView;

        public MainPresenter(MainView mainView)
        {
            this.mainView = mainView;

            this.mainView.ShowPetView += ShowPetView;
            this.mainView.ShowOwnerView += ShowOwnerView;
            this.mainView.ShowVetView += ShowVetView;
        }

        private void ShowVetView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowOwnerView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    
        private void ShowPetView(object sender, EventArgs e)
        {
           PetView view = PetView.GetInstance(mainView);
           PetRepository repository = new();
           new PetPresenter(view, repository);
        }
    }
}
