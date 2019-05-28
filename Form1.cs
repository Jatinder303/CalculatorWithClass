using System;
using System.Windows.Forms;

namespace CalculatorWithClass
{
    public partial class Calculator : Form
    {

        Calulator Calcul = new Calulator(); // declare object of the class
        public Calculator()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Calcul.Add(Txt_FirstNumber.Text, Txt_SecondNumber.Text); // Call Add funtion from class
        }

        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Calcul.Sub(Txt_FirstNumber.Text, Txt_SecondNumber.Text); // Call Sub funtion from class
        }

        private void Btn_Multi_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Calcul.Multi(Txt_FirstNumber.Text, Txt_SecondNumber.Text); // Call Multi funtion from class
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Calcul.Div(Txt_FirstNumber.Text, Txt_SecondNumber.Text); // Call Div funtion from class
        }

        private void Btn_Clear_Click(object sender, EventArgs e) // Clear the controls of the form and reset the form
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }
    }
}
