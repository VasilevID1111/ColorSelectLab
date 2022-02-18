using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_256HEX
{
    public partial class Text_box_hex : TextBox
    {

        private bool IsHex = false;
        private int ColorNumber = 0;

        public Text_box_hex()
        {
            InitializeComponent();
            //Text = ColorNumber.ToString();
        }

        public Text_box_hex(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (IsHex) {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && !(e.KeyChar>64 && e.KeyChar <71 || e.KeyChar > 96 && e.KeyChar < 103))
                    e.Handled = true;
            } else {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text!="")
            {
                if (IsHex)
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
                }
                else
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
                }
                SelectionStart = Text.Length;
            }
            base.OnTextChanged(e);
        }

    }
}
