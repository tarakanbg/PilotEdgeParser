namespace PilotEdgeParser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
      this.dataGridViewATC = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATC)).BeginInit();
      this.SuspendLayout();
      // 
      // richTextBoxInfo
      // 
      this.richTextBoxInfo.Location = new System.Drawing.Point(13, 0);
      this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.richTextBoxInfo.Name = "richTextBoxInfo";
      this.richTextBoxInfo.ReadOnly = true;
      this.richTextBoxInfo.Size = new System.Drawing.Size(536, 66);
      this.richTextBoxInfo.TabIndex = 0;
      this.richTextBoxInfo.Text = "";
      this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // dataGridViewATC
      // 
      this.dataGridViewATC.AllowUserToAddRows = false;
      this.dataGridViewATC.AllowUserToDeleteRows = false;
      this.dataGridViewATC.AllowUserToOrderColumns = true;
      this.dataGridViewATC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewATC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridViewATC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewATC.Location = new System.Drawing.Point(13, 73);
      this.dataGridViewATC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dataGridViewATC.Name = "dataGridViewATC";
      this.dataGridViewATC.ReadOnly = true;
      this.dataGridViewATC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
      this.dataGridViewATC.Size = new System.Drawing.Size(536, 197);
      this.dataGridViewATC.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(562, 271);
      this.Controls.Add(this.dataGridViewATC);
      this.Controls.Add(this.richTextBoxInfo);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.Text = "Pilotedge Active Controllers";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATC)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewATC;
    }
}

