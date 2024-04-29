namespace ATTENDANCE
{
    partial class attendance
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
            this.pnl_header = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_adminPanel = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtTimein = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAdminPanel = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTimein = new System.Windows.Forms.Label();
            this.lblTImeout = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.pnl_adminPanel.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(7)))), ((int)(((byte)(80)))));
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Location = new System.Drawing.Point(3, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1304, 100);
            this.pnl_header.TabIndex = 0;
            // 
            // pnl_adminPanel
            // 
            this.pnl_adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(7)))), ((int)(((byte)(80)))));
            this.pnl_adminPanel.Controls.Add(this.btnLogOut);
            this.pnl_adminPanel.Controls.Add(this.txtAdminPanel);
            this.pnl_adminPanel.Location = new System.Drawing.Point(12, 115);
            this.pnl_adminPanel.Name = "pnl_adminPanel";
            this.pnl_adminPanel.Size = new System.Drawing.Size(259, 583);
            this.pnl_adminPanel.TabIndex = 1;
            this.pnl_adminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.lblTImeout);
            this.pnlDashboard.Controls.Add(this.lblTimein);
            this.pnlDashboard.Controls.Add(this.lblDate);
            this.pnlDashboard.Controls.Add(this.lblID);
            this.pnlDashboard.Controls.Add(this.btnUpdate);
            this.pnlDashboard.Controls.Add(this.txtTimeout);
            this.pnlDashboard.Controls.Add(this.txtTimein);
            this.pnlDashboard.Controls.Add(this.txtDate);
            this.pnlDashboard.Controls.Add(this.txtID);
            this.pnlDashboard.Controls.Add(this.dgvAttendance);
            this.pnlDashboard.Location = new System.Drawing.Point(290, 115);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1001, 583);
            this.pnlDashboard.TabIndex = 0;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(3, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(695, 55);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "ATTENDANCE MANAGEMENT";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Time_In,
            this.Time_out,
            this.Date});
            this.dgvAttendance.Location = new System.Drawing.Point(205, 18);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(570, 199);
            this.dgvAttendance.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Time_In
            // 
            this.Time_In.HeaderText = "Time In";
            this.Time_In.MinimumWidth = 6;
            this.Time_In.Name = "Time_In";
            this.Time_In.Width = 125;
            // 
            // Time_out
            // 
            this.Time_out.HeaderText = "Time Out";
            this.Time_out.MinimumWidth = 6;
            this.Time_out.Name = "Time_out";
            this.Time_out.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(205, 262);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 30);
            this.txtID.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(493, 262);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(282, 30);
            this.txtDate.TabIndex = 2;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeout.Location = new System.Drawing.Point(493, 330);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(282, 30);
            this.txtTimeout.TabIndex = 4;
            // 
            // txtTimein
            // 
            this.txtTimein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimein.Location = new System.Drawing.Point(205, 330);
            this.txtTimein.Name = "txtTimein";
            this.txtTimein.Size = new System.Drawing.Size(282, 30);
            this.txtTimein.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(205, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(570, 52);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtAdminPanel
            // 
            this.txtAdminPanel.AutoSize = true;
            this.txtAdminPanel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPanel.ForeColor = System.Drawing.Color.White;
            this.txtAdminPanel.Location = new System.Drawing.Point(22, 18);
            this.txtAdminPanel.Name = "txtAdminPanel";
            this.txtAdminPanel.Size = new System.Drawing.Size(206, 33);
            this.txtAdminPanel.TabIndex = 1;
            this.txtAdminPanel.Text = "ADMIN PANEL";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(201, 236);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 23);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(493, 236);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblTimein
            // 
            this.lblTimein.AutoSize = true;
            this.lblTimein.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimein.ForeColor = System.Drawing.Color.Black;
            this.lblTimein.Location = new System.Drawing.Point(201, 304);
            this.lblTimein.Name = "lblTimein";
            this.lblTimein.Size = new System.Drawing.Size(74, 23);
            this.lblTimein.TabIndex = 7;
            this.lblTimein.Text = "Time In";
            // 
            // lblTImeout
            // 
            this.lblTImeout.AutoSize = true;
            this.lblTImeout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTImeout.ForeColor = System.Drawing.Color.Black;
            this.lblTImeout.Location = new System.Drawing.Point(493, 304);
            this.lblTImeout.Name = "lblTImeout";
            this.lblTImeout.Size = new System.Drawing.Size(90, 23);
            this.lblTImeout.TabIndex = 8;
            this.lblTImeout.Text = "Time Out";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(28, 523);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 39);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1303, 710);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendance";
            this.Text = "attendance";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_adminPanel.ResumeLayout(false);
            this.pnl_adminPanel.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_header;
        private System.Windows.Forms.Panel pnl_adminPanel;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label txtAdminPanel;
        private System.Windows.Forms.Label lblTImeout;
        private System.Windows.Forms.Label lblTimein;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TextBox txtTimein;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

