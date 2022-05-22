﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITHelpWinFrm.EF;
using ITHelpWinFrm.Utils;

namespace ITHelpWinFrm
{
    public partial class Reg_Form : Form
    {
        public Reg_Form()
        {
            InitializeComponent();
        }

        private void Reg_Form_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DatabaseContext.db.User.ToList();
            genderBindingSource.DataSource = DatabaseContext.db.Gender.ToList();
            officeBindingSource.DataSource = DatabaseContext.db.Office.ToList();
            roleBindingSource.DataSource = DatabaseContext.db.Role.ToList();
        }

        private void Closebut_Click(object sender, EventArgs e)
        {
            Admin_Form FRMAdm = new Admin_Form();
            this.Close();
            FRMAdm.Show();
        }

        private void Regbut_Click(object sender, EventArgs e)
        {
            int id_Office;
            bool bid_Office = int.TryParse(iD_OfficeComboBox.Text, out id_Office);
            if (bid_Office == false)
            {
                MessageBox.Show("Неверный формат ID"+iD_OfficeComboBox);
                return;
            }
            int gender;
            bool bgen = int.TryParse(iD_OfficeComboBox.Text, out gender);
            if (bgen == false)
            {
                MessageBox.Show("Неверный формат ID" + iD_GenderComboBox);
                return;
            }
            int role;
            bool brole = int.TryParse(iD_OfficeComboBox.Text, out role);
            if (brole == false)
            {
                MessageBox.Show("Неверный формат ID" + рольComboBox);
                return;
            }
            User usr = new User();
            usr.Логин = логинTextBox.Text;
            usr.Пароль = парольTextBox.Text;
            usr.ФИО = фИОTextBox.Text;
            usr.Дата_Рождения = дата_РожденияDateTimePicker.ToString();
            usr.Почта = почтаTextBox.Text;
            usr.ID_Gender = gender;
            usr.ID_Office =id_Office;
            usr.ID_Role = role;
            DatabaseContext.db.User.Add(usr);
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }
    }
}
