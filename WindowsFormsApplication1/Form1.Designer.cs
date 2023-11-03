namespace WindowsFormsApplication1
{
    partial class form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.EggradioButt2 = new System.Windows.Forms.RadioButton();
            this.ChickenRadioButt1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.copyRequestButt = new System.Windows.Forms.Button();
            this.eggQualityLabel = new System.Windows.Forms.Label();
            this.prepareFoodButton = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.ListBox();
            this.MenuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.EggradioButt2);
            this.MenuGroupBox.Controls.Add(this.ChickenRadioButt1);
            this.MenuGroupBox.Location = new System.Drawing.Point(42, 51);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(346, 57);
            this.MenuGroupBox.TabIndex = 0;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "menu";
            // 
            // EggradioButt2
            // 
            this.EggradioButt2.AutoSize = true;
            this.EggradioButt2.Location = new System.Drawing.Point(224, 23);
            this.EggradioButt2.Name = "EggradioButt2";
            this.EggradioButt2.Size = new System.Drawing.Size(43, 17);
            this.EggradioButt2.TabIndex = 1;
            this.EggradioButt2.TabStop = true;
            this.EggradioButt2.Text = "egg";
            this.EggradioButt2.UseVisualStyleBackColor = true;
            this.EggradioButt2.CheckedChanged += new System.EventHandler(this.EggradioButt2_CheckedChanged);
            // 
            // ChickenRadioButt1
            // 
            this.ChickenRadioButt1.AutoSize = true;
            this.ChickenRadioButt1.Location = new System.Drawing.Point(58, 23);
            this.ChickenRadioButt1.Name = "ChickenRadioButt1";
            this.ChickenRadioButt1.Size = new System.Drawing.Size(63, 17);
            this.ChickenRadioButt1.TabIndex = 0;
            this.ChickenRadioButt1.TabStop = true;
            this.ChickenRadioButt1.Text = "chicken";
            this.ChickenRadioButt1.UseVisualStyleBackColor = true;
            this.ChickenRadioButt1.CheckedChanged += new System.EventHandler(this.ChickenRadioButt1_CheckedChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(39, 143);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(44, 13);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(100, 140);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(63, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(266, 137);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(122, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "submit new request";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // copyRequestButt
            // 
            this.copyRequestButt.Location = new System.Drawing.Point(42, 184);
            this.copyRequestButt.Name = "copyRequestButt";
            this.copyRequestButt.Size = new System.Drawing.Size(346, 23);
            this.copyRequestButt.TabIndex = 5;
            this.copyRequestButt.Text = "Copy the previous request";
            this.copyRequestButt.UseVisualStyleBackColor = true;
            this.copyRequestButt.Click += new System.EventHandler(this.copyRequestButt_Click);
            // 
            // eggQualityLabel
            // 
            this.eggQualityLabel.AutoSize = true;
            this.eggQualityLabel.Location = new System.Drawing.Point(39, 223);
            this.eggQualityLabel.Name = "eggQualityLabel";
            this.eggQualityLabel.Size = new System.Drawing.Size(62, 13);
            this.eggQualityLabel.TabIndex = 6;
            this.eggQualityLabel.Text = "Egg quality:";
            // 
            // prepareFoodButton
            // 
            this.prepareFoodButton.Location = new System.Drawing.Point(42, 261);
            this.prepareFoodButton.Name = "prepareFoodButton";
            this.prepareFoodButton.Size = new System.Drawing.Size(346, 23);
            this.prepareFoodButton.TabIndex = 7;
            this.prepareFoodButton.Text = "prepare food";
            this.prepareFoodButton.UseVisualStyleBackColor = true;
            this.prepareFoodButton.Click += new System.EventHandler(this.prepareFoodButton_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(39, 306);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(37, 13);
            this.resultlabel.TabIndex = 8;
            this.resultlabel.Text = "results";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(174, 245);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(43, 13);
            this.qualityLabel.TabIndex = 9;
            this.qualityLabel.Text = "______";
            // 
            // food
            // 
            this.food.FormattingEnabled = true;
            this.food.Location = new System.Drawing.Point(42, 337);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(346, 69);
            this.food.TabIndex = 10;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.food);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.prepareFoodButton);
            this.Controls.Add(this.eggQualityLabel);
            this.Controls.Add(this.copyRequestButt);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.QuantityLabel);
            this.Name = "form";
            this.Text = "Culinary Paradise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuGroupBox.ResumeLayout(false);
            this.MenuGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.RadioButton EggradioButt2;
        private System.Windows.Forms.RadioButton ChickenRadioButt1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button copyRequestButt;
        private System.Windows.Forms.Label eggQualityLabel;
        private System.Windows.Forms.Button prepareFoodButton;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.ListBox food;
    }
}

