using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorControl
{
    public partial class ColorSelect : UserControl
    {
        const int WM_PASTE = 0x0302;
        public ColorSelect()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Hex.Checked)
            {
                red.IsHex = true;
                green.IsHex = true;
                blue.IsHex = true;
                ChangeDecToHex();
            }
            if (Dec.Checked)
            {
                red.IsHex = false;
                green.IsHex = false;
                blue.IsHex = false;
                ChangeHexToDec();
            }
        }

        private void ChangeHexToDec()
        {
            red.Text = red.ColorNumber.ToString();
            green.Text = green.ColorNumber.ToString();
            blue.Text = blue.ColorNumber.ToString();
        }

        private void ChangeDecToHex()
        {
            red.Text = Convert.ToString(red.ColorNumber, 16).ToUpper();
            green.Text = Convert.ToString(green.ColorNumber, 16).ToUpper();
            blue.Text = Convert.ToString(blue.ColorNumber, 16).ToUpper();
        }

        private void sender_Leave(object sender, EventArgs e)
        {
            Color_update();
        }
        private void sender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Color_update();
        }
        private void Color_update()
        {
            colorRectangle1.Color = Color.FromArgb(red.ColorNumber, green.ColorNumber, blue.ColorNumber);
        }

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg.ToString() == "770")
        //    {
        //        MessageBox.Show("11");
        //    }
        //    if (m.Msg == WM_PASTE)
        //    {
        //        Control ff = this.ActiveControl;
        //        IContainerControl pp;
        //        try
        //        {
        //            while (true)//здесь мы идем по всем контейнерам активных контрол
        //            {
        //                pp = (IContainerControl)ff;//Здесь мы вывалимся, когда активный элемент не содержит контролов, то есть он последний активный
        //                if (pp.ActiveControl == null) break;//если дальше нет активных контролов - выходим
        //                ff = pp.ActiveControl;
        //            }
        //        }
        //        catch (Exception ex)//здесь мы вывалимся с цикла, когда найдем нужный последний контрол
        //        {
        //        }
        //        TextBoxHex editBox = new TextBoxHex();//не помню как там тип текстбокса пишется)
        //        if (ff != null && ff.GetType() == editBox.GetType())//проверяем чтобы был TextBoxHex
        //        {
        //            editBox = (TextBoxHex)ff;
        //        }

        //        bool is_hex_num = false;
        //        bool is_number = false;
        //        int n = 0; //hex
        //        int k = 0; //dec
        //        string buffer = Clipboard.GetText();
        //        for (int i = 0; i < buffer.Length; i++)
        //        {
        //            if (char.IsDigit(buffer[i]))
        //            {
        //                k++;
        //                n++;
        //            }
        //            if ((char)buffer[i] > 64 && (char)buffer[i] < 71 || (char)buffer[i] > 96 && (char)buffer[i] < 103)
        //            {
        //                n++;
        //            }
        //        }
        //        if (k == buffer.Length)
        //        {
        //            is_number = true;
        //            is_hex_num = false;
        //        }
        //        if (n == buffer.Length)
        //        {
        //            is_number = true;
        //            is_hex_num = true;
        //        }

        //        if (buffer != "")
        //        {
        //            if (Hex.Checked && is_hex_num && is_number)
        //            {
        //                int num = Int32.Parse(buffer, System.Globalization.NumberStyles.HexNumber);
        //                if (num < 0)
        //                {
        //                    editBox.Text = "0";
        //                    editBox.ColorNumber = 0;
        //                }
        //                else if (num > 255)
        //                {
        //                    editBox.Text = "FF";
        //                    editBox.ColorNumber = 255;
        //                }
        //                else
        //                    editBox.ColorNumber = num;
        //            }
        //            else if (Dec.Checked && is_number)
        //            {
        //                int num = Int32.Parse(buffer);
        //                if (num < 0)
        //                {
        //                    editBox.Text = "0";
        //                    editBox.ColorNumber = 0;
        //                }
        //                else if (num > 255)
        //                {
        //                    editBox.Text = "255";
        //                    editBox.ColorNumber = 255;
        //                }
        //                else
        //                    editBox.ColorNumber = num;
        //            }
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
    }
}
