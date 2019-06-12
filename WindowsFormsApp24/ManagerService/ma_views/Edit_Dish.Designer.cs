namespace MAIN_GUI_Mangaer_window.ma_views
{
    partial class Edit_Dish
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
            this.comboBox1DishTypeEdit = new System.Windows.Forms.ComboBox();
            this.label7PathToImgDishEdit = new System.Windows.Forms.Label();
            this.numericUpDown2DishEditSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1EditDishPrice = new System.Windows.Forms.NumericUpDown();
            this.button3CancelDishEdit = new System.Windows.Forms.Button();
            this.button2EditDish = new System.Windows.Forms.Button();
            this.button1EditDishImage = new System.Windows.Forms.Button();
            this.textBox4DishDescriptonEdit = new System.Windows.Forms.TextBox();
            this.textBox1EditDishName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2DishEditSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1EditDishPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1DishTypeEdit
            // 
            this.comboBox1DishTypeEdit.FormattingEnabled = true;
            this.comboBox1DishTypeEdit.Location = new System.Drawing.Point(480, 72);
            this.comboBox1DishTypeEdit.Name = "comboBox1DishTypeEdit";
            this.comboBox1DishTypeEdit.Size = new System.Drawing.Size(121, 21);
            this.comboBox1DishTypeEdit.TabIndex = 23;
            // 
            // label7PathToImgDishEdit
            // 
            this.label7PathToImgDishEdit.AutoSize = true;
            this.label7PathToImgDishEdit.Location = new System.Drawing.Point(327, 195);
            this.label7PathToImgDishEdit.Name = "label7PathToImgDishEdit";
            this.label7PathToImgDishEdit.Size = new System.Drawing.Size(109, 13);
            this.label7PathToImgDishEdit.TabIndex = 22;
            this.label7PathToImgDishEdit.Text = " * Image not loaded * ";
            // 
            // numericUpDown2DishEditSize
            // 
            this.numericUpDown2DishEditSize.Location = new System.Drawing.Point(231, 152);
            this.numericUpDown2DishEditSize.Name = "numericUpDown2DishEditSize";
            this.numericUpDown2DishEditSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2DishEditSize.TabIndex = 21;
            // 
            // numericUpDown1EditDishPrice
            // 
            this.numericUpDown1EditDishPrice.Location = new System.Drawing.Point(231, 110);
            this.numericUpDown1EditDishPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1EditDishPrice.Name = "numericUpDown1EditDishPrice";
            this.numericUpDown1EditDishPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1EditDishPrice.TabIndex = 20;
            // 
            // button3CancelDishEdit
            // 
            this.button3CancelDishEdit.Location = new System.Drawing.Point(480, 399);
            this.button3CancelDishEdit.Name = "button3CancelDishEdit";
            this.button3CancelDishEdit.Size = new System.Drawing.Size(75, 23);
            this.button3CancelDishEdit.TabIndex = 18;
            this.button3CancelDishEdit.Text = "Cancel";
            this.button3CancelDishEdit.UseVisualStyleBackColor = true;
            // 
            // button2EditDish
            // 
            this.button2EditDish.Location = new System.Drawing.Point(231, 399);
            this.button2EditDish.Name = "button2EditDish";
            this.button2EditDish.Size = new System.Drawing.Size(75, 23);
            this.button2EditDish.TabIndex = 17;
            this.button2EditDish.Text = "Edit";
            this.button2EditDish.UseVisualStyleBackColor = true;
            this.button2EditDish.Click += new System.EventHandler(this.Button2EditDish_Click);
            // 
            // button1EditDishImage
            // 
            this.button1EditDishImage.Location = new System.Drawing.Point(231, 190);
            this.button1EditDishImage.Name = "button1EditDishImage";
            this.button1EditDishImage.Size = new System.Drawing.Size(75, 23);
            this.button1EditDishImage.TabIndex = 19;
            this.button1EditDishImage.Text = "Browse";
            this.button1EditDishImage.UseVisualStyleBackColor = true;
            this.button1EditDishImage.Click += new System.EventHandler(this.Button1EditDishImage_Click);
            // 
            // textBox4DishDescriptonEdit
            // 
            this.textBox4DishDescriptonEdit.Location = new System.Drawing.Point(231, 251);
            this.textBox4DishDescriptonEdit.Multiline = true;
            this.textBox4DishDescriptonEdit.Name = "textBox4DishDescriptonEdit";
            this.textBox4DishDescriptonEdit.Size = new System.Drawing.Size(324, 116);
            this.textBox4DishDescriptonEdit.TabIndex = 16;
            // 
            // textBox1EditDishName
            // 
            this.textBox1EditDishName.Location = new System.Drawing.Point(231, 73);
            this.textBox1EditDishName.Name = "textBox1EditDishName";
            this.textBox1EditDishName.Size = new System.Drawing.Size(100, 20);
            this.textBox1EditDishName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dish Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dish Image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dish Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dish Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dish Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dish name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Dish:";
            // 
            // Edit_Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1DishTypeEdit);
            this.Controls.Add(this.label7PathToImgDishEdit);
            this.Controls.Add(this.numericUpDown2DishEditSize);
            this.Controls.Add(this.numericUpDown1EditDishPrice);
            this.Controls.Add(this.button3CancelDishEdit);
            this.Controls.Add(this.button2EditDish);
            this.Controls.Add(this.button1EditDishImage);
            this.Controls.Add(this.textBox4DishDescriptonEdit);
            this.Controls.Add(this.textBox1EditDishName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Dish";
            this.Text = "MAIN - Edit dish";
            this.Load += new System.EventHandler(this.Edit_Dish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2DishEditSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1EditDishPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1DishTypeEdit;
        private System.Windows.Forms.Label label7PathToImgDishEdit;
        private System.Windows.Forms.NumericUpDown numericUpDown2DishEditSize;
        private System.Windows.Forms.NumericUpDown numericUpDown1EditDishPrice;
        private System.Windows.Forms.Button button3CancelDishEdit;
        private System.Windows.Forms.Button button2EditDish;
        private System.Windows.Forms.Button button1EditDishImage;
        private System.Windows.Forms.TextBox textBox4DishDescriptonEdit;
        private System.Windows.Forms.TextBox textBox1EditDishName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}