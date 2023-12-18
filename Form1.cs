using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagation_JohnCadungog
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int numberOfClicks = 0;
        int totalIterations = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 1, 1);
            totalIterations = 0;
            numberOfClicks = 0;
            labelClicked.Text = numberOfClicks.ToString();
            labelTotal.Text = totalIterations.ToString();
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            numberOfClicks++;
            labelClicked.Text = numberOfClicks.ToString();
            totalIterations = (numberOfClicks * 1600);
            labelTotal.Text = totalIterations.ToString();
             

            for (int i = 0; i < 1600; i++)
            {
                
                // Row 1
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 2
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 3
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 4
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 5
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 6
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 7
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 8
                nn.setInputs(0, 0.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 9
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 10
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 11
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 12
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 0.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 13
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 14
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 0.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 15
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 0.0); // D
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // Row 16
                nn.setInputs(0, 1.0); // A
                nn.setInputs(1, 1.0); // B
                nn.setInputs(2, 1.0); // C
                nn.setInputs(3, 1.0); // D
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
         

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
           
            nn.setInputs(0, Convert.ToDouble(textBox1.Text)); 
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (nn != null)
            {
                saveFileDialog1.DefaultExt = "txt"; 
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; 

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        nn.saveWeights(saveFileDialog1.FileName);
                        MessageBox.Show("Weights saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving weights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
    }
}
