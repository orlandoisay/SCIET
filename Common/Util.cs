using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Util
    {
        public static String GetSolutionFolder()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }

        public static String GetLogoPath()
        {
            return Path.Combine(
                    Util.GetSolutionFolder(),
                    "Common",
                    "Resources",
                    Properties.Settings.Default.LOGO_PATH);
        }
    }
}
