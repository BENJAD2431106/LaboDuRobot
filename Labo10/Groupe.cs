using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10
{
    public class Groupe
    {
        string Nom { get; set; }
        List<Etudiant> EtudiantList { get; set; }
        public Groupe(string nom, List<Etudiant> etudiantList)
        {
            Nom = nom;
            EtudiantList = etudiantList;
        }
        public void AddStudent(Etudiant etudiant)
        {
            EtudiantList.Add(etudiant);
        }

        public double CalculerMoy()
        {
            double sommeGr = 0;
            double moyGr = 0;
            foreach (Etudiant etu in EtudiantList)
            {
                sommeGr += etu.CalculerMoyenne();
            }
            moyGr = sommeGr / EtudiantList.Count();
            return moyGr;
        }
        public bool EstPresent(string nom)
        {
            foreach (Etudiant etu in EtudiantList)
            {
                if (nom == etu.GetNom())
                { return true; }
            }
            return false;
        }
    }
}
