using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Entity;
using FootballClubMS.Repository;
using System.Data.Sql;
using System.Data.SqlClient;
using FootballClubMS.Framework;

namespace FootballClubMS.Applications
{
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        public Login l;
        private DataSet Ds { get; set; }
        private EmployeeEntity em;
        public Manager(Login l,string id)
        {
            InitializeComponent();
            this.l = l;
            this.Ds = EmployeeRepository.GetSpecificEmployee(id);
            this.em = new EmployeeEntity(Ds);
            this.txtManagerId.Text = em.Id;
            this.txtManagerName.Text = em.Name;
            this.txtManagerEmail.Text = em.Email;
            this.txtManagerSalary.Text = em.Salary.ToString();
            PopulateGridViewPlayers();
        }
        public void PopulateGridViewPlayers()
        {
            try
            {
                this.Ds = PlayerRepository.GetAllPlayers();
                this.dgvPlayers.AutoGenerateColumns = false;
                this.dgvPlayers.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void PopulateGridViewPlayersSearched()
        {
            try
            {
                this.Ds = PlayerRepository.SearchPlayer(this.txtPlayerSearch.Text);
                this.dgvPlayers.AutoGenerateColumns = false;
                this.dgvPlayers.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
                
        }

        public void GenerateSquadWithFormation1()
        {
            try
            {
                this.Ds = PlayerRepository.GetTwoStriker();
                string str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                string str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                this.lblCf1F1.Text = str;
                this.lblCf2F1.Text = str1;

                this.Ds = PlayerRepository.GetFourMidfielder();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                string str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                string str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                this.lblMid1F1.Text = str;
                this.lblMid2F1.Text = str1;
                this.lblMid3F1.Text = str2;
                this.lblMid4F1.Text = str3;


                this.Ds = PlayerRepository.GetFourDefender();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                this.lblDef1F1.Text = str;
                this.lblDef2F1.Text = str1;
                this.lblDef3F1.Text = str2;
                this.lblDef4F1.Text = str3;

                this.Ds = PlayerRepository.GetGoalkeeper();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                this.lblGkF1.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Short of players");
            }

        }

        private void GenerateSquadWithFormation2()
        {

            try
            {
                this.Ds = PlayerRepository.GetThreeStriker();
                string str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                string str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                string str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                this.lblCf1F2.Text = str;
                this.lblCf2F2.Text = str1;
                this.lblCf3F2.Text = str2;

                this.Ds = PlayerRepository.GetThreeMidfielder();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                this.lblMid1F2.Text = str;
                this.lblMid2F2.Text = str1;
                this.lblMid3F2.Text = str2;


                this.Ds = PlayerRepository.GetFourDefender();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                string str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                this.lblDef1F2.Text = str;
                this.lblDef2F2.Text = str1;
                this.lblDef3F2.Text = str2;
                this.lblDef4F2.Text = str3;

                this.Ds = PlayerRepository.GetGoalkeeper();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                this.lblGkF2.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Short of players");
            }

        }

        public void GenerateSquadWithFormation3()
        {
            try
            {
                this.Ds = PlayerRepository.GetOneStriker();
                string str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                this.lblCfF3.Text = str;


                this.Ds = PlayerRepository.GetFourMidfielder();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                String str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                string str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                string str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                this.lblMid1F3.Text = str;
                this.lblMid2F3.Text = str1;
                this.lblMid3F3.Text = str2;
                this.lblMid4F3.Text = str3;


                this.Ds = PlayerRepository.GetFiveDefender();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                string str4 = Ds.Tables[0].Rows[4]["Player_name"].ToString();
                this.lblDef1F3.Text = str;
                this.lblDef2F3.Text = str1;
                this.lblDef3F3.Text = str2;
                this.lblDef4F3.Text = str3;
                this.lblDef5F3.Text = str4;

                this.Ds = PlayerRepository.GetGoalkeeper();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                this.lblGkF3.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Short of players");
            }

        }
        public void GenerateSquadWithFormation4()
        {
            try
            {
                this.Ds = PlayerRepository.GetTwoStriker();
                string str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                string str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                this.lblCf1F4.Text = str;
                this.lblCf2F4.Text = str1;

                this.Ds = PlayerRepository.GetThreeMidfielder();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                string str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                this.lblMid1F4.Text = str;
                this.lblMid2F4.Text = str1;
                this.lblMid3F4.Text = str2;



                this.Ds = PlayerRepository.GetFiveDefender();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                string str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                string str4 = Ds.Tables[0].Rows[4]["Player_name"].ToString();
                this.lblDef1F4.Text = str;
                this.lblDef2F4.Text = str1;
                this.lblDef3F4.Text = str2;
                this.lblDef4F4.Text = str3;
                this.lblDef5F4.Text = str4;

                this.Ds = PlayerRepository.GetGoalkeeper();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                this.lblGkF4.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Short of players");
            }

        }
        public void GenerateSquadWithFormation5()
        {
            try
            {
                this.Ds = PlayerRepository.GetTwoStriker();
                string str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                string str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                this.lblCf1F5.Text = str;
                this.lblCf2F5.Text = str1;

                this.Ds = PlayerRepository.GetFiveMidfielder();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                string str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                string str3 = Ds.Tables[0].Rows[3]["Player_name"].ToString();
                string str4 = Ds.Tables[0].Rows[4]["Player_name"].ToString();
                this.lblMid1F5.Text = str;
                this.lblMid2F5.Text = str1;
                this.lblMid3F5.Text = str2;
                this.lblMid4F5.Text = str3;
                this.lblMid5F5.Text = str4;


                this.Ds = PlayerRepository.GetThreeDefender();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                str1 = Ds.Tables[0].Rows[1]["Player_name"].ToString();
                str2 = Ds.Tables[0].Rows[2]["Player_name"].ToString();
                this.lblDef1F5.Text = str;
                this.lblDef2F5.Text = str1;
                this.lblDef3F5.Text = str2;


                this.Ds = PlayerRepository.GetGoalkeeper();
                str = Ds.Tables[0].Rows[0]["Player_name"].ToString();
                this.lblGkF5.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Short of players");
            }

        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CmbFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbFormation.Text == "4-4-2")
            {
                GenerateSquadWithFormation1();
                this.pnlFormation1.Visible = true;
                this.pnlFormation2.Visible = false;
                this.pnlFormation3.Visible = false;
                this.pnlFormation4.Visible = false;
                this.pnlFormation5.Visible = false;
            }
            else if (this.cmbFormation.Text == "4-3-3")
            {
                GenerateSquadWithFormation2();
                this.pnlFormation2.Visible = true;
                this.pnlFormation1.Visible = false;
                this.pnlFormation3.Visible = false;
                this.pnlFormation4.Visible = false;
                this.pnlFormation5.Visible = false;
            }
            else if (this.cmbFormation.Text == "5-4-1")
            {
                GenerateSquadWithFormation3();
                this.pnlFormation3.Visible = true;
                this.pnlFormation2.Visible = false;
                this.pnlFormation1.Visible = false;
                this.pnlFormation4.Visible = false;
                this.pnlFormation5.Visible = false;
            }
            else if (this.cmbFormation.Text == "5-3-2")
            {
                GenerateSquadWithFormation4();
                this.pnlFormation4.Visible = true;
                this.pnlFormation2.Visible = false;
                this.pnlFormation1.Visible = false;
                this.pnlFormation3.Visible = false;
                this.pnlFormation5.Visible = false;
            }
            else if (this.cmbFormation.Text == "3-5-2")
            {
                GenerateSquadWithFormation5();
                this.pnlFormation5.Visible = true;
                this.pnlFormation2.Visible = false;
                this.pnlFormation1.Visible = false;
                this.pnlFormation3.Visible = false;
                this.pnlFormation4.Visible = false;

            }
            else
            {
                MessageBox.Show("nothing");
            }

        }

        private void TxtPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGridViewPlayersSearched();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
              try
            {

                if (Validation.IsStringValid(this.txtOldPassword.Text) == true && Validation.IsStringValid(this.txtNewPassword.Text) == true)
                {


                    LoginEntity le = new LoginEntity(this.em.Id, this.txtOldPassword.Text.ToString());
                    bool check = LoginRepository.SearchUser(le);
                    if (check)
                    {
                        LoginRepository.UpdateUserPassword(le, this.txtNewPassword.Text.ToString());
                        MessageBox.Show("Password updated");
                        this.txtOldPassword.Text = "";
                        this.txtNewPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Insert Correct password");
                    }
                }
                else
                {
                    MessageBox.Show("Insert Password");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.Visible = true;
        }

        private void BtnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                double performance = 0;
                if ((Validation.IsStringValid(this.txtPlayerId.Text) == true) && (Validation.IsStringValid(this.txtGoalCount.Text) == true) && (Validation.IsStringValid(this.txtAssistCount.Text) == true) && (Validation.IsStringValid(this.txtBigChanceCreate.Text) == true) && (Validation.IsStringValid(this.txtBigChanceMissed.Text) == true) && (Validation.IsStringValid(this.txtClearence.Text) == true) && (Validation.IsStringValid(this.txtError.Text) == true) && (Validation.IsStringValid(this.txtSave.Text) == true) && (Validation.IsStringValid(this.txtPenaltySave.Text) == true))
                {
                    string id = this.txtPlayerId.Text;
                    int goalCount = Convert.ToInt32(this.txtGoalCount.Text);
                    int assistCount = Convert.ToInt32(this.txtAssistCount.Text);
                    int bigChanceCreateCount = Convert.ToInt32(this.txtBigChanceCreate.Text);
                    int bigChanceMissedCount = Convert.ToInt32(this.txtBigChanceMissed.Text);
                    int clearenceCount = Convert.ToInt32(this.txtClearence.Text);
                    int saveCount = Convert.ToInt32(this.txtSave.Text);
                    int penaltySaveCount = Convert.ToInt32(this.txtPenaltySave.Text);
                    int errorLeadToGoalCount = Convert.ToInt32(this.txtError.Text);


                    this.Ds = PlayerRepository.GetPlayerPosition(id);
                    string s = Ds.Tables[0].Rows[0]["Position"].ToString();

                    if (s == "defender")
                    {
                        performance = goalCount * 6 + assistCount * 3 + bigChanceCreateCount * 2 + bigChanceMissedCount * (-2) + clearenceCount * 2 + errorLeadToGoalCount * (-5);
                        {
                            if (performance > 10)
                                performance = 10;
                        }

                        PlayerRepository.SetPlayerPerformance(performance, id);
                        MessageBox.Show("Updated");
                        PopulateGridViewPlayers();
                        this.txtPlayerId.Text = "";
                        this.txtGoalCount.Text = "";
                        this.txtAssistCount.Text = "";
                        this.txtBigChanceCreate.Text = "";
                        this.txtBigChanceMissed.Text = "";
                        this.txtClearence.Text = "";
                        this.txtSave.Text = "";
                        this.txtPenaltySave.Text = "";
                        this.txtError.Text = "";


                    }

                    else if (s == "midfielder")
                    {
                        performance = goalCount * 5 + assistCount * 4 + bigChanceCreateCount * 2 + bigChanceMissedCount * (-2) + clearenceCount * 2;
                        {
                            if (performance > 10)
                                performance = 10;
                        }
                        PlayerRepository.SetPlayerPerformance(performance, id);
                        MessageBox.Show("Updated");
                        PopulateGridViewPlayers();
                        this.txtPlayerId.Text = "";
                        this.txtGoalCount.Text = "";
                        this.txtAssistCount.Text = "";
                        this.txtBigChanceCreate.Text = "";
                        this.txtBigChanceMissed.Text = "";
                        this.txtClearence.Text = "";
                        this.txtSave.Text = "";
                        this.txtPenaltySave.Text = "";
                        this.txtError.Text = "";
                    }
                    else if (s == "striker")
                    {
                        performance = goalCount * 4 + assistCount * 2 + bigChanceCreateCount * 2 + bigChanceMissedCount * (-2) + clearenceCount * 2;
                        {
                            if (performance > 10)
                                performance = 10;
                        }
                        PlayerRepository.SetPlayerPerformance(performance, id);
                        MessageBox.Show("Updated");
                        PopulateGridViewPlayers();
                        this.txtPlayerId.Text = "";
                        this.txtGoalCount.Text = "";
                        this.txtAssistCount.Text = "";
                        this.txtBigChanceCreate.Text = "";
                        this.txtBigChanceMissed.Text = "";
                        this.txtClearence.Text = "";
                        this.txtSave.Text = "";
                        this.txtPenaltySave.Text = "";
                        this.txtError.Text = "";
                    }
                    else if (s == "goalkeeper")
                    {
                        performance = clearenceCount * 3 + errorLeadToGoalCount * (-4) + saveCount * 2 + penaltySaveCount * 4;
                        {
                            if (performance > 10)
                                performance = 10;
                        }
                        PlayerRepository.SetPlayerPerformance(performance, id);
                        MessageBox.Show("Updated");
                        PopulateGridViewPlayers();
                        this.txtPlayerId.Text = "";
                        this.txtGoalCount.Text = "";
                        this.txtAssistCount.Text = "";
                        this.txtBigChanceCreate.Text = "";
                        this.txtBigChanceMissed.Text = "";
                        this.txtClearence.Text = "";
                        this.txtSave.Text = "";
                        this.txtPenaltySave.Text = "";
                        this.txtError.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("i am in else");
                    }
                }

                else
                {
                    MessageBox.Show("Insert All field properly");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input correct values");
            }
        }

        private void DgvPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtPlayerId.Text = this.dgvPlayers.CurrentRow.Cells["player_id"].Value.ToString();
        }
    }
}
