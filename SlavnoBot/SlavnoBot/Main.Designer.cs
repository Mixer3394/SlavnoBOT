namespace SlavnoBot
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPrzebiegRozmowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pytajPrzedZamknięciemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.image_pb = new System.Windows.Forms.PictureBox();
            this.input_tb = new System.Windows.Forms.TextBox();
            this.new_send_btn = new System.Windows.Forms.Button();
            this.output_lb = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszPrzebiegRozmowyToolStripMenuItem,
            this.pytajPrzedZamknięciemToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zapiszPrzebiegRozmowyToolStripMenuItem
            // 
            this.zapiszPrzebiegRozmowyToolStripMenuItem.Name = "zapiszPrzebiegRozmowyToolStripMenuItem";
            this.zapiszPrzebiegRozmowyToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.zapiszPrzebiegRozmowyToolStripMenuItem.Text = "Zapisz przebieg rozmowy";
            // 
            // pytajPrzedZamknięciemToolStripMenuItem
            // 
            this.pytajPrzedZamknięciemToolStripMenuItem.Name = "pytajPrzedZamknięciemToolStripMenuItem";
            this.pytajPrzedZamknięciemToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.pytajPrzedZamknięciemToolStripMenuItem.Text = "Pytaj przed zamknięciem";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // image_pb
            // 
            this.image_pb.Location = new System.Drawing.Point(647, 43);
            this.image_pb.Name = "image_pb";
            this.image_pb.Size = new System.Drawing.Size(263, 344);
            this.image_pb.TabIndex = 3;
            this.image_pb.TabStop = false;
            // 
            // input_tb
            // 
            this.input_tb.Location = new System.Drawing.Point(23, 407);
            this.input_tb.Name = "input_tb";
            this.input_tb.Size = new System.Drawing.Size(735, 22);
            this.input_tb.TabIndex = 4;
            this.input_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_tb_KeyDown);
            // 
            // new_send_btn
            // 
            this.new_send_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.new_send_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_send_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.new_send_btn.Location = new System.Drawing.Point(764, 388);
            this.new_send_btn.Name = "new_send_btn";
            this.new_send_btn.Size = new System.Drawing.Size(146, 41);
            this.new_send_btn.TabIndex = 7;
            this.new_send_btn.Text = "Wyślij";
            this.new_send_btn.UseVisualStyleBackColor = false;
            this.new_send_btn.Click += new System.EventHandler(this.new_send_btn_Click);
            // 
            // output_lb
            // 
            this.output_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output_lb.FormattingEnabled = true;
            this.output_lb.HorizontalScrollbar = true;
            this.output_lb.IntegralHeight = false;
            this.output_lb.ItemHeight = 20;
            this.output_lb.Location = new System.Drawing.Point(23, 43);
            this.output_lb.Name = "output_lb";
            this.output_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.output_lb.Size = new System.Drawing.Size(618, 344);
            this.output_lb.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(934, 453);
            this.Controls.Add(this.output_lb);
            this.Controls.Add(this.new_send_btn);
            this.Controls.Add(this.input_tb);
            this.Controls.Add(this.image_pb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Chatbot Sławno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszPrzebiegRozmowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pytajPrzedZamknięciemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox image_pb;
        private System.Windows.Forms.TextBox input_tb;
        private System.Windows.Forms.Button new_send_btn;
        private System.Windows.Forms.ListBox output_lb;
    }
}

