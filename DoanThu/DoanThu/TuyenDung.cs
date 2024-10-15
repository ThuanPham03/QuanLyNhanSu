namespace DoanThu
{
    public partial class TuyenDung : Form
    {
        public TuyenDung()
        {
            InitializeComponent();
        }
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime PostedDate { get; set; }
            public DateTime Deadline { get; set; }
            public List<Candidate> Candidates { get; set; } = new List<Candidate>();
        public class Candidate
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime AppliedDate { get; set; }
            public bool IsInterviewed { get; set; }
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Luong());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
