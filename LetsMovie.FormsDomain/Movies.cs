using LetsMovie.FormsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.FormsMenu
{
    public class Movies
    {
        public int Id { get; }
        public string Title { get; set; }
        public EnumGender Gender { get; set; }
        public DateOnly DateOfReleased { get; set; }

        public Movies(int id, string title, EnumGender gender, string dateOfReleased)
        {
            Id = id;
            Title = title;
            Gender = gender;
            DateOnly.TryParse(dateOfReleased, out DateOnly PutDateOfReleased);
            DateOfReleased = PutDateOfReleased;
        }
    }
}
