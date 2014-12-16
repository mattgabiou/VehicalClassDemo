namespace VehicalClassDemo
{
     partial class FormVehicalStats
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
               this.labelMake = new System.Windows.Forms.Label();
               this.labelMakeData = new System.Windows.Forms.Label();
               this.labelModel = new System.Windows.Forms.Label();
               this.labelModelData = new System.Windows.Forms.Label();
               this.labelYear = new System.Windows.Forms.Label();
               this.labelYearData = new System.Windows.Forms.Label();
               this.labelPrice = new System.Windows.Forms.Label();
               this.labelPriceData = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // labelMake
               // 
               this.labelMake.AutoSize = true;
               this.labelMake.Location = new System.Drawing.Point(13, 13);
               this.labelMake.Name = "labelMake";
               this.labelMake.Size = new System.Drawing.Size(37, 13);
               this.labelMake.TabIndex = 0;
               this.labelMake.Text = "Make:";
               // 
               // labelMakeData
               // 
               this.labelMakeData.AutoSize = true;
               this.labelMakeData.Location = new System.Drawing.Point(54, 13);
               this.labelMakeData.Name = "labelMakeData";
               this.labelMakeData.Size = new System.Drawing.Size(0, 13);
               this.labelMakeData.TabIndex = 1;
               // 
               // labelModel
               // 
               this.labelModel.AutoSize = true;
               this.labelModel.Location = new System.Drawing.Point(11, 44);
               this.labelModel.Name = "labelModel";
               this.labelModel.Size = new System.Drawing.Size(39, 13);
               this.labelModel.TabIndex = 2;
               this.labelModel.Text = "Model:";
               // 
               // labelModelData
               // 
               this.labelModelData.AutoSize = true;
               this.labelModelData.Location = new System.Drawing.Point(56, 44);
               this.labelModelData.Name = "labelModelData";
               this.labelModelData.Size = new System.Drawing.Size(0, 13);
               this.labelModelData.TabIndex = 3;
               // 
               // labelYear
               // 
               this.labelYear.AutoSize = true;
               this.labelYear.Location = new System.Drawing.Point(13, 71);
               this.labelYear.Name = "labelYear";
               this.labelYear.Size = new System.Drawing.Size(32, 13);
               this.labelYear.TabIndex = 4;
               this.labelYear.Text = "Year:";
               // 
               // labelYearData
               // 
               this.labelYearData.AutoSize = true;
               this.labelYearData.Location = new System.Drawing.Point(54, 71);
               this.labelYearData.Name = "labelYearData";
               this.labelYearData.Size = new System.Drawing.Size(0, 13);
               this.labelYearData.TabIndex = 5;
               // 
               // labelPrice
               // 
               this.labelPrice.AutoSize = true;
               this.labelPrice.Location = new System.Drawing.Point(13, 98);
               this.labelPrice.Name = "labelPrice";
               this.labelPrice.Size = new System.Drawing.Size(34, 13);
               this.labelPrice.TabIndex = 6;
               this.labelPrice.Text = "Price:";
               // 
               // labelPriceData
               // 
               this.labelPriceData.AutoSize = true;
               this.labelPriceData.Location = new System.Drawing.Point(53, 98);
               this.labelPriceData.Name = "labelPriceData";
               this.labelPriceData.Size = new System.Drawing.Size(0, 13);
               this.labelPriceData.TabIndex = 7;
               // 
               // FormVehicalStats
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(284, 262);
               this.Controls.Add(this.labelPriceData);
               this.Controls.Add(this.labelPrice);
               this.Controls.Add(this.labelYearData);
               this.Controls.Add(this.labelYear);
               this.Controls.Add(this.labelModelData);
               this.Controls.Add(this.labelModel);
               this.Controls.Add(this.labelMakeData);
               this.Controls.Add(this.labelMake);
               this.Name = "FormVehicalStats";
               this.Text = "FormVehicalStats";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label labelMake;
          private System.Windows.Forms.Label labelModel;
          private System.Windows.Forms.Label labelYear;
          private System.Windows.Forms.Label labelPrice;
          internal System.Windows.Forms.Label labelMakeData;
          internal System.Windows.Forms.Label labelModelData;
          internal System.Windows.Forms.Label labelYearData;
          internal System.Windows.Forms.Label labelPriceData;
     }
}