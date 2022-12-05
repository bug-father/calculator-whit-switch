using System.Data;

namespace calculator2
{
    public partial class Form1 : Form
    {
        int input1;
        public Form1()
        {
            InitializeComponent();
        }
        private void txt_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public static string DoIt(object sender)
        {
            Form1 man = new Form1();
            string oprandType = "";
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "man.btn_Radical":
                    oprandType = "ssss";
                    break;
            }
            return oprandType;
        }
        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            Button btnClick = sender as Button;
            if (sender == btn_ClearAll)
            {
                txt_Input.Text = string.Empty;
               
                lbl_oprand.Text = string.Empty;
                lbl_Result.Text = string.Empty;
            }
            if (txt_Input.Text != string.Empty)
            {
                input1 = int.Parse(txt_Input.Text);
                switch (btnClick.Name)
                {
                    case "btn_Radical":
                        lbl_oprand.Text = "√" + txt_Input.Text;
                        lbl_Result.Text = oprand.radical(input1).ToString();
                        lbl_History.Text += lbl_oprand.Text + " = " + oprand.radical(input1).ToString() + "\r\n";
                        txt_Input.Text = string.Empty;
                        break;
                    case "btn_Log":
                        lbl_oprand.Text = $"log({txt_Input.Text})";
                        lbl_Result.Text = oprand.log(input1).ToString();
                        lbl_History.Text += lbl_oprand.Text + "=" + lbl_Result.Text + "\r\n";
                        txt_Input.Text = string.Empty;
                        break;
                    case "btn_power":
                        lbl_oprand.Text = input1 + " ^";
                        txt_Input.Text = string.Empty;
                        
                        break;
                    case "btn_sum":
                        lbl_oprand.Text = txt_Input.Text + " + ";
                        txt_Input.Text = string.Empty;
                        break;
                    case "btn_minus":
                        lbl_oprand.Text = txt_Input.Text + " - ";
                        txt_Input.Text = string.Empty;
                        break;
                    case "btn_multi":
                        lbl_oprand.Text = txt_Input.Text + " X ";
                        txt_Input.Text = string.Empty;
                        break;
                    case "btn_devide":
                        lbl_oprand.Text = txt_Input.Text + " ÷ ";
                        txt_Input.Text = string.Empty;
                        break;
                }


            }
            else
            {

            }



        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if (txt_Input.Text != string.Empty)
            {
                int input2 = int.Parse(txt_Input.Text);

                string oprandText = lbl_oprand.Text;
                switch (oprandText)
                {
                    case string sum when sum.Contains("+"):
                        lbl_oprand.Text += input2;
                        lbl_Result.Text = oprand.sum(input1, input2).ToString();
                        lbl_History.Text += lbl_oprand.Text + " = " + lbl_Result.Text + "\r\n";
                        break;
                       case string minus when minus.Contains("-"):
                        lbl_oprand.Text += input2;
                        lbl_Result.Text=oprand.minus(input1, input2).ToString();
                        lbl_History.Text += lbl_oprand.Text + " = " + lbl_Result.Text + "\r\n";
                        break;
                        case string multy when multy.Contains("X"):
                        lbl_oprand.Text += input2;
                        lbl_Result.Text=oprand.multi(input1, input2).ToString();
                        lbl_History.Text += lbl_oprand.Text + " = " + lbl_Result.Text +"\r\n";
                        break;
                        case string devide when devide.Contains("÷"):
                        lbl_oprand.Text += input2;
                        lbl_Result.Text=oprand.devide(input1, input2).ToString();
                        lbl_History.Text += lbl_oprand.Text + " = " + lbl_Result.Text + "\r\n";
                        break;
                    case string power when power.Contains("^"):
                        lbl_oprand.Text += input2;
                        lbl_Result.Text=oprand.Power(input1, input2).ToString();
                        lbl_History.Text += lbl_oprand.Text + " = " + lbl_Result.Text + "\r\n";
                        break;


                }

            }
            else
            {
                MessageBox.Show("لطفا عدد را وارد کنید");
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btn=sender as Button;
            switch (btn.Name)
            {
                case "btn_0":
                    txt_Input.Text += "0";
                    break;
                case "btn_1":
                    txt_Input.Text += "1";
                    break;
                case "btn_2":
                    txt_Input.Text += "2";
                    break;
                case "btn_3":
                    txt_Input.Text += "3";
                    break;
                case "btn_4":
                    txt_Input.Text += "4";
                    break;
                case "btn_5":
                    txt_Input.Text += "5";
                    break;
                case "btn_6":
                    txt_Input.Text += "6";
                    break;
                case "btn_7":
                    txt_Input.Text += "7";
                    break;
                case "btn_8":
                    txt_Input.Text += "8";
                    break;
                case "btn_9":
                    txt_Input.Text += "9";
                    break;
                case "btn_Dot":
                    txt_Input.Text += ".";
                    break;
            }
        }
    }
}