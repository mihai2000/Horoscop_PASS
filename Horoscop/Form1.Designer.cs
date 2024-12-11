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
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            ButtonPrezice = new Button();
            ButtonCreate = new Button();
            ButtonUpdate = new Button();
            ButtonGet = new Button();
            ButtonSQL = new Button();
            ButtonXML = new Button();
            ButtonDelete = new Button();
            textBoxNumarMatricol = new TextBox();
            textBoxNume = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxMedie = new TextBox();
            medieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numarMatricolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewStudents = new DataGridView();
            ButtonRefresh = new Button();
            Title = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Student);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // ButtonPrezice
            // 
            ButtonPrezice.Location = new Point(549, 199);
            ButtonPrezice.Name = "ButtonPrezice";
            ButtonPrezice.Size = new Size(75, 23);
            ButtonPrezice.TabIndex = 3;
            ButtonPrezice.Text = "Prezice";
            ButtonPrezice.UseVisualStyleBackColor = true;
            ButtonPrezice.Click += ButtonPrezice_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(475, 112);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(109, 23);
            ButtonCreate.TabIndex = 7;
            ButtonCreate.Text = "Create Student";
            ButtonCreate.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(590, 112);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(109, 23);
            ButtonUpdate.TabIndex = 8;
            ButtonUpdate.Text = "Update Student";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonGet
            // 
            ButtonGet.Location = new Point(475, 170);
            ButtonGet.Name = "ButtonGet";
            ButtonGet.Size = new Size(224, 23);
            ButtonGet.TabIndex = 9;
            ButtonGet.Text = "Get Student by numar matricol";
            ButtonGet.UseVisualStyleBackColor = true;
            // 
            // ButtonSQL
            // 
            ButtonSQL.Location = new Point(23, 161);
            ButtonSQL.Name = "ButtonSQL";
            ButtonSQL.Size = new Size(75, 23);
            ButtonSQL.TabIndex = 10;
            ButtonSQL.Text = "SQL";
            ButtonSQL.UseVisualStyleBackColor = true;
            ButtonSQL.Click += ButtonSQL_Click;
            // 
            // ButtonXML
            // 
            ButtonXML.Location = new Point(23, 132);
            ButtonXML.Name = "ButtonXML";
            ButtonXML.Size = new Size(75, 23);
            ButtonXML.TabIndex = 11;
            ButtonXML.Text = "XML";
            ButtonXML.UseVisualStyleBackColor = true;
            ButtonXML.Click += ButtonXML_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(590, 141);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(109, 23);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Delete Student";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxNumarMatricol
            // 
            textBoxNumarMatricol.Location = new Point(143, 347);
            textBoxNumarMatricol.Name = "textBoxNumarMatricol";
            textBoxNumarMatricol.Size = new Size(100, 23);
            textBoxNumarMatricol.TabIndex = 1;
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(249, 348);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(100, 23);
            textBoxNume.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 329);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Numar Matricol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 329);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Nume: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 329);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 14;
            label4.Text = "Medie";
            // 
            // textBoxMedie
            // 
            textBoxMedie.Location = new Point(355, 347);
            textBoxMedie.Name = "textBoxMedie";
            textBoxMedie.Size = new Size(100, 23);
            textBoxMedie.TabIndex = 13;
            // 
            // medieDataGridViewTextBoxColumn
            // 
            medieDataGridViewTextBoxColumn.DataPropertyName = "Medie";
            medieDataGridViewTextBoxColumn.HeaderText = "Medie";
            medieDataGridViewTextBoxColumn.Name = "medieDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // numarMatricolDataGridViewTextBoxColumn
            // 
            numarMatricolDataGridViewTextBoxColumn.DataPropertyName = "NumarMatricol";
            numarMatricolDataGridViewTextBoxColumn.HeaderText = "NumarMatricol";
            numarMatricolDataGridViewTextBoxColumn.Name = "numarMatricolDataGridViewTextBoxColumn";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { numarMatricolDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn, medieDataGridViewTextBoxColumn });
            dataGridViewStudents.DataSource = studentBindingSource1;
            dataGridViewStudents.Location = new Point(126, 112);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(343, 193);
            dataGridViewStudents.TabIndex = 0;
            // 
            // ButtonRefresh
            // 
            ButtonRefresh.Location = new Point(475, 141);
            ButtonRefresh.Name = "ButtonRefresh";
            ButtonRefresh.Size = new Size(109, 23);
            ButtonRefresh.TabIndex = 15;
            ButtonRefresh.Text = "Get All Students";
            ButtonRefresh.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(126, 37);
            Title.Name = "Title";
            Title.Size = new Size(237, 37);
            Title.TabIndex = 16;
            Title.Text = "Horoscop Studenti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 17;
            label3.Text = "Choose Database";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 436);
            Controls.Add(label3);
            Controls.Add(Title);
            Controls.Add(ButtonRefresh);
            Controls.Add(label4);
            Controls.Add(textBoxMedie);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonXML);
            Controls.Add(ButtonSQL);
            Controls.Add(ButtonGet);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonCreate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonPrezice);
            Controls.Add(textBoxNume);
            Controls.Add(textBoxNumarMatricol);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonPrezice;
        private BindingSource studentBindingSource;
        private BindingSource studentBindingSource1;
        private Button ButtonCreate;
        private Button ButtonUpdate;
        private Button ButtonGet;
        private Button ButtonSQL;
        private Button ButtonXML;
        private Button ButtonDelete;
        private TextBox textBoxNumarMatricol;
        private TextBox textBoxNume;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBoxMedie;
        private DataGridViewTextBoxColumn medieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numarMatricolDataGridViewTextBoxColumn;
        private DataGridView dataGridViewStudents;
        private Button ButtonRefresh;
        private Label Title;
        private Label label3;
    }
}
