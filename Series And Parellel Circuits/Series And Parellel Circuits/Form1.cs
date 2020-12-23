/*Written By: Yashraj Nagpal
 * Written For: Mr. Kolch
 * Subject: TEJ 3M1
 * April 1, 2019
 * Description: Series Parallel Circuit App
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series_And_Parellel_Circuits
{
    public partial class SeriesParellel : Form
    {
        public SeriesParellel()
        {
            InitializeComponent();
        }
        Random r = new Random();
        double s1, s2, s3, p2, p3, p4, s1r1, s2r1, s2r2, s3r1, s3r2, s3r3, p2r1, p2r2, p3r1, p3r2, p3r3, p4r1, p4r2, p4r3, p4r4;
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void series_CheckedChanged(object sender, EventArgs e)
        {
            DiffParellel.Visible = false; // Makes it invisible 
            DiffSeries.Visible = true;
            parellelpic1.Visible = false;
            parellelpic2.Visible = false;
            parellelpic3.Visible = false;
            seriespic1.Visible = false;
            seriespic2.Visible = false;
            seriespic3.Visible = false;
            tableP3.Visible = false;
            AnswerP2.Visible = false;
            CheckP3.Visible = false;
            tableS2.Visible = false;
            CheckP4.Visible = false;
            AnsweP3.Visible = false;
            AnswerS2.Visible = false;
            CheckP2.Visible = false;
            tableS3.Visible = false;
            newp4.Visible = false;
            AnswerS3.Visible = false;
            CheckS2.Visible = false;
            tableP4.Visible = false;
            CheckS3.Visible = false;
            newp2.Visible = false;
            CheckS1.Visible = false;
            news2.Visible = false;
            AnsweP4.Visible = false;
            newS1.Visible = false;
            AnswerS1.Visible = false;
            tableP2.Visible = false;
            news3.Visible = false;
            newp3.Visible = false;
            tableS1.Visible = false;
            res1S.Checked = false;
            res2S.Checked = false; //Makes it so it is unchecked
            res3S.Checked = false;
            res2P.Checked = false;
            res3P.Checked = false;
            res4P.Checked = false;
            BackColor = Color.PaleTurquoise; //Changes the color
            tableS1.BackColor = Color.PaleTurquoise;
            tableS2.BackColor = Color.PaleTurquoise;
            tableS2.BackColor = Color.PaleTurquoise;
            tableP2.BackColor = Color.PaleTurquoise;
            tableP3.BackColor = Color.PaleTurquoise;
            tableP4.BackColor = Color.PaleTurquoise;
            pvs.BackColor = Color.LightPink;
            DiffParellel.BackColor = Color.LightPink;
            DiffSeries.BackColor = Color.LightPink;


            textVS11.BackColor = Color.LightPink;
            textIS11.BackColor = Color.LightPink;
            textIS1T.BackColor = Color.LightPink;
            textRS1T.BackColor = Color.LightPink;

            textVS21.BackColor = Color.LightPink;
            textVS22.BackColor = Color.LightPink;
            textIS21.BackColor = Color.LightPink;
            textIS22.BackColor = Color.LightPink;
            textIS2T.BackColor = Color.LightPink;
            textRS2T.BackColor = Color.LightPink;

            textVS31.BackColor = Color.LightPink;
            textVS32.BackColor = Color.LightPink;
            textVS33.BackColor = Color.LightPink;
            textIS31.BackColor = Color.LightPink;
            textIS32.BackColor = Color.LightPink;
            textIS33.BackColor = Color.LightPink;
            textIS3T.BackColor = Color.LightPink;
            textRS3T.BackColor = Color.LightPink;


            textVP21.BackColor = Color.LightPink;
            textVP22.BackColor = Color.LightPink;
            textIP21.BackColor = Color.LightPink;
            textIP22.BackColor = Color.LightPink;
            textIP2T.BackColor = Color.LightPink;
            textRP2T.BackColor = Color.LightPink;

            textVP31.BackColor = Color.LightPink;
            textVP32.BackColor = Color.LightPink;
            textVP33.BackColor = Color.LightPink;
            textIP31.BackColor = Color.LightPink;
            textIP32.BackColor = Color.LightPink;
            textIP33.BackColor = Color.LightPink;
            textIP3T.BackColor = Color.LightPink;
            textRP3T.BackColor = Color.LightPink;

            textVP41.BackColor = Color.LightPink;
            textVP42.BackColor = Color.LightPink;
            textVP43.BackColor = Color.LightPink;
            textVP44.BackColor = Color.LightPink;
            textIP41.BackColor = Color.LightPink;
            textIP42.BackColor = Color.LightPink;
            textIP43.BackColor = Color.LightPink;
            textIP44.BackColor = Color.LightPink;
            textIP4T.BackColor = Color.LightPink;
            textRP4T.BackColor = Color.LightPink;


            textVS11.Text = ""; //Makes the textboxes blank 
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";




        }

        private void parellel_CheckedChanged(object sender, EventArgs e)
        {
            DiffParellel.Visible = true;
            DiffSeries.Visible = false;
            parellelpic1.Visible = false;
            parellelpic2.Visible = false;
            parellelpic3.Visible = false;
            seriespic1.Visible = false;
            tableS2.Visible = false;
            CheckP4.Visible = false;
            tableP3.Visible = false;
            CheckP3.Visible = false;
            AnswerP2.Visible = false;
            AnsweP4.Visible = false;
            seriespic2.Visible = false;
            seriespic3.Visible = false;
            newS1.Visible = false;
            tableP4.Visible = false;
            tableP2.Visible = false;
            AnswerS3.Visible = false;
            CheckS2.Visible = false;
            AnsweP3.Visible = false;
            tableS3.Visible = false;
            news3.Visible = false;
            CheckS3.Visible = false;
            newp2.Visible = false;
            newp4.Visible = false;
            newp3.Visible = false;
            CheckP2.Visible = false;
            tableS1.Visible = false;
            news2.Visible = false;
            CheckS1.Visible = false;
            AnswerS2.Visible = false;
            AnswerS1.Visible = false;
            res1S.Checked = false;
            res2S.Checked = false;
            res3S.Checked = false;
            res2P.Checked = false;
            res3P.Checked = false;
            res4P.Checked = false;
            BackColor = Color.LightPink;
            tableS1.BackColor = Color.LightPink;
            tableS2.BackColor = Color.LightPink;
            tableS2.BackColor = Color.LightPink;
            tableP2.BackColor = Color.LightPink;
            tableP3.BackColor = Color.LightPink;
            tableP4.BackColor = Color.LightPink;
            pvs.BackColor = Color.PaleTurquoise;
            DiffParellel.BackColor = Color.PaleTurquoise;
            DiffSeries.BackColor = Color.PaleTurquoise;


            textVS11.BackColor = Color.PaleTurquoise;
            textIS11.BackColor = Color.PaleTurquoise;
            textIS1T.BackColor = Color.PaleTurquoise;
            textRS1T.BackColor = Color.PaleTurquoise;

            textVS21.BackColor = Color.PaleTurquoise;
            textVS22.BackColor = Color.PaleTurquoise;
            textIS21.BackColor = Color.PaleTurquoise;
            textIS22.BackColor = Color.PaleTurquoise;
            textIS2T.BackColor = Color.PaleTurquoise;
            textRS2T.BackColor = Color.PaleTurquoise;

            textVS31.BackColor = Color.PaleTurquoise;
            textVS32.BackColor = Color.PaleTurquoise;
            textVS33.BackColor = Color.PaleTurquoise;
            textIS31.BackColor = Color.PaleTurquoise;
            textIS32.BackColor = Color.PaleTurquoise;
            textIS33.BackColor = Color.PaleTurquoise;
            textIS3T.BackColor = Color.PaleTurquoise;
            textRS3T.BackColor = Color.PaleTurquoise;


            textVP21.BackColor = Color.PaleTurquoise;
            textVP22.BackColor = Color.PaleTurquoise;
            textIP21.BackColor = Color.PaleTurquoise;
            textIP22.BackColor = Color.PaleTurquoise;
            textIP2T.BackColor = Color.PaleTurquoise;
            textRP2T.BackColor = Color.PaleTurquoise;

            textVP31.BackColor = Color.PaleTurquoise;
            textVP32.BackColor = Color.PaleTurquoise;
            textVP33.BackColor = Color.PaleTurquoise;
            textIP31.BackColor = Color.PaleTurquoise;
            textIP32.BackColor = Color.PaleTurquoise;
            textIP33.BackColor = Color.PaleTurquoise;
            textIP3T.BackColor = Color.PaleTurquoise;
            textRP3T.BackColor = Color.PaleTurquoise;

            textVP41.BackColor = Color.PaleTurquoise;
            textVP42.BackColor = Color.PaleTurquoise;
            textVP43.BackColor = Color.PaleTurquoise;
            textVP44.BackColor = Color.PaleTurquoise;
            textIP41.BackColor = Color.PaleTurquoise;
            textIP42.BackColor = Color.PaleTurquoise;
            textIP43.BackColor = Color.PaleTurquoise;
            textIP44.BackColor = Color.PaleTurquoise;
            textIP4T.BackColor = Color.PaleTurquoise;
            textRP4T.BackColor = Color.PaleTurquoise;

            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";


        }

        private void res1S_CheckedChanged(object sender, EventArgs e)
        {
            parellelpic1.Visible = false;
            parellelpic2.Visible = false;
            parellelpic3.Visible = false;
            seriespic1.Visible = true;
            seriespic2.Visible = false;
            CheckP4.Visible = false;
            tableP3.Visible = false;
            AnsweP4.Visible = false;
            seriespic3.Visible = false;
            tableP4.Visible = false;
            AnsweP3.Visible = false;
            AnswerP2.Visible = false;
            CheckP3.Visible = false;
            tableP2.Visible = false;
            tableS3.Visible = false;
            CheckS3.Visible = false;
            newp4.Visible = false;
            AnswerS3.Visible = false;
            CheckS2.Visible = false;
            AnswerS2.Visible = false;
            newp3.Visible = false;
            CheckP2.Visible = false;
            news3.Visible = false;
            tableS1.Visible = true;
            news2.Visible = false;
            newp2.Visible = false;
            tableS2.Visible = false;
            CheckS1.Visible = true;
            AnswerS1.Visible = true;
           

            s1 = r.Next(10, 51);
            textVS1T.Text = (s1.ToString()); //Generates then prints a random value
            textVS1T.Enabled = false; //Disables the textbox
            s1r1 = r.Next(10, 51);
            textRS11.Text = (s1r1.ToString());
            textRS11.Enabled = false;
            newS1.Visible = true;


        }

        private void res2S_CheckedChanged(object sender, EventArgs e)
        {
            parellelpic1.Visible = false;
            tableP4.Visible = false;
            parellelpic2.Visible = false;
            parellelpic3.Visible = false;
            seriespic1.Visible = false;
            seriespic2.Visible = true;
            seriespic3.Visible = false;
            CheckP4.Visible = false;
            AnsweP4.Visible = false;
            CheckS1.Visible = false;
            AnswerS1.Visible = false;
            CheckP3.Visible = false;
            AnsweP3.Visible = false;
            tableP3.Visible = false;
            tableP2.Visible = false;
            AnswerP2.Visible = false;
            tableS3.Visible = false;
            newS1.Visible = false;
            newp3.Visible = false;
            CheckS3.Visible = false;
            newp4.Visible = false;
            AnswerS3.Visible = false;
            news2.Visible = false;
            news3.Visible = false;
            CheckP2.Visible = false;
            tableS2.Visible = true;
            newp2.Visible = false;
            tableS1.Visible = false;
            CheckS2.Visible = true;
            AnswerS2.Visible = true;
            s2 = r.Next(10, 51);
            textVS2T.Text = (s2.ToString());
            textVS2T.Enabled = false;
            s2r1 = r.Next(10, 51);
            textRS21.Text = (s2r1.ToString());
            textRS21.Enabled = false;
            s2r2 = r.Next(10, 51);
            textRS22.Text = (s2r2.ToString());
            textRS22.Enabled = false;
            news2.Visible = true;
        }

        private void res3S_CheckedChanged(object sender, EventArgs e)
        {
            parellelpic1.Visible = false;
            parellelpic2.Visible = false;
            parellelpic3.Visible = false;
            CheckP4.Visible = false;
            seriespic1.Visible = false;
            seriespic2.Visible = false;
            seriespic3.Visible = true;
            AnsweP4.Visible = false;
            AnswerS1.Visible = false;
            tableP4.Visible = false;
            tableP3.Visible = false;
            news2.Visible = false;
            CheckP3.Visible = false;
            AnsweP3.Visible = false;
            newS1.Visible = false;
            tableS1.Visible = false;
            CheckS2.Visible = false;
            newp3.Visible = false;
            tableP2.Visible = false;
            newp4.Visible = false;
            CheckP2.Visible = false;
            AnswerP2.Visible = false;
            tableS2.Visible = false;
            tableS3.Visible = true;
            newp2.Visible = false;
            AnswerS2.Visible = false;
            CheckS1.Visible = false;
            CheckS3.Visible = true;
            AnswerS3.Visible = true;
            s3 = r.Next(10, 51);
            textVS3T.Text = (s3.ToString());
            textVS3T.Enabled = false;
            s3r1 = r.Next(10, 51);
            textRS31.Text = (s3r1.ToString());
            textRS31.Enabled = false;
            s3r2 = r.Next(10, 51);
            textRS32.Text = (s3r2.ToString());
            textRS32.Enabled = false;
            s3r3 = r.Next(10, 51);
            textRS33.Text = (s3r3.ToString());
            textRS33.Enabled = false;
            news3.Visible = true;

        }

        private void newS1_Click(object sender, EventArgs e)
        {
            res1S.Checked = false;
            res1S.Checked = true;
            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";
            textVS11.BackColor = Color.LightPink;
            textIS11.BackColor = Color.LightPink;
            textIS1T.BackColor = Color.LightPink;
            textRS1T.BackColor = Color.LightPink;
        }

        private void news2_Click(object sender, EventArgs e)
        {
            res2S.Checked = false;
            res2S.Checked = true;
            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";
            textVS21.BackColor = Color.LightPink;
            textVS22.BackColor = Color.LightPink;
            textIS21.BackColor = Color.LightPink;
            textIS22.BackColor = Color.LightPink;
            textIS2T.BackColor = Color.LightPink;
            textRS2T.BackColor = Color.LightPink;
        }

        private void news3_Click(object sender, EventArgs e)
        {
            res3S.Checked = false;
            res3S.Checked = true;
            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";
            textVS31.BackColor = Color.LightPink;
            textVS32.BackColor = Color.LightPink;
            textVS33.BackColor = Color.LightPink;
            textIS31.BackColor = Color.LightPink;
            textIS32.BackColor = Color.LightPink;
            textIS33.BackColor = Color.LightPink;
            textIS3T.BackColor = Color.LightPink;
            textRS3T.BackColor = Color.LightPink;
        }

        private void newp2_Click(object sender, EventArgs e)
        {
            res2P.Checked = false;
            res2P.Checked = true;
            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";

            textVP21.BackColor = Color.PaleTurquoise;
            textVP22.BackColor = Color.PaleTurquoise;
            textIP21.BackColor = Color.PaleTurquoise;
            textIP22.BackColor = Color.PaleTurquoise;
            textIP2T.BackColor = Color.PaleTurquoise;
            textRP2T.BackColor = Color.PaleTurquoise;
        }

        private void newp3_Click(object sender, EventArgs e)
        {
            res3P.Checked = false;
            res3P.Checked = true;
            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";

            textVP31.BackColor = Color.PaleTurquoise;
            textVP32.BackColor = Color.PaleTurquoise;
            textVP33.BackColor = Color.PaleTurquoise;
            textIP31.BackColor = Color.PaleTurquoise;
            textIP32.BackColor = Color.PaleTurquoise;
            textIP33.BackColor = Color.PaleTurquoise;
            textIP3T.BackColor = Color.PaleTurquoise;
            textRP3T.BackColor = Color.PaleTurquoise;
        }

        private void newp4_Click(object sender, EventArgs e)
        {
            res4P.Checked = false;
            res4P.Checked = true;
            textVS11.Text = "";
            textIS11.Text = "";
            textIS1T.Text = "";
            textRS1T.Text = "";

            textVS21.Text = "";
            textVS22.Text = "";
            textIS21.Text = "";
            textIS22.Text = "";
            textIS2T.Text = "";
            textRS2T.Text = "";

            textVS31.Text = "";
            textVS32.Text = "";
            textVS33.Text = "";
            textIS31.Text = "";
            textIS32.Text = "";
            textIS33.Text = "";
            textIS3T.Text = "";
            textRS3T.Text = "";


            textVP21.Text = "";
            textVP22.Text = "";
            textIP21.Text = "";
            textIP22.Text = "";
            textIP2T.Text = "";
            textRP2T.Text = "";

            textVP31.Text = "";
            textVP32.Text = "";
            textVP33.Text = "";
            textIP31.Text = "";
            textIP32.Text = "";
            textIP33.Text = "";
            textIP3T.Text = "";
            textRP3T.Text = "";

            textVP41.Text = "";
            textVP42.Text = "";
            textVP43.Text = "";
            textVP44.Text = "";
            textIP41.Text = "";
            textIP42.Text = "";
            textIP43.Text = "";
            textIP44.Text = "";
            textIP4T.Text = "";
            textRP4T.Text = "";
            textVP41.BackColor = Color.PaleTurquoise;
            textVP42.BackColor = Color.PaleTurquoise;
            textVP43.BackColor = Color.PaleTurquoise;
            textVP44.BackColor = Color.PaleTurquoise;
            textIP41.BackColor = Color.PaleTurquoise;
            textIP42.BackColor = Color.PaleTurquoise;
            textIP43.BackColor = Color.PaleTurquoise;
            textIP44.BackColor = Color.PaleTurquoise;
            textIP4T.BackColor = Color.PaleTurquoise;
            textRP4T.BackColor = Color.PaleTurquoise;
        }

        private void tableS3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void res2P_CheckedChanged(object sender, EventArgs e)
        {
            parellelpic1.Visible = true;
            parellelpic2.Visible = false;
            parellelpic3.Visible = false;
            seriespic1.Visible = false;
            news2.Visible = false;
            seriespic2.Visible = false;
            CheckP4.Visible = false;
            AnsweP4.Visible = false;
            AnswerS2.Visible = false;
            newS1.Visible = false;
            seriespic3.Visible = false;
            news3.Visible = false;
            tableP4.Visible = false;
            newp3.Visible = false;
            tableS1.Visible = false;
            tableP3.Visible = false;
            AnswerS3.Visible = false;
            tableS3.Visible = false;
            AnswerS1.Visible = false;
            CheckP3.Visible = false;
            CheckS2.Visible = false;
            tableS2.Visible = false;
            newp4.Visible = false;
            AnsweP3.Visible = false;
            CheckS1.Visible = false;
            tableP2.Visible = true;
            CheckS3.Visible = false;
            CheckP2.Visible = true;
            AnswerP2.Visible = true;
            newp2.Visible = true;

            p2 = r.Next(10, 51);
            textVP2T.Text = (p2.ToString());
            textVP2T.Enabled = false;
            p2r1 = r.Next(10, 51);
            textRP21.Text = (p2r1.ToString());
            textRP21.Enabled = false;
            p2r2 = r.Next(10, 51);
            textRP22.Text = (p2r2.ToString());
            textRP22.Enabled = false;

        }

        private void res3P_CheckedChanged(object sender, EventArgs e)
        {
            parellelpic1.Visible = false;
            parellelpic2.Visible = true;
            parellelpic3.Visible = false;
            CheckP4.Visible = false;
            seriespic1.Visible = false;
            seriespic2.Visible = false;
            seriespic3.Visible = false;
            tableP4.Visible = false;
            newS1.Visible = false;
            AnswerS3.Visible = false;
            AnswerS2.Visible = false;
            news3.Visible = false;
            news2.Visible = false;
            CheckS2.Visible = false;
            newp2.Visible = false;
            tableS3.Visible = false;
            AnswerS1.Visible = false;
            AnsweP4.Visible = false;
            tableP2.Visible = false;
            tableP3.Visible = true;
            AnswerP2.Visible = false;
            tableS1.Visible = false;
            tableS2.Visible = false;
            CheckS3.Visible = false;
            CheckP3.Visible = true;
            CheckP2.Visible = false;
            AnsweP3.Visible = true;
            newp4.Visible = false;
            CheckS1.Visible = false;
            newp3.Visible = true;
            p3 = r.Next(10, 51);
            textVP3T.Text = (p3.ToString());
            textVP3T.Enabled = false;
            p3r1 = r.Next(10, 51);
            textRP31.Text = (p3r1.ToString());
            textRP31.Enabled = false;
            p3r2 = r.Next(10, 51);
            textRP32.Text = (p3r2.ToString());
            textRP32.Enabled = false;
            p3r3 = r.Next(10, 51);
            textRP33.Text = (p3r3.ToString());
            textRP33.Enabled = false;

        }

        private void res4P_CheckedChanged(object sender, EventArgs e)
        {
            parellelpic1.Visible = false;
            parellelpic2.Visible = false;
            parellelpic3.Visible = true;
            seriespic1.Visible = false;
            tableS2.Visible = false;
            seriespic2.Visible = false;
            AnswerS2.Visible = false;
            newS1.Visible = false;
            news2.Visible = false;
            news3.Visible = false;
            tableS3.Visible = false;
            AnswerS1.Visible = false;
            seriespic3.Visible = false;
            CheckS2.Visible = false;
            tableP4.Visible = true;
            AnswerS3.Visible = false;
            tableS1.Visible = false;
            CheckS1.Visible = false;
            CheckP2.Visible = false;
            CheckS3.Visible = false;
            CheckP4.Visible = true;
            AnswerP2.Visible = false;
            tableP2.Visible = false;
            newp3.Visible = false;
            CheckP3.Visible = false;
            newp2.Visible = false;
            AnsweP4.Visible = true;
            AnsweP3.Visible = false;
            tableP3.Visible = false;
            newp4.Visible = true;
 
            p4 = r.Next(10, 51); //Generates a random value
            textVP4T.Text = (p4.ToString()); 
            textVP4T.Enabled = false; // Disables the textbox
            p4r1 = r.Next(10, 51);
            textRP41.Text = (p4r1.ToString());
            textRP41.Enabled = false;
            p4r2 = r.Next(10, 51);
            textRP42.Text = (p4r2.ToString());
            textRP42.Enabled = false;
            p4r3 = r.Next(10, 51);
            textRP43.Text = (p4r3.ToString());
            textRP43.Enabled = false;
            p4r4 = r.Next(10, 51);
            textRP44.Text = (p4r4.ToString());
            textRP44.Enabled = false;
        }

        private void P43_Click(object sender, EventArgs e)
        {

        }

        private void CheckP4_Click(object sender, EventArgs e)
        {
            double p4rt, p4v1, p4v2, p4v3, p4v4, p4it, p4i1, p4i2, p4i3, p4i4;

            p4v1 = p4;
            p4v1 = Math.Round(p4v1, 2); // Rounds values to 2 decimal places 

            p4v2 = p4;
            p4v2 = Math.Round(p4v2, 2);

            p4v3 = p4;
            p4v3 = Math.Round(p4v3, 2);

            p4v4 = p4;
            p4v4 = Math.Round(p4v4, 2);


            p4i1 = p4v1 / p4r1;
            p4i1 = Math.Round(p4i1, 2);

            p4i2 = p4v2 / p4r2;
            p4i2 = Math.Round(p4i2, 2);

            p4i3 = p4v3 / p4r3;
            p4i3 = Math.Round(p4i3, 2);

            p4i4 = p4v4 / p4r4;
            p4i4 = Math.Round(p4i4, 2);

            p4it = p4i1 + p4i2 + p4i3 + p4i4;
            p4it = Math.Round(p4it, 2);

            p4rt = p4 / p4it;
            p4rt = Math.Round(p4rt, 2);


            if (textVP41.Text.Equals(p4v1.ToString()) &&
                textVP42.Text.Equals(p4v2.ToString()) && 
                textVP43.Text.Equals(p4v3.ToString()) && 
                textVP44.Text.Equals(p4v4.ToString()) &&
                textIP4T.Text.Equals(p4it.ToString()) &&
                textIP41.Text.Equals(p4i1.ToString()) &&
                textIP42.Text.Equals(p4i2.ToString()) &&
                textIP43.Text.Equals(p4i3.ToString()) && 
                textIP44.Text.Equals(p4i4.ToString()) && 
                textRP4T.Text.Equals(p4rt.ToString()))
            {
                MessageBox.Show("Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(textVP41.Text.Equals(p4v1.ToString()))) {
                textVP41.BackColor = Color.Red;
            }
            else {textVP41.BackColor = Color.PaleTurquoise; }

            if (!(textVP42.Text.Equals(p4v2.ToString())))
            {
                textVP42.BackColor = Color.Red;
            }
            else { textVP42.BackColor = Color.PaleTurquoise; }

            if (!(textVP43.Text.Equals(p4v3.ToString())))
            {
                textVP43.BackColor = Color.Red;
            }
            else { textVP43.BackColor = Color.PaleTurquoise; }

            if (!(textVP44.Text.Equals(p4v4.ToString())))
            {
                textVP44.BackColor = Color.Red;
            }
            else { textVP44.BackColor = Color.PaleTurquoise; }

            if (!(textIP4T.Text.Equals(p4it.ToString())))
            {
                textIP4T.BackColor = Color.Red;
            }
            else { textIP4T.BackColor = Color.PaleTurquoise; }

            if (!(textIP41.Text.Equals(p4i1.ToString())))
            {
                textIP41.BackColor = Color.Red;
            }
            else { textIP41.BackColor = Color.PaleTurquoise; }

            if (!(textIP42.Text.Equals(p4i2.ToString())))
            {
                textIP42.BackColor = Color.Red;
            }
            else { textIP42.BackColor = Color.PaleTurquoise; }

            if (!(textIP43.Text.Equals(p4i3.ToString())))
            {
                textIP43.BackColor = Color.Red;
            }
            else { textIP43.BackColor = Color.PaleTurquoise; }

            if (!(textIP44.Text.Equals(p4i4.ToString())))
            {
                textIP44.BackColor = Color.Red;
            }
            else { textIP44.BackColor = Color.PaleTurquoise; }

            if (!(textRP4T.Text.Equals(p4rt.ToString())))
            {
                textRP4T.BackColor = Color.Red;
            }
            else { textRP4T.BackColor = Color.PaleTurquoise; }

        }

        private void AnsweP4_Click(object sender, EventArgs e)
        {

            double p4rt, p4v1, p4v2, p4v3, p4v4, p4it, p4i1, p4i2, p4i3, p4i4;

            p4v1 = p4;
            p4v1 = Math.Round(p4v1, 2);

            p4v2 = p4;
            p4v2 = Math.Round(p4v2, 2);

            p4v3 = p4;
            p4v3 = Math.Round(p4v3, 2);

            p4v4 = p4;
            p4v4 = Math.Round(p4v4, 2);


            p4i1 = p4v1 / p4r1;
            p4i1 = Math.Round(p4i1, 2);

            p4i2 = p4v2 / p4r2;
            p4i2 = Math.Round(p4i2, 2);

            p4i3 = p4v3 / p4r3;
            p4i3 = Math.Round(p4i3, 2);

            p4i4 = p4v4 / p4r4;
            p4i4 = Math.Round(p4i4, 2);

            p4it = p4i1 + p4i2 + p4i3 + p4i4;
            p4it = Math.Round(p4it, 2);

            p4rt = p4 / p4it;
            p4rt = Math.Round(p4rt, 2);


            textVP41.Text=(p4v1.ToString());
            textVP42.Text=(p4v2.ToString());
            textVP43.Text=(p4v3.ToString());
            textVP44.Text=(p4v4.ToString());
            textIP4T.Text=(p4it.ToString());
            textIP41.Text=(p4i1.ToString());
            textIP42.Text=(p4i2.ToString());
            textIP43.Text=(p4i3.ToString());
            textIP44.Text=(p4i4.ToString());
            textRP4T.Text=(p4rt.ToString());
            textVP41.BackColor = Color.PaleTurquoise;
            textVP42.BackColor = Color.PaleTurquoise;
            textVP43.BackColor = Color.PaleTurquoise;
            textVP44.BackColor = Color.PaleTurquoise;
            textIP41.BackColor = Color.PaleTurquoise;
            textIP42.BackColor = Color.PaleTurquoise;
            textIP43.BackColor = Color.PaleTurquoise;
            textIP44.BackColor = Color.PaleTurquoise;
            textIP4T.BackColor = Color.PaleTurquoise;
            textRP4T.BackColor = Color.PaleTurquoise;
        }

        private void CheckP3_Click(object sender, EventArgs e)
        {
            double p3rt, p3it, p3i1, p3i2, p3i3, p3v1, p3v2, p3v3;
            p3v1 = p3;
            p3v1 = Math.Round(p3v1, 2);
            p3v2 = p3;
            p3v2 = Math.Round(p3v2, 2);
            p3v3 = p3;
            p3v3 = Math.Round(p3v3, 2);
            p3i1 = p3v1 / p3r1;
            p3i1 = Math.Round(p3i1, 2);
            p3i2 = p3v2 / p3r2;
            p3i2 = Math.Round(p3i2, 2);
            p3i3 = p3v3 / p3r3;
            p3i3 = Math.Round(p3i3, 2);
            p3it = p3i1 + p3i2 + p3i3;
            p3it = Math.Round(p3it, 2);
            p3rt = p3 / p3it;
            p3rt = Math.Round(p3rt, 2);

            if (textRP3T.Text.Equals(p3rt.ToString()) && 
                textIP3T.Text.Equals(p3it.ToString()) && 
                textIP31.Text.Equals(p3i1.ToString()) && 
                textIP32.Text.Equals(p3i2.ToString()) && 
                textIP33.Text.Equals(p3i3.ToString()) && 
                textVP31.Text.Equals(p3v1.ToString()) && 
                textVP32.Text.Equals(p3v2.ToString()) && 
                textVP33.Text.Equals(p3v3.ToString()))
            {
                MessageBox.Show("Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(textVP33.Text.Equals(p3v3.ToString())))
            {
                textVP33.BackColor = Color.Red;
            }
            else { textVP33.BackColor = Color.PaleTurquoise; }

            if (!(textVP32.Text.Equals(p3v2.ToString())))
            {
                textVP32.BackColor = Color.Red;
            }
            else { textVP32.BackColor = Color.PaleTurquoise; }

            if (!(textVP31.Text.Equals(p3v1.ToString())))
            {
                textVP31.BackColor = Color.Red;
            }
            else { textVP31.BackColor = Color.PaleTurquoise; }

            if (!(textIP33.Text.Equals(p3i3.ToString())))
            {
                textIP33.BackColor = Color.Red;
            }
            else { textIP33.BackColor = Color.PaleTurquoise; }

            if (!(textIP32.Text.Equals(p3i2.ToString())))
            {
                textIP32.BackColor = Color.Red;
            }
            else { textIP32.BackColor = Color.PaleTurquoise; }

            if (!(textIP31.Text.Equals(p3i1.ToString())))
            {
                textIP31.BackColor = Color.Red;
            }
            else { textIP31.BackColor = Color.PaleTurquoise; }

            if (!(textRP3T.Text.Equals(p3rt.ToString())))
            {
                textRP3T.BackColor = Color.Red;
            }
            else { textRP3T.BackColor = Color.PaleTurquoise; }

            if (!(textIP3T.Text.Equals(p3it.ToString())))
            {
                textIP3T.BackColor = Color.Red;
            }
            else { textIP3T.BackColor = Color.PaleTurquoise; }
        }

        private void AnsweP3_Click(object sender, EventArgs e)
        {
            double p3rt, p3it, p3i1, p3i2, p3i3, p3v1, p3v2, p3v3;
            p3v1 = p3;
            p3v1 = Math.Round(p3v1, 2);
            p3v2 = p3;
            p3v2 = Math.Round(p3v2, 2);
            p3v3 = p3;
            p3v3 = Math.Round(p3v3, 2);
            p3i1 = p3v1 / p3r1;
            p3i1 = Math.Round(p3i1, 2);
            p3i2 = p3v2 / p3r2;
            p3i2 = Math.Round(p3i2, 2);
            p3i3 = p3v3 / p3r3;
            p3i3 = Math.Round(p3i3, 2);
            p3it = p3i1 + p3i2 + p3i3;
            p3it = Math.Round(p3it, 2);
            p3rt = p3 / p3it;
            p3rt = Math.Round(p3rt, 2);
            textRP3T.Text=(p3rt.ToString());
            textIP3T.Text=(p3it.ToString());
            textIP31.Text=(p3i1.ToString());
            textIP32.Text=(p3i2.ToString());
            textIP33.Text=(p3i3.ToString());
            textVP31.Text=(p3v1.ToString());
            textVP32.Text=(p3v2.ToString());
            textVP33.Text=(p3v3.ToString());
            textVP31.BackColor = Color.PaleTurquoise;
            textVP32.BackColor = Color.PaleTurquoise;
            textVP33.BackColor = Color.PaleTurquoise;
            textIP31.BackColor = Color.PaleTurquoise;
            textIP32.BackColor = Color.PaleTurquoise;
            textIP33.BackColor = Color.PaleTurquoise;
            textIP3T.BackColor = Color.PaleTurquoise;
            textRP3T.BackColor = Color.PaleTurquoise;
        }

        private void CheckP2_Click(object sender, EventArgs e)
        {
            double p2v1 = p2;
            p2v1 = Math.Round(p2v1, 2);
            double p2v2 = p2;
            p2v2 = Math.Round(p2v2, 2);
            double p2i1 = p2v1 / p2r1;
            p2i1 = Math.Round(p2i1, 2);
            double p2i2 = p2v2 / p2r2;
            p2i2 = Math.Round(p2i2, 2);
            double p2it = p2i1 + p2i2;
            p2it = Math.Round(p2it, 2);
            double p2rt = p2 / p2it;
            p2rt = Math.Round(p2rt, 2);



            if (textRP2T.Text.Equals(p2rt.ToString()) &&
                textIP2T.Text.Equals(p2it.ToString()) &&
                textIP21.Text.Equals(p2i1.ToString()) &&
                textIP22.Text.Equals(p2i2.ToString()) &&
                textVP21.Text.Equals(p2v1.ToString()) &&
                textVP22.Text.Equals(p2v2.ToString()))
            {
                MessageBox.Show("Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(textVP22.Text.Equals(p2v2.ToString())))
            {
                textVP22.BackColor = Color.Red;
            }
            else { textVP22.BackColor = Color.PaleTurquoise; }

            if (!(textVP21.Text.Equals(p2v1.ToString())))
            {
                textVP21.BackColor = Color.Red;
            }
            else { textVP21.BackColor = Color.PaleTurquoise; }

            if (!(textIP22.Text.Equals(p2i2.ToString())))
            {
                textIP22.BackColor = Color.Red;
            }
            else { textIP22.BackColor = Color.PaleTurquoise; }

            if (!(textIP21.Text.Equals(p2i1.ToString())))
            {
                textIP21.BackColor = Color.Red;
            }
            else { textIP21.BackColor = Color.PaleTurquoise; }

            if (!(textIP2T.Text.Equals(p2it.ToString())))
            {
                textIP2T.BackColor = Color.Red;
            }
            else { textIP2T.BackColor = Color.PaleTurquoise; }

            if (!(textRP2T.Text.Equals(p2rt.ToString())))
            {
                textRP2T.BackColor = Color.Red;
            }
            else { textRP2T.BackColor = Color.PaleTurquoise; }

        }

    

        private void AnswerP2_Click(object sender, EventArgs e)
        {

            double p2v1 = p2;
            p2v1 = Math.Round(p2v1, 2);
            double p2v2 = p2;
            p2v2 = Math.Round(p2v2, 2);
            double p2i1 = p2v1 / p2r1;
            p2i1 = Math.Round(p2i1, 2);
            double p2i2 = p2v2 / p2r2;
            p2i2 = Math.Round(p2i2, 2);
            double p2it = p2i1 + p2i2;
            p2it = Math.Round(p2it, 2);
            double p2rt = p2 / p2it;
            p2rt = Math.Round(p2rt, 2);

            textRP2T.Text = (p2rt.ToString());
            textIP2T.Text = (p2it.ToString());
            textIP21.Text = (p2i1.ToString());
            textIP22.Text = (p2i2.ToString());
            textVP21.Text = (p2.ToString());
            textVP22.Text = (p2v2.ToString());
            textVP21.BackColor = Color.PaleTurquoise;
            textVP22.BackColor = Color.PaleTurquoise;
            textIP21.BackColor = Color.PaleTurquoise;
            textIP22.BackColor = Color.PaleTurquoise;
            textIP2T.BackColor = Color.PaleTurquoise;
            textRP2T.BackColor = Color.PaleTurquoise;
        }

        private void CheckS3_Click(object sender, EventArgs e)
        {
            double s3rt = s3r1 + s3r2 + s3r3;
            s3rt = Math.Round(s3rt, 2);
            double s3it = s3 / s3rt;
            s3it = Math.Round(s3it, 2);
            double s3i1 = s3it;
            s3i1 = Math.Round(s3i1, 2);
            double s3i2 = s3it;
            s3i2 = Math.Round(s3i2, 2);
            double s3i3 = s3it;
            s3i3 = Math.Round(s3i3, 2);
            double s3v1 = s3r1 * s3i1;
            s3v1 = Math.Round(s3v1, 2);
            double s3v2 = s3r2 * s3i2;
            s3v2 = Math.Round(s3v2, 2);
            double s3v3 = s3r3 * s3i3;
            s3v3 = Math.Round(s3v3, 2);


            if (textRS3T.Text.Equals(Math.Round(s3rt, 2).ToString()) &&
                textIS3T.Text.Equals(Math.Round(s3it, 2).ToString()) &&
                textIS31.Text.Equals(Math.Round(s3i1, 2).ToString()) &&
                textIS32.Text.Equals(Math.Round(s3i2, 2).ToString()) &&
                textIS33.Text.Equals(Math.Round(s3i3, 2).ToString()) &&
                textVS31.Text.Equals(Math.Round(s3v1, 2).ToString()) &&
                textVS32.Text.Equals(Math.Round(s3v2, 2).ToString()) &&
                textVS33.Text.Equals(Math.Round(s3v3, 2).ToString()))
            {
                MessageBox.Show("Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(textVS33.Text.Equals(Math.Round(s3v3, 2).ToString())))
            {
                textVS33.BackColor = Color.Red;
            }
            else { textVS33.BackColor = Color.LightPink; }

            if (!(textVS32.Text.Equals(Math.Round(s3v2, 2).ToString())))
            {
                textVS32.BackColor = Color.Red;
            }
            else { textVS32.BackColor = Color.LightPink; }

            if (!(textVS31.Text.Equals(Math.Round(s3v1, 2).ToString())))
            {
                textVS31.BackColor = Color.Red;
            }
            else { textVS31.BackColor = Color.LightPink; }

            if (!(textIS33.Text.Equals(Math.Round(s3i3, 2).ToString())))
            {
                textIS33.BackColor = Color.Red;
            }
            else { textIS33.BackColor = Color.LightPink; }

            if (!(textIS32.Text.Equals(Math.Round(s3i2, 2).ToString())))
            {
                textIS32.BackColor = Color.Red;
            }
            else { textIS32.BackColor = Color.LightPink; }

            if (!(textIS31.Text.Equals(Math.Round(s3i1, 2).ToString())))
            {
                textIS31.BackColor = Color.Red;
            }
            else { textIS31.BackColor = Color.LightPink; }

            if (!(textIS3T.Text.Equals(Math.Round(s3it, 2).ToString())))
            {
                textIS3T.BackColor = Color.Red;
            }
            else { textIS3T.BackColor = Color.LightPink; }

            if (!(textRS3T.Text.Equals(Math.Round(s3rt, 2).ToString())))
            {
                textRS3T.BackColor = Color.Red;
            }
            else { textRS3T.BackColor = Color.LightPink; }

        }

        private void AnswerS3_Click(object sender, EventArgs e)
        {
            double s3rt = s3r1 + s3r2 + s3r3;
            s3rt = Math.Round(s3rt, 2);
            double s3it = s3 / s3rt;
            s3it = Math.Round(s3it, 2);
            double s3i1 = s3it;
            s3i1 = Math.Round(s3i1, 2);
            double s3i2 = s3it;
            s3i2 = Math.Round(s3i2, 2);
            double s3i3 = s3it;
            s3i3 = Math.Round(s3i3, 2);
            double s3v1 = s3r1 * s3i1;
            s3v1 = Math.Round(s3v1, 2);
            double s3v2 = s3r2 * s3i2;
            s3v2 = Math.Round(s3v2, 2);
            double s3v3 = s3r3 * s3i3;
            s3v3 = Math.Round(s3v3, 2);
            textRS3T.Text=(Math.Round(s3rt, 2).ToString());
            textIS3T.Text=(Math.Round(s3it, 2).ToString());
            textIS31.Text=(Math.Round(s3i1, 2).ToString());
            textIS32.Text=(Math.Round(s3i2, 2).ToString());
            textIS33.Text=(Math.Round(s3i3, 2).ToString());
            textVS31.Text=(Math.Round(s3v1, 2).ToString());
            textVS32.Text=(Math.Round(s3v2, 2).ToString());
            textVS33.Text=(Math.Round(s3v3, 2).ToString());
            textVS31.BackColor = Color.LightPink;
            textVS32.BackColor = Color.LightPink;
            textVS33.BackColor = Color.LightPink;
            textIS31.BackColor = Color.LightPink;
            textIS32.BackColor = Color.LightPink;
            textIS33.BackColor = Color.LightPink;
            textIS3T.BackColor = Color.LightPink;
            textRS3T.BackColor = Color.LightPink;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckS2_Click(object sender, EventArgs e)
        {
            double rs2t = s2r1 + s2r2;
            rs2t = Math.Round(rs2t, 2);
            double is2t = s2 / rs2t;
            is2t = Math.Round(is2t, 2);
            double is21 = is2t;
            is21 = Math.Round(is21, 2);
            double is22 = is2t;
            is22 = Math.Round(is22, 2);
            double vs21 = is21 * s2r1;
            vs21 = Math.Round(vs21, 2);
            double vs22 = is22 * s2r2;
            vs22 = Math.Round(vs22, 2);



            if (textRS2T.Text.Equals(Math.Round(rs2t, 2).ToString()) &&
                textIS2T.Text.Equals(Math.Round(is2t, 2).ToString()) &&
                textIS21.Text.Equals(Math.Round(is21, 2).ToString()) &&
                textIS22.Text.Equals(Math.Round(is22, 2).ToString()) &&
                textVS21.Text.Equals(Math.Round(vs21, 2).ToString()) &&
                textVS22.Text.Equals(Math.Round(vs22, 2).ToString()))
            {
                MessageBox.Show("Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(textVS22.Text.Equals(Math.Round(vs22, 2).ToString())))
            {
                textVS22.BackColor = Color.Red;
            }
            else { textVS22.BackColor = Color.LightPink; }

            if (!(textVS21.Text.Equals(Math.Round(vs21, 2).ToString())))
            {
                textVS21.BackColor = Color.Red;
            }
            else { textVS21.BackColor = Color.LightPink; }

            if (!(textIS22.Text.Equals(Math.Round(is22, 2).ToString())))
            {
                textIS22.BackColor = Color.Red;
            }
            else { textIS22.BackColor = Color.LightPink; }

            if (!(textIS21.Text.Equals(Math.Round(is21, 2).ToString())))
            {
                textIS21.BackColor = Color.Red;
            }
            else { textIS21.BackColor = Color.LightPink; }

            if (!(textIS2T.Text.Equals(Math.Round(is2t, 2).ToString())))
            {
                textIS2T.BackColor = Color.Red;
            }
            else { textIS2T.BackColor = Color.LightPink; }

            if (!(textRS2T.Text.Equals(Math.Round(rs2t, 2).ToString())))
            {
                textRS2T.BackColor = Color.Red;
            }
            else { textRS2T.BackColor = Color.LightPink; }

        }

        private void AnswerS2_Click(object sender, EventArgs e)
        {

            double rs2t = s2r1 + s2r2;
            rs2t = Math.Round(rs2t, 2);
            double is2t = s2 / rs2t;
            is2t = Math.Round(is2t, 2);
            double is21 = is2t;
            is21 = Math.Round(is21, 2);
            double is22 = is2t;
            is22 = Math.Round(is22, 2);
            double vs21 = is21 * s2r1;
            vs21 = Math.Round(vs21, 2);
            double vs22 = is22 * s2r2;
            vs22 = Math.Round(vs22, 2);
            textRS2T.Text=(Math.Round(rs2t, 2).ToString());
            textIS2T.Text=(Math.Round(is2t, 2).ToString());
            textIS21.Text=(Math.Round(is21, 2).ToString());
            textIS22.Text=(Math.Round(is22, 2).ToString());
            textVS21.Text=(Math.Round(vs21, 2).ToString());
            textVS22.Text=(Math.Round(vs22, 2).ToString());
            textVS21.BackColor = Color.LightPink;
            textVS22.BackColor = Color.LightPink;
            textIS21.BackColor = Color.LightPink;
            textIS22.BackColor = Color.LightPink;
            textIS2T.BackColor = Color.LightPink;
            textRS2T.BackColor = Color.LightPink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rs1t = s1r1;
            rs1t = Math.Round(rs1t, 2);
            double is1t = s1 / s1r1;
            is1t = (Math.Round(is1t, 2));
            double is11 = is1t;
            is11 = Math.Round(is11, 2);
            double vs11 = is11 * s1r1;
            vs11 = Math.Round(vs11, 2);


            if (textRS1T.Text.Equals(Math.Round(rs1t, 2).ToString()) &&
               textIS1T.Text.Equals(Math.Round(is1t, 2).ToString()) &&
               textIS11.Text.Equals(Math.Round(is11, 2).ToString()) &&
               textVS11.Text.Equals(Math.Round(vs11, 2).ToString()))
            {
                MessageBox.Show("Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(textVS11.Text.Equals(Math.Round(vs11, 2).ToString())))
            {
                textVS11.BackColor = Color.Red;
            }
            else { textVS11.BackColor = Color.LightPink; }

            if (!(textIS11.Text.Equals(Math.Round(is11, 2).ToString())))
            {
                textIS11.BackColor = Color.Red;
            }
            else { textIS11.BackColor = Color.LightPink; }

            if (!(textIS1T.Text.Equals(Math.Round(is1t, 2).ToString())))
            {
                textIS1T.BackColor = Color.Red;
            }
            else { textIS1T.BackColor = Color.LightPink; }

            if (!(textRS1T.Text.Equals(Math.Round(rs1t, 2).ToString())))
            {
                textRS1T.BackColor = Color.Red;
            }
            else { textRS1T.BackColor = Color.LightPink; }

        }

        private void AnswerS1_Click(object sender, EventArgs e)
        {
            double rs1t = s1r1;
            rs1t = Math.Round(rs1t, 2);
            double is1t = s1 / s1r1;
            is1t = (Math.Round(is1t, 2));
            double is11 = is1t;
            is11 = Math.Round(is11, 2);
            double vs11 = is11 * s1r1;
            vs11 = Math.Round(vs11, 2);
            textRS1T.Text=(Math.Round(rs1t, 2).ToString());
            textIS1T.Text=(Math.Round(is1t, 2).ToString());
            textIS11.Text= Math.Round(is11, 2).ToString();
            textVS11.Text= Math.Round(vs11, 2).ToString();
            textVS11.BackColor = Color.LightPink;
            textIS11.BackColor = Color.LightPink;
            textIS1T.BackColor = Color.LightPink;
            textRS1T.BackColor = Color.LightPink;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In a Series Circuit: " +
                "\nV total = V1 + V2 + V3...." +
                "\nI total = I1 = I2 = I3...." +
                "\nR total = R1 + R2 + R3...." +
                "\n\nIn a Parallel Circuit: " +
                "\nV total = V1 = V2 = V3....  " +
                "\nI total = I1 + I2 + I3...." +
                "\n1/R total = 1/R1 + 1/R2 + 1/R3....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the circuit bellow!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
