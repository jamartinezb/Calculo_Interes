
namespace calcular_intereses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapCre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaCal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 56);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha fin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(347, 56);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(282, 27);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "capital vigente del crédito";
            // 
            // txtCapCre
            // 
            this.txtCapCre.Location = new System.Drawing.Point(31, 140);
            this.txtCapCre.Name = "txtCapCre";
            this.txtCapCre.Size = new System.Drawing.Size(287, 27);
            this.txtCapCre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "tasa de interés";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(347, 140);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(282, 27);
            this.txtTasa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "subsidio";
            // 
            // txtSub
            // 
            this.txtSub.AutoSize = true;
            this.txtSub.Location = new System.Drawing.Point(31, 223);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(17, 20);
            this.txtSub.TabIndex = 9;
            this.txtSub.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Intereses";
            // 
            // txtInter
            // 
            this.txtInter.AutoSize = true;
            this.txtInter.Location = new System.Drawing.Point(347, 223);
            this.txtInter.Name = "txtInter";
            this.txtInter.Size = new System.Drawing.Size(17, 20);
            this.txtInter.TabIndex = 11;
            this.txtInter.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "total a pagar ";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(31, 321);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(17, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(292, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dias";
            // 
            // txtDias
            // 
            this.txtDias.AutoSize = true;
            this.txtDias.Location = new System.Drawing.Point(684, 61);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(17, 20);
            this.txtDias.TabIndex = 16;
            this.txtDias.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Días calendario";
            // 
            // txtDiaCal
            // 
            this.txtDiaCal.AutoSize = true;
            this.txtDiaCal.Location = new System.Drawing.Point(684, 143);
            this.txtDiaCal.Name = "txtDiaCal";
            this.txtDiaCal.Size = new System.Drawing.Size(17, 20);
            this.txtDiaCal.TabIndex = 18;
            this.txtDiaCal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(21, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 182);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.txtDiaCal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCapCre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIDA SAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapCre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtInter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtDias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtDiaCal;
        private System.Windows.Forms.Panel panel1;
    }
}

