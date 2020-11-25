namespace Client
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
            this.radioBtnShow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.radioBtnEdit = new System.Windows.Forms.RadioButton();
            this.radioBtnRemove = new System.Windows.Forms.RadioButton();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.listItem = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnShow
            // 
            this.radioBtnShow.AutoSize = true;
            this.radioBtnShow.Location = new System.Drawing.Point(6, 31);
            this.radioBtnShow.Name = "radioBtnShow";
            this.radioBtnShow.Size = new System.Drawing.Size(87, 17);
            this.radioBtnShow.TabIndex = 1;
            this.radioBtnShow.TabStop = true;
            this.radioBtnShow.Text = "Посмотреть";
            this.radioBtnShow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.radioBtnEdit);
            this.groupBox1.Controls.Add(this.radioBtnRemove);
            this.groupBox1.Controls.Add(this.radioBtnAdd);
            this.groupBox1.Controls.Add(this.radioBtnShow);
            this.groupBox1.Location = new System.Drawing.Point(340, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(7, 124);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Выполнить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // radioBtnEdit
            // 
            this.radioBtnEdit.AutoSize = true;
            this.radioBtnEdit.Location = new System.Drawing.Point(6, 100);
            this.radioBtnEdit.Name = "radioBtnEdit";
            this.radioBtnEdit.Size = new System.Drawing.Size(102, 17);
            this.radioBtnEdit.TabIndex = 4;
            this.radioBtnEdit.TabStop = true;
            this.radioBtnEdit.Text = "Редактировать";
            this.radioBtnEdit.UseVisualStyleBackColor = true;
            // 
            // radioBtnRemove
            // 
            this.radioBtnRemove.AutoSize = true;
            this.radioBtnRemove.Location = new System.Drawing.Point(6, 77);
            this.radioBtnRemove.Name = "radioBtnRemove";
            this.radioBtnRemove.Size = new System.Drawing.Size(68, 17);
            this.radioBtnRemove.TabIndex = 3;
            this.radioBtnRemove.TabStop = true;
            this.radioBtnRemove.Text = "Удалить";
            this.radioBtnRemove.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(6, 54);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(75, 17);
            this.radioBtnAdd.TabIndex = 2;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Добавить";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            // 
            // listItem
            // 
            this.listItem.FormattingEnabled = true;
            this.listItem.Location = new System.Drawing.Point(12, 13);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(322, 160);
            this.listItem.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(490, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 133);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление/редактирование";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество сотрудников:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название подразделения:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(12, 247);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(245, 20);
            this.txtPort.TabIndex = 12;
            this.txtPort.Text = "5050";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Порт:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 203);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(245, 20);
            this.txtHost.TabIndex = 11;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Хост:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 273);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(245, 28);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Соединить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(284, 203);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(459, 98);
            this.txtStatus.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 317);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnRemove;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton radioBtnEdit;
        private System.Windows.Forms.ListBox listItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

