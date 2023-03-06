using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryCrud.View
{
    public interface IMainView
    {
        event EventHandler ShowPetView;
        event EventHandler ShowVetView;
        event EventHandler ShowOwnerView;
    }
}
