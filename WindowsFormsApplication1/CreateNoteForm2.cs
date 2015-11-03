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

        List<TimeSpan> timeList;
        string[] strings;
        TimeSpan[] times;

        string participantName;
        string currentDate;

        DateTimePicker arrivalTime;
        string arrivalTimeDesc;

        DateTimePicker goal1StartTime;
        string objective_cb1;
        string objective_rtb1;
        string details1_rtb;
        DateTimePicker goal1EndTime;

        DateTimePicker goal2StartTime;
        string objective_cb2;
        string objective_rtb2;
        string details2_rtb;
        DateTimePicker goal2EndTime;

        DateTimePicker goal3StartTime;
        string objective_cb3;
        string objective_rtb3;
        string details3_rtb;
        DateTimePicker goal3EndTime;

        DateTimePicker goal4StartTime;
        string objective_cb4;
        string objective_rtb4;
        string details4_rtb;
        DateTimePicker goal4EndTime;

        DateTimePicker departureTime;

        string header;
        string arrival;
        string goal1;
        string goal2;
        string goal3;
        string goal4;
        string goal1End;
        string goal2End;
        string goal3End;
        string goal4End;
        string lunch;
        string lunchEnd;
        string bathroom;
        string medication;
        string seizure;
        string tantrum;
        string departure;

        public CreateNoteForm2(string participantName, string currentDate, DateTimePicker arrivalTime, string arrivalTimeDesc,
            DateTimePicker goal1StartTime, string objective_cb1, string objective_rtb1, string details1_rtb, DateTimePicker goal1EndTime,
            DateTimePicker goal2StartTime, string objective_cb2, string objective_rtb2, string details2_rtb, DateTimePicker goal2EndTime,
            DateTimePicker goal3StartTime, string objective_cb3, string objective_rtb3, string details3_rtb, DateTimePicker goal3EndTime,
            DateTimePicker goal4StartTime, string objective_cb4, string objective_rtb4, string details4_rtb, DateTimePicker goal4EndTime,
            DateTimePicker departureTime)
        {
            this.participantName = participantName;
            this.currentDate = currentDate;

            this.arrivalTime = arrivalTime;
            this.arrivalTimeDesc = arrivalTimeDesc;

            this.goal1StartTime = goal1StartTime;
            this.goal1EndTime = goal1EndTime;
            this.objective_cb1 = objective_cb1;
            this.objective_rtb1 = objective_rtb1;
            this.details1_rtb = details1_rtb;

            this.goal2StartTime = goal2StartTime;
            this.goal2EndTime = goal2EndTime;
            this.objective_cb2 = objective_cb2;
            this.objective_rtb2 = objective_rtb2;
            this.details2_rtb = details2_rtb;

            this.goal3StartTime = goal3StartTime;
            this.goal3EndTime = goal3EndTime;
            this.objective_cb3 = objective_cb3;
            this.objective_rtb3 = objective_rtb3;
            this.details3_rtb = details3_rtb;

            this.goal4StartTime = goal4StartTime;
            this.goal4EndTime = goal4EndTime;
            this.objective_cb4 = objective_cb4;
            this.objective_rtb4 = objective_rtb4;
            this.details4_rtb = details4_rtb;

            this.departureTime = departureTime;



            InitializeComponent();

            coffeeTimeStart.Format = DateTimePickerFormat.Custom;
            coffeeTimeStart.ShowUpDown = true;

            coffeeTimeEnd.Format = DateTimePickerFormat.Custom;
            coffeeTimeEnd.ShowUpDown = true;

            lunchTimeStart.Format = DateTimePickerFormat.Custom;
            lunchTimeStart.ShowUpDown = true;

            lunchTimeEnd.Format = DateTimePickerFormat.Custom;
            lunchTimeEnd.ShowUpDown = true;

            bathroomTime.Format = DateTimePickerFormat.Custom;
            bathroomTime.ShowUpDown = true;

            medicationTime.Format = DateTimePickerFormat.Custom;
            medicationTime.ShowUpDown = true;

            seizureTime.Format = DateTimePickerFormat.Custom;
            seizureTime.ShowUpDown = true;

            tantrumTime.Format = DateTimePickerFormat.Custom;
            tantrumTime.ShowUpDown = true;


            //contract_tb.Text = progressNote;



            header = participantName + "\t \t \t \t \t" + currentDate.ToString() + "\n \n" +
                "Progress Notes are to include any daily activities, behavior issues, appointments and progress" +
                " towards goals. Place all dates in parenthesis ( ) at the beginning of note on the far left side, circle the " +
                " letter of the goal documenting on, include time beginning and ending of activity. Place signature and title after each data entry" +
                "\n \n" +

                currentDate + "\n \n";



            arrival = participantName + " arrived at the facility at " + arrivalTime.Text + " " + arrivalTimeDesc + "\n \n";

            

            goal1 = "At " + goal1StartTime.Text + " " + participantName + " began their first objective. " +
            objective_cb1 + " " + objective_rtb1 + "\n \n" + details1_rtb + " ";
            goal1End = participantName + " finished working on objective " + objective_cb1 + " at " + goal1EndTime.Text
            + "\n \n";

            goal2 = "At " + goal2StartTime.Text + " " + participantName + " started working on their second objective. " +
            objective_cb2 + " " + objective_rtb2 + "\n \n" + details2_rtb + " ";

            goal2End = participantName + " finished working on objective " + objective_cb2 + " at " + goal2EndTime.Text
             + "\n \n";


            goal3 = "At " + goal3StartTime.Text + " " + participantName + " moved on to their third objective. " +
            objective_cb3 + " " + objective_rtb3 + "\n \n" + details3_rtb + " ";



            goal3End = participantName + " finished working on objective " + objective_cb3 + " at " + goal3EndTime.Text
               + "\n \n";


            goal4 = "At " + goal4StartTime.Text + " " + participantName + " made it to their final objective. " +
            objective_cb4 + " " + objective_rtb4 + "\n \n" + details4_rtb + " ";

            

            goal4End = participantName + " finished working on objective " + objective_cb4 + " at " + goal4EndTime.Text
                + "\n \n";

            lunch = "At " + lunchTimeStart + " " + participantName + " began lunch." + " " + lunchTimeDesc + " ";

            lunchEnd = participantName + " finished lunch at " + lunchTimeEnd;

            bathroom = participantName + " had to use the bathroom at " + bathroomTime.Text + " " + bathroomTimeDesc.Text;

            medication = participantName + " had to take medication at " + medicationTime.Text + " " + medicationTimeDesc;

            seizure = participantName + " had a seizure at " + seizureTime + " " + seizureTimeDesc;

            tantrum = participantName + " had a tantrum at " + tantrumTime + " " + tantrumTimeDesc;

            departure = participantName + " got ready to leave and left the facility at " + departureTime.Text;

            previewNote_tb.Text = header + arrival + goal1 + goal1End + goal2 + goal2End + goal3 + goal3End + goal4 + goal4End + departure;



        }

        public Form RefToForm1 { get; set; }

        private void backButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.CenterToScreen();
            this.RefToForm1.Show();

        }


        private void SortTimesAndStrings()
        { 

            timeList = new List<TimeSpan>();

            timeList.Add(goal1StartTime.Value.TimeOfDay);
            timeList.Add(goal2StartTime.Value.TimeOfDay);
            timeList.Add(goal3StartTime.Value.TimeOfDay);
            timeList.Add(goal4StartTime.Value.TimeOfDay);
            timeList.Add(goal1EndTime.Value.TimeOfDay);
            timeList.Add(goal2EndTime.Value.TimeOfDay);
            timeList.Add(goal3EndTime.Value.TimeOfDay);
            timeList.Add(goal4EndTime.Value.TimeOfDay);
            timeList.Add(arrivalTime.Value.TimeOfDay);
            timeList.Add(coffeeTimeStart.Value.TimeOfDay);
            timeList.Add(lunchTimeStart.Value.TimeOfDay);
            timeList.Add(lunchTimeEnd.Value.TimeOfDay);
            timeList.Add(bathroomTime.Value.TimeOfDay);
            timeList.Add(medicationTime.Value.TimeOfDay);
            timeList.Add(seizureTime.Value.TimeOfDay);
            timeList.Add(tantrumTime.Value.TimeOfDay);

            timeList.Sort();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            times = new TimeSpan[] {goal1StartTime.Value.TimeOfDay,
                                    goal2StartTime.Value.TimeOfDay,
                                    goal3StartTime.Value.TimeOfDay,
                                    goal4StartTime.Value.TimeOfDay,
                                    goal1EndTime.Value.TimeOfDay,
                                    goal2EndTime.Value.TimeOfDay,
                                    goal3EndTime.Value.TimeOfDay,
                                    goal4EndTime.Value.TimeOfDay,
                                    arrivalTime.Value.TimeOfDay,
                                    coffeeTimeStart.Value.TimeOfDay,
                                    lunchTimeStart.Value.TimeOfDay,
                                    lunchTimeEnd.Value.TimeOfDay,
                                    bathroomTime.Value.TimeOfDay,
                                    medicationTime.Value.TimeOfDay,
                                    seizureTime.Value.TimeOfDay,
                                    tantrumTime.Value.TimeOfDay};

            strings = new string[] {goal1, goal2, goal3, goal4, goal1End, goal2End, goal3End, goal4End,
                                    arrivalTimeDesc, coffeeTimeDesc.Text, lunch, lunchEnd, bathroom, medication,
                                    seizure, tantrum};


            SortTimesAndStrings();

            int[] newOrder = new int[16];

            int index;

            for (int i = 0; i < times.Length; i++)
            {
                index = timeList.IndexOf(times[i]);
                newOrder[i] = index;
                previewNote_tb.Text += strings[newOrder[i]].ToString();
            }
            

        }

    }
}
