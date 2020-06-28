/*  This program is a unit converter and helps the average person convert between units they may use in daily life.
 *  It can convert 3 different types of values to their SI unit and back. 
 *  For Length, the program can convert from miles, yards and feet to kilometers and viceversa.
 *  For Mass, the program can convert from pounds, ounces and carats to kilograms and viceversa.
 *  For Temperature, the program can convert from Farenheit and Kelvin to Celcius and viceversa. Although Celcius is not the SI unit for temperature, 
 *  it is very commonly used in Canada and that is why I chose to deviate to this option.
 *  My program changes colours for a few seconds when you first start up the program and that is the special feature in my program.
 *  The interesting part of the project was actually constructing the program. This is because I got to learn a new program on my own and actually apply it.
 *  The most challenging aspect of the project was figuring out how to switch between panels. It took me quite a while to understand that panels have an 
 *  order to them and that moving them changes the order they are placed in. Figuring out how to switch between panels was undeniably the hardest part of the 
 *  project.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double convertedValue = 0;
        string ft = " ";            // These global variables store different values before implementing them in methods.
        string meter = " ";
        string yard = " ";
        string miles = " ";
        string ounce = " ";
        string kilo = " ";
        string pound = " ";
        string carat = " ";
        string farenheit = " ";
        string celcius = " ";
        string kelvin = " ";
        int i = 0;  // integer to define the timer
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lengthPanel.Visible = true; // change panels
            
        }

        
        private void feetButton_Click(object sender, EventArgs e)
        {
            feetPanel.Visible = true;
           
        }

        private void p1_Click(object sender, EventArgs e)   // 'p' refers to the previous button and switch panels.
        {
            lengthPanel.Visible = false;                        // goes back to the main menu with the different types of conversions
        }
        private void p2_Click(object sender, EventArgs e)
        {
            feetPanel.Visible = false;                          // goes back to the length conversions panel from the feet panel.
            lengthPanel.Visible = true;
        }
        private void p3_Click(object sender, EventArgs e)
        {
            lengthPanel.Visible = true;                         // goes back to the length conversions panel from the yard panel.
            yardPanel.Visible = false;
        }
        private void p4_Click(object sender, EventArgs e)
        {
            milesPanel.Visible = false;                         // goes back to the length conversions panel from the miles panel.
            lengthPanel.Visible = true;
        }
        private void p5_Click(object sender, EventArgs e)
        {
            massPanel.Visible = false;
            lengthPanel.Visible = false;                        // goes back to the main panel with the different types of conversions
        }
        private void p6_Click(object sender, EventArgs e)
        {
            massPanel.Visible = true;                       // goes back to the panel with the different mass conversions from the ounce panel.
            ouncePanel.Visible = false;
        }

        private void p7_Click(object sender, EventArgs e)   // goes back to the panel with the different mass conversions from the pound panel
        {
            poundPanel.Visible = false;
            massPanel.Visible = true;
        }
        private void p8_Click(object sender, EventArgs e)   //goes back to the panel with the different mass conversions from the carat panel.
        {
            massPanel.Visible = true;
            caratPanel.Visible = false;
        }
        private void p9_Click(object sender, EventArgs e)   // goes back to the main menu with Length, Mass and Temp.
        {
            tempPanel.Visible = false;
            lengthPanel.Visible = false;
            massPanel.Visible = false;
        }

        private void p10_Click(object sender, EventArgs e)  // Goes back to the panel with temperature conversions from the farenheit panel.
        {
            farenheitPanel.Visible = false;
            tempPanel.Visible = true;
        }
        private void p11_Click(object sender, EventArgs e)  // Goes back to the panel with temperature conversions from the kelvin panel.   
        {
            tempPanel.Visible = true;
            kelvinPanel.Visible = false;
        }

        private void yardButton_Click(object sender, EventArgs e)
        {
            yardPanel.Visible = true;                           // switches to the panel with the yard conversions.
                
        }
        private void milesButton_Click(object sender, EventArgs e)
        {
            milesPanel.Visible = true;                          // switches to the panel with the miles conversions.
        }

        private void ounceButton_Click(object sender, EventArgs e)
        {
            ouncePanel.Visible = true;                          // switches to the panel with the ounce conversions.
        }
       
        private void massButton_Click(object sender, EventArgs e)
        {
            massPanel.Visible = true;                           // switches to the panel that shows options for mass conversions
            lengthPanel.Visible = false;
        }
        private void poundButton_Click(object sender, EventArgs e) // switches to the panel with the pound conversions
        {
            poundPanel.Visible = true;
            ouncePanel.Visible = false;
        }
        private void caratButton_Click(object sender, EventArgs e) // switches to the panel with carat conversions
        {
            caratPanel.Visible = true;
            ouncePanel.Visible = false;
            poundPanel.Visible = false;
        }
        private void tempButton_Click(object sender, EventArgs e)   // switches to the panel with the temperature conversions
        {
            tempPanel.Visible = true;
            lengthPanel.Visible = false;

        }
        private void fButton_Click(object sender, EventArgs e)      // switches to the panel with the farenheit conversions
        {       
            farenheitPanel.Visible = true;

        }
        private void kButton_Click(object sender, EventArgs e)
        {
            kelvinPanel.Visible = true;
            farenheitPanel.Visible = false;
        }

        //Length Conversions
        // From here starts the code for Feet to Meter
        private void feetBox_TextChanged(object sender, EventArgs e)
        {
            string feet = feetBox.Text;         // get input and then store it in the global variable
            ft = feet; 

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            
            double num = convertFToM(ft);           // call the convert method when the 'Convert' button is clicked
            convertedValue = num;
            meterBox.Text = convertedValue.ToString(); // convert to string so that I can output it
        }

        private double convertFToM(string feet)
        {
            
            double num = Convert.ToDouble(feet); // Convert the inputted feet, that is in string form, to double.
            double answer = num / 3.28;             // 1 meter = 3.28 ft
            return answer;
        }
        // From here the code for M to Ft starts
        private void meterText_TextChanged(object sender, EventArgs e)
        {
            string m = meterText.Text;
            meter = m;
        }

        private double convertMToF(string meter)
        {
            double num = Convert.ToDouble(meter);
            double answer = num * 3.28;
            return answer;
        }

        private void mToFButton_Click(object sender, EventArgs e)
        {
            double num = convertMToF(meter);
            convertedValue = num;
            feetText.Text = convertedValue.ToString();
        }
        //Conversion from Yards to Meters code starts here
        

        private void ydToM_Click(object sender, EventArgs e)
        {
            double num = convertYdToM(yard);        
            convertedValue = num;
            mBox.Text = convertedValue.ToString();
        }

        private double convertYdToM(string yard)
        {
            double num = Convert.ToDouble(yard);
            double answer = num * 0.9144;       // conversion to meters
            return answer;
        }

        private void ydBox_TextChanged(object sender, EventArgs e)
        {
            string yd = ydBox.Text;
            yard = yd;
        }
       // Conversion from Meters to Yards code starts here
        private void mToYd_Click(object sender, EventArgs e)
        {
            double num = convertMToYd(meter);
            convertedValue = num;
            yardBox.Text = convertedValue.ToString();
        }

        private double convertMToYd(string meter)
        {
            double num = Convert.ToDouble(meter);
            double answer = num * 1.094;
            return answer;
        }

        private void mtBox_TextChanged(object sender, EventArgs e)
        {
            string m = mtBox.Text;
            meter = m;
        }
        // Miles to Meters Conversion Code starts here
        private void mlToMt_Click(object sender, EventArgs e)
        {
            double num = convertmlToMt(miles);
            convertedValue = num;
            metBox.Text = convertedValue.ToString();
        }

        private double convertmlToMt(string miles)
        {
            double num = Convert.ToDouble(miles);
            double answer = num * 1609;
            return answer;
        }

        private void mlBox_TextChanged(object sender, EventArgs e)
        {
            string ml = mlBox.Text;
            miles = ml;
        }
        //Conversion from Meters to Miles code starts here
        private void mtToMl_Click(object sender, EventArgs e)
        {
            double num = convertMtToMl(meter);
            convertedValue = num;
            milesBox.Text = convertedValue.ToString();
        }

        private double convertMtToMl(string meter)
        {
            double num = Convert.ToDouble(meter);
            double answer = num / 1609;
            return answer;
        }

        private void metersBox_TextChanged(object sender, EventArgs e)
        {
            string m = metersBox.Text;
            meter = m;
        }
        // Mass Conversions

        // Ounce to Kg code starts here

        private void ozToKg_Click(object sender, EventArgs e)
        {
            double num = convertOzToKg(ounce);
            convertedValue = num;
            kgBox.Text = convertedValue.ToString();
        }
        private double convertOzToKg(string ounce)
        {
            double num = Convert.ToDouble(ounce);
            double answer = num / 35.274;
            return answer;
        }

        private void oBox_TextChanged(object sender, EventArgs e)
        {
            string o = oBox.Text;
            ounce = o;
        }
        //Code for Kg to Ounce starts here.
        private void kgToOz_Click(object sender, EventArgs e)
        {
            double num = convertKgToOz(kilo);
            convertedValue = num;
            ozBox.Text = convertedValue.ToString();
        }
        
        private double convertKgToOz(string kilo)
        {
            double num = Convert.ToDouble(kilo);
            double answer = num * 35.274;
            return answer; 
        }

        private void kiloBox_TextChanged(object sender, EventArgs e)
        {
            string k = kiloBox.Text;
            kilo = k;
        }
        //Convert Lb to Kg Code starts here
        private void lbToKg_Click(object sender, EventArgs e)
        {
            double num = convertLbToKg(pound);
            convertedValue = num;
            kilosBox.Text = convertedValue.ToString();
        }

        private double convertLbToKg(string pound)
        {
            double num = Convert.ToDouble(pound);
            double answer = num / 2.205;
            return answer;
        }
        private void lbBox_TextChanged(object sender, EventArgs e)
        {
            string l = lbBox.Text;
            pound = l;
        }

        // Kg to Lb Code Starts here
        private void kgToLb_Click(object sender, EventArgs e)
        {
            double num = convertKgToLb(kilo);
            convertedValue = num;
            poundBox.Text = convertedValue.ToString();
        }

        private double convertKgToLb(string kilo)
        {
            double num = Convert.ToDouble(kilo);
            double answer = num * 2.205;
            return answer;
        }

        private void kBox_TextChanged(object sender, EventArgs e)
        {
            string k = kBox.Text;
            kilo = k;
        }
        // Code for carat to kg
        private void ctToKg_Click(object sender, EventArgs e)
        {
            double num = convertCtToKg(carat);
            convertedValue = num;
            kiloText.Text = convertedValue.ToString();
        }
        
        private double convertCtToKg(string carat)
        {
            double num = Convert.ToDouble(carat);
            double answer = num / 5000;
            return answer;
        }

        private void ctBox_TextChanged(object sender, EventArgs e)
        {
            string c = ctBox.Text;
            carat = c;
        }
        //Code for kg to carat
        private void kgToCt_Click(object sender, EventArgs e)
        {
            double num = convertKgToCt(kilo);
            convertedValue = num;
            caratBox.Text = convertedValue.ToString();
        }
        private double convertKgToCt(string kilo)
        {
            double num = Convert.ToDouble(kilo);
            double answer = num * 5000;
            return answer;
        }

        private void kgText_TextChanged(object sender, EventArgs e)
        {
            string k = kgText.Text;
            kilo = k;
        }
        // Temperature Conversions
        //Farenheit to Celcius conversion code starts here
        private void fToC_Click(object sender, EventArgs e)
        {
            double num = convertFToC(farenheit);
            convertedValue = num;
            cBox.Text = convertedValue.ToString();
        }

        private double convertFToC(string farenheit)
        {
            double num = Convert.ToDouble(farenheit);
            double answer = (num - 32) * (0.55);
            return answer;
        }

        private void fBox_TextChanged(object sender, EventArgs e)
        {
            string f = fBox.Text;
            farenheit = f;
        }

        //code for celcius to farenheit starts here
        private void cToF_Click(object sender, EventArgs e)
        {
            double num = convertCToF(celcius);
            convertedValue = num;
            fText.Text = convertedValue.ToString();
        }
        private double convertCToF(string celcius)
        {
            double num = Convert.ToDouble(celcius);
            double answer = (num * (1.8)) + 32;
            return answer;
        }

        private void cText_TextChanged(object sender, EventArgs e)
        {
            string c = cText.Text;
            celcius = c;
        }

        //Code for Kelvin to Celcius
        private void kToC_Click(object sender, EventArgs e)
        {
            double num = convertKToC(kelvin);
            convertedValue = num;
            celBox.Text = convertedValue.ToString();
        }
        private double convertKToC(string kelvin)
        {
            double num = Convert.ToDouble(kelvin);
            double answer = num - 273.15;
            return answer;
        }
        private void kelBox_TextChanged(object sender, EventArgs e)
        {
            string k = kelBox.Text;
            kelvin = k;
        }
        //code for Celcius to Kelvin
        private void cToK_Click(object sender, EventArgs e)
        {
            double num = convertCToK(celcius);
            convertedValue = num;
            kelText.Text = convertedValue.ToString();
        }
        private double convertCToK(string celcius)
        {
            double num = Convert.ToDouble(celcius);
            double answer = num + 273.15;
            return answer;
        }
        private void celText_TextChanged(object sender, EventArgs e)
        {
            string c = celText.Text;
            celcius = c;
        }

        private void timer_Tick(object sender, EventArgs e)     // this method starts the switch between colours when you first start the program.
        {
            if(i%2 == 0)
            {
                this.BackColor = Color.LightSteelBlue;
                i++;
            }
            else
            {
                this.BackColor = Color.LimeGreen;
                i++;
            }
            if(i == 4)
            {
                timer.Enabled = false;
            }
            
        }

      

       
    }
}
