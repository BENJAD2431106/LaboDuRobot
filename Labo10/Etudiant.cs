using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10
{
    public class Etudiant
    {
        string nom;
        List<double> Notes { get; set; }
        public Etudiant(string nom, List<double> notes)
        {
            this.nom = nom;
            Notes = notes;
        }
        public string GetNom() { return nom; }
        public double CalculerMoyenne()
        {
            double somme = 0;
            double moy = 0;
            foreach (double note in Notes)
            {
                somme += note;
            }
            moy = somme / Notes.Count();
            return moy;
        }
        public bool EstEnVoieDeReussite()
        {
            if (CalculerMoyenne() >= 60)
                return true;
            else
                return false;
        }
    }
}
