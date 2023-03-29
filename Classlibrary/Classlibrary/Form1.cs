namespace Classlibrary
{
    public partial class Form1 : Form
    {
        StudentController controller = new StudentController();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_student_id = this.tbID.Text;
            this.tbListofStudent.Text = "";
            controller.addStudent2List(input_student_id, input_name);
            this.tbListofStudent.Text = controller.displayData(tbListofStudent.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.saveFile(this.tbListofStudent.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.openFile();
            controller.displayData(tbListofStudent.Text);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}