﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationManagement
{
    public partial class MainForm : Form
    {
        string connectionType = Login.myConnectionType;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CancellationMaster Cancel = new CancellationMaster();
            Cancel.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CancellationMaster Cancel = new CancellationMaster();
            Cancel.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReservationMaster Res = new ReservationMaster();
            Res.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ReservationMaster Res = new ReservationMaster();
            Res.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TravelMaster Tr = new TravelMaster();
            Tr.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TravelMaster Tr = new TravelMaster();
            Tr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PassengerMaster Ps = new PassengerMaster();
            Ps.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PassengerMaster PS = new PassengerMaster();
            PS.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TrainMaster TM = new TrainMaster();
            TM.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrainMaster TM = new TrainMaster();
            TM.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Analysis analysis = new Analysis();
            analysis.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(connectionType == "A")
            { 
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
            }

            else if (connectionType == "B")
            {
                this.pictureBox1.Location = new System.Drawing.Point(300, 72);
                this.pictureBox5.Location = new System.Drawing.Point(500, 72);
                this.label2.Location = new System.Drawing.Point(277, 199);
                this.label7.Location = new System.Drawing.Point(495, 199);

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label9.Visible = false;
            }

            else if (connectionType == "C")
            {
                this.pictureBox2.Location = new System.Drawing.Point(214, 72);
                this.pictureBox3.Location = new System.Drawing.Point(391, 72);
                this.pictureBox4.Location = new System.Drawing.Point(547, 72);
                this.label3.Location = new System.Drawing.Point(184, 199);
                this.label4.Location = new System.Drawing.Point(386, 199);
                this.label5.Location = new System.Drawing.Point(556, 199);
                pictureBox1.Visible = false; 
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false; 
                label2.Visible = false; 
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false; 
                label7.Visible = false; 
                label9.Visible = false; 
            }
        }
    }
}
