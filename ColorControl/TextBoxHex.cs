using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorControl
{
    public partial class TextBoxHex : TextBox
    {
        const int WM_PASTE = 0x0302;
        public bool IsHex = false;
        public int ColorNumber = 0;
        public TextBoxHex()
        {
            InitializeComponent();
            Text = ColorNumber.ToString();
        }

        public TextBoxHex(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            
            if (IsHex)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && !(e.KeyChar > 64 && e.KeyChar < 71 || e.KeyChar > 96 && e.KeyChar < 103))
                    e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                check_string();
            }
            base.OnKeyPress(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            check_string();
            base.OnLeave(e);
        }

        private void check_string()
        {
            if (Text != "" && Text.Length < 7)
            {
                if (IsHex)
                {
                    int n = 0; //hex
                    for (int i = 0; i < Text.Length; i++)
                    {
                        if (char.IsDigit(Text[i]) || ((char)Text[i] > 64 && (char)Text[i] < 71 || (char)Text[i] > 96 && (char)Text[i] < 103))
                        {
                            n++;
                        }
                    }
                    if (n == Text.Length)
                    {
                        int num = Int32.Parse(Text, System.Globalization.NumberStyles.HexNumber);
                        if (num < 0)
                        {
                            Text = "0";
                            ColorNumber = 0;
                        }
                        else if (num > 255)
                        {
                            Text = "FF";
                            ColorNumber = 255;
                        }
                        else
                            ColorNumber = num;
                    }
                }
                else
                {
                    int k = 0; //dec
                    for (int i = 0; i < Text.Length; i++)
                    {
                        if (char.IsDigit(Text[i]))
                            k++;
                    }
                    if (k == Text.Length)
                    {
                        int num = Int32.Parse(Text);
                        if (num < 0)
                        {
                            Text = "0";
                            ColorNumber = 0;
                        }
                        else if (num > 255)
                        {
                            Text = "255";
                            ColorNumber = 255;
                        }
                        else
                            ColorNumber = num;
                    }
                }
            }
            if (Text.Length >= 7) { Text = "0"; ColorNumber = 0; }
            SelectionStart = Text.Length;
        }

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_PASTE)
        //    {
        //        string buffer = Clipboard.GetText();
        //        bool is_hex_num = false;
        //        bool is_number = false;
        //        int n = 0; //hex
        //        int k = 0; //dec
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
        //            if ( is_hex_num && is_number)
        //            {
        //                int num = Int32.Parse(buffer, System.Globalization.NumberStyles.HexNumber);
        //                if (num < 0)
        //                {
        //                    Text = "0";
        //                    ColorNumber = 0;
        //                }
        //                else if (num > 255)
        //                {
        //                    Text = "FF";
        //                    ColorNumber = 255;
        //                }
        //                else
        //                    ColorNumber = num;
        //            }
        //            else if (is_number)
        //            {
        //                int num = Int32.Parse(buffer);
        //                if (num < 0)
        //                {
        //                    Text = "0";
        //                    ColorNumber = 0;
        //                }
        //                else if (num > 255)
        //                {
        //                    Text = "255";
        //                    ColorNumber = 255;
        //                }
        //                else
        //                    ColorNumber = num;
        //            }
        //        }
        //    }
        //}
    }
}
