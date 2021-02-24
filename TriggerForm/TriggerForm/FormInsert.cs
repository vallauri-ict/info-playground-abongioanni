using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TriggerForm
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
            int maxYear = DateTime.Now.Year - 18;
            int maxMonth = DateTime.Now.Month;
            int maxDay = DateTime.Now.Day;
            if (maxDay == 29 && maxMonth == 2)
            {
                maxDay--;
            }
            dtp.MaxDate = Convert.ToDateTime($"{maxYear}-{maxMonth}-{maxDay}");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string country;
            if (txtCountry.isNull().ToString() == "NULL")
            {
                country = "'IT'";
            }
            else
            {
                country = txtCountry.isNull().ToString();
            }
            string sql = $"INSERT INTO Driver(number, full_name, country, date_birth, team_id, podiums_number) " +
                         $"VALUES({nmudNumber.Value}, {txtFullName.isNull().ToString()}, {country}, " +
                         $"'{dtp.Value.ToString("yyyy-MM-dd")}', {nmudTeamID.Value}, {nmudPodiusNumber.Value});";
            Commons.Query(sql);
            Close();
        }
    }
}
