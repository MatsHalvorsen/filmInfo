using System.Xml.Serialization;

namespace BokFilm
{
    internal class Produkt
    {
        private string _Title;
        private string _Description;
        private string _Author;
        private bool _isAFilm;
        private string _MainCh;

        public Produkt(string title, string author, bool isAFilm, string MC, string description)
        {
            _Title = title;
            _Description = description;
            _Author = author;
            _isAFilm = isAFilm;
            //_MainCh = _isAFilm ? MC: string.Empty;
            _MainCh = MC;
        }

        public void PrintInfo()
        {
            var isFilm = _isAFilm? "film": "book";
            Console.WriteLine($"{_Title}\nThe {isFilm} was made by {_Author} \nMain Character - {_MainCh} \n \n  {_Description}");

        }

    }
}