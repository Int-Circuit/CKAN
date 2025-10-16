using System;
using Eto.Forms;
using System.IO;

namespace GUI_Test
{
    public class AboutHelper

    {
        public static void ShowAboutDiag(Form parent)
        {
			var About = new AboutDialog
            {
                Title = "Test",
			    Website = new Uri ("https://github.com/KSP-CKAN/CKAN/"),
                Logo = PathHelper.Logo,
            };
			About.ShowDialog(parent);       
        }
    }
}