using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSalaDeAula
{
    public partial class frmCalSuper : Form
    {
        public frmCalSuper()
        {
            InitializeComponent();
        }
        decimal vNumAnt, vNumAtual;
        string vOperacao;
        bool vLimpar = false;

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
        }

        private void f_Botoes(object sender, EventArgs e)
        {
            string sNumero = ((Button)sender).Text;
            if (vLimpar)
            {
                lblVisor.Text = "";
                vLimpar = false;
            }
            if (lblVisor.Text == "0" && sNumero != ",") lblVisor.Text = "";
            if (sNumero == "," && !(lblVisor.Text.Contains(",")) || sNumero != ",")
            {
                lblVisor.Text += sNumero;
            }
            lblVisor.Focus();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            vNumAtual = decimal.Parse(lblVisor.Text);
            switch (vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;

                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;

                case "/":
                    try
                    {
                        decimal divisao = (vNumAnt / vNumAtual);
                        lblVisor.Text = divisao.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        lblVisor.Text = "Não é possível dividir por 0";
                    }

                    break;

                case "x":
                    lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    break;

                case "+/-":
                    lblVisor.Text = (vNumAtual * -1).ToString();
                    break;
                default:
                    break;
            }
        }

       // private void Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void FrmCalSuper_KeyDown(object sender, KeyEventArgs e)
        {
            lbl1.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            Button Botao = new Button();

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                Botao.Text = e.KeyCode.ToString().Substring(1);
                f_Botoes(Botao, e);
            }

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                Botao.Text = e.KeyCode.ToString().Substring(6);
                f_Botoes(Botao, e);
            }

            switch (e.KeyCode)
            {
                case Keys.Add:
                    {
                        Botao.Text = "+";
                        f_Op(Botao, e);
                        break;
                    }
                case Keys.Enter:
                    {
                        BtnIgual_Click(sender, e);
                        break;
                    }
                case Keys.Back:
                    {
                        lblVisor.Text =
                            lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
                        if (lblVisor.Text == "") lblVisor.Text = "0";
                        break;
                    }
                case Keys.Divide:
                    {
                        Botao.Text = "/";
                        f_Op(Botao, e);
                        break;
                    }
                case Keys.Multiply:
                    {
                        Botao.Text = "x";
                        f_Op(Botao, e);
                        break;
                    }
                case Keys.Subtract:
                    {
                        Botao.Text = "-";
                        f_Op(Botao, e);
                        break;
                    }
                case Keys.Oemcomma:
                    {
                        Botao.Text = ",";
                        f_Botoes(Botao, e);
                        break;
                    }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text =
                lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text == "") lblVisor.Text = "0";
        }

        private void LblVisor_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalSuper_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInvertSinal_Click(object sender, EventArgs e)
        {
            Button Botao = new Button();
            f_Op(Botao, e);

        }

        private void f_Op(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimpar = true;
            lblVisor.Focus();
        }
    }
}
