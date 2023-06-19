namespace Internship_PRJ
{
    partial class Screen_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_1));
            this.Fill_Survey = new System.Windows.Forms.Button();
            this.View_Survey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Survey_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fill_Survey
            // 
            this.Fill_Survey.BackColor = System.Drawing.Color.Snow;
            this.Fill_Survey.Location = new System.Drawing.Point(181, 226);
            this.Fill_Survey.Name = "Fill_Survey";
            this.Fill_Survey.Size = new System.Drawing.Size(283, 50);
            this.Fill_Survey.TabIndex = 1;
            this.Fill_Survey.Text = "Fill Survey";
            this.Fill_Survey.UseVisualStyleBackColor = false;
            this.Fill_Survey.Click += new System.EventHandler(this.Fill_Survey_Click);
            // 
            // View_Survey
            // 
            this.View_Survey.BackColor = System.Drawing.Color.Snow;
            this.View_Survey.Location = new System.Drawing.Point(160, 400);
            this.View_Survey.Name = "View_Survey";
            this.View_Survey.Size = new System.Drawing.Size(10, 11);
            this.View_Survey.TabIndex = 1;
            this.View_Survey.Text = "View Survey";
            this.View_Survey.UseVisualStyleBackColor = false;
            this.View_Survey.Click += new System.EventHandler(this.View_Survey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(289, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hi !!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Survey_data
            // 
            this.Survey_data.Location = new System.Drawing.Point(214, 300);
            this.Survey_data.Name = "Survey_data";
            this.Survey_data.Size = new System.Drawing.Size(238, 48);
            this.Survey_data.TabIndex = 4;
            this.Survey_data.Text = "Survey data";
            this.Survey_data.UseVisualStyleBackColor = true;
            this.Survey_data.Click += new System.EventHandler(this.Survey_data_Click);
            // 
            // Screen_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(709, 472);
            this.Controls.Add(this.Survey_data);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_Survey);
            this.Controls.Add(this.Fill_Survey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Screen_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Fill_Survey;
        private System.Windows.Forms.Button View_Survey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Survey_data;
    }
}

