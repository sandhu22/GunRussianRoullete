namespace GunRussianRoullete
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Spinbtn = new System.Windows.Forms.Button();
            this.Shootbtn = new System.Windows.Forms.Button();
            this.SAbtn = new System.Windows.Forms.Button();
            this.Playagainbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Russian Roullete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 308);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Loadbtn
            // 
            this.Loadbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.Loadbtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(609, 92);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(156, 50);
            this.Loadbtn.TabIndex = 2;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = false;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Spinbtn
            // 
            this.Spinbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.Spinbtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spinbtn.Location = new System.Drawing.Point(609, 157);
            this.Spinbtn.Name = "Spinbtn";
            this.Spinbtn.Size = new System.Drawing.Size(156, 50);
            this.Spinbtn.TabIndex = 3;
            this.Spinbtn.Text = "Spin";
            this.Spinbtn.UseVisualStyleBackColor = false;
            this.Spinbtn.Click += new System.EventHandler(this.spinbtn_Click);
            // 
            // Shootbtn
            // 
            this.Shootbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.Shootbtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shootbtn.Location = new System.Drawing.Point(609, 222);
            this.Shootbtn.Name = "Shootbtn";
            this.Shootbtn.Size = new System.Drawing.Size(156, 50);
            this.Shootbtn.TabIndex = 4;
            this.Shootbtn.Text = "Shoot";
            this.Shootbtn.UseVisualStyleBackColor = false;
            this.Shootbtn.Click += new System.EventHandler(this.shootbtn_Click);
            // 
            // SAbtn
            // 
            this.SAbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.SAbtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAbtn.Location = new System.Drawing.Point(599, 288);
            this.SAbtn.Name = "SAbtn";
            this.SAbtn.Size = new System.Drawing.Size(179, 50);
            this.SAbtn.TabIndex = 5;
            this.SAbtn.Text = "ShootAway";
            this.SAbtn.UseVisualStyleBackColor = false;
            this.SAbtn.Click += new System.EventHandler(this.SAbtn_Click);
            // 
            // Playagainbtn
            // 
            this.Playagainbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.Playagainbtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playagainbtn.Location = new System.Drawing.Point(609, 366);
            this.Playagainbtn.Name = "Playagainbtn";
            this.Playagainbtn.Size = new System.Drawing.Size(156, 50);
            this.Playagainbtn.TabIndex = 6;
            this.Playagainbtn.Text = "PlayAgain";
            this.Playagainbtn.UseVisualStyleBackColor = false;
            this.Playagainbtn.Click += new System.EventHandler(this.Playagainbtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Playagainbtn);
            this.Controls.Add(this.SAbtn);
            this.Controls.Add(this.Shootbtn);
            this.Controls.Add(this.Spinbtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Spinbtn;
        private System.Windows.Forms.Button Shootbtn;
        private System.Windows.Forms.Button SAbtn;
        private System.Windows.Forms.Button Playagainbtn;
    }
}