namespace ColorControl
{
    partial class ColorSelect
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dec = new System.Windows.Forms.RadioButton();
            this.Hex = new System.Windows.Forms.RadioButton();
            this.colorRectangle1 = new ColorControl.ColorRectangle(this.components);
            this.blue = new ColorControl.TextBoxHex(this.components);
            this.green = new ColorControl.TextBoxHex(this.components);
            this.red = new ColorControl.TextBoxHex(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Синий";
            // 
            // Dec
            // 
            this.Dec.AutoSize = true;
            this.Dec.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dec.Location = new System.Drawing.Point(38, 150);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(64, 28);
            this.Dec.TabIndex = 1;
            this.Dec.TabStop = true;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.Dec.Leave += new System.EventHandler(this.sender_Leave);
            // 
            // Hex
            // 
            this.Hex.AutoSize = true;
            this.Hex.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hex.Location = new System.Drawing.Point(126, 150);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(64, 28);
            this.Hex.TabIndex = 1;
            this.Hex.TabStop = true;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = true;
            this.Hex.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            this.Hex.Leave += new System.EventHandler(this.sender_Leave);
            // 
            // colorRectangle1
            // 
            this.colorRectangle1.Color = System.Drawing.Color.Black;
            this.colorRectangle1.Location = new System.Drawing.Point(212, 8);
            this.colorRectangle1.Name = "colorRectangle1";
            this.colorRectangle1.Size = new System.Drawing.Size(168, 170);
            this.colorRectangle1.TabIndex = 3;
            this.colorRectangle1.Text = "colorRectangle1";
            // 
            // blue
            // 
            this.blue.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blue.Location = new System.Drawing.Point(106, 105);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(100, 32);
            this.blue.TabIndex = 2;
            this.blue.Text = "0";
            this.blue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sender_KeyPress);
            this.blue.Leave += new System.EventHandler(this.sender_Leave);
            // 
            // green
            // 
            this.green.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.green.Location = new System.Drawing.Point(106, 56);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(100, 32);
            this.green.TabIndex = 2;
            this.green.Text = "0";
            this.green.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sender_KeyPress);
            this.green.Leave += new System.EventHandler(this.sender_Leave);
            // 
            // red
            // 
            this.red.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.red.Location = new System.Drawing.Point(106, 8);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(100, 32);
            this.red.TabIndex = 2;
            this.red.Text = "0";
            this.red.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sender_KeyPress);
            this.red.Leave += new System.EventHandler(this.sender_Leave);
            // 
            // ColorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorRectangle1);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorSelect";
            this.Size = new System.Drawing.Size(396, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Dec;
        private System.Windows.Forms.RadioButton Hex;
        private TextBoxHex red;
        private TextBoxHex green;
        private TextBoxHex blue;
        private ColorRectangle colorRectangle1;
    }
}
