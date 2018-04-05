using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Battle_Ships
{
    public partial class frmBattleships : Form
       
    {
        int Cruiser = 0 ;
        int Battle = 0;
        int Submarine = 0;
        int Patrol = 0;
        int Destroyer = 0;
        int Total = 0;

        public frmBattleships()
            
        {
            
            InitializeComponent();
            
        }

        private void frmBattleships_Load(object sender, EventArgs e)
        {
            lblDisplay.Hide();
            txtOne.Hide();
            btnShoot.Hide();
            btnShootagain.Hide();
            lblCoordinates.Hide();

            lblCruiser.Hide();
            lblSub.Hide();
            lblPatrol.Hide();
            lblDestroyer.Hide();
            lblBattle.Hide();

            lblCDestroyed.Hide();
            lblSDestroyed.Hide();
            lblPDestroyed.Hide();
            lblDDestroyed.Hide();
            lblBDestroyed.Hide();

            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblName.Hide();
            txtName.Hide();
            btnClose.Hide();
            btnPlay.Hide();
            btnShootagain.Hide();
            lblIntro.Hide();

            lblDisplay.Text = "Hellow " + txtName.Text + ", Enter the position you gess from the grid.";

            lblDisplay.Show();
            txtOne.Show();
            btnShoot.Show();
            txtOne.Focus();

            btnShoot.Show();
            btnClose.Show();
            lblCoordinates.Show();

            btnShootagain.Hide();
            lblName.Hide();
            lblIntro.Hide();
            btnPlay.Hide();
            txtName.Hide();

            txtOne.Focus();

            lblCDestroyed.Show();
            lblSDestroyed.Show();
            lblPDestroyed.Show();
            lblDDestroyed.Show();
            lblBDestroyed.Show();

            
        }



        private void btnShootagain_Click(object sender, EventArgs e)
        {
            txtOne.Focus();//puts the cursor in the txtX textbox

            btnShoot.Show();
            btnClose.Show();

            txtOne.Clear();

            lblDisplay.Text = "";

            lblName.Hide();
            lblIntro.Hide();

            txtName.Hide();

            btnPlay.Hide();
            btnShootagain.Hide();

            ptrWin.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            btnShootagain.Show();
            btnClose.Show();

            //Declare string huntArrayg
            string[,] hunt = new string[10, 10];

            //Initiate Jagged array for hunt
            

            //***************************************************************

            //declare the HITS and MISSES to display results
            int searchInt1;
            int result;

            searchInt1 = Convert.ToInt32(txtOne.Text);
            result = searchInt1;


            //Identify the list of labels to access and manipulate within the hunt array
            List<Label> lbl = new List<Label>() { lblA1, lblA2, lblA3, lblA4, lblA5, lblA6, lblA7, lblA8, lblA9, lblA10,
                                                  lblB1, lblB2, lblB3, lblB4, lblB5, lblB6, lblB7, lblB8, lblB9, lblB10, 
                                                  lblC1, lblC2, lblB3, lblC4, lblC5, lblC6, lblC7, lblC8, lblC9, lblC10,
                                                  lblD1, lblD2, lblB3, lblD4, lblD5, lblD6, lblD7, lblD8, lblD9, lblD10,
                                                  lblE1, lblE2, lblE3, lblB4, lblE5, lblE6, lblE7, lblE8, lblE9, lblE10,
                                                  lblF1, lblF2, lblF3, lblF4, lblF5, lblF6, lblF7, lblF8, lblF9, lblF10,
                                                  lblG1, lblG2, lblG3, lblG4, lblG5, lblG6, lblG7, lblG8, lblG9, lblG10,
                                                  lblH1, lblH2, lblB3, lblH4, lblH5, lblH6, lblH7, lblH8, lblH9, lblH10,
                                                  lblI1, lblI2, lblI3, lblI4, lblI5, lblI6, lblI7, lblI8, lblI9, lblI10,
                                                  lblJ1, lblJ2, lblJ3, lblJ4, lblJ5, lblJ6, lblJ7, lblJ8, lblJ9, lblJ10,
                                                };

            //iterate thru the hunt arrays rows and columns
            int rows = hunt.GetLength(0);
            int columns = hunt.GetLength(1);

            foreach (int i in Enumerable.Range(0, hunt.GetLength(0)))
                foreach (int j in Enumerable.Range(0, hunt.GetLength(1)))
                    //Console.WriteLine(hunt[i, j]);


                    if (result == 13)
                    {
                        hunt[1, 2] = "Submarine"; lblB3.Text = "S"; this.lblB3.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[1, 2] + " on the grid.";

                    }
                    else if (result == 23)
                    {
                        hunt[2, 2] = "Submarin"; this.lblC3.Text = "S"; this.lblC3.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[2, 2] + "  on the grid.";

                    }
                    else if (result == 52)
                    {
                        hunt[5, 1] = "Battleship"; this.lblF2.Text = "B"; this.lblF2.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[5, 1] + " on the grid.";

                    }
                    else if (result == 62)
                    {
                        hunt[6, 1] = "Battleship"; this.lblG2.Text = "B"; this.lblG2.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[6, 1] + " on the grid.";

                    }
                    else if (result == 72)
                    {
                        hunt[7, 1] = "Battleship"; this.lblH2.Text = "B"; this.lblH2.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[7, 1] + " on the grid.";

                    }
                    else if (result == 82)
                    {
                        hunt[8, 1] = "Battleship"; this.lblI2.Text = "B"; this.lblI2.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[8, 1] + " on the grid.";

                    }
                    else if (result == 92)
                    {
                        hunt[9, 1] = "Battleship"; this.lblJ2.Text = "B"; this.lblJ2.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[9, 1] + " on the grid.";

                    }

                    else if (result == 26)
                    {
                        hunt[2, 5] = "Destroyer"; this.lblC6.Text = "D"; this.lblC6.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[2, 5] + " on the grid.";

                    }

                    else if (result == 27)
                    {
                        hunt[2, 6] = "Destroyer"; this.lblC7.Text = "D"; this.lblC7.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[2, 6] + " on the grid.";

                    }
                    else if (result == 28)
                    {
                        hunt[2, 7] = "Destroyer"; this.lblC8.Text = "D"; this.lblC7.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[2, 7] + " on the grid.";

                    }
                    else if (result == 29)
                    {
                        hunt[2, 8] = "Destroyer"; this.lblC9.Text = "D"; this.lblC9.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[2, 8] + " on the grid.";

                    }
                    else if (result == 57)
                    {
                        hunt[5, 6] = "Patrol Boat "; this.lblF7.Text = "P"; this.lblF7.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[5, 6] + " on the grid.";

                    }
                    else if (result == 58)
                    {
                        hunt[5, 7] = "Patrol Boat "; this.lblF8.Text = "P"; this.lblF8.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[5, 7] + " on the grid.";

                    }
                    else if (result == 44)
                    {
                        hunt[4, 3] = "Cruiser"; this.lblE4.Text = "C"; this.lblE4.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[4, 3] + " on the grid.";

                    }
                    else if (result == 54)
                    {
                        hunt[5, 3] = "Cruiser"; this.lblF4.Text = "C"; this.lblF4.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[5, 3] + " on the grid.";

                    }
                    else if (result == 64)
                    {
                        hunt[6, 3] = "Cruiser"; this.lblG4.Text = "C"; this.lblG4.BackColor = Color.Brown;
                        lblDisplay.Text = "Congratulations. You have hit " + hunt[6, 3] + " on the grid.";

                    }


                    //DEFAULT - all numbers entered that are not declared are sent to the default statement
                    
                    else if (searchInt1 != 1)
                    {
                        lbl[searchInt1 - 1].Text = "Miss"; lbl[searchInt1 - 1].BackColor = Color.Black;
                        lblDisplay.Text = "Sorry, grid position " + searchInt1 + " hasn't found any ship. Try Again";


                    }
            if (result == 44 || result == 54 || result == 64)
            {
               Cruiser = Cruiser + 1;
                lblCruiser.Text = Cruiser.ToString();

            }
           
            if (result == 13 || result == 23)
            {
               Submarine = Submarine + 1;
                lblSub.Text = Submarine.ToString();
            }

            if (result == 57 || result == 58)
            {
                Patrol  = Patrol + 1;
                lblPatrol.Text = Patrol .ToString();
            }

            if (result == 26 || result == 27 || result == 28 || result == 29)
            {
                Destroyer = Destroyer + 1;
                lblDestroyer.Text = Destroyer.ToString();
            }

            if (result == 52 || result == 62 || result == 72 || result == 82 || result == 92)
            {
                Battle = Battle + 1;
                lblBattle.Text = Battle.ToString();
            }

            if (Patrol == 2)
            {
                lblPDestroyed.BackColor = Color.Red;
            }

            if (Cruiser == 3)
            {
                lblCDestroyed.BackColor = Color.Red;
            }

            if (Battle == 5)
            {
                lblBDestroyed.BackColor = Color.Red;
            }

            if (Submarine == 2)
            {
                lblSDestroyed.BackColor = Color.Red;
            }

            if (Destroyer == 4)
            {
                lblDDestroyed.BackColor = Color.Red;
            }

            if (result == 26 || result == 27 || result == 28 || result == 29 || result == 44 || result == 54 || result == 64 || result == 13 || result == 23 || result == 57 || result == 58 || result == 52 || result == 62 || result == 72 || result == 82 || result == 92)
            {
                Total = Total + 1;
                lblTotal.Text = Total.ToString();

            }

            if (Total == 16)
            {
                ptrWin.Show();
            }


        }
    }
}

        
        
    