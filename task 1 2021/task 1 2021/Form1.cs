using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1_2021
{
    public partial class frm1 : Form
    {
        GameEngine gameEngine;
        public frm1()
        {
            InitializeComponent();

            gameEngine = new GameEngine();
            lblMap.Text = gameEngine.View;
            InitializeComponent();
            btnAttack.Enabled = false;
            //lblStats.Text = Hero.ToString(); //(donno why this doesn't work, tired)

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Up);
            lblMap.Text = gameEngine.View;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Down);
            lblMap.Text = gameEngine.View;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Left);
            lblMap.Text = gameEngine.View;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.Right);
            lblMap.Text = gameEngine.View;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            //Attack
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveGame();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGame();
        }
        private void SaveGame()
        {
            gameEngine.Save();
            UpdateDisplay();
        }

        private void LoadGame()
        {
            gameEngine.Load();
            lblStats.Text = gameEngine.HeroStats;
            lblMap.Text = gameEngine.View;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblMap.Text = gameEngine.Map.ToString();
            lblStats.Text = gameEngine.PlayerStats;
        }


        // test
    }
}
