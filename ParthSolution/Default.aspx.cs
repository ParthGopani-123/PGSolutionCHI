using InterviewQuestion.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParthSolution
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            House houseList = new House();
            houseList.AddTestData();

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("is Palindrom?", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Wingspan", typeof(float));

            for (int i = 0; i < houseList.Count; i++)
            {
                PetBase petBase = houseList[i];
                DataRow row1 = dt.NewRow();
                row1["Name"] = petBase.Name;
                row1["is Palindrom?"] = petBase.IsNameAPalindrome == true ? "True" : "False";
                row1["Gender"] = (petBase.Gender == Gender.Female) ? "Female" : "Male";
                row1["Age"] = petBase.Age;

                if (petBase is Bird)
                {
                    row1["Type"] = "Bird";                   
                    row1["Wingspan"] = (petBase as Bird).Wingspan;
                }
                else if (petBase is Cat)
                {          
                    row1["Type"] = "Cat"; 
                }
                else if (petBase is Dog)
                {             
                    row1["Type"] = "Dog";            
                }

                dt.Rows.Add(row1);            

            }

            gvDetails.DataSource = dt;
            gvDetails.DataBind();
        }

    }
}