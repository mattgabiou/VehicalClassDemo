namespace VehicalClassDemo
{
     partial class MainForm
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
               this.comboBoxVehicalType = new System.Windows.Forms.ComboBox();
               this.labelSelectCar = new System.Windows.Forms.Label();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // comboBoxVehicalType
               // 
               this.comboBoxVehicalType.FormattingEnabled = true;
               this.comboBoxVehicalType.Items.AddRange(new object[] {
            "Small Car",
            "Truck",
            "Suv",
            "Van",
            "Compact",
            "Sports Car"});
               this.comboBoxVehicalType.Location = new System.Drawing.Point(132, 40);
               this.comboBoxVehicalType.Name = "comboBoxVehicalType";
               this.comboBoxVehicalType.Size = new System.Drawing.Size(121, 21);
               this.comboBoxVehicalType.TabIndex = 1;
               this.comboBoxVehicalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicalType_SelectedIndexChanged);
               // 
               // labelSelectCar
               // 
               this.labelSelectCar.AutoSize = true;
               this.labelSelectCar.Location = new System.Drawing.Point(12, 48);
               this.labelSelectCar.Name = "labelSelectCar";
               this.labelSelectCar.Size = new System.Drawing.Size(114, 13);
               this.labelSelectCar.TabIndex = 2;
               this.labelSelectCar.Text = "1. Select Vehical Type";
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(539, 24);
               this.menuStrip1.TabIndex = 3;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "&File";
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
               this.helpToolStripMenuItem.Text = "&Help";
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
               this.aboutToolStripMenuItem.Text = "&About";
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(539, 83);
               this.Controls.Add(this.labelSelectCar);
               this.Controls.Add(this.comboBoxVehicalType);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "MainForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "Vehical Class Demo";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ComboBox comboBoxVehicalType;
          private System.Windows.Forms.Label labelSelectCar;
          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
     }
}

