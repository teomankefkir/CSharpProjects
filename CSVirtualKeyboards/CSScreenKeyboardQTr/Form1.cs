using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSScreenKeyboardQTr
{
    public partial class frmScreenKeyboardQTr : Form
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

        public frmScreenKeyboardQTr()
        {
            InitializeComponent();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
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
                SendKeys.Send("ı");
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

        private void btnSoftG_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Ğ");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("ğ");
            }
        }

        private void btnUwithCDot_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Ü");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("ü");
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

        private void btnSwithComma_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Ş");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("ş");
            }
        }

        private void btnIwithDot_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("İ");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send(",");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void btnGandL_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("<");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(">");
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

        private void btnOwithDot_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Ö");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("ö");
            }
        }

        private void btnCwithComma_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("Ç");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("ç");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send(".");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(":");
            }
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void btnEandSign_Click(object sender, EventArgs e)
        {
            if (checkBoxCapsLock.Checked || checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("'");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("é");
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
                SendKeys.Send("^");
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
                SendKeys.Send("&");
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
                SendKeys.Send("/");
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
                SendKeys.Send("(");
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
                SendKeys.Send(")");
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
                SendKeys.Send("=");
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
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
            {
                SendKeys.Send("_");
                checkBoxShiftL.Checked = false;
                checkBoxShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send("-");
            }
        }

        private void btnZeroNum_Click(object sender, EventArgs e)
        {

        }

        private void btnOneNum_Click(object sender, EventArgs e)
        {

        }

        private void btnTwoNum_Click(object sender, EventArgs e)
        {

        }

        private void btnThreeNum_Click(object sender, EventArgs e)
        {

        }

        private void btnFourNum_Click(object sender, EventArgs e)
        {

        }

        private void btnFiveNum_Click(object sender, EventArgs e)
        {

        }

        private void btnSixNum_Click(object sender, EventArgs e)
        {

        }

        private void btnSevenNum_Click(object sender, EventArgs e)
        {

        }

        private void btnEightNum_Click(object sender, EventArgs e)
        {

        }

        private void btnNineNum_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisionNum_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicationNum_Click(object sender, EventArgs e)
        {

        }

        private void btnMinusNum_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusNum_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
        }

        private void btnEnterNum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnPageUp_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnPageDown_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnScrollLock_Click(object sender, EventArgs e)
        {

        }

        private void btnPauseBreak_Click(object sender, EventArgs e)
        {

        }

        private void btnFunction_Click(object sender, EventArgs e)
        {

        }

        private void btnEscape_Click(object sender, EventArgs e)
        {

        }

        private void btnFOne_Click(object sender, EventArgs e)
        {

        }

        private void btnFTwo_Click(object sender, EventArgs e)
        {

        }

        private void btnF3_Click(object sender, EventArgs e)
        {

        }

        private void btnFFour_Click(object sender, EventArgs e)
        {

        }

        private void btnFFive_Click(object sender, EventArgs e)
        {

        }

        private void btnFSix_Click(object sender, EventArgs e)
        {

        }

        private void btnFSeven_Click(object sender, EventArgs e)
        {

        }

        private void btnFEight_Click(object sender, EventArgs e)
        {

        }

        private void btnFNine_Click(object sender, EventArgs e)
        {

        }

        private void btnFTen_Click(object sender, EventArgs e)
        {

        }

        private void btnFEleven_Click(object sender, EventArgs e)
        {

        }

        private void btnTwelve_Click(object sender, EventArgs e)
        {

        }

        private void btnQuestionMark_Click(object sender, EventArgs e)
        {
            if (checkBoxShiftL.Checked || checkBoxShiftR.Checked)
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
    }
}