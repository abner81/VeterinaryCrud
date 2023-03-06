using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryCrud.View
{
    public interface IPetView
    {
        //Fields
        public string Name { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        //States
        string SearchValue { get; set; }
        string IsEdit { get; set; }
        string IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetPetListBindingSource(BindingSource petList);
        void Show();
    }
}
