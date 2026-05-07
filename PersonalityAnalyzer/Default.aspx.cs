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
            if (rblIllusion1.SelectedValue == "Duck")
            {
                lblResult.Text = "You saw a Duck! You are highly observant, detail-oriented, and tend to approach problems with a logical mindset.";
            }
            else if (rblIllusion1.SelectedValue == "Rabbit")
            {
                lblResult.Text = "You saw a Rabbit! You are creative, intuitive, and rely heavily on your instincts when making decisions.";
            }
            else
            {
                lblResult.Text = "Please select an option first!";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}