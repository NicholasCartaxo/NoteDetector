namespace NoteDetector {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.bind0 = new System.Windows.Forms.Label();
            this.bind1 = new System.Windows.Forms.Label();
            this.bind2 = new System.Windows.Forms.Label();
            this.bind3 = new System.Windows.Forms.Label();
            this.bind4 = new System.Windows.Forms.Label();
            this.bind5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peak Frequency:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(64, 104);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(187, 45);
            this.trackBar1.TabIndex = 50;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mic Sensibility: 50";
            // 
            // bind0
            // 
            this.bind0.AutoSize = true;
            this.bind0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bind0.Location = new System.Drawing.Point(38, 174);
            this.bind0.Name = "bind0";
            this.bind0.Size = new System.Drawing.Size(29, 25);
            this.bind0.TabIndex = 52;
            this.bind0.Text = "Q";
            // 
            // bind1
            // 
            this.bind1.AutoSize = true;
            this.bind1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bind1.Location = new System.Drawing.Point(73, 174);
            this.bind1.Name = "bind1";
            this.bind1.Size = new System.Drawing.Size(33, 25);
            this.bind1.TabIndex = 53;
            this.bind1.Text = "W";
            // 
            // bind2
            // 
            this.bind2.AutoSize = true;
            this.bind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bind2.Location = new System.Drawing.Point(112, 174);
            this.bind2.Name = "bind2";
            this.bind2.Size = new System.Drawing.Size(27, 25);
            this.bind2.TabIndex = 54;
            this.bind2.Text = "E";
            // 
            // bind3
            // 
            this.bind3.AutoSize = true;
            this.bind3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bind3.Location = new System.Drawing.Point(145, 174);
            this.bind3.Name = "bind3";
            this.bind3.Size = new System.Drawing.Size(28, 25);
            this.bind3.TabIndex = 55;
            this.bind3.Text = "R";
            // 
            // bind4
            // 
            this.bind4.AutoSize = true;
            this.bind4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bind4.Location = new System.Drawing.Point(216, 174);
            this.bind4.Name = "bind4";
            this.bind4.Size = new System.Drawing.Size(28, 25);
            this.bind4.TabIndex = 56;
            this.bind4.Text = "D";
            // 
            // bind5
            // 
            this.bind5.AutoSize = true;
            this.bind5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bind5.Location = new System.Drawing.Point(250, 174);
            this.bind5.Name = "bind5";
            this.bind5.Size = new System.Drawing.Size(26, 25);
            this.bind5.TabIndex = 57;
            this.bind5.Text = "F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 229);
            this.Controls.Add(this.bind5);
            this.Controls.Add(this.bind4);
            this.Controls.Add(this.bind3);
            this.Controls.Add(this.bind2);
            this.Controls.Add(this.bind1);
            this.Controls.Add(this.bind0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Note Detector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bind0;
        private System.Windows.Forms.Label bind1;
        private System.Windows.Forms.Label bind2;
        private System.Windows.Forms.Label bind3;
        private System.Windows.Forms.Label bind4;
        private System.Windows.Forms.Label bind5;
    }
}

