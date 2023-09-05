using System.IO.Pipes;

namespace Digikala_Sematech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p1 = new Product();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < comboBox1.Items.Count; i++) {
                comboBox1.DataSource = Product.color.red;
            //}
            
        }


    }
}