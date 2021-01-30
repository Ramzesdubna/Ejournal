namespace Кабельный_журнал
{
    partial class Form1
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
            this.systemBox = new System.Windows.Forms.ComboBox();
            this.clampblockBox = new System.Windows.Forms.ComboBox();
            this.lockerBox = new System.Windows.Forms.ComboBox();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEnterElement = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.markingBox = new System.Windows.Forms.ComboBox();
            this.subsystemBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clampBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // systemBox
            // 
            this.systemBox.FormattingEnabled = true;
            this.systemBox.Items.AddRange(new object[] {
            "01 - Вакуумная система",
            "02 - СВЧ",
            "03 - Система охлаждения установки",
            "04 - Система термостабилизации установки"});
            this.systemBox.Location = new System.Drawing.Point(12, 58);
            this.systemBox.Name = "systemBox";
            this.systemBox.Size = new System.Drawing.Size(182, 21);
            this.systemBox.TabIndex = 0;
            // 
            // clampblockBox
            // 
            this.clampblockBox.FormattingEnabled = true;
            this.clampblockBox.Items.AddRange(new object[] {
            "306-03.01 - Клеммный блок №1 шкафа №3 в помещении 306",
            "306-03.03 - Клеммный блок №3 шкафа №3 в помещении 306",
            "205-01.01 - Клеммный блок №1 шкафа №1 в помещении 205",
            "306-01.02 - Клеммный блок №2 шкафа №1 в помещении 306"});
            this.clampblockBox.Location = new System.Drawing.Point(12, 156);
            this.clampblockBox.Name = "clampblockBox";
            this.clampblockBox.Size = new System.Drawing.Size(182, 21);
            this.clampblockBox.TabIndex = 1;
            // 
            // lockerBox
            // 
            this.lockerBox.FormattingEnabled = true;
            this.lockerBox.Items.AddRange(new object[] {
            "306-01 Шкаф оборудования №1 в помещении 306",
            "306-03 Шкаф оборудования №3 в помещении 306",
            "205-01 Шкаф оборудования №1 в помещении 205"});
            this.lockerBox.Location = new System.Drawing.Point(618, 58);
            this.lockerBox.Name = "lockerBox";
            this.lockerBox.Size = new System.Drawing.Size(182, 21);
            this.lockerBox.TabIndex = 2;
            // 
            // roomBox
            // 
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Items.AddRange(new object[] {
            "205",
            "306",
            "122"});
            this.roomBox.Location = new System.Drawing.Point(419, 58);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(182, 21);
            this.roomBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Система";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(614, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = " Шкаф оборудования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Помещение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Клеммный блок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(417, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип кабеля";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(614, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Маркировка";
            // 
            // BtnEnterElement
            // 
            this.BtnEnterElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnterElement.Location = new System.Drawing.Point(219, 256);
            this.BtnEnterElement.Name = "BtnEnterElement";
            this.BtnEnterElement.Size = new System.Drawing.Size(148, 23);
            this.BtnEnterElement.TabIndex = 10;
            this.BtnEnterElement.Text = "Добавить элемент";
            this.BtnEnterElement.UseVisualStyleBackColor = true;
            this.BtnEnterElement.Click += new System.EventHandler(this.BtnEnterElement_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.Location = new System.Drawing.Point(419, 256);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(148, 23);
            this.BtnEnter.TabIndex = 11;
            this.BtnEnter.Text = "Применить";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "ПВС 3*1,5",
            "ВВГ 3*2,5",
            "ПВС 2*0,75",
            "UTP 8*0,29"});
            this.TypeBox.Location = new System.Drawing.Point(419, 156);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(182, 21);
            this.TypeBox.TabIndex = 12;
            // 
            // markingBox
            // 
            this.markingBox.FormattingEnabled = true;
            this.markingBox.Items.AddRange(new object[] {
            "01.306-03.01-12:01.205-01.01-09",
            "03.306-01.02-08:03.205-00.00-05"});
            this.markingBox.Location = new System.Drawing.Point(618, 156);
            this.markingBox.Name = "markingBox";
            this.markingBox.Size = new System.Drawing.Size(182, 21);
            this.markingBox.TabIndex = 13;
            // 
            // subsystemBox
            // 
            this.subsystemBox.FormattingEnabled = true;
            this.subsystemBox.Location = new System.Drawing.Point(214, 58);
            this.subsystemBox.Name = "subsystemBox";
            this.subsystemBox.Size = new System.Drawing.Size(182, 21);
            this.subsystemBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(215, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Подсистема";
            // 
            // clampBox
            // 
            this.clampBox.FormattingEnabled = true;
            this.clampBox.Location = new System.Drawing.Point(214, 156);
            this.clampBox.Name = "clampBox";
            this.clampBox.Size = new System.Drawing.Size(182, 21);
            this.clampBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(219, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Клемма";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 383);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clampBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subsystemBox);
            this.Controls.Add(this.markingBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.BtnEnterElement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.lockerBox);
            this.Controls.Add(this.clampblockBox);
            this.Controls.Add(this.systemBox);
            this.Name = "Form1";
            this.Text = "Кабельный журнал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox systemBox;
        private System.Windows.Forms.ComboBox clampblockBox;
        private System.Windows.Forms.ComboBox lockerBox;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEnterElement;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.ComboBox markingBox;
        private System.Windows.Forms.ComboBox subsystemBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox clampBox;
        private System.Windows.Forms.Label label9;
    }
}

