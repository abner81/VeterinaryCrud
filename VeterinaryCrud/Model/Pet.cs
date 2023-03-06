using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using VeterinaryCrud.Model;

namespace VeterinaryCrud.Model
{
    public interface IPetParams
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Type { get; set; }
        public string Color { get; set; }
    }

    public class Pet
    {
        private int id;
        private string type;
        private string color;

        //Validation constants
        const int MAX_LENGTH = 50;
        const int MIN_LENGTH = 3;
        const string LENGTH_ERROR_MESSAGE = "O valor deve ter entre 3 - 50 caracteres";


        //public Pet(IPetParams petParams)
        public Pet(int id, string name, string type, string color)
        {
        
            this.id = id;
            this.type = type;
            this.Name = name;
            this.color = color;
        }

        public Pet()
        {
        }

        public Pet((int id, string name, string type, string color) value)
        {
        }

        [Required(ErrorMessage = "o Id e obrigatorio")]
        public int Id { get { return id; } set { id = value; } }

        [Required(ErrorMessage = "o Name e obrigatorio")]
        [StringLength(MAX_LENGTH, ErrorMessage = LENGTH_ERROR_MESSAGE, MinimumLength = MIN_LENGTH)]
        public string Name { get; set; }

        [Required(ErrorMessage = "o Type e obrigatorio")]
        [StringLength(MAX_LENGTH, ErrorMessage = LENGTH_ERROR_MESSAGE, MinimumLength = MIN_LENGTH)]
        public string Type { get { return type; } set { type = value; } }

        [Required(ErrorMessage = "o Color e obrigatorio")]
        [StringLength(MAX_LENGTH, ErrorMessage = LENGTH_ERROR_MESSAGE, MinimumLength = MIN_LENGTH)]
        public string Color { get { return color; } set { color = value; } }


    }
}


