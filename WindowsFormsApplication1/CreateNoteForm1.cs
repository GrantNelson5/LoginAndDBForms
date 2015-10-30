using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class CreateNoteForm1 : Form
    {

        string docToTxtName;

        

        public CreateNoteForm1()
        {
            InitializeComponent();

            /******************************************
            * This is converting the date time picker 
            * format to time only
            *******************************************/

            goal1StartTime.Format = DateTimePickerFormat.Custom;
            goal1StartTime.ShowUpDown = true;

            goal1EndTime.Format = DateTimePickerFormat.Custom;
            goal1EndTime.ShowUpDown = true;

            goal2StartTime.Format = DateTimePickerFormat.Custom;
            goal2StartTime.ShowUpDown = true;

            goal2EndTime.Format = DateTimePickerFormat.Custom;
            goal2EndTime.ShowUpDown = true;

            goal3StartTime.Format = DateTimePickerFormat.Custom;
            goal3StartTime.ShowUpDown = true;

            goal3EndTime.Format = DateTimePickerFormat.Custom;
            goal3EndTime.ShowUpDown = true;

            goal4StartTime.Format = DateTimePickerFormat.Custom;
            goal4StartTime.ShowUpDown = true;

            goal4EndTime.Format = DateTimePickerFormat.Custom;
            goal4EndTime.ShowUpDown = true;

            arrivalTime.Format = DateTimePickerFormat.Custom;
            arrivalTime.ShowUpDown = true;

            departureTime.Format = DateTimePickerFormat.Custom;
            departureTime.ShowUpDown = true;

        }

        /**********************************************
        * Creating the streamReader to read and write
        * to files and saving the file name
        ***********************************************/

        StreamReader readFile;
        StreamReader openFile;
        string fileName;

       
        
        /**********************************************************
        * This is the method that send the text from the word doc
        * to the contract_tb control it reads from the text file 
        * created in the importButton_Click event handler method
        ***********************************************************/
        private void TextToBox()
        {
            
            try
            {

                string numberLine;
                int count = 0;
                readFile = File.OpenText(docToTxtName);
                while ((numberLine = readFile.ReadLine()) != null)
                {
                    count++;
                }

                readFile.Close();

                readFile = File.OpenText(docToTxtName);

                for (int i = 0; i < count; i++)
                {
                    string line = readFile.ReadLine();
                    contract_tb.Text += line + "\n";
                }

                readFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read:");
                MessageBox.Show(ex.Message);

            }

        }
        

        private void importButton_Click(object sender, EventArgs e)
        {
            // clears the textbox before a contract is loaded

            contract_tb.Clear();

            // opening the openfiledialog1 control to allow the user to select a file

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                   {
                       try
                       {

                           //Create a document object

                           Document document = new Document();

                           document.LoadFromFile(openFileDialog1.FileName);

                    docToTxtName = openFileDialog1.FileName + ".txt";

                    //Save doc file to a txt format.

                    document.SaveToFile(docToTxtName, FileFormat.Txt);

                    document.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("The file could not be read: " + ex.Message);
                            }

                TextToBox();

            }
        }

        
        /*******************************************************************************
        * This is a test button labeled "save as pdf" on the create new progress note form
        * This is the code to load from a file and read from that file to a new fileformat
        ********************************************************************************/

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Document document = new Document();

                document.LoadFromFile(docToTxtName);
                document.SaveToFile("PDFTest.pdf", FileFormat.PDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be saved: " + ex.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contract_tb.Copy();
    }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            objective1_rtb.Copy();
            /*objective2_rtb.Copy();
            objective3_rtb.Copy();
            objective4_rtb.Copy();
            details1_rtb.Copy();
            details2_rtb.Copy();
            details3_rtb.Copy();
            details4_rtb.Copy();
            contract_tb.Copy();*/
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objective1_rtb.Cut();
            /*objective2_rtb.Cut();
            objective3_rtb.Cut();
            objective4_rtb.Cut();
            details1_rtb.Cut();
            details2_rtb.Cut();
            details3_rtb.Cut();
            details4_rtb.Cut();
            contract_tb.Cut();*/
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objective1_rtb.Paste();
            /*objective2_rtb.Paste();
            objective3_rtb.Paste();
            objective4_rtb.Paste();
            details1_rtb.Paste();
            details2_rtb.Paste();
            details3_rtb.Paste();
            details4_rtb.Paste();
            contract_tb.Paste();*/
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            contract_tb.Clear();
            string test;
            test = participantName_tb.Text + "\t \t \t \t \t" + CurrentDateTime_CF1.Text + "\n \n" +
                "Progress Notes are to include any daily activities, behavior issues, appointments and progress" +
                " towards goals. Place all dates in parenthesis ( ) at the beginning of note on the far left side, circle the " +
                " letter of the goal documenting on, include time beginning and ending of activity. Place signature and title after each data entry" +
                "\n \n" +
                
                CurrentDateTime_CF1.Text + "\n \n" +  

                 participantName_tb.Text + " arrived at the facility at " + arrivalTime.Text + arrivalTimeDesc_tb.Text + "\n \n" +

                "At " + goal1StartTime.Text + " " + participantName_tb.Text + " began their first objective. " + 
                objective_cb1.Text + " " + objective1_rtb.Text + "\n \n" + details1_rtb.Text + " " +
                participantName_tb.Text + " finished working on objective " + objective_cb1.Text + " at " + goal1EndTime.Text 
                + "\n \n" +

                "At " + goal2StartTime.Text + " " + participantName_tb.Text + " started working on their second objective. " +
                objective_cb2.Text + " " + objective2_rtb.Text + "\n \n" + details2_rtb.Text + " " +
                participantName_tb.Text + " finished working on objective " + objective_cb2.Text + " at " + goal2EndTime.Text
                + "\n \n" +


                "At " + goal3StartTime.Text + " " + participantName_tb.Text + " moved on to their third objective. " +
                objective_cb3.Text + " " + objective3_rtb.Text + "\n \n" + details3_rtb.Text + " " +
                participantName_tb.Text + " finished working on objective " + objective_cb3.Text + " at " + goal3EndTime.Text
                + "\n \n" +


                "At " + goal4StartTime.Text + " " + participantName_tb.Text + " made it to their final objective. " +
                objective_cb4.Text + " " + objective4_rtb.Text + "\n \n" + details4_rtb.Text + " " +
                participantName_tb.Text + " finished working on objective " + objective_cb4.Text + " at " + goal4EndTime.Text
                + "\n \n" +

                departureTimeDesc_tb.Text + participantName_tb.Text + " got ready to leave and left the facility at " + departureTime.Text ;

            CreateNoteForm2 nextStep = new CreateNoteForm2(participantName_tb.Text, CurrentDateTime_CF1.Text, arrivalTime, arrivalTimeDesc_tb.Text,
                goal1StartTime, objective_cb1.Text, objective1_rtb.Text, details1_rtb.Text, goal1EndTime,
                goal2StartTime, objective_cb1.Text, objective2_rtb.Text, details1_rtb.Text, goal2EndTime,
                goal3StartTime, objective_cb1.Text, objective3_rtb.Text, details1_rtb.Text, goal3EndTime,
                goal4StartTime, objective_cb1.Text, objective4_rtb.Text, details1_rtb.Text, goal4EndTime,
                departureTime, departureTimeDesc_tb.Text);

            nextStep.RefToForm1 = this;
            this.Visible = false;
            nextStep.Show();
        }

        private void CreateNoteForm1_Load(object sender, EventArgs e)
        {
            CurrentDateTime_CF1.Value = DateTime.Now;
            CurrentDateTime_CF1.Format = DateTimePickerFormat.Custom;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            contract_tb.Clear();
        }

        private void clearFromButton_Click(object sender, EventArgs e)
        {
            arrivalTimeDesc_tb.Clear();
            departureTimeDesc_tb.Clear();
            participantName_tb.Clear();
            details1_rtb.Clear();
            details2_rtb.Clear();
            details3_rtb.Clear();
            details4_rtb.Clear();
            objective1_rtb.Clear();
            objective2_rtb.Clear();
            objective3_rtb.Clear();
            objective4_rtb.Clear();
        }
    }

}

