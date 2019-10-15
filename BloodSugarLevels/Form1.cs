using System;
using System.Linq;
using System.Windows.Forms;

namespace BloodSugarLevels
{
    public partial class Form1 : Form
    {
        private Patient[] patients = new Patient[3];

        public Form1()
        {
            byte example = 255;
            Console.WriteLine(example);
            Console.WriteLine((sbyte) example);
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Patient patient1 = new Patient();
            patient1.Name = NameTextBox1.Text;
            patient1.BloodSugar[0] = double.Parse(MondayTextBox1.Text);
            patient1.BloodSugar[1] = double.Parse(TuesdayTextBox1.Text);
            patient1.BloodSugar[2] = double.Parse(WednesdayTextBox1.Text);
            patient1.BloodSugar[3] = double.Parse(ThursdayTextBox1.Text);
            patient1.BloodSugar[4] = double.Parse(FridayTextBox1.Text);
            double average1 = patient1.CalculateAverage();
            AverageTextBox1.Text = average1.ToString();
            CommentTextBox1.Text = CalculateComment(average1);

            Patient patient2 = new Patient();
            patient2.Name = NameTextBox2.Text;
            patient2.BloodSugar[0] = double.Parse(MondayTextBox2.Text);
            patient2.BloodSugar[1] = double.Parse(TuesdayTextBox2.Text);
            patient2.BloodSugar[2] = double.Parse(WednesdayTextBox2.Text);
            patient2.BloodSugar[3] = double.Parse(ThursdayTextBox2.Text);
            patient2.BloodSugar[4] = double.Parse(FridayTextBox2.Text);
            double average2 = patient2.CalculateAverage();
            AverageTextBox2.Text = average2.ToString();
            CommentTextBox2.Text = CalculateComment(average2);

            Patient patient3 = new Patient();
            patient3.Name = NameTextBox1.Text;
            patient3.BloodSugar[0] = double.Parse(MondayTextBox3.Text);
            patient3.BloodSugar[1] = double.Parse(TuesdayTextBox3.Text);
            patient3.BloodSugar[2] = double.Parse(WednesdayTextBox3.Text);
            patient3.BloodSugar[3] = double.Parse(ThursdayTextBox3.Text);
            patient3.BloodSugar[4] = double.Parse(FridayTextBox3.Text);
            double average3 = patient3.CalculateAverage();
            AverageTextBox3.Text = average3.ToString();
            CommentTextBox3.Text = CalculateComment(average3);
        }

        private string CalculateComment(double average)
        {
            if (average <= 4)
            {
                return "Increase carbohydrate content";
            }

            if (average > 6)
            {
                return "Reduce carbohydrate content";
            }

            return "Excellent";
        }
    }

    internal class Patient
    {
        public string Name { get; set; }
        public double[] BloodSugar = new double[5];

        public double CalculateAverage() => BloodSugar.Sum() / BloodSugar.Length;
    }

}
