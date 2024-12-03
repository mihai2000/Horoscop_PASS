namespace Horoscop
{
    public static class Horoscop
    {
        public static string PreziceEvolutieMedie(string numarMatricol, string nume)
        {
            int suma = numarMatricol.Sum(c => c) + nume.Sum(c => c);
            return (suma % 2 == 1) ? "Media va crește" : "Media va scădea";
        }

        public static string PreziceZiBuna(string numarMatricol, string nume)
        {
            int ziuaCurenta = DateTime.Now.Day;
            char primaLitera = nume[0];
            int suma = ziuaCurenta + primaLitera;
            return (suma % 2 == 1) ? "Va avea o zi bună" : "Nu va avea o zi bună";
        }

        public static string PreziceMediiScazute(List<Student> students)
        {
            int count = students.Count(s => s.Medie > 8 && (s.NumarMatricol.Sum(c => c) + s.Nume.Sum(c => c)) % 2 == 0);
            return $"{count} studenți cu medie peste 8 vor avea media scăzută.";
        }
    }
}
