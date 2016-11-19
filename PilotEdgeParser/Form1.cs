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
              line = reader.ReadLine();
              if (line == null)
              {
                // there are no more lines; break out of the loop
                break;
              }

              string[] parts = line.Split(':');
              // "CS" in parts[0] 
              // "Name" in parts[2] 
              // "ROLE" in parts[3] 

              if (parts.Length > 2)
              {
                if (parts[3] == "ATC")
                {
                  string year = parts[37].Substring(0, 4);
                  string month = parts[37].Substring(4, 2);
                  string day = parts[37].Substring(6, 2);
                  string hour = parts[37].Substring(8, 2);
                  string minute = parts[37].Substring(10, 2);
                  string second = parts[37].Substring(12, 2);
                  string con_string = $"{month}/{day}/{year} {hour}:{minute}:{second}";
                  DateTime date_obj = Convert.ToDateTime(con_string);
                  string date_str = date_obj.ToString("MM'/'dd'/'yyyy HH':'mm':'ss");
                  string row_string = parts[0] + "," + parts[2] + "," + date_str;
                  sw.WriteLine(row_string);
                }

                else if (parts[3] == "PILOT")

                {
                  if (parts[2] == "DRONE")
                  {
                    drone_count += 1;
                  }
                  else
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
      richTextBoxInfo.Text = reder.ReadToEnd();

      List<string[]> rows = File.ReadAllLines(myTempFileParsed).Select(x => x.Split(',')).ToList();
      DataTable dt = new DataTable();
      dt.Columns.Add("Callsign");
      dt.Columns.Add("Name");
      dt.Columns.Add("Onilne since");
      rows.ForEach(x =>
      {
        dt.Rows.Add(x);
      });
      dataGridViewATC.DataSource = dt;
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      string myTempFileInfo = Path.Combine(Path.GetTempPath(), "pe_info.txt");
      TextReader reder = File.OpenText(myTempFileInfo);
      richTextBoxInfo.Text = reder.ReadToEnd();
    }
  }
}
