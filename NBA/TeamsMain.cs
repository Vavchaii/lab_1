using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class TeamsMain : Form
    {
        
        public static Team[] teams = new Team[15];
        public TeamsMain()
        {
            InitializeComponent();

            #region Логотипы команд
            String[] imgList = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg","11.jpg","12.jpg","13.jpg","14.jpg","15.jpg","16.jpg","17.jpg","18.jpg","19.jpg","20.jpg","21.jpg","22.jpg","23.jpg","24.jpg","25.jpg","26.jpg","27.jpg","28.jpg","29.jpg","30.jpg"};
            int index = 0;

            logo1.Load("../../Teams/" + imgList[0]);
            logo2.Load("../../Teams/" + imgList[1]);
            logo3.Load("../../Teams/" + imgList[2]);
            logo4.Load("../../Teams/" + imgList[3]);
            logo5.Load("../../Teams/" + imgList[4]);
            logo6.Load("../../Teams/" + imgList[5]);
            logo7.Load("../../Teams/" + imgList[6]);
            logo8.Load("../../Teams/" + imgList[7]);
            logo9.Load("../../Teams/" + imgList[8]);
            logo10.Load("../../Teams/" + imgList[9]);
            logo11.Load("../../Teams/" + imgList[10]);
            logo12.Load("../../Teams/" + imgList[11]);
            logo13.Load("../../Teams/" + imgList[12]);
            logo14.Load("../../Teams/" + imgList[13]);
            logo15.Load("../../Teams/" + imgList[14]);
            logo16.Load("../../Teams/" + imgList[15]);
            logo17.Load("../../Teams/" + imgList[16]);
            logo18.Load("../../Teams/" + imgList[17]);
            logo19.Load("../../Teams/" + imgList[18]);
            logo20.Load("../../Teams/" + imgList[19]);
            logo21.Load("../../Teams/" + imgList[20]);
            logo22.Load("../../Teams/" + imgList[21]);
            logo23.Load("../../Teams/" + imgList[22]);
            logo24.Load("../../Teams/" + imgList[23]);
            logo25.Load("../../Teams/" + imgList[24]);
            logo26.Load("../../Teams/" + imgList[25]);
            logo27.Load("../../Teams/" + imgList[26]);
            logo28.Load("../../Teams/" + imgList[27]);
            logo29.Load("../../Teams/" + imgList[28]);
            logo30.Load("../../Teams/" + imgList[29]);
            #endregion

            #region создание команд
            Team team = new Team();

            teams[0] = new Team();
            teams[0].Set(1, "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].Set(2, "Orlando Magic", "ORL", "2.jpg");

            teams[2] = new Team();
            teams[2].Set(3, "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new Team();
            teams[3].Set(4, "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].Set(5, "Charlotte Hornets", "CHA", "5.jpg");

            teams[5] = new Team();
            teams[5].Set(6, "Detroit Pistons", "DET", "6.jpg");

            teams[6] = new Team();
            teams[6].Set(7, "Indiana Pacers", "IND", "7.jpg");

            teams[7] = new Team();
            teams[7].Set(8, "Cleveland Cavaliers", "CLE", "8.jpg");

            teams[8] = new Team();
            teams[8].Set(9, "Chicago Bulls", "CHI", "9.jpg");

            teams[9] = new Team();
            teams[9].Set(10, "Milwaukee Bucks", "MIL", "10.jpg");

            teams[10] = new Team();
            teams[10].Set(11, "Boston Celtics", "BOS", "11.jpg");

            teams[11] = new Team();
            teams[11].Set(12, "Philadelphia 76ers", "PHI", "12.jpg");

            teams[12] = new Team();
            teams[12].Set(13, "New York Knicks", "NY", "13.jpg");

            teams[13] = new Team();
            teams[13].Set(14, "Brooklyn Nets", "BKN", "14.jpg");

            teams[14] = new Team();
            teams[14].Set(15, "Toronto Raptors", "TOR", "15.jpg");
            #endregion

            #region Имена команда
            label10.Text = teams[0].Name;
            label11.Text = teams[1].Name;
            label12.Text = teams[2].Name;
            label13.Text = teams[3].Name;
            label14.Text = teams[4].Name;
            label15.Text = teams[5].Name;
            label16.Text = teams[6].Name;
            label17.Text = teams[7].Name;
            label18.Text = teams[8].Name;
            label19.Text = teams[9].Name;
            label20.Text = teams[10].Name;
            label21.Text = teams[11].Name;
            label22.Text = teams[12].Name;
            label23.Text = teams[13].Name;
            label24.Text = teams[14].Name;
            #endregion
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TeamsMain1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void logo16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 1;
            TDform.Show();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 2;
            TDform.Show();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 3;
            TDform.Show();
        }

        private void label13_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 4;
            TDform.Show();
        }

        private void label14_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 5;
            TDform.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 6;
            TDform.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 7;
            TDform.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 8;
            TDform.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 9;
            TDform.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 10;
            TDform.Show();
        }

        private void label20_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 11;
            TDform.Show();
        }

        private void label21_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 12;
            TDform.Show();
        }

        private void label22_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 13;
            TDform.Show();
        }

        private void label23_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 14;
            TDform.Show();
        }

        private void label24_Click_1(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 15;
            TDform.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
