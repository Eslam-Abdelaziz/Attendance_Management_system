
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Attendance_Management_System.Forms
{
    public partial class UserControlTeacherReport : UserControl
    {
        public string UsersFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/users.xml"));
        public string ClassesFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/classes.xml"));
        public string AttendanceFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Data/attendance.xml"));
        private string currentSelectedClassName;
        public UserControlTeacherReport()
        {
            InitializeComponent();
        }

        private void UserControlTeacherReport_Load(object sender, EventArgs e)
        {
            string teacherId = "456"; //MMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWW
            comboBoxClass.Items.Clear();
            List<string> classNames = Classes.Attendance.LoadClassesForTeacher(teacherId, UsersFilePath);
            comboBoxClass.Items.AddRange(classNames.ToArray());
        }
        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = comboBoxClass.SelectedItem.ToString();
            string classId = Classes.Attendance.GetClassIdFromName(selectedClass, ClassesFilePath);
            currentSelectedClassName = selectedClass;
            dataGridViewTeacherReport.Rows.Clear();
            List<Classes.Attendance> students = Classes.Attendance.LoadStudentsForClass(classId, AttendanceFilePath);
            foreach (var student in students)
            {
                dataGridViewTeacherReport.Rows.Add(currentSelectedClassName, student.name, student.date, student.status);
            }
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPrint_Hover(object sender, EventArgs e)
        {

        }

        private void ExportPdf_Button_click(object sender, EventArgs e)
        {
            if (dataGridViewTeacherReport.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "result.pdf";
                bool ErrorMessage = false;
                if(save.ShowDialog()== DialogResult.OK) 
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch(Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("unable to write data in disk" + ex.Message);
                        }
                    }
                    if(!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
            else
            {

            }
        }

        private void ExportExcel_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
