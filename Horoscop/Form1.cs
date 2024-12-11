namespace Horoscop
{
    public partial class Form1 : Form
    {
        private IStudentDAO studentDAO;

        public Form1()
        {
            InitializeComponent();
            ButtonXML.Click += new EventHandler(ButtonXML_Click);
            ButtonSQL.Click += new EventHandler(ButtonSQL_Click);
            ButtonCreate.Click += new EventHandler(ButtonCreate_Click);
            ButtonUpdate.Click += new EventHandler(ButtonUpdate_Click);
            ButtonDelete.Click += new EventHandler(ButtonDelete_Click);
            ButtonGet.Click += new EventHandler(ButtonGet_Click);
            ButtonPrezice.Click += new EventHandler(ButtonPrezice_Click);
            ButtonRefresh.Click += new EventHandler(ButtonRefresh_Click);
        }
        
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string numarMatricol = textBoxNumarMatricol.Text;
            string nume = textBoxNume.Text;
            string medieText = textBoxMedie.Text;
            double medie = string.IsNullOrWhiteSpace(medieText) ? 4.0 : double.Parse(medieText);

            if (string.IsNullOrWhiteSpace(numarMatricol) || string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Please enter both Numar Matricol and Nume.");
                return;
            }

            Student newStudent = new Student
            {
                NumarMatricol = numarMatricol,
                Nume = nume,
                Medie = medie
            };

            studentDAO.AddStudent(newStudent);
            LoadStudents();
        }

        // Event handler for Update button
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string numarMatricol = textBoxNumarMatricol.Text;
            string nume = textBoxNume.Text;
            string medieText = textBoxMedie.Text;
            double medie = string.IsNullOrWhiteSpace(medieText) ? 4.0 : double.Parse(medieText);

            if (string.IsNullOrWhiteSpace(numarMatricol) || string.IsNullOrWhiteSpace(nume))
            {
                MessageBox.Show("Please enter both Numar Matricol and Nume.");
                return;
            }

            Student updatedStudent = new Student
            {
                NumarMatricol = numarMatricol,
                Nume = nume,
                Medie = medie
            };

            if (studentDAO.UpdateStudent(numarMatricol, updatedStudent))
            {
                LoadStudents();
            }
            else
            {
                MessageBox.Show($"Studentul cu numele: {nume} și numărul matricol: {numarMatricol} nu există.");
            }
        }
        // Event handler for Delete button
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string numarMatricol = textBoxNumarMatricol.Text;
            if (string.IsNullOrWhiteSpace(numarMatricol))
            {
                MessageBox.Show("Please enter Numar Matricol.");
                return;
            }

            if (studentDAO.DeleteStudent(numarMatricol))
            {
                LoadStudents();
            }
            else
            {
                MessageBox.Show($"Studentul cu numărul matricol {numarMatricol} nu există.");
            }
        }

        // Event handler for Get Student button
        private void ButtonGet_Click(object sender, EventArgs e)
        {
            string numarMatricol = textBoxNumarMatricol.Text;
            if (string.IsNullOrWhiteSpace(numarMatricol))
            {
                MessageBox.Show("Please enter Numar Matricol.");
                return;
            }

            Student student = studentDAO.GetStudentByNumarMatricol(numarMatricol);
            if (student != null)
            {
                dataGridViewStudents.DataSource = new List<Student> { student };

            }
            else
            {
                MessageBox.Show($"Studentul cu numărul matricol {numarMatricol} nu există.");
            }
        }
        private void ButtonSQL_Click(object sender, EventArgs e)
        {
            studentDAO = new StudentDAOSQL();
            LoadStudents();
            Title.Text = "Horoscop Studenti - SQL";

        }

        private void ButtonXML_Click(object sender, EventArgs e)
        {
            studentDAO = new StudentDAOXML();
            LoadStudents();
            Title.Text = "Horoscop Studenti - XML";

        }
        private void LoadStudents()
        {
            List<Student> students = studentDAO.GetStudents();
            dataGridViewStudents.DataSource = students;
        }
        private void ButtonPrezice_Click(object sender, EventArgs e)
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

            // Chack if student exists
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

            // Prediction algorithm
            string evolutieMedie = Horoscop.PreziceEvolutieMedie(numarMatricol, nume);
            string ziBuna = Horoscop.PreziceZiBuna(numarMatricol, nume);
            string mediiScazute = Horoscop.PreziceMediiScazute(studentDAO.GetStudents());

            // Afișarea rezultatelor
            MessageBox.Show($"Predicția evoluției mediei: {evolutieMedie}\nPredicția zilei bune: {ziBuna}\n{mediiScazute}");
        }


    }
}
