using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Model
    {
        public ObservableCollection<Film> ListaFilmow { get; set; } = new ObservableCollection<Film>(new Film[]{
            new Film(){
                Tytul="Elvis",
                Rezyser="Baz Luhrmann",
                Produkcja="USA / Australia",
                Nosnik="DVD",
                DataWydania=DateTime.Parse("20.06.2022"),
            },
            new Film(){Tytul="Czarny telefon", Rezyser="Scott Derrickson", Produkcja="USA", Nosnik = "DVD", DataWydania=DateTime.Parse("24.06.2022")},
            new Film(){Tytul="Pajêcza g³owa", Rezyser="Joseph Kosinski", Produkcja="USA", Nosnik = "DVD", DataWydania=DateTime.Parse("17.06.2022")},
            new Film(){Tytul="Rzut ¿ycia", Rezyser="Jeremiah Zagar", Produkcja="Japan", Nosnik = "DVD", DataWydania=DateTime.Parse("8.06.2022")},
        });

        internal Film NowyFilm()
        {
            Film nowa = new Film();
            ListaFilmow.Add(nowa);
            return nowa;
        }
    }
}
