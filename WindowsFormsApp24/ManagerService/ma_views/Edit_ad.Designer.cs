namespace MAIN_GUI_Mangaer_window.ma_views
{
    partial class Edit_ad
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
            this.button3EditAdCancel = new System.Windows.Forms.Button();
            this.button2EditAd = new System.Windows.Forms.Button();
            this.dateTimePicker1ExpDateEdit = new System.Windows.Forms.DateTimePicker();
            this.button1EditBrowseAdImage = new System.Windows.Forms.Button();
            this.checkBox1EditAdState = new System.Windows.Forms.CheckBox();
            this.textBox2EditAdDescription = new System.Windows.Forms.TextBox();
            this.textBox5EditAdURL = new System.Windows.Forms.TextBox();
            this.textBox4EditAdPrice = new System.Windows.Forms.TextBox();
            this.textBox1EditAdCompanyName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8AdEditImgLoaded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1DeleteAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3EditAdCancel
            // 
            this.button3EditAdCancel.Location = new System.Drawing.Point(348, 415);
            this.button3EditAdCancel.Name = "button3EditAdCancel";
            this.button3EditAdCancel.Size = new System.Drawing.Size(75, 23);
            this.button3EditAdCancel.TabIndex = 20;
            this.button3EditAdCancel.Text = "Cancel";
            this.button3EditAdCancel.UseVisualStyleBackColor = true;
            this.button3EditAdCancel.Click += new System.EventHandler(this.Button3EditAdCancel_Click);
            // 
            // button2EditAd
            // 
            this.button2EditAd.Location = new System.Drawing.Point(116, 415);
            this.button2EditAd.Name = "button2EditAd";
            this.button2EditAd.Size = new System.Drawing.Size(75, 23);
            this.button2EditAd.TabIndex = 21;
            this.button2EditAd.Text = "Edit";
            this.button2EditAd.UseVisualStyleBackColor = true;
            this.button2EditAd.Click += new System.EventHandler(this.Button2EditAdCreate_Click);
            // 
            // dateTimePicker1ExpDateEdit
            // 
            this.dateTimePicker1ExpDateEdit.Location = new System.Drawing.Point(223, 163);
            this.dateTimePicker1ExpDateEdit.Name = "dateTimePicker1ExpDateEdit";
            this.dateTimePicker1ExpDateEdit.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1ExpDateEdit.TabIndex = 19;
            // 
            // button1EditBrowseAdImage
            // 
            this.button1EditBrowseAdImage.Location = new System.Drawing.Point(223, 126);
            this.button1EditBrowseAdImage.Name = "button1EditBrowseAdImage";
            this.button1EditBrowseAdImage.Size = new System.Drawing.Size(75, 23);
            this.button1EditBrowseAdImage.TabIndex = 18;
            this.button1EditBrowseAdImage.Text = "Browse";
            this.button1EditBrowseAdImage.UseVisualStyleBackColor = true;
            this.button1EditBrowseAdImage.Click += new System.EventHandler(this.Button1EditBrowseAdImage_Click);
            // 
            // checkBox1EditAdState
            // 
            this.checkBox1EditAdState.AutoSize = true;
            this.checkBox1EditAdState.Location = new System.Drawing.Point(343, 91);
            this.checkBox1EditAdState.Name = "checkBox1EditAdState";
            this.checkBox1EditAdState.Size = new System.Drawing.Size(56, 17);
            this.checkBox1EditAdState.TabIndex = 17;
            this.checkBox1EditAdState.Text = "Active";
            this.checkBox1EditAdState.UseVisualStyleBackColor = true;
            // 
            // textBox2EditAdDescription
            // 
            this.textBox2EditAdDescription.Location = new System.Drawing.Point(223, 280);
            this.textBox2EditAdDescription.Multiline = true;
            this.textBox2EditAdDescription.Name = "textBox2EditAdDescription";
            this.textBox2EditAdDescription.Size = new System.Drawing.Size(200, 98);
            this.textBox2EditAdDescription.TabIndex = 13;
            // 
            // textBox5EditAdURL
            // 
            this.textBox5EditAdURL.Location = new System.Drawing.Point(223, 246);
            this.textBox5EditAdURL.Name = "textBox5EditAdURL";
            this.textBox5EditAdURL.Size = new System.Drawing.Size(200, 20);
            this.textBox5EditAdURL.TabIndex = 14;
            // 
            // textBox4EditAdPrice
            // 
            this.textBox4EditAdPrice.Location = new System.Drawing.Point(223, 207);
            this.textBox4EditAdPrice.Name = "textBox4EditAdPrice";
            this.textBox4EditAdPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox4EditAdPrice.TabIndex = 15;
            // 
            // textBox1EditAdCompanyName
            // 
            this.textBox1EditAdCompanyName.Location = new System.Drawing.Point(223, 89);
            this.textBox1EditAdCompanyName.Name = "textBox1EditAdCompanyName";
            this.textBox1EditAdCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBox1EditAdCompanyName.TabIndex = 16;
            this.textBox1EditAdCompanyName.TextChanged += new System.EventHandler(this.TextBox1EditAdName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ad description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expiration date:";
            // 
            // label8AdEditImgLoaded
            // 
            this.label8AdEditImgLoaded.AutoSize = true;
            this.label8AdEditImgLoaded.Location = new System.Drawing.Point(322, 131);
            this.label8AdEditImgLoaded.Name = "label8AdEditImgLoaded";
            this.label8AdEditImgLoaded.Size = new System.Drawing.Size(89, 13);
            this.label8AdEditImgLoaded.TabIndex = 10;
            this.label8AdEditImgLoaded.Text = "Image not loaded";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Company name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Edit ad:";
            // 
            // button1DeleteAd
            // 
            this.button1DeleteAd.Location = new System.Drawing.Point(237, 415);
            this.button1DeleteAd.Name = "button1DeleteAd";
            this.button1DeleteAd.Size = new System.Drawing.Size(75, 23);
            this.button1DeleteAd.TabIndex = 21;
            this.button1DeleteAd.Text = "Delete";
            this.button1DeleteAd.UseVisualStyleBackColor = true;
            this.button1DeleteAd.Click += new System.EventHandler(this.Button2EditAdCreate_Click);
            // 
            // Edit_ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3EditAdCancel);
            this.Controls.Add(this.button1DeleteAd);
            this.Controls.Add(this.button2EditAd);
            this.Controls.Add(this.dateTimePicker1ExpDateEdit);
            this.Controls.Add(this.button1EditBrowseAdImage);
            this.Controls.Add(this.checkBox1EditAdState);
            this.Controls.Add(this.textBox2EditAdDescription);
            this.Controls.Add(this.textBox5EditAdURL);
            this.Controls.Add(this.textBox4EditAdPrice);
            this.Controls.Add(this.textBox1EditAdCompanyName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8AdEditImgLoaded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Edit_ad";
            this.Text = "MAIN - Edit ad";
            this.Load += new System.EventHandler(this.Edit_ad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3EditAdCancel;
        private System.Windows.Forms.Button button2EditAd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1ExpDateEdit;
        private System.Windows.Forms.Button button1EditBrowseAdImage;
        private System.Windows.Forms.CheckBox checkBox1EditAdState;
        private System.Windows.Forms.TextBox textBox2EditAdDescription;
        private System.Windows.Forms.TextBox textBox5EditAdURL;
        private System.Windows.Forms.TextBox textBox4EditAdPrice;
        private System.Windows.Forms.TextBox textBox1EditAdCompanyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8AdEditImgLoaded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1DeleteAd;
    }
}