﻿using GTA3TOOLS.EditorForms;
using RageCore.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA3TOOLS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var gtaPath = new GTAPATH("gta3.exe");

            //Application.Run(new Gta3ExplorerForm(gtaPath));

            Application.Run(new ModelView());
        }
    }
}
