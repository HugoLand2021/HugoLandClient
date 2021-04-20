﻿using Hugo_LAND.Client.HugoLandServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hugo_LAND.Client.Vue
{
    public partial class frmCreateHero : Form
    {
        private readonly Random _random = new Random();
        private string nomCompte;
        private readonly HeroServiceClient HeroService = new HeroServiceClient();
        private readonly AccountServiceClient compteJoueurService = new AccountServiceClient();
        private readonly WorldServiceClient worldServiceClient = new WorldServiceClient();
        private readonly ClassServiceClient classServiceClient = new ClassServiceClient();
        private readonly List<WorldDetailsDTO> worldsList = new List<WorldDetailsDTO>();
        private readonly List<ClassDetailsDTO> classList = new List<ClassDetailsDTO>();

        public frmCreateHero(frmMain main)
        {
            InitializeComponent();
            nomCompte = main.accountDetails.PlayerName;
            worldsList = worldServiceClient.GetAllWorldNames().ToList();
            classList = classServiceClient.GetAllClasses().ToList();
            cmbDescription.DataSource = worldsList.Select(w => w.Description).ToList();
            cmbNomClass.DataSource = classList.Select(c => c.ClassName).ToList();
            UpdateStats();

        }

        private void btnCreateHeroFrm_Click(object sender, EventArgs e)
        {
            HeroDetailsDTO hero = new HeroDetailsDTO()
            {
                HeroName = txtnomHero.Text,
                StatDex = int.Parse(txtstatBaseDex.Text),
                StatInt = int.Parse(txtstatBaseInt.Text),
                StatStr = int.Parse(txtstatBaseStr.Text),
                StatVitality = int.Parse(txtstatBaseVitalite.Text),
                Class = cmbNomClass.Text,
                World = cmbDescription.Text,
                UserName = nomCompte
            };
            HeroService.CreateHero(hero);
        }

        private void btnCancelHeroFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStats()
        {
            var currClass = classList[cmbNomClass.SelectedIndex];

            txtstatBaseDex.Text = (currClass.StatBaseDex + _random.Next(0, 11)).ToString();
            txtstatBaseInt.Text = (currClass.StatBaseInt + _random.Next(0, 11)).ToString(); ;
            txtstatBaseStr.Text = (currClass.StatBaseStr + _random.Next(0, 11)).ToString(); ;
            txtstatBaseVitalite.Text = (currClass.StatBaseVitality + _random.Next(0, 11)).ToString(); ;

        }

        private void cmbNomClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }
    }
}
