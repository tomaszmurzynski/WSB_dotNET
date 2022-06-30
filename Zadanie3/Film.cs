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
        readonly static Dictionary<string, string[]> powi¹zaneW³aœciwoœci = new Dictionary<string, string[]>()
        {
            ["Tytul"] = new string[] { "TytulFilmu" },
            ["Rezyser"] = new string[] { "Rezyser" },
            ["Produkcja"] = new string[] { "Produkcja" },
            ["Nosnik"] = new string[] { "Nosnik" },
            ["DataWydania"] = new string[] { "DataWydania" },
            ["TytylFilmu"] = new string[] { "Szczegó³y" },
        };
        public void OnPropertyChanged(
            [CallerMemberName] string w³aœciwoœæ = null,
            HashSet<string> za³atwioneW³aœciwoœci = null
            )
        {
            if (za³atwioneW³aœciwoœci == null)
                za³atwioneW³aœciwoœci = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(w³aœciwoœæ));
            za³atwioneW³aœciwoœci.Add(w³aœciwoœæ);

            if (powi¹zaneW³aœciwoœci.ContainsKey(w³aœciwoœæ))
                foreach (string powi¹zanaW³aœciwoœæ in powi¹zaneW³aœciwoœci[w³aœciwoœæ])
                    if (!za³atwioneW³aœciwoœci.Contains(powi¹zanaW³aœciwoœæ))
                        OnPropertyChanged(
                            powi¹zanaW³aœciwoœæ,
                            za³atwioneW³aœciwoœci
                            );
        }

        public static uint nastêpneID = 0;

        public uint ID { get; } = nastêpneID++;
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
        
        
        public string Szczegó³y => $"{FilmRezyser}, {Nosnik} ";

        /*public override string ToString()
        {
            return ImiêNazwisko;
        }*/
    }
}
