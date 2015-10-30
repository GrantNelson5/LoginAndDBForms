using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreateNoteForm2 : Form
    {
        public CreateNoteForm2(string participantName, string currentDate, DateTimePicker arrivalTime, string arrivalTimeDesc, 
            DateTimePicker goal1StartTime, string objective_cb1, string objective_rtb1, string details1_rtb, DateTimePicker goal1EndTime,
            DateTimePicker goal2StartTime, string objective_cb2, string objective_rtb2, string details2_rtb, DateTimePicker goal2EndTime,
            DateTimePicker goal3StartTime, string objective_cb3, string objective_rtb3, string details3_rtb, DateTimePicker goal3EndTime,
            DateTimePicker goal4StartTime, string objective_cb4, string objective_rtb4, string details4_rtb, DateTimePicker goal4EndTime,
            DateTimePicker departureTime, string departureTimeDesc )
        {
            InitializeComponent();
            //contract_tb.Text = progressNote;

            string test;
            test = participantName + "\t \t \t \t \t" + currentDate.ToString() + "\n \n" +
                "Progress Notes are to include any daily activities, behavior issues, appointments and progress" +
                " towards goals. Place all dates in parenthesis ( ) at the beginning of note on the far left side, circle the " +
                " letter of the goal documenting on, include time beginning and ending of activity. Place signature and title after each data entry" +
                "\n \n" +

                currentDate + "\n \n" +

                 participantName + " arrived at the facility at " + arrivalTime.Text + arrivalTimeDesc + "\n \n" +

                "At " + goal1StartTime.Text + " " + participantName + " began their first objective. " +
                objective_cb1 + " " + objective_rtb1 + "\n \n" + details1_rtb + " " +
                participantName + " finished working on objective " + objective_cb1 + " at " + goal1EndTime.Text
                + "\n \n" +

                "At " + goal2StartTime.Text + " " + participantName + " started working on their second objective. " +
                objective_cb2 + " " + objective_rtb2 + "\n \n" + details2_rtb + " " +
                participantName + " finished working on objective " + objective_cb2 + " at " + goal2EndTime.Text
                + "\n \n" +


                "At " + goal3StartTime.Text + " " + participantName + " moved on to their third objective. " +
                objective_cb3 + " " + objective_rtb3 + "\n \n" + details3_rtb + " " +
                participantName + " finished working on objective " + objective_cb3 + " at " + goal3EndTime.Text
                + "\n \n" +


                "At " + goal4StartTime.Text + " " + participantName + " made it to their final objective. " +
                objective_cb4 + " " + objective_rtb4 + "\n \n" + details4_rtb + " " +
                participantName + " finished working on objective " + objective_cb4 + " at " + goal4EndTime.Text
                + "\n \n" +

                departureTimeDesc + participantName + " got ready to leave and left the facility at " + departureTime.Text;

            previewNote_tb.Text = test;

        }

        public Form RefToForm1 { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefToForm1.Show();
        }
    }
}
