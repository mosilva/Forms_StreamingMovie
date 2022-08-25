using LetsMovie.FormsMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.FormsDomain
{
    public static class MovieCollections
    {
        public static List<Movies> ListCatalogMovies = new List<Movies>()
        {
            new Movies(1, "Indiana Jones: O reino da caveira de cristal",EnumGender.Adventure,"2008-05-21"),
            new Movies(2, "O auto  da compadecida",EnumGender.Comedy,"2000-09-10"),
            new Movies(3, "A verdade nua e crua", EnumGender.Romantic_Comedy,"2009-09-18"),
            new Movies(4, "Kill Bill - Volume 1", EnumGender.Action, "2004-04-23"),
            new Movies(5, "Kill Bill - Volume 2", EnumGender.Action, "2004-10-08"),
            new Movies(6, "Mississipi em chamas", EnumGender.Action, "1989-03-23"),
            new Movies(7, "O Poderoso Chefão", EnumGender.Action, "1972-03-24"),
            new Movies(8, "Thor: Amor e Trovão", EnumGender.Heroes, "2022-07-07"),
            new Movies(9, "V de vingança", EnumGender.Action, "2006-04-07"),
            new Movies(10, "Diário de uma paixão", EnumGender.Romance, "2004-08-13"),
            new Movies(11, "O Exorcista", EnumGender.Horror, "1974-06-29")
        };
        public static Stack<Movies> StackReleasesAddMovies = new Stack<Movies>(ListCatalogMovies);

        public static Queue<Movies> QueueTopFivesDateOfReleasedMovies = new Queue<Movies>(
            ListCatalogMovies
            .OrderBy(p => p.DateOfReleased)
            .Take(5));

        public static Dictionary<EnumGender, List<Movies>> DictionaryGenderMovies = new Dictionary<EnumGender, List<Movies>>()
        {
            {EnumGender.Action, ListCatalogMovies.Where(p => p.Gender == EnumGender.Action).ToList()},
            {EnumGender.Adventure, ListCatalogMovies.Where(p => p.Gender == EnumGender.Adventure).ToList()},
            {EnumGender.Heroes, ListCatalogMovies.Where(p => p.Gender == EnumGender.Heroes).ToList()},
            {EnumGender.Comedy, ListCatalogMovies.Where(p => p.Gender == EnumGender.Comedy).ToList()},
            {EnumGender.Romantic_Comedy, ListCatalogMovies.Where(p => p.Gender == EnumGender.Romantic_Comedy).ToList()},
            {EnumGender.Romance, ListCatalogMovies.Where(p => p.Gender == EnumGender.Romance).ToList()},
            {EnumGender.Horror, ListCatalogMovies.Where(p => p.Gender == EnumGender.Horror).ToList()},
        };

        public static void AtualizaCollections()
        {
            DictionaryGenderMovies = new Dictionary<EnumGender, List<Movies>>()
            {
                {EnumGender.Action, ListCatalogMovies.Where(p => p.Gender == EnumGender.Action).ToList()},
                {EnumGender.Adventure, ListCatalogMovies.Where(p => p.Gender == EnumGender.Adventure).ToList()},
                {EnumGender.Heroes, ListCatalogMovies.Where(p => p.Gender == EnumGender.Heroes).ToList()},
                {EnumGender.Comedy, ListCatalogMovies.Where(p => p.Gender == EnumGender.Comedy).ToList()},
                {EnumGender.Romantic_Comedy, ListCatalogMovies.Where(p => p.Gender == EnumGender.Romantic_Comedy).ToList()},
                {EnumGender.Romance, ListCatalogMovies.Where(p => p.Gender == EnumGender.Romance).ToList()},
                {EnumGender.Horror, ListCatalogMovies.Where(p => p.Gender == EnumGender.Horror).ToList()},
            };

            StackReleasesAddMovies = new Stack<Movies>(ListCatalogMovies);

            QueueTopFivesDateOfReleasedMovies = new Queue<Movies>(
                ListCatalogMovies
                .OrderBy(p => p.DateOfReleased)
                .Take(5));
    }

    }
}