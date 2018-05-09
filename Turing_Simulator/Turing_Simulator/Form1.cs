using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turing_Machines;

namespace Turing_Simulator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            string selectedMachine = comboBox1.GetItemText(comboBox1.SelectedItem);
            // fill the data grid view 
            char[] input = txtInput.Text.ToCharArray();
            int position;
            int count; 
            for (int i = 0; i < input.Length; i++)
            {
                DGVTuring[i, 0].Value = input[i]; 
            }
            switch (selectedMachine)
            {
                case "Palíndromo":
                    TuringMachinePalin palindrome = new TuringMachinePalin();
                    position = 0;
                    count = 0;
                    lblStepsCount.Text = count.ToString(); 
                    DGVTuring.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    if (palindrome.evaluateInput(input))
                    {
                        for (int i = 0; i < palindrome.headMovements.Count; i++)
                        {
                            if (palindrome.headMovements[i] == 'R')
                            { 
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position++;
                                DGVTuring[i, 0].Value = palindrome.tape[i];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position--;
                                if(i < palindrome.tape.Count)
                                    DGVTuring[i, 0].Value = palindrome.tape[i];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            lblState.Text = palindrome.history[i];
                            count++;
                            lblStepsCount.Text = count.ToString(); 
                            System.Threading.Thread.Sleep(1000); 
                            this.Refresh(); 
                        }
                        lblState.Text = "Aceptado"; 
                    }
                    break;
                case "Multiplicación Unario":
                    TuringMachineMult mult = new TuringMachineMult();
                    position = 0;
                    count = 0;
                    lblStepsCount.Text = count.ToString();
                    DGVTuring.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    if (mult.evaluateInput(input))
                    {
                        for (int i = 0; i < mult.headMovements.Count; i++)
                        {
                            if (mult.headMovements[i] == 'R')
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position++;
                                DGVTuring[i, 0].Value = mult.tape[position];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position--;
                                //if (i < mult.tape.Count)
                                    DGVTuring[i, 0].Value = mult.tape[position];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            lblState.Text = mult.history[i];
                            count++;
                            lblStepsCount.Text = count.ToString();
                            System.Threading.Thread.Sleep(1000);
                            this.Refresh();
                        }
                        lblState.Text = "Aceptado";
                    }
                    break;
                case "Suma Unario":
                    TuringMachineSum sum = new TuringMachineSum(); 
                    position = 0;
                    count = 0;
                    lblStepsCount.Text = count.ToString();
                    DGVTuring.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    if (sum.evaluateInput(input))
                    {
                        for (int i = 0; i < sum.headMovements.Count; i++)
                        {
                            if (sum.headMovements[i] == 'R')
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position++;
                                DGVTuring[i, 0].Value = sum.tape[position];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position--;
                                DGVTuring[i, 0].Value = sum.tape[position];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            lblState.Text = sum.history[i];
                            count++;
                            lblStepsCount.Text = count.ToString();
                            System.Threading.Thread.Sleep(1000);
                            this.Refresh();
                        }
                    }
                    lblState.Text = "Aceptado";
                        break;
                case "Resta Unario":
                    TuringMachineSub sub = new TuringMachineSub();
                    position = 0;
                    count = 0;
                    lblStepsCount.Text = count.ToString();
                    DGVTuring.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    if (sub.evaluateInput(input))
                    {
                        for (int i = 0; i < sub.headMovements.Count; i++)
                        {
                            if (sub.headMovements[i] == 'R')
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position++;
                                DGVTuring[i, 0].Value = sub.tape[position];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.White;
                                position--;
                                //if (i < mult.tape.Count)
                                DGVTuring[i, 0].Value = sub.tape[position];
                                DGVTuring.Rows[0].Cells[position].Style.BackColor = Color.Red;
                            }
                            lblState.Text = sub.history[i];
                            count++;
                            lblStepsCount.Text = count.ToString();
                            System.Threading.Thread.Sleep(1000);
                            this.Refresh();
                        }
                        lblState.Text = "Aceptado";
                        

                    }
                    break; 
            }
        }
    }
}
