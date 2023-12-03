
namespace Syrk_Lab6
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
            this.components = new System.ComponentModel.Container();
            this.queueText = new System.Windows.Forms.Label();
            this.Cashier1Text = new System.Windows.Forms.Label();
            this.Cashier2Text = new System.Windows.Forms.Label();
            this.Cashier3Text = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timeText = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientsServedText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // queueText
            // 
            this.queueText.AutoSize = true;
            this.queueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queueText.Location = new System.Drawing.Point(117, 216);
            this.queueText.Name = "queueText";
            this.queueText.Size = new System.Drawing.Size(29, 31);
            this.queueText.TabIndex = 4;
            this.queueText.Text = "0";
            // 
            // Cashier1Text
            // 
            this.Cashier1Text.AutoSize = true;
            this.Cashier1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cashier1Text.Location = new System.Drawing.Point(423, 46);
            this.Cashier1Text.Name = "Cashier1Text";
            this.Cashier1Text.Size = new System.Drawing.Size(29, 31);
            this.Cashier1Text.TabIndex = 5;
            this.Cashier1Text.Text = "0";
            // 
            // Cashier2Text
            // 
            this.Cashier2Text.AutoSize = true;
            this.Cashier2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cashier2Text.Location = new System.Drawing.Point(423, 216);
            this.Cashier2Text.Name = "Cashier2Text";
            this.Cashier2Text.Size = new System.Drawing.Size(29, 31);
            this.Cashier2Text.TabIndex = 6;
            this.Cashier2Text.Text = "0";
            // 
            // Cashier3Text
            // 
            this.Cashier3Text.AutoSize = true;
            this.Cashier3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cashier3Text.Location = new System.Drawing.Point(423, 369);
            this.Cashier3Text.Name = "Cashier3Text";
            this.Cashier3Text.Size = new System.Drawing.Size(29, 31);
            this.Cashier3Text.TabIndex = 7;
            this.Cashier3Text.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.timeText.Location = new System.Drawing.Point(12, 9);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(405, 39);
            this.timeText.TabIndex = 8;
            this.timeText.Text = "Магазин работает 0 сек.";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Syrk_Lab6.Properties.Resources.shopper_with_bags_318_26644;
            this.pictureBox5.InitialImage = global::Syrk_Lab6.Properties.Resources._2515196;
            this.pictureBox5.Location = new System.Drawing.Point(653, 159);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(147, 141);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Syrk_Lab6.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(472, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 131);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Syrk_Lab6.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(472, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Syrk_Lab6.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(472, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Syrk_Lab6.Properties.Resources._2515196;
            this.pictureBox1.InitialImage = global::Syrk_Lab6.Properties.Resources._2515196;
            this.pictureBox1.Location = new System.Drawing.Point(152, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // clientsServedText
            // 
            this.clientsServedText.AutoSize = true;
            this.clientsServedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsServedText.Location = new System.Drawing.Point(716, 318);
            this.clientsServedText.Name = "clientsServedText";
            this.clientsServedText.Size = new System.Drawing.Size(29, 31);
            this.clientsServedText.TabIndex = 10;
            this.clientsServedText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientsServedText);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.Cashier3Text);
            this.Controls.Add(this.Cashier2Text);
            this.Controls.Add(this.Cashier1Text);
            this.Controls.Add(this.queueText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label queueText;
        private System.Windows.Forms.Label Cashier1Text;
        private System.Windows.Forms.Label Cashier2Text;
        private System.Windows.Forms.Label Cashier3Text;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label clientsServedText;
    }
}

