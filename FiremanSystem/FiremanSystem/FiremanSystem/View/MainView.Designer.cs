namespace FiremanSystem.View
{
    partial class MainView
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
            this.btnFireMan = new System.Windows.Forms.Button();
            this.btnFireTruck = new System.Windows.Forms.Button();
            this.btnAccidents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFireMan
            // 
            this.btnFireMan.Location = new System.Drawing.Point(280, 135);
            this.btnFireMan.Name = "btnFireMan";
            this.btnFireMan.Size = new System.Drawing.Size(164, 49);
            this.btnFireMan.TabIndex = 0;
            this.btnFireMan.Text = "FireMan";
            this.btnFireMan.UseVisualStyleBackColor = true;
            this.btnFireMan.Click += new System.EventHandler(this.btnFireMan_Click);
            // 
            // btnFireTruck
            // 
            this.btnFireTruck.Location = new System.Drawing.Point(280, 233);
            this.btnFireTruck.Name = "btnFireTruck";
            this.btnFireTruck.Size = new System.Drawing.Size(164, 49);
            this.btnFireTruck.TabIndex = 1;
            this.btnFireTruck.Text = "FireTruck";
            this.btnFireTruck.UseVisualStyleBackColor = true;
            this.btnFireTruck.Click += new System.EventHandler(this.btnFireTruck_Click);
            // 
            // btnAccidents
            // 
            this.btnAccidents.Location = new System.Drawing.Point(280, 314);
            this.btnAccidents.Name = "btnAccidents";
            this.btnAccidents.Size = new System.Drawing.Size(164, 48);
            this.btnAccidents.TabIndex = 2;
            this.btnAccidents.Text = "Accidents";
            this.btnAccidents.UseVisualStyleBackColor = true;
            this.btnAccidents.Click += new System.EventHandler(this.btnAccidents_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccidents);
            this.Controls.Add(this.btnFireTruck);
            this.Controls.Add(this.btnFireMan);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFireMan;
        private System.Windows.Forms.Button btnFireTruck;
        private System.Windows.Forms.Button btnAccidents;
    }
}