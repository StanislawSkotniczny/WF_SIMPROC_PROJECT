using Microsoft.Win32;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public char[] allowedChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        public Dictionary<string, string> register = new Dictionary<string, string>();
        public Form1()
        {
            register.Add("AL", " ");
            register.Add("AH", " ");
            register.Add("BL", " ");
            register.Add("BH", " ");
            register.Add("CL", " ");
            register.Add("CH", " ");
            register.Add("DL", " ");
            register.Add("DH", " ");

            InitializeComponent();
        }

        private void AL_TextChanged(object sender, EventArgs e)
        {

            if (AL.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == AL.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == AL.Text[1])
                            {
                                register["AL"] = AL.Text;
                            }

                        }
                    }
                }
            }
        }

        private void AH_TextChanged(object sender, EventArgs e)
        {
            if (AH.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == AH.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == AH.Text[1])
                            {
                                register["AH"] = AH.Text;
                            }

                        }
                    }
                }
            }
        }

        private void BL_TextChanged(object sender, EventArgs e)
        {
            if (BL.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == BL.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == BL.Text[1])
                            {
                                register["BL"] = BL.Text;
                            }

                        }
                    }
                }
            }
        }

        private void BH_TextChanged(object sender, EventArgs e)
        {
            if (BH.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == BH.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == BH.Text[1])
                            {
                                register["BH"] = BH.Text;
                            }

                        }
                    }
                }
            }
        }

        private void CL_TextChanged(object sender, EventArgs e)
        {
            if (CL.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == CL.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == CL.Text[1])
                            {
                                register["CL"] = CL.Text;
                            }

                        }
                    }
                }
            }
        }

        private void CH_TextChanged(object sender, EventArgs e)
        {
            if (CH.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == CH.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == CH.Text[1])
                            {
                                register["CH"] = CH.Text;
                            }

                        }
                    }
                }
            }
        }

        private void DL_TextChanged(object sender, EventArgs e)
        {
            if (DL.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == DL.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == DL.Text[1])
                            {
                                register["DL"] = DL.Text;
                            }

                        }
                    }
                }
            }
        }

        private void DH_TextChanged(object sender, EventArgs e)
        {
            if (DH.Text.Length == 2)
            {
                for (int i = 0; i < allowedChars.Length; i++)
                {
                    if (allowedChars[i] == DH.Text[0])
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (allowedChars[j] == DH.Text[1])
                            {
                                register["DH"] = DH.Text;
                            }

                        }
                    }
                }
            }
        }

       

        private void Run_Click(object sender, EventArgs e)
        {
            string Reg2 = "";
            string Reg1 = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string combox1 = comboBox3.Items[comboBox3.SelectedIndex].ToString();
            if ((combox1 != "NOT") && (combox1 != "INC") && (combox1 != "DEC"))
            {
                Reg2 = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            }
            if ( combox1== "MOV")
            {
                MOV(Reg1, Reg2);                
            }
            else if (combox1 == "XCHG")
            {
                XCHG(Reg1, Reg2);
            }
            else if (combox1 == "NOT")
            {
                NOT(Reg1);
            }
            else if (combox1 == "INC")
            {
                INC(Reg1);
            }
            else if (combox1 == "DEC")
            {
                DEC(Reg1);
            }
            else if (combox1 == "AND")
            {
                AND(Reg1 , Reg2);
            }
            else if (combox1 == "OR")
            {
                OR(Reg1, Reg2);
            }
            else if (combox1 == "XOR")
            {
                XOR(Reg1, Reg2);
            }

            AfterRunClick();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MOV(string reg1 , string reg2)
        {
            register[reg2] = register[reg1];  
        }

        private void XCHG(string reg1 , string reg2)
        {
            string x = register[reg2];
            register[reg2] = register[reg1];
            register[reg1] = x;
        }
        private void NOT(string reg1)
        {
            string y = "";
         
            string bin1 = binary(register[reg1]);
            if (bin1.Length < 8)
            {
                bin1 = fullFillDigits(bin1, 8);
            }

            for(int i = 0; i < bin1.Length; i++)
            {
                if (bin1[i]== '1')
                {
                    y += '0';
                }
                else
                {
                    y += '1';
                }
            }
            register[reg1] = hex(y);   
        }
        private void INC(string reg1)
        {
            if (register[reg1] == "FF") return;
            int intVal = int.Parse(register[reg1], System.Globalization.NumberStyles.HexNumber);
            intVal++;
            register[reg1] = int1(intVal);
        }
        private void DEC(string reg1)
        {
            if (register[reg1] == "00") return;
            int intVal = int.Parse(register[reg1], System.Globalization.NumberStyles.HexNumber);
            intVal--;
            register[reg1] = int1(intVal);
        }
        private void AND(string reg1 , string reg2)
        {
            string z = "";
            string bin1 = binary(register[reg1]);
            string bin2 = binary(register[reg2]);
            if (bin1.Length < 8)
            {
                bin1 = fullFillDigits(bin1, 8);
            }
            if (bin2.Length < 8)
            {
                bin2 = fullFillDigits(bin2, 8);
            }
            for (int i = 0; i < bin1.Length ; i++ )
                {
                if (bin1[i] =='1' && bin2[i]=='1')
                {
                    z += "1";
                }
                else
                {
                    z += "0";
                }
            }
           register[reg1] = hex(z);
        }
        private void OR(string reg1, string reg2)
        {
            string z = "";
            string bin1 = binary(register[reg1]);
            string bin2 = binary(register[reg2]);
            if (bin1.Length < 8)
            {
                bin1 = fullFillDigits(bin1, 8);
            }
            if (bin2.Length < 8)
            {
                bin2 = fullFillDigits(bin2, 8);
            }
            for (int i = 0; i < bin1.Length; i++)
            {
                if (bin1[i] == '0' && bin2[i] == '0')
                {
                    z += "0";
                }
                else 
                {
                    z += "1";
                }
            }
            register[reg1] = hex(z);
        }
        private void XOR(string reg1, string reg2)
        {
            string z = "";
            string bin1 = binary(register[reg1]);
            string bin2 = binary(register[reg2]);
            if (bin1.Length < 8)
            {
                bin1 = fullFillDigits(bin1, 8);
            }
            if (bin2.Length < 8)
            {
                bin2 = fullFillDigits(bin2, 8);
            }
            for (int i = 0; i < bin1.Length; i++)
            {
                if ((bin1[i] == '0' && bin2[i] == '0') || (bin1[i] == '1' && bin2[i] == '1'))
                {
                    z += "0";
                }
                else
                {
                    z += "1";
                }
            }
            register[reg1] = hex(z);
        }
        private void AfterRunClick()
        {
            AL.Text = register["AL"];
            AH.Text = register["AH"];
            BL.Text = register["BL"];
            BH.Text = register["BH"];
            CL.Text = register["CL"];
            CH.Text = register["CH"];
            DL.Text = register["DL"];
            DH.Text = register["DH"];
        }
        private string binary(string hexval)
        {
            string bin = "";
            bin= Convert.ToString(Convert.ToInt32(hexval, 16), 2);
            return bin;
        }
        private string hex(string bin)
        {
            string hex1 = "";
            hex1 = Convert.ToInt32(bin, 2).ToString("X2");
            return hex1;
        }
        private string int1(int intval)
        {
            string hexval = "";
            hexval = intval.ToString("X2");
            return hexval;
        }
        private string fullFillDigits(string toFullFill, int fullFillToLength)
        {
            string fullFilledRegister = "";
            string temp = toFullFill;
            int length = fullFillToLength - toFullFill.Length;
            for (int i = 0; i < length; i++)
            {
                fullFilledRegister += "0";
            }
            fullFilledRegister += temp;
            return fullFilledRegister;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void REG1_Click(object sender, EventArgs e)
        {

        }
    }   
}