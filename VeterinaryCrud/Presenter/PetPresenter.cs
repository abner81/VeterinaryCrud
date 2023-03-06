using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryCrud.Model;
using VeterinaryCrud.View;

namespace VeterinaryCrud.Presenter
{
    public class PetPresenter
    {
        private IPetRepository repository;
        private IPetView view;
        private BindingSource bindingSource;
        private IEnumerable<Pet> petList;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            bindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            view.SetPetListBindingSource(bindingSource);
            SubscribeEventHandlers();
            LoadAllPetList();
            view.Show();
        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            bindingSource.DataSource = petList;
        }

        private void SubscribeEventHandlers()
        {
            view.EditEvent += CancelAction;
            view.SearchEvent += SearchPet;
            view.DeleteEvent += DeleteSelectedPet;
            view.SaveEvent += SavePet;
            view.AddNewEvent += AddPet;
            view.CancelEvent += CancelAction;
        }

        private void SearchPet(object sender, EventArgs e)
        {
          bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue) petList = repository.GetByValue(view.SearchValue);
            else petList = repository.GetAll();
          bindingSource.DataSource = petList;
        }

        private void SavePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
