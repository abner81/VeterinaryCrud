using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryCrud.Model;
using VeterinaryCrud.View;
using VeterinaryCrud.Presenter;

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
            view.EditEvent += EditAction;
            view.SearchEvent += SearchPet;
            view.DeleteEvent += DeleteSelectedPet;
            view.SaveEvent += SavePet;
            view.AddNewEvent += AddPet;
            view.CancelEvent += CancelAction;
        }

        private void EditAction(object sender, EventArgs e)
        {
            var toBeEdited = (Pet)bindingSource.Current;
            view.Id = toBeEdited.Id.ToString();
            view.Color = toBeEdited.Color;
            view.Name = toBeEdited.Name;
            view.Type = toBeEdited.Type;

            view.IsEdit = true;
            view.IsSuccessful = false;
            view.Message = "";
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
            var pet = new Pet();
            pet.Id = Convert.ToInt32(view.Id);
            pet.Color = view.Color;
            pet.Name = view.Name;
            pet.Type = view.Type;

            try
            {
                new ModelDataValidation().Validate(pet);
                if (view.IsEdit) repository.Edit(pet);
                else repository.Add(pet);

                view.Message = $"Pet {(view.IsEdit ? "editado" : "adicionado")} com sucesso!";
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.Message = ex.Message;
                view.IsSuccessful = false;
            }
        }

        private void AddPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
            view.Name = "";
        }

        private void CleanViewFields()
        {
            view.IsEdit = false;
            view.IsSuccessful = false;
            view.Message = "";

         view.Id = "";
            view.Name = "";
            view.Color = "";
            view.Type = "";
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (Pet)bindingSource.Current;
                repository.Delete(pet.Id);

                view.IsSuccessful = true;
                view.Message = "Pet deletado com sucesso!";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object sender, EventArgs args)
        {
            CleanViewFields();
        }
    }
}
