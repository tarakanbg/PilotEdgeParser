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
            string myTempFileInfo = Path.Combine(Path.GetTempPath(), "pe_info.txt");
            Client.DownloadFile("http://map.pilotedge.net/vspro.dat", myTempFileOrig);
            // open the file in a way so that we can read it line by line
            using (Stream fileStream = File.Open(myTempFileOrig, FileMode.Open))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                using (StreamWriter sw = new StreamWriter(myTempFileParsed))
                {

                    using (StreamWriter swinfo = new StreamWriter(myTempFileInfo))
                    {

                        string line = null;
                        int pilot_count = 0;
                        int drone_count = 0;
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
                                    string row_string = parts[0] + "," + parts[2];
                                    sw.WriteLine(row_string);
                                }

                                else if (parts[3] == "PILOT")

                                {
                                    if (parts[2] == "DRONE")
                                    {
                                        drone_count += 1;
                                    } else
                                    {
                                        pilot_count += 1;
                                    }
                                }
                            }

                        } while (true);

                        swinfo.WriteLine($"Pilots on the network: {pilot_count}");
                        swinfo.WriteLine($"Drones on the network: {drone_count}");
                    }

                }
               
            }
           
            InitializeComponent();

            TextReader reder = File.OpenText(myTempFileInfo);
            richTextBox1.Text = reder.ReadToEnd();

            List<string[]> rows = File.ReadAllLines(myTempFileParsed).Select(x => x.Split(',')).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Callsign");
            dt.Columns.Add("Name");
            rows.ForEach(x => {
                dt.Rows.Add(x);
            });
            dataGridView1.DataSource = dt;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string myTempFileInfo = Path.Combine(Path.GetTempPath(), "pe_info.txt");
            string myTempFileParsed = Path.Combine(Path.GetTempPath(), "pe_parsed.txt");
            TextReader reder = File.OpenText(myTempFileInfo);
            richTextBox1.Text = reder.ReadToEnd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
