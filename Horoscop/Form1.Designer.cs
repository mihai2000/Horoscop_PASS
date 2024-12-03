namespace Horoscop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewStudents = new DataGridView();
            numarMatricolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            medieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            textBoxNumarMatricol = new TextBox();
            textBoxNume = new TextBox();
            buttonPrezice = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { numarMatricolDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn, medieDataGridViewTextBoxColumn });
            dataGridViewStudents.DataSource = studentBindingSource1;
            dataGridViewStudents.Location = new Point(190, 70);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(343, 188);
            dataGridViewStudents.TabIndex = 0;
            // 
            // numarMatricolDataGridViewTextBoxColumn
            // 
            numarMatricolDataGridViewTextBoxColumn.DataPropertyName = "NumarMatricol";
            numarMatricolDataGridViewTextBoxColumn.HeaderText = "NumarMatricol";
            numarMatricolDataGridViewTextBoxColumn.Name = "numarMatricolDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // medieDataGridViewTextBoxColumn
            // 
            medieDataGridViewTextBoxColumn.DataPropertyName = "Medie";
            medieDataGridViewTextBoxColumn.HeaderText = "Medie";
            medieDataGridViewTextBoxColumn.Name = "medieDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Student);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // textBoxNumarMatricol
            // 
            textBoxNumarMatricol.Location = new Point(190, 307);
            textBoxNumarMatricol.Name = "textBoxNumarMatricol";
            textBoxNumarMatricol.Size = new Size(100, 23);
            textBoxNumarMatricol.TabIndex = 1;
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(327, 307);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(100, 23);
            textBoxNume.TabIndex = 2;
            // 
            // buttonPrezice
            // 
            buttonPrezice.Location = new Point(458, 307);
            buttonPrezice.Name = "buttonPrezice";
            buttonPrezice.Size = new Size(75, 23);
            buttonPrezice.TabIndex = 3;
            buttonPrezice.Text = "Prezice";
            buttonPrezice.UseVisualStyleBackColor = true;
            buttonPrezice.Click += buttonPrezice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 289);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Numar Matricol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 289);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Nume: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 9);
            label3.Name = "label3";
            label3.Size = new Size(212, 32);
            label3.TabIndex = 6;
            label3.Text = "Horoscop Studenti";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 436);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPrezice);
            Controls.Add(textBoxNume);
            Controls.Add(textBoxNumarMatricol);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private TextBox textBoxNumarMatricol;
        private TextBox textBoxNume;
        private Button buttonPrezice;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn numarMatricolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn medieDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private BindingSource studentBindingSource1;
    }
}
