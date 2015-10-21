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
        public CreateNoteForm1()
        {
            InitializeComponent();

            /******************************************
            * This is converting the date time picker 
            * format to time only
            *******************************************/

            goal1StartTime.Format = DateTimePickerFormat.Time;
            goal1StartTime.ShowUpDown = true;

            goal1EndTime.Format = DateTimePickerFormat.Time;
            goal1EndTime.ShowUpDown = true;

            goal2StartTime.Format = DateTimePickerFormat.Time;
            goal2StartTime.ShowUpDown = true;

            goal2EndTime.Format = DateTimePickerFormat.Time;
            goal2EndTime.ShowUpDown = true;

            goal3StartTime.Format = DateTimePickerFormat.Time;
            goal3StartTime.ShowUpDown = true;

            goal3EndTime.Format = DateTimePickerFormat.Time;
            goal3EndTime.ShowUpDown = true;

            goal4StartTime.Format = DateTimePickerFormat.Time;
            goal4StartTime.ShowUpDown = true;

            goal4EndTime.Format = DateTimePickerFormat.Time;
            goal4EndTime.ShowUpDown = true;

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
                readFile = File.OpenText("Test.txt");
                while ((numberLine = readFile.ReadLine()) != null)
                {
                    count++;
                }

                readFile.Close();

                readFile = File.OpenText("Test.txt");

                for (int i = 0; i < count; i++)
                {
                    string line = readFile.ReadLine();
                    contract_tb.Text += line + "\n";
                }
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
                    

                    /************************************************************
                    * Drashtee this is where the file gets saved as a .txt files
                    * named Test, we need it to be saved as something that changes
                    * so that we dont get the file is in use by another process
                    * error, do this however you see fit. To test if it works, 
                    * open 1 contract and then try to open another after the first
                    * contract is successfully loaded
                    *************************************************************/

                    //Save doc file to a txt format.

                    document.SaveToFile("Test.txt", FileFormat.Txt);
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

                document.LoadFromFile("Test.txt");
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
    }

}

