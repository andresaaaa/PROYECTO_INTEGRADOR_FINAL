using Microsoft.VisualBasic.Logging;
using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class EstudentForm_controller
    {
        View_Principal EstudentForm;
        Persona Persona;
        Questions Questions = new Questions();
        public static List<Persona> List;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Semester;
        public string Age;
        public long Phone;
        public string Facultad;
        public string Programa;
        public string Document_type;
        public string Document_number;
        public string Birthdate;
        public string Gender;
        public string Stratum;
        public string Departament;
        public string Municipality;
        

        public EstudentForm_controller(View_Principal estudentForm, Persona persona)
        {
            EstudentForm = estudentForm;
            Persona = persona;

            List = new List<Persona>();

            

            FillComboBox();

            estudentForm.SubmitButton.Click += SubmitButton_Click;
            estudentForm.FacultyNameBox.TextChanged += FacultyNameBox_TextChanged;
            estudentForm.ProgramNameBox.Click += ProgramNameBox_Click;
            estudentForm.DepartamentCoBox.TextChanged += DepartamentCoBox_TextChanged;
            estudentForm.MaleRadio.CheckedChanged += MaleRadio_CheckedChanged;
            estudentForm.FemaleRadio.CheckedChanged += FemaleRadio_CheckedChanged;
            estudentForm.OtherRadio.CheckedChanged += OtherRadio_CheckedChanged;

            estudentForm.FormClosing += EstudentForm_FormClosing;
            
        }

        private void EstudentForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (true)
            {
                
            }

        }

        private void SubmitButton_Click(object? sender, EventArgs e)
        {
            FirstName = EstudentForm.FirstNameBox.Text;
            LastName = EstudentForm.LastNameBox.Text;
            Email = EstudentForm.EmailBox.Text;
            Semester = EstudentForm.SemesterBox.Value.ToString();
            Age = EstudentForm.AgeBox.Value.ToString();
            Phone = Convert.ToInt64(EstudentForm.PhoneNumberBox.Text);
            Facultad = EstudentForm.FacultyNameBox.SelectedItem.ToString();
            Programa = EstudentForm.ProgramNameBox.SelectedItem.ToString();
            Document_type = EstudentForm.DocumentTypeBox.SelectedItem.ToString();
            Document_number = EstudentForm.DocumentNumberBox.Text;
            Birthdate = EstudentForm.BirthDateBox.Value.ToString();
            Gender = EstudentForm.Gender;
            Stratum = EstudentForm.StratumCoBox.SelectedItem.ToString();
            Departament = EstudentForm.DepartamentCoBox.SelectedItem.ToString();
            Municipality = EstudentForm.municipalityCoBox.SelectedItem.ToString();

            Persona persona = new Persona(FirstName, LastName, Email, Convert.ToInt32(Semester), Convert.ToInt32(Age),
            Convert.ToInt64(Phone),Facultad , Programa,Document_type,
            Document_number, Convert.ToDateTime(Birthdate), Gender, Stratum, Departament, Municipality);
            persona.add();
            List.Add(persona);

            MessageBox.Show("Respuestas guardadas exitosamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Responder el siguiente formulario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstudentForm.Hide();
            Questions.ShowDialog();
            EstudentForm.Close();


        }
        private void FacultyNameBox_TextChanged(object sender, EventArgs e)
        {
            EstudentForm.ProgramNameBox.Text = "";
            EstudentForm.ProgramNameBox.Items.Clear();
        }
        private void DepartamentCoBox_TextChanged(object? sender, EventArgs e)
        {
            FillMunicipality();
        }

        private void MaleRadio_CheckedChanged(object? sender, EventArgs e)
        {
            if (EstudentForm.MaleRadio.Checked) 
            {
                EstudentForm.Gender = "Masculino";
                
            }
        }

        private void FemaleRadio_CheckedChanged(object? sender, EventArgs e)
        {
            if (EstudentForm.FemaleRadio.Checked)
            {
                EstudentForm.Gender = "Femenino";
               
            }
        }

        private void OtherRadio_CheckedChanged(object? sender, EventArgs e)
        {
            if (EstudentForm.OtherRadio.Checked)
            {
                EstudentForm.Gender = "Otro";
    
            }
        }
        private void ProgramNameBox_Click(object sender, EventArgs e)
        {
            if (!(EstudentForm.FacultyNameBox.Text.Any()))
            {
                MessageBox.Show("Falta informacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (EstudentForm.FacultyNameBox.SelectedItem.ToString() == "Facultad de Ciencias Administrativas, Contables y Económicas")
            {
                EstudentForm.ProgramNameBox.Items.Clear();
                EstudentForm.ProgramNameBox.Items.AddRange
                (
                       new string[]
                       {
                           "Administración de Empresas","Contaduría","Economía"
                       }
                );
            }
            else if (EstudentForm.FacultyNameBox.SelectedItem.ToString() == "Ingenieria")
            {
                EstudentForm.ProgramNameBox.Items.Clear();
                EstudentForm.ProgramNameBox.Items.AddRange
                (
                       new string[]
                       {
                           "Ingenieria en sistemas","Ingenieria en ambiental y sanitaria","Ingenieria en agroindustrial"
                       }
                );
            }
            

        }
        public void FillComboBox()
        {
            EstudentForm.DocumentTypeBox.Items.AddRange
            (
                new string[]
                {
                    "Cedula","Cedula extranjera","pasaporte","Tarjeta de identidad"
                }
            );

            EstudentForm.FacultyNameBox.Items.AddRange
            (
                new string[]
                {
                    "Ingenieria","Facultad de Ciencias Administrativas, Contables y Económicas"
                }
            );

            EstudentForm.StratumCoBox.Items.AddRange
            (
                new string[]
                {
                    "Estrato 1: Bajo-bajo","Estrato 2: Bajo","Estrato 3: Medio-bajo","Estrato 4: Medio","Estrato 5: Medio-alto","Estrato 6: Alto"
                }
            );

            FillDepartament();

        }
        public void FillDepartament()
        {
            if (Modelo.Departament.Listdepartaments == null)
                Modelo.Departament.Listdepartaments = new List<Departament>();

            using (StreamReader leer = new StreamReader("Departamentos.txt"))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 2)
                        {
                            Modelo.Departament.Listdepartaments.Add(new Departament(Convert.ToInt32(datos[0].Trim()), datos[1].Trim()));

                        }
                    }
                }
            }

            foreach (var item in Modelo.Departament.Listdepartaments)
            {
                EstudentForm.DepartamentCoBox.Items.Add(item.Name);
            }


        }
        public void FillMunicipality()
        {
            if (Modelo.Departament.ListMunicipality == null)
                Modelo.Departament.ListMunicipality = new List<Municipality>();

            using (StreamReader leer = new StreamReader("Ciudades.txt"))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 3)
                        {
                            Modelo.Departament.ListMunicipality.Add(new Municipality(Convert.ToInt32(datos[0].Trim()), datos[1].Trim(), Convert.ToInt32(datos[2].Trim())));

                        }
                    }
                }
            }

            int Code = 0;
            for (int i = 0; i < Modelo.Departament.Listdepartaments.Count; i++)
            {
                if (EstudentForm.DepartamentCoBox.SelectedItem.ToString() == Modelo.Departament.Listdepartaments[i].Name)
                {
                    Code = Modelo.Departament.Listdepartaments[i].Code;
                }
            }

            EstudentForm.municipalityCoBox.Items.Clear();


            foreach (var item in Modelo.Departament.ListMunicipality)
            {
                if (item.Departament == Code)
                {
                    EstudentForm.municipalityCoBox.Items.Add(item.Name);
                }
            }
        }
    }
}
