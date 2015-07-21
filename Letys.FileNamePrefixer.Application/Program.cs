using Letys.FileNamePrefixer.File;
using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Letys.FileNamePrefixer.Log;

namespace Letys.FileNamePrefixer.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = string.Empty;
            string target = string.Empty;
            int prefixLength = 5;
            bool showHelp = false;

            ILog log = LogFactory.GetFileLogger();

            var p = new OptionSet()
            {
                { "s=|source=", s => source = s },
                { "t=|target=", t => target = t },
                { "l=|length=", l => prefixLength = Convert.ToInt32(l) },
                { "h|?|help", v => showHelp = true }
            };

            p.Parse(args);

            if (showHelp)
            {
                DisplayCommandLineDetails();
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                Console.WriteLine("The source is missing.");

                return;
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                Console.WriteLine("The target is missing.");
                return;
            }

            try
            {
                IFileController fc = FileControllerFactory.CreateFileController(source, target);
                fc.ConvertFiles();

                string message = string.Format("I've added prefix to {0} file(s).", fc.ConvertedFiles.Count);

                Console.WriteLine(message);
                log.Info(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Converting files ended with error.");
                log.Error(ex);
            }

            Console.WriteLine("\nPress key ...");
            Console.ReadKey();
        }

        static void DisplayCommandLineDetails()
        {
            Console.WriteLine("s|source - the source folder");
            Console.WriteLine("t|target - the target folder");
            Console.WriteLine("l|length - the length of prefix");
            Console.WriteLine("h|?|help - display help");
        }
    }
}
