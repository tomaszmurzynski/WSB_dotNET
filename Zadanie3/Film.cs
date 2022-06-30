using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly static Dictionary<string, string[]> powi�zaneW�a�ciwo�ci = new Dictionary<string, string[]>()
        {
            ["Tytul"] = new string[] { "TytulFilmu" },
            ["Rezyser"] = new string[] { "Rezyser" },
            ["Produkcja"] = new string[] { "Produkcja" },
            ["Nosnik"] = new string[] { "Nosnik" },
            ["DataWydania"] = new string[] { "DataWydania" },
            ["TytylFilmu"] = new string[] { "Szczeg�y" },
        };
        public void OnPropertyChanged(
            [CallerMemberName] string w�a�ciwo�� = null,
            HashSet<string> za�atwioneW�a�ciwo�ci = null
            )
        {
            if (za�atwioneW�a�ciwo�ci == null)
                za�atwioneW�a�ciwo�ci = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(w�a�ciwo��));
            za�atwioneW�a�ciwo�ci.Add(w�a�ciwo��);

            if (powi�zaneW�a�ciwo�ci.ContainsKey(w�a�ciwo��))
                foreach (string powi�zanaW�a�ciwo�� in powi�zaneW�a�ciwo�ci[w�a�ciwo��])
                    if (!za�atwioneW�a�ciwo�ci.Contains(powi�zanaW�a�ciwo��))
                        OnPropertyChanged(
                            powi�zanaW�a�ciwo��,
                            za�atwioneW�a�ciwo�ci
                            );
        }

        public static uint nast�pneID = 0;

        public uint ID { get; } = nast�pneID++;
        string
            tytul,
            rezyser,
            produkcja,
            nosnik
            ;
        DateTime?
            dataWydania
            ;

        public string FilmRezyser
        {
            get { return $"{Tytul} {Rezyser}"; }
        }

        public string Tytul
        {
            get => tytul;
            set
            {
                tytul = value;
                OnPropertyChanged();
            }
        }
        public string Rezyser
        {
            get => rezyser;
            set
            {
               rezyser = value;
               OnPropertyChanged();
            }
        }
        public string Produkcja
        {
            get => produkcja;
            set
            {
               produkcja = value;
               OnPropertyChanged();
            }
        }
        public string Nosnik
        {
            get => nosnik;
            set
            {
               nosnik = value;
               OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }
        
        
        public string Szczeg�y => $"{FilmRezyser}, {Nosnik} ";

        /*public override string ToString()
        {
            return Imi�Nazwisko;
        }*/
    }
}
