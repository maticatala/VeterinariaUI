﻿using CapaDatos.Contracts;
using CapaDatos.Repository;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.Usuarios
{
    public partial class frmLogin : Form
    {
        private CN_Usuario cN_user = new CN_Usuario();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usr = cN_user.LoginUser(txtUsuario.Text, txtPassword.Text);
                MainForm frm = new MainForm(usr);
                this.Hide();
                frm.Show();
                frm.FormClosed += Logout;
                
            } catch (Exception ex)
            {
                msgErrror(ex.Message);
                LimpiarCampos();
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Show();
            txtUsuario.Focus();
            lblErrorMessage.Visible = false;
        }


        private void msgErrror(string msg)
        {
            lblErrorMessage.Text = "   "+msg;
            lblErrorMessage.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPage_Click(object sender, EventArgs e)
        {

        }
    }
}
