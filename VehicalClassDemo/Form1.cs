using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicalClassDemo
{
     public partial class MainForm : Form
     {
          public MainForm()
          {
               InitializeComponent();
          }

          private void comboBoxVehicalType_SelectedIndexChanged(object sender, EventArgs e)
          {
               // List the common textboxes
               ShowCommonFields();
               
          }

          // Create List to hold the data for all the Textboxes
          List<TextBox> TextBoxList = new List<TextBox>();

          // Create List to hold the data for all the Labels
          // [Used?]

          // Create List of Vehicals
          List<Vehical> ListVehicals = new List<Vehical>();

          // Methods
          private void ShowCommonFields()
          {
               // Resize Main form based on fields needed
               this.Size = new Size(555, 425);

               // ******************************************
               // Make
               // *****************************************
               // Create Make Label and Make TextBox. Horizontal is first, then Vertical
               Label labelMake = new Label();
               labelMake.Location = new Point(12, 100);
               labelMake.Text = "Enter Make";
               this.Controls.Add(labelMake);

               //TextBox textBoxMake = new TextBox();
               //textBoxMake.Location = new Point(100, 100);
               //textBoxMake.Text = "Maokai";
               // Make Textbox
               TextBoxList.Add(new TextBox()
               {
                    Location = new System.Drawing.Point(120, 100),
                    Size = new System.Drawing.Size(156, 80),
                    Text = "Ford"
               });
               this.Controls.Add(TextBoxList[0]);
               // ******** END MAKE ***********************


               // ******************************************
               // Model
               // *****************************************
               // Create Model Label and Model TextBox. Horizontal is first, then Vertical
               Label labelModel = new Label();
               labelModel.Location = new Point(12, 140);
               labelModel.Text = "Enter Model";
               this.Controls.Add(labelModel);

               TextBoxList.Add(new TextBox()
               {
                    Location = new System.Drawing.Point(120, 140),
                    Size = new System.Drawing.Size(156, 80),
                    Text = "Aerostar"
               });
               this.Controls.Add(TextBoxList[1]);
               // ******** END Model ***********************


               // ******************************************
               // Year
               // *****************************************
               // Create Year Label and Year TextBox. Horizontal is first, then Vertical
               Label labelYear = new Label();
               labelYear.Location = new Point(12, 180);
               labelYear.Text = "Enter Year";
               this.Controls.Add(labelYear);

               // Year Textbox
               TextBoxList.Add(new TextBox()
               {
                    Location = new System.Drawing.Point(120, 180),
                    Size = new System.Drawing.Size(156, 80),
                    Text = "1994"
               });
               this.Controls.Add(TextBoxList[2]);
               // ******** END Year ***********************


               // ******************************************
               // Price
               // *****************************************
               // Create Price Label and Price TextBox. Horizontal is first, then Vertical
               Label labelPrice = new Label();
               labelPrice.Location = new Point(12, 220);
               labelPrice.Text = "Enter Price";
               this.Controls.Add(labelPrice);

               // Price Textbox
               TextBoxList.Add(new TextBox()
               {
                    Location = new System.Drawing.Point(120, 220),
                    Size = new System.Drawing.Size(156, 80),
                    Text = "18000"
               });
               this.Controls.Add(TextBoxList[3]);
               // ******** END Price ***********************

               //if (comboBoxVehicalType.SelectedItem.ToString() == "Suv")
                 //   MessageBox.Show("Its SUV");

               // Add button for appropriate vehical
               // Determine what vehical type is selected in combobox
               /* Small Car(Luxuries) Truck(Tow Power) Suv(Options) Van(Passengers) Compact(MPG) Sports Car(Accelleration)
                */
               string selectedVehcialType = comboBoxVehicalType.Text;
               switch (selectedVehcialType)
               {
                    case "Suv":
                         MessageBox.Show("Suv selected");
                         break;
                    case "Small Car":
                         MessageBox.Show("Small Car selected");
                         break;
                    case "Van":
                         
                              //MessageBox.Show("Van selected");
                              // ******************************************
                              // Passengers
                              // *****************************************
                              // Create Passengers label and text box. Horizontal is first, then Vertical
                              Label labelPassengers = new Label();
                              labelPassengers.Location = new Point(12, 260);
                              labelPassengers.Text = "Passengers";
                              this.Controls.Add(labelPassengers);

                              // Passengers Textbox
                              TextBoxList.Add(new TextBox()
                              {
                                   Location = new System.Drawing.Point(120, 260),
                                   Size = new System.Drawing.Size(156, 80),
                                   //Text = "Nautilus",
                                   Visible = true
                                   
                              });
                              this.Controls.Add(TextBoxList.Last());
                              MessageBox.Show("Past adding");

                              
                         break;
                    default:
                         MessageBox.Show("Unknown selected");
                         break;
               }


               // Create the button to add the car
               Button buttonAdd = new Button();
               buttonAdd.Location = new Point(110, 300);
               buttonAdd.Text = "Add";
               this.Controls.Add(buttonAdd);
               buttonAdd.Click += new EventHandler(buttonAdd_Click);

               // Create the button to display the vehicals
               Button buttonShow = new Button();
               buttonShow.Location = new Point(240, 300);
               buttonShow.Size = new Size(100,30);
               buttonShow.Text = "Show Vehicals";
               this.Controls.Add(buttonShow);
               buttonShow.Click += new EventHandler(buttonShow_Click);

               

               // Testing redraw
               //Refresh();
               //MainForm.
               //this.Refresh();
               //this.Show();
               //this.ShowDialog();
               //this.Update();

          }// end ShowCommonFields

          private void buttonAdd_Click(object sender, EventArgs e)
          {

               
               
               // Create Vehical Object from data in fields
               createBaseVehical();

               // Clear the textboxes
               clearBoxes();
          }

          private void buttonShow_Click(object sender, EventArgs e)
          {
               //MessageBox.Show("Your clicked buttonShow");

               // Create an instance of the FormVehicalStats class
               FormVehicalStats myFormVehicalForm = new FormVehicalStats();

               //myFormVehicalForm.labelMakeData.Text = TextBoxList[0].Text.ToString();
               //myFormVehicalForm.labelMakeData.Text = ListVehicals[0].Make;
               //myFormVehicalForm.labelMakeData.Text = "Rumble";
               
               // Resize the form
               myFormVehicalForm.Size = new Size(555, 425);
               
               // Display the form
              // myFormVehicalForm.ShowDialog();



               foreach (Vehical automobile in ListVehicals)
               {
                    myFormVehicalForm.labelMakeData.Text = automobile.Make;
                    myFormVehicalForm.labelModelData.Text = automobile.Model;
                    myFormVehicalForm.labelPriceData.Text = automobile.Price;
                    myFormVehicalForm.labelYearData.Text = automobile.Year;  
  
                    // Add Vehical Specific Information
                    // Determine what vehical type is selected in combobox
                    /* Small Car(Luxuries) Truck(Tow Power) Suv(Options) Van(Passengers) Compact(MPG) Sports Car(Accelleration)
                    */
                    string selectedVehcialType = comboBoxVehicalType.Text;
                    switch (selectedVehcialType)
                    {
                         case "Van":
                              // Create Passengers label. Horizontal is first, then Vertical
                              Label labelPassengersShow = new Label();
                              labelPassengersShow.Location = new Point(12, 130);
                              labelPassengersShow.AutoSize = true;
                              labelPassengersShow.Text = "Passengers:";
                              myFormVehicalForm.Controls.Add(labelPassengersShow);

                              // Create Passengers label with value
                              Label labelPassengersShowAmount = new Label();
                              labelPassengersShowAmount.Location = new Point(90, 130);
                              labelPassengersShowAmount.Text = "Goomba";
                              //labelPassengersShowAmount.Text = TextBoxList[4].Text;
                              myFormVehicalForm.Controls.Add(labelPassengersShowAmount);
                              break;
                         default:
                              
                              
                              break;

                    
                    }
                    // Display the data on each vehical
                    myFormVehicalForm.ShowDialog();
               }

               

              
          }
          private void clearBoxes()
          {
               int textBoxCount = TextBoxList.Count;
               for (int i = 0; i < textBoxCount; i++)
               {
                    TextBoxList[i].Text = "";

               }
               
               // Set the textboxes to something after the clear
               TextBoxList[0].Text = "Ford";
               //TextBoxList[1].Text = "";
               //TextBoxList[2].Text = "";
               //TextBoxList[3].Text = "";
               
               Refresh();
          }

          private void createBaseVehical()
          {
               // Determine what vehical type is selected in combobox
               /* Small Car(Luxuries) Truck(Tow Power) Suv(Options) Van(Passengers) Compact(MPG) Sports Car(Accelleration)
                */
               string selectedVehcialType = comboBoxVehicalType.Text;
               switch (selectedVehcialType)
               {
                    case "Van":
                         ListVehicals.Add(new VehicalVan()
                         {
                              Make = TextBoxList[0].Text,
                              Model = TextBoxList[1].Text,
                              Year = TextBoxList[2].Text,
                              Price = TextBoxList[3].Text,
                              Passengers = int.Parse(TextBoxList[4].Text)
                         });
                         break;
                    default:
                         ListVehicals.Add(new Vehical()
                         {
                              Make = TextBoxList[0].Text,
                              Model = TextBoxList[1].Text,
                              Year = TextBoxList[2].Text,
                              Price = TextBoxList[3].Text
                         });
                         break;
               }
          }
     }
}
