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
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;


namespace PilotEdgeToolbox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      WebClient Client = new WebClient();
      string myTempFileOrig = Path.Combine(Path.GetTempPath(), "pe.txt");
      string myTempFileParsed = Path.Combine(Path.GetTempPath(), "pe_parsed.txt");
      string myTempFileInfo = Path.Combine(Path.GetTempPath(), "pe_info.txt");
      string myTempFilePilots = Path.Combine(Path.GetTempPath(), "pe_pilots.txt");
      Client.DownloadFile("http://map.pilotedge.net/vspro.dat", myTempFileOrig);

      using (Stream fileStream = File.Open(myTempFileOrig, FileMode.Open))
      using (StreamReader reader = new StreamReader(fileStream))
      {
        using (StreamWriter sw = new StreamWriter(myTempFileParsed))
        {
          using (StreamWriter swinfo = new StreamWriter(myTempFileInfo))
          {
            using (StreamWriter swpilots = new StreamWriter(myTempFilePilots))
            {

              string line = null;
              int pilot_count = 0;
              int drone_count = 0;
              int ifr_pilots = 0;
              int vfr_pilots = 0;
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

                      string year = parts[37].Substring(0, 4);
                      string month = parts[37].Substring(4, 2);
                      string day = parts[37].Substring(6, 2);
                      string hour = parts[37].Substring(8, 2);
                      string minute = parts[37].Substring(10, 2);
                      string second = parts[37].Substring(12, 2);
                      string con_string = $"{month}/{day}/{year} {hour}:{minute}:{second}";
                      DateTime date_obj = Convert.ToDateTime(con_string);
                      string date_str = date_obj.ToString("MM'/'dd'/'yyyy HH':'mm':'ss");
                      string f_rules = "";
                      if (parts[21] == "I") { f_rules = "IFR"; ifr_pilots += 1; } else if (parts[21] == "V") { f_rules = "VFR"; vfr_pilots += 1; }
                      string row_string = $"{parts[0]}, {parts[2]}, {parts[9]}, {parts[11]}, {parts[13]},  {f_rules}, {date_str}, {parts[5]}, {parts[6]}";
                      swpilots.WriteLine(row_string);
                    }
                  }
                }

              } while (true);

              swinfo.WriteLine($"Pilots on the network: {pilot_count}");
              swinfo.WriteLine($"Drones on the network: {drone_count}");
              swinfo.WriteLine($"IFR flights: {ifr_pilots}; VFR flights: {pilot_count - ifr_pilots}");
            }
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

      List<string[]> rows_pilots = File.ReadAllLines(myTempFilePilots).Select(x => x.Split(',')).ToList();
      DataTable dt_pilots = new DataTable();
      dt_pilots.Columns.Add("Callsign");
      dt_pilots.Columns.Add("Name");
      dt_pilots.Columns.Add("A/C");
      dt_pilots.Columns.Add("From");
      dt_pilots.Columns.Add("To");
      dt_pilots.Columns.Add("Rules");
      dt_pilots.Columns.Add("Onilne since");
      dt_pilots.Columns.Add("Lat");
      dt_pilots.Columns.Add("Lon");
      rows_pilots.ForEach(x =>
      {
        dt_pilots.Rows.Add(x);
      });
      dataGridViewPilots.DataSource = dt_pilots;
      dataGridViewPilots.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dataGridViewPilots.Columns[2].Width = 60;
      dataGridViewPilots.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dataGridViewPilots.Columns[3].Width = 60;
      dataGridViewPilots.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dataGridViewPilots.Columns[4].Width = 60;
      dataGridViewPilots.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dataGridViewPilots.Columns[5].Width = 60;
      dataGridViewPilots.Columns[7].Visible = false;
      dataGridViewPilots.Columns[8].Visible = false;
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      string myTempFileInfo = Path.Combine(Path.GetTempPath(), "pe_info.txt");
      TextReader reder = File.OpenText(myTempFileInfo);
      richTextBoxInfo.Text = reder.ReadToEnd();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AboutBox1 a = new AboutBox1();
      a.Show();
    }

    private void gMapControl1_Load(object sender, EventArgs e)
    {
      gMapControl1.MapProvider = BingMapProvider.Instance;
      GMaps.Instance.Mode = AccessMode.ServerOnly;
      gMapControl1.Position = new PointLatLng(35.4057297, -117.2676734);
      gMapControl1.ShowCenter = false;

      GMapOverlay markers = new GMapOverlay("markers");
      string myTempFilePilots = Path.Combine(Path.GetTempPath(), "pe_pilots.txt");
      List<string[]> rows = File.ReadAllLines(myTempFilePilots).Select(x => x.Split(',')).ToList();
      rows.ForEach(x =>
      {
        if (x[5].Trim() == "IFR")
        {
          GMapMarker marker = new GMarkerGoogle(new PointLatLng(Double.Parse(x[7]), Double.Parse(x[8])), GMarkerGoogleType.blue_small);
          string tooltip_string = $"{x[0].Trim()}\n{x[1].Trim()}\n{x[2].Trim()}\n{x[3].Trim()}-{x[4].Trim()}";
          marker.ToolTipText = tooltip_string;
          markers.Markers.Add(marker);
        }
        else
        {
          GMapMarker marker = new GMarkerGoogle(new PointLatLng(Double.Parse(x[7]), Double.Parse(x[8])), GMarkerGoogleType.green_small);
          string tooltip_string = $"{x[0].Trim()}\n{x[1].Trim()}\n{x[2].Trim()}\n{x[3].Trim()}-{x[4].Trim()}";
          marker.ToolTipText = tooltip_string;
          markers.Markers.Add(marker);
        }
      });
      gMapControl1.Overlays.Add(markers);
    }
  }
}
