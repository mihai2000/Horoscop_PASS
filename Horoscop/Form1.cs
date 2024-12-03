namespace Horoscop
{
    public partial class Form1 : Form
    {
        private IStudentDAO studentDAO;

        public Form1()
        {
            InitializeComponent();
            //studentDAO = new StudentDAOSQL();
            studentDAO = new StudentDAOXML();

            LoadStudents();

        }
        private void LoadStudents()
        {
            List<Student> students = studentDAO.GetStudents();
            dataGridViewStudents.DataSource = students;
        }
        private void buttonPrezice_Click(object sender, EventArgs e)
        {
            string numarMatricol = textBoxNumarMatricol.Text;
            string nume = textBoxNume.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(numarMatricol))
            {
                MessageBox.Show("Vă rugăm să introduceți numărul matricol.");
                textBoxNumarMatricol.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Vă rugăm să introduceți numele.");
                textBoxNume.Focus();
                return;
            }

            // Verificarea existenței studentului
            Student student = studentDAO.GetStudentByNumarMatricol(numarMatricol);
            if (student == null)
            {
                MessageBox.Show($"Studentul cu numărul matricol {numarMatricol} nu există.");
                return;
            }

            // Check if the student exists by Nume
            if (!student.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Studentul cu numele: {nume} și numărul matricol: {numarMatricol} nu există.");
                return;
            }

            // Aplicarea algoritmilor de predicție
            string evolutieMedie = Horoscop.PreziceEvolutieMedie(numarMatricol, nume);
            string ziBuna = Horoscop.PreziceZiBuna(numarMatricol, nume);
            string mediiScazute = Horoscop.PreziceMediiScazute(studentDAO.GetStudents());

            // Afișarea rezultatelor
            MessageBox.Show($"Predicția evoluției mediei: {evolutieMedie}\nPredicția zilei bune: {ziBuna}\n{mediiScazute}");
        }
    }
}
