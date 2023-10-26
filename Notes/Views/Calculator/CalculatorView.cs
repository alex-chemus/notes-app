using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Notes;

public partial class CalculatorView : Form
{
    public CalculatorView()
    {
        InitializeComponent();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        expressionBox.Text = "";
        resultLabel.Text = "";
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        Expression expresstion = new Expression(expressionBox.Text);
        try
        {
            resultLabel.Text = expresstion.calculate().ToString();
        }
        catch
        {
            MessageBox.Show("Произошла ошибка");
        }
    }
}
