using Labo10;
namespace TestsLabo10
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_CalculerMoy()
        {
            List<double> notesJ = new List<double>()
            { 77, 34.5, 98, 59};
            Etudiant etudiant = new Etudiant("Jad", notesJ);
            double resAttendu = 67.125;
            double resObtenu = etudiant.CalculerMoyenne();

            Assert.Equal(resAttendu, resObtenu);
        }
        [Fact]
        public void Test2_EstEnVoieDeR()
        {
            List<double> notesJ = new List<double>()
            { 77, 34.5, 98, 59};
            Etudiant etudiant = new Etudiant("Jad", notesJ);
            bool resAttendu = true;
            bool resObtenu = etudiant.EstEnVoieDeReussite();

            Assert.Equal(resAttendu, resObtenu);
        }
        [Fact]
        public void Test3_CalcuerMoyGrp()
        {
            List<double> notesA = new List<double>()
            { 87, 34.5, 68, 79};
            Etudiant etudiantA = new Etudiant("Alex", notesA);
            List<double> notesJ = new List<double>()
            { 77, 34.5, 98, 59};
            Etudiant etudiantJ = new Etudiant("Jad", notesJ);
            List<double> notesN = new List<double>()
            { 47, 74.5, 98, 29};
            Etudiant etudiantN = new Etudiant("Nicolas", notesN);

            List<Etudiant> etudiants = new List<Etudiant>()
            { etudiantA, etudiantJ, etudiantN };

            Groupe grp = new Groupe("Grp10", etudiants);
            double moy1 = 0;
            double sum1 = 0;

            foreach (var etu in etudiants) {sum1 += etu.CalculerMoyenne(); }
            moy1 = sum1 / etudiants.Count();
            double resAttendu = moy1;
            double resObtenu = grp.CalculerMoy();

            Assert.Equal(resAttendu, resObtenu);
        }
        [Fact]
        public void Test4_ValiderPresence()
        {
            List<double> notesA = new List<double>()
            { 87, 34.5, 68, 79};
            Etudiant etudiantA = new Etudiant("Alex", notesA);
            List<double> notesJ = new List<double>()
            { 77, 34.5, 98, 59};
            Etudiant etudiantJ = new Etudiant("Jad", notesJ);
            List<double> notesN = new List<double>()
            { 47, 74.5, 98, 29};
            Etudiant etudiantN = new Etudiant("Nicolas", notesN);

            List<Etudiant> etudiants = new List<Etudiant>()
            { etudiantA, etudiantJ, etudiantN };

            Groupe grp = new Groupe("Grp10", etudiants);

            bool resAttendu = false;
            bool resObtenu = grp.EstPresent("Alexandre");
            bool resAttendu1 = true;
            bool resObtenu1 = grp.EstPresent("Alex");
            Assert.Equal(resAttendu, resObtenu);
            Assert.Equal(resAttendu1, resObtenu1);
        }
    }
}