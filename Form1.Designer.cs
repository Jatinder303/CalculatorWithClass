namespace CalculatorWithClass
{
    partial class Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_FirstNumber = new System.Windows.Forms.Label();
            this.Lbl_SecondNumber = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.Txt_FirstNumber = new System.Windows.Forms.TextBox();
            this.Txt_SecondNumber = new System.Windows.Forms.TextBox();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Sub = new System.Windows.Forms.Button();
            this.Btn_Multi = new System.Windows.Forms.Button();
            this.Btn_Div = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FirstNumber
            // 
            this.lbl_FirstNumber.AutoSize = true;
            this.lbl_FirstNumber.Location = new System.Drawing.Point(141, 64);
            this.lbl_FirstNumber.Name = "lbl_FirstNumber";
            this.lbl_FirstNumber.Size = new System.Drawing.Size(66, 13);
            this.lbl_FirstNumber.TabIndex = 0;
            this.lbl_FirstNumber.Text = "First Number";
            // 
            // Lbl_SecondNumber
            // 
            this.Lbl_SecondNumber.AutoSize = true;
            this.Lbl_SecondNumber.Location = new System.Drawing.Point(141, 111);
            this.Lbl_SecondNumber.Name = "Lbl_SecondNumber";
            this.Lbl_SecondNumber.Size = new System.Drawing.Size(84, 13);
            this.Lbl_SecondNumber.TabIndex = 1;
            this.Lbl_SecondNumber.Text = "Second Number";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(144, 155);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result.TabIndex = 2;
            this.lbl_Result.Text = "Result";
            // 
            // Txt_FirstNumber
            // 
            this.Txt_FirstNumber.Location = new System.Drawing.Point(348, 64);
            this.Txt_FirstNumber.Name = "Txt_FirstNumber";
            this.Txt_FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.Txt_FirstNumber.TabIndex = 3;
            // 
            // Txt_SecondNumber
            // 
            this.Txt_SecondNumber.Location = new System.Drawing.Point(348, 111);
            this.Txt_SecondNumber.Name = "Txt_SecondNumber";
            this.Txt_SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.Txt_SecondNumber.TabIndex = 4;
            // 
            // Txt_Result
            // 
            this.Txt_Result.Location = new System.Drawing.Point(348, 155);
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Size = new System.Drawing.Size(100, 20);
            this.Txt_Result.TabIndex = 5;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(59, 227);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Sub
            // 
            this.Btn_Sub.Location = new System.Drawing.Point(170, 227);
            this.Btn_Sub.Name = "Btn_Sub";
            this.Btn_Sub.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sub.TabIndex = 7;
            this.Btn_Sub.Text = "Sub";
            this.Btn_Sub.UseVisualStyleBackColor = true;
            this.Btn_Sub.Click += new System.EventHandler(this.Btn_Sub_Click);
            // 
            // Btn_Multi
            // 
            this.Btn_Multi.Location = new System.Drawing.Point(289, 227);
            this.Btn_Multi.Name = "Btn_Multi";
            this.Btn_Multi.Size = new System.Drawing.Size(75, 23);
            this.Btn_Multi.TabIndex = 8;
            this.Btn_Multi.Text = "Multi";
            this.Btn_Multi.UseVisualStyleBackColor = true;
            this.Btn_Multi.Click += new System.EventHandler(this.Btn_Multi_Click);
            // 
            // Btn_Div
            // 
            this.Btn_Div.Location = new System.Drawing.Point(408, 227);
            this.Btn_Div.Name = "Btn_Div";
            this.Btn_Div.Size = new System.Drawing.Size(75, 23);
            this.Btn_Div.TabIndex = 9;
            this.Btn_Div.Text = "Div";
            this.Btn_Div.UseVisualStyleBackColor = true;
            this.Btn_Div.Click += new System.EventHandler(this.Btn_Div_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(532, 227);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 10;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(660, 227);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 11;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Div);
            this.Controls.Add(this.Btn_Multi);
            this.Controls.Add(this.Btn_Sub);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txt_Result);
            this.Controls.Add(this.Txt_SecondNumber);
            this.Controls.Add(this.Txt_FirstNumber);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.Lbl_SecondNumber);
            this.Controls.Add(this.lbl_FirstNumber);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstNumber;
        private System.Windows.Forms.Label Lbl_SecondNumber;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox Txt_FirstNumber;
        private System.Windows.Forms.TextBox Txt_SecondNumber;
        private System.Windows.Forms.TextBox Txt_Result;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Sub;
        private System.Windows.Forms.Button Btn_Multi;
        private System.Windows.Forms.Button Btn_Div;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Exit;
    }
}

