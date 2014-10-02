﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());     
            if (CapaConexion.Usuario.Logueado) {
                Application.Run(new frmPrincipal());
            }
        }
    }
}