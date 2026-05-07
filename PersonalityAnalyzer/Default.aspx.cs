using System;

namespace PersonalityAnalyzer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Check agar user ne dono questions ke answer diye hain
            if (string.IsNullOrEmpty(rblIllusion1.SelectedValue) || string.IsNullOrEmpty(rblIllusion2.SelectedValue))
            {
                lblResult.Text = "Please select an option for BOTH images!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            lblResult.ForeColor = System.Drawing.Color.DarkSlateBlue;
            string finalResult = "Your Personality Profile: <br/>";

            // Logic for Image 1
            if (rblIllusion1.SelectedValue == "Duck")
                finalResult += "- You have a logical and detail-oriented mind. <br/>";
            else
                finalResult += "- You are highly creative and intuitive. <br/>";

            // Logic for Image 2
            if (rblIllusion2.SelectedValue == "Faces")
                finalResult += "- You are deeply focused on people, communication, and relationships.";
            else
                finalResult += "- You appreciate structure, quiet focus, and look at the bigger picture.";

            lblResult.Text = finalResult;
        }
    }
}