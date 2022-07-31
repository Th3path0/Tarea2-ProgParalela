namespace ProcessKiller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslProcessCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUpdateProcessList = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_id = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_CPU = new System.Windows.Forms.ListBox();
            this.lst_memoriafisica = new System.Windows.Forms.ListBox();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslProcessCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 673);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1167, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tslProcessCount
            // 
            this.tslProcessCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tslProcessCount.Name = "tslProcessCount";
            this.tslProcessCount.Size = new System.Drawing.Size(179, 25);
            this.tslProcessCount.Text = "toolStripStatusLabel1";
            // 
            // btnUpdateProcessList
            // 
            this.btnUpdateProcessList.Location = new System.Drawing.Point(69, 631);
            this.btnUpdateProcessList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateProcessList.Name = "btnUpdateProcessList";
            this.btnUpdateProcessList.Size = new System.Drawing.Size(112, 35);
            this.btnUpdateProcessList.TabIndex = 2;
            this.btnUpdateProcessList.Text = "actualizar";
            this.btnUpdateProcessList.UseVisualStyleBackColor = true;
            this.btnUpdateProcessList.Click += new System.EventHandler(this.btnUpdateProcessList_Click_1);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(276, 631);
            this.btnKill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(112, 35);
            this.btnKill.TabIndex = 3;
            this.btnKill.Text = "detener";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(982, 631);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 631);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "informacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lst_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lst_CPU);
            this.panel1.Controls.Add(this.lst_memoriafisica);
            this.panel1.Controls.Add(this.lstProcesses);
            this.panel1.Location = new System.Drawing.Point(34, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 578);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(106, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID:";
            // 
            // lst_id
            // 
            this.lst_id.FormattingEnabled = true;
            this.lst_id.HorizontalScrollbar = true;
            this.lst_id.ItemHeight = 20;
            this.lst_id.Location = new System.Drawing.Point(39, 54);
            this.lst_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_id.Name = "lst_id";
            this.lst_id.ScrollAlwaysVisible = true;
            this.lst_id.Size = new System.Drawing.Size(174, 504);
            this.lst_id.TabIndex = 24;
            this.lst_id.SelectedIndexChanged += new System.EventHandler(this.lst_id_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(976, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "CPU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(618, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ram:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(334, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Procesos:";
            // 
            // lst_CPU
            // 
            this.lst_CPU.FormattingEnabled = true;
            this.lst_CPU.HorizontalScrollbar = true;
            this.lst_CPU.ItemHeight = 20;
            this.lst_CPU.Location = new System.Drawing.Point(908, 54);
            this.lst_CPU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_CPU.Name = "lst_CPU";
            this.lst_CPU.ScrollAlwaysVisible = true;
            this.lst_CPU.Size = new System.Drawing.Size(174, 504);
            this.lst_CPU.TabIndex = 20;
            // 
            // lst_memoriafisica
            // 
            this.lst_memoriafisica.FormattingEnabled = true;
            this.lst_memoriafisica.HorizontalScrollbar = true;
            this.lst_memoriafisica.ItemHeight = 20;
            this.lst_memoriafisica.Location = new System.Drawing.Point(592, 54);
            this.lst_memoriafisica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_memoriafisica.Name = "lst_memoriafisica";
            this.lst_memoriafisica.ScrollAlwaysVisible = true;
            this.lst_memoriafisica.Size = new System.Drawing.Size(174, 504);
            this.lst_memoriafisica.TabIndex = 19;
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.HorizontalScrollbar = true;
            this.lstProcesses.ItemHeight = 20;
            this.lstProcesses.Location = new System.Drawing.Point(287, 54);
            this.lstProcesses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.ScrollAlwaysVisible = true;
            this.lstProcesses.Size = new System.Drawing.Size(174, 504);
            this.lstProcesses.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnUpdateProcessList);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslProcessCount;
        private System.Windows.Forms.Button btnUpdateProcessList;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_CPU;
        private System.Windows.Forms.ListBox lst_memoriafisica;
        private System.Windows.Forms.ListBox lstProcesses;
    }
}

