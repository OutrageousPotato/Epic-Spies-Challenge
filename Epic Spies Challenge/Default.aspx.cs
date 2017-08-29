using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epic_Spies_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                oldAssignmentEnd.SelectedDate = oldAssignmentEnd.TodaysDate;
                newAssignmentStart.SelectedDate = newAssignmentStart.TodaysDate.AddDays(14);
                newAssignmentEnd.SelectedDate = newAssignmentEnd.TodaysDate.AddDays(21);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            DateTime oldEnd = oldAssignmentEnd.SelectedDate;
            DateTime newStart = newAssignmentStart.SelectedDate;
            DateTime newEnd = newAssignmentEnd.SelectedDate;

            TimeSpan missionSpan = newEnd.Subtract(newStart);
            TimeSpan vacationSpan = newStart.Subtract(oldEnd);

            if (vacationSpan.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks " +
                    "between previous assignment and new assignment.";

                newAssignmentStart.SelectedDate = newAssignmentStart.SelectedDate.AddDays(14 - vacationSpan.TotalDays);
                newAssignmentStart.VisibleDate = newAssignmentStart.SelectedDate;
            }

            else
            {
                double totalMissionDays = missionSpan.TotalDays;
                double missionCost = 500 * totalMissionDays;

                if (totalMissionDays > 21)
                {
                    missionCost += 1000;
                }

                resultLabel.Text = String.Format("Assignment of " +
                    "{0} to assignment " +
                    "{1} is authorized. Budget total: " +
                    "{2:C}",
                    nameTextBox.Text,
                    assignmentTextBox.Text,
                    missionCost);

            }
        }   
        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}