using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSScreenKeyboardQEng
{
    public partial class frmScreenKeyboardQEng : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        public frmScreenKeyboardQEng()
        {
            InitializeComponent();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if(checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Q");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("W");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("E");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("R");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("T");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Y");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("U");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("I");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("O");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("P");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("A");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("S");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("D");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("F");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("G");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("H");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("J");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("K");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("L");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Z");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("X");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("C");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("V");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("B");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("N");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("M");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }
        //btnCurlyBracesL
        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{{}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }
        //btnCurlyBracesR
        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{}}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void btnTilde_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{~}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{'}");
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("!");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("'");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("£");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("$");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("%");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{&}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("*");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("(");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send(")");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("-");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("_");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{+}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }
        //backspace button here
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            /*if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = txtDisplay.Text = "0";
            }*/
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
        }

        private void btnColons_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send(":");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{@}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{'}");
            }
        }

        private void btnTilteB_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("{~}");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("#");
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("<");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send(">");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void btnQuestionMark_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("?");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("/");
            }
        }

        private void btnNameless_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("|");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("\\");
            }
        }

        private void btnZeroNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void btnOneNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void btnTwoNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void btnThreeNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void btnFourNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void btnFiveNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void btnSixNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void btnSevenNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void btnEightNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void btnNineNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void btnDivisionNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("/");
        }

        private void btnMultiplicationNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("*");
        }

        private void btnMinusNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("-");
        }

        private void btnPlusNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{+}");
        }

        private void btnEnterNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send(".");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("{Delete}");
            }
        }

        private void btnFOne_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void btnFTwo_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void btnFFour_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void btnFFive_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void btnFSix_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void btnFSeven_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void btnFEight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void btnFNine_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void btnFTen_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void btnFEleven_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void btnTwelve_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }
        //start button here
        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnPrintScreen_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }
        
        private void btnScrollLock_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SCROLLLOCK}");
        }
        
        private void btnPageUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }
        
        private void btnPageDown_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }
        //pause break button here
        private void btnPauseBreak_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PAUBRK}");
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }
        //function button here
        private void btnFunction_Click(object sender, EventArgs e)
        {

        }
        //up arrow button here
        private void btnUpArrow_Click(object sender, EventArgs e)
        {

        }
        //left arrow button here
        private void btnLeftArrow_Click(object sender, EventArgs e)
        {

        }
        //down arrow button here
        private void btnDownArrow_Click(object sender, EventArgs e)
        {

        }
        //right arrow button here
        private void btnRightArrow_Click(object sender, EventArgs e)
        {

        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{INS}");
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Home}");
        }
        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{End}");
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }
        
        private void btnTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }
    }
}