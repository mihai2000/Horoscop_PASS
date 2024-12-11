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
            //InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {

            Label labelTitle = new Label
            {
                Text = "Horoscop Studenti",
                Font = new System.Drawing.Font("Arial", 16),
                AutoSize = true,
                Location = new System.Drawing.Point((this.Width / 2) - 100, 10)
            };
            Controls.Add(labelTitle);

            Button buttonXML = new Button
            {
                Text = "XML",
                Location = new System.Drawing.Point(10, 10)
            };
            buttonXML.Click += new EventHandler(ButtonXML_Click);

            Button buttonSQL = new Button
            {
                Text = "SQL",
                Location = new System.Drawing.Point(90, 10)
            };
            buttonSQL.Click += new EventHandler(ButtonSQL_Click);

            Controls.Add(buttonXML);
            Controls.Add(buttonSQL);

            dataGridViewStudents = new DataGridView
            {
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(500, 200)
            };
            Controls.Add(dataGridViewStudents);

            // Labels for NumarMatricol, Nume, and Medie
            Label labelNumarMatricol = new Label { Text = "Numar Matricol", Location = new System.Drawing.Point(10, 260) };
            Label labelNume = new Label { Text = "Nume", Location = new System.Drawing.Point(120, 260) };
            Label labelMedie = new Label { Text = "Medie", Location = new System.Drawing.Point(230, 260) };

            Controls.Add(labelNumarMatricol);
            Controls.Add(labelNume);
            Controls.Add(labelMedie);

            //TextBoxes for NumarMatricol and Nume
            textBoxNumarMatricol = new TextBox { Location = new System.Drawing.Point(10, 280), Width = 100 };
            textBoxNume = new TextBox { Location = new System.Drawing.Point(120, 280), Width = 100 };
            textBoxMedie = new TextBox { Location = new System.Drawing.Point(230, 280), Width = 70 }; // Medie TextBox

            Controls.Add(textBoxNumarMatricol);
            Controls.Add(textBoxNume);
            Controls.Add(textBoxMedie);

            // Buttons for various operations
            Button buttonCreate = new Button { Text = "Create", Location = new System.Drawing.Point(310, 280) };
            buttonCreate.Click += new EventHandler(ButtonCreate_Click);
            Controls.Add(buttonCreate);

            Button buttonUpdate = new Button { Text = "Update", Location = new System.Drawing.Point(390, 280) };
            buttonUpdate.Click += new EventHandler(ButtonUpdate_Click);
            Controls.Add(buttonUpdate);

            Button buttonDelete = new Button { Text = "Delete", Location = new System.Drawing.Point(470, 280) };
            buttonDelete.Click += new EventHandler(ButtonDelete_Click);
            Controls.Add(buttonDelete);

            Button buttonGet = new Button { Text = "Get Student", Location = new System.Drawing.Point(550, 280) };
            buttonGet.Click += new EventHandler(ButtonGet_Click);
            Controls.Add(buttonGet);

            // Button for prediction
            Button buttonPrezice = new Button { Text = "Prezice", Location = new System.Drawing.Point(630, 280) };
            buttonPrezice.Click += new EventHandler(ButtonPrezice_Click);
            Controls.Add(buttonPrezice);

            Button buttonRefresh = new Button { Text = "Refresh", Location = new System.Drawing.Point(10, 320) };
            buttonRefresh.Click += new EventHandler(ButtonRefresh_Click);
            Controls.Add(buttonRefresh);

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
            //Controls.Clear();
            //InitializeCustomComponents();
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
