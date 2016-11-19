using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace PilotEdgeParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            WebClient Client = new WebClient();
            string myTempFileOrig = Path.Combine(Path.GetTempPath(), "pe.txt");
            string myTempFileParsed = Path.Combine(Path.GetTempPath(), "pe_parsed.txt");
            Client.DownloadFile("http://map.pilotedge.net/vspro.dat", myTempFileOrig);
            // open the file in a way so that we can read it line by line
            using (Stream fileStream = File.Open(myTempFileOrig, FileMode.Open))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                using (StreamWriter sw = new StreamWriter(myTempFileParsed))
                {
                    
                    string line = null;
                    do
                    {
                        // get the next line from the file
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            // there are no more lines; break out of the loop
                            break;
                        }

                        // split the line on each semicolon character
                        string[] parts = line.Split(':');
                        // now the array contains values as such:
                        // "CS" in parts[0] 
                        // "Surname" in parts[1] 
                        // "Name" in parts[2] 
                        // "ROLE" in parts[3] 

                        if (parts.Length > 2)
                        {
                            if (parts[3] == "ATC")
                            {
                                string row_string = parts[0] + " - " + parts[2];
                                sw.WriteLine(row_string);
                            }
                        }

                    } while (true);
                }
               
            }
            InitializeComponent();
            TextReader reder = File.OpenText(myTempFileParsed);
            richTextBox1.Text = reder.ReadToEnd();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string myTempFileOrig = Path.Combine(Path.GetTempPath(), "pe.txt");
            string myTempFileParsed = Path.Combine(Path.GetTempPath(), "pe_parsed.txt");
            TextReader reder = File.OpenText(myTempFileParsed);
            richTextBox1.Text = reder.ReadToEnd();
        }
    }
}
