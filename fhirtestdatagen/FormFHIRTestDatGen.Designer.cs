﻿namespace fhirtestdatagen
{
    partial class FormFHIRTestDatGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFHIRTestDatGen));
            this.listViewData = new System.Windows.Forms.ListView();
            this.chPatientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientTelecom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chchPatientGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientDeceased = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientMarital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientMultiBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientPhoto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientComms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientCareProvider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientManagOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxJSON = new System.Windows.Forms.TextBox();
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.tabOrganizations = new System.Windows.Forms.TabPage();
            this.listViewOrgs = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrgType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSHA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCounty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripOrgs = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPatients = new System.Windows.Forms.ToolStrip();
            this.butGPs = new System.Windows.Forms.ToolStripButton();
            this.butPCTs = new System.Windows.Forms.ToolStripButton();
            this.butTrusts = new System.Windows.Forms.ToolStripButton();
            this.butIndependents = new System.Windows.Forms.ToolStripButton();
            this.butGenerate = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabsMain.SuspendLayout();
            this.tabPatients.SuspendLayout();
            this.tabOrganizations.SuspendLayout();
            this.toolStripOrgs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPatientId,
            this.chPatientName,
            this.chPatientTelecom,
            this.chchPatientGender,
            this.chPatientDOB,
            this.chPatientDeceased,
            this.chPatientAddress,
            this.chPatientMarital,
            this.chPatientMultiBirth,
            this.chPatientPhoto,
            this.chPatientContact,
            this.chPatientAnimal,
            this.chPatientComms,
            this.chPatientCareProvider,
            this.chPatientManagOrg,
            this.chPatientLink,
            this.chPatientActive});
            this.listViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewData.FullRowSelect = true;
            this.listViewData.GridLines = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(3, 57);
            this.listViewData.MultiSelect = false;
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(1479, 296);
            this.listViewData.TabIndex = 1;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            this.listViewData.SelectedIndexChanged += new System.EventHandler(this.listViewData_SelectedIndexChanged);
            // 
            // chPatientId
            // 
            this.chPatientId.Text = "ID";
            this.chPatientId.Width = 120;
            // 
            // chPatientName
            // 
            this.chPatientName.Text = "Name";
            this.chPatientName.Width = 180;
            // 
            // chPatientTelecom
            // 
            this.chPatientTelecom.Text = "Telecom";
            this.chPatientTelecom.Width = 300;
            // 
            // chchPatientGender
            // 
            this.chchPatientGender.Text = "Gender";
            this.chchPatientGender.Width = 48;
            // 
            // chPatientDOB
            // 
            this.chPatientDOB.Text = "DOB";
            this.chPatientDOB.Width = 80;
            // 
            // chPatientDeceased
            // 
            this.chPatientDeceased.Text = "Deceased";
            this.chPatientDeceased.Width = 64;
            // 
            // chPatientAddress
            // 
            this.chPatientAddress.Text = "Address";
            this.chPatientAddress.Width = 300;
            // 
            // chPatientMarital
            // 
            this.chPatientMarital.Text = "Marital";
            this.chPatientMarital.Width = 48;
            // 
            // chPatientMultiBirth
            // 
            this.chPatientMultiBirth.Text = "MultiBirth";
            this.chPatientMultiBirth.Width = 56;
            // 
            // chPatientPhoto
            // 
            this.chPatientPhoto.Text = "Photo";
            this.chPatientPhoto.Width = 48;
            // 
            // chPatientContact
            // 
            this.chPatientContact.Text = "Contact";
            this.chPatientContact.Width = 260;
            // 
            // chPatientAnimal
            // 
            this.chPatientAnimal.Text = "Animal";
            this.chPatientAnimal.Width = 48;
            // 
            // chPatientComms
            // 
            this.chPatientComms.Text = "Comms";
            this.chPatientComms.Width = 120;
            // 
            // chPatientCareProvider
            // 
            this.chPatientCareProvider.Text = "CareProvider";
            this.chPatientCareProvider.Width = 120;
            // 
            // chPatientManagOrg
            // 
            this.chPatientManagOrg.Text = "ManagOrg";
            this.chPatientManagOrg.Width = 120;
            // 
            // chPatientLink
            // 
            this.chPatientLink.Text = "Link";
            this.chPatientLink.Width = 120;
            // 
            // chPatientActive
            // 
            this.chPatientActive.Text = "Active";
            this.chPatientActive.Width = 48;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1493, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabsMain);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.textBoxJSON);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 452);
            this.panel1.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 382);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1493, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // textBoxJSON
            // 
            this.textBoxJSON.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxJSON.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxJSON.Location = new System.Drawing.Point(0, 385);
            this.textBoxJSON.Multiline = true;
            this.textBoxJSON.Name = "textBoxJSON";
            this.textBoxJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJSON.Size = new System.Drawing.Size(1493, 67);
            this.textBoxJSON.TabIndex = 2;
            // 
            // tabsMain
            // 
            this.tabsMain.Controls.Add(this.tabOrganizations);
            this.tabsMain.Controls.Add(this.tabPatients);
            this.tabsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsMain.Location = new System.Drawing.Point(0, 0);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(1493, 382);
            this.tabsMain.TabIndex = 4;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.listViewData);
            this.tabPatients.Controls.Add(this.toolStripPatients);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(1485, 356);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // tabOrganizations
            // 
            this.tabOrganizations.Controls.Add(this.listViewOrgs);
            this.tabOrganizations.Controls.Add(this.toolStripOrgs);
            this.tabOrganizations.Location = new System.Drawing.Point(4, 22);
            this.tabOrganizations.Name = "tabOrganizations";
            this.tabOrganizations.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrganizations.Size = new System.Drawing.Size(1485, 356);
            this.tabOrganizations.TabIndex = 1;
            this.tabOrganizations.Text = "Organizations";
            this.tabOrganizations.UseVisualStyleBackColor = true;
            // 
            // listViewOrgs
            // 
            this.listViewOrgs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chOrgType,
            this.chOds,
            this.chSHA,
            this.chName,
            this.chPhone,
            this.chFax,
            this.chStreet,
            this.chTown,
            this.chZip,
            this.chCounty});
            this.listViewOrgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrgs.FullRowSelect = true;
            this.listViewOrgs.GridLines = true;
            this.listViewOrgs.Location = new System.Drawing.Point(3, 57);
            this.listViewOrgs.Name = "listViewOrgs";
            this.listViewOrgs.Size = new System.Drawing.Size(1479, 296);
            this.listViewOrgs.TabIndex = 3;
            this.listViewOrgs.UseCompatibleStateImageBehavior = false;
            this.listViewOrgs.View = System.Windows.Forms.View.Details;
            this.listViewOrgs.SelectedIndexChanged += new System.EventHandler(this.listViewOrgs_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 56;
            // 
            // chOrgType
            // 
            this.chOrgType.Text = "Org. Type";
            // 
            // chOds
            // 
            this.chOds.Text = "ODS code";
            this.chOds.Width = 64;
            // 
            // chSHA
            // 
            this.chSHA.Text = "SHA";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 376;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Phone";
            this.chPhone.Width = 88;
            // 
            // chFax
            // 
            this.chFax.Text = "Fax";
            this.chFax.Width = 88;
            // 
            // chStreet
            // 
            this.chStreet.Text = "Street";
            this.chStreet.Width = 360;
            // 
            // chTown
            // 
            this.chTown.Text = "Town";
            this.chTown.Width = 160;
            // 
            // chZip
            // 
            this.chZip.Text = "Postcode";
            this.chZip.Width = 72;
            // 
            // chCounty
            // 
            this.chCounty.Text = "County";
            this.chCounty.Width = 160;
            // 
            // toolStripOrgs
            // 
            this.toolStripOrgs.ImageScalingSize = new System.Drawing.Size(48, 32);
            this.toolStripOrgs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butGPs,
            this.butPCTs,
            this.butTrusts,
            this.butIndependents});
            this.toolStripOrgs.Location = new System.Drawing.Point(3, 3);
            this.toolStripOrgs.Name = "toolStripOrgs";
            this.toolStripOrgs.Size = new System.Drawing.Size(1479, 54);
            this.toolStripOrgs.TabIndex = 4;
            this.toolStripOrgs.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1493, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelInfo.Text = "Info...";
            // 
            // toolStripPatients
            // 
            this.toolStripPatients.ImageScalingSize = new System.Drawing.Size(48, 32);
            this.toolStripPatients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butGenerate});
            this.toolStripPatients.Location = new System.Drawing.Point(3, 3);
            this.toolStripPatients.Name = "toolStripPatients";
            this.toolStripPatients.Size = new System.Drawing.Size(1479, 54);
            this.toolStripPatients.TabIndex = 2;
            // 
            // butGPs
            // 
            this.butGPs.Image = global::fhirtestdatagen.Properties.Resources.gp;
            this.butGPs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butGPs.Name = "butGPs";
            this.butGPs.Size = new System.Drawing.Size(105, 51);
            this.butGPs.Text = "Load GP Practices";
            this.butGPs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butGPs.Click += new System.EventHandler(this.butGPs_Click);
            // 
            // butPCTs
            // 
            this.butPCTs.Image = global::fhirtestdatagen.Properties.Resources.pct;
            this.butPCTs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butPCTs.Name = "butPCTs";
            this.butPCTs.Size = new System.Drawing.Size(67, 51);
            this.butPCTs.Text = "Load PCTs";
            this.butPCTs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butPCTs.Click += new System.EventHandler(this.butPCTs_Click);
            // 
            // butTrusts
            // 
            this.butTrusts.Image = global::fhirtestdatagen.Properties.Resources.trust;
            this.butTrusts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butTrusts.Name = "butTrusts";
            this.butTrusts.Size = new System.Drawing.Size(72, 51);
            this.butTrusts.Text = "Load Trusts";
            this.butTrusts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butTrusts.Click += new System.EventHandler(this.butTrusts_Click);
            // 
            // butIndependents
            // 
            this.butIndependents.Image = global::fhirtestdatagen.Properties.Resources.independent;
            this.butIndependents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butIndependents.Name = "butIndependents";
            this.butIndependents.Size = new System.Drawing.Size(135, 51);
            this.butIndependents.Text = "Load Independent Orgs";
            this.butIndependents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butIndependents.Click += new System.EventHandler(this.butIndependents_Click);
            // 
            // butGenerate
            // 
            this.butGenerate.Image = global::fhirtestdatagen.Properties.Resources.patients;
            this.butGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(151, 51);
            this.butGenerate.Text = "Generate Random Patients";
            this.butGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // FormFHIRTestDatGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFHIRTestDatGen";
            this.Text = "FHIR - Test Data Generator";
            this.Load += new System.EventHandler(this.FormFHIRTestDatGen_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabsMain.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            this.tabOrganizations.ResumeLayout(false);
            this.tabOrganizations.PerformLayout();
            this.toolStripOrgs.ResumeLayout(false);
            this.toolStripOrgs.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripPatients.ResumeLayout(false);
            this.toolStripPatients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader chPatientId;
        private System.Windows.Forms.ColumnHeader chPatientName;
        private System.Windows.Forms.ColumnHeader chPatientTelecom;
        private System.Windows.Forms.ColumnHeader chchPatientGender;
        private System.Windows.Forms.ColumnHeader chPatientDOB;
        private System.Windows.Forms.ColumnHeader chPatientDeceased;
        private System.Windows.Forms.ColumnHeader chPatientAddress;
        private System.Windows.Forms.ColumnHeader chPatientMarital;
        private System.Windows.Forms.ColumnHeader chPatientMultiBirth;
        private System.Windows.Forms.ColumnHeader chPatientPhoto;
        private System.Windows.Forms.ColumnHeader chPatientContact;
        private System.Windows.Forms.ColumnHeader chPatientAnimal;
        private System.Windows.Forms.ColumnHeader chPatientComms;
        private System.Windows.Forms.ColumnHeader chPatientManagOrg;
        private System.Windows.Forms.ColumnHeader chPatientLink;
        private System.Windows.Forms.ColumnHeader chPatientActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxJSON;
        private System.Windows.Forms.TabControl tabsMain;
        private System.Windows.Forms.TabPage tabOrganizations;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.ListView listViewOrgs;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chOrgType;
        private System.Windows.Forms.ColumnHeader chOds;
        private System.Windows.Forms.ColumnHeader chSHA;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chFax;
        private System.Windows.Forms.ColumnHeader chStreet;
        private System.Windows.Forms.ColumnHeader chTown;
        private System.Windows.Forms.ColumnHeader chZip;
        private System.Windows.Forms.ColumnHeader chCounty;
        private System.Windows.Forms.ToolStrip toolStripOrgs;
        private System.Windows.Forms.ToolStripButton butGPs;
        private System.Windows.Forms.ToolStripButton butPCTs;
        private System.Windows.Forms.ToolStripButton butTrusts;
        private System.Windows.Forms.ToolStripButton butIndependents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStrip toolStripPatients;
        private System.Windows.Forms.ToolStripButton butGenerate;
        private System.Windows.Forms.ColumnHeader chPatientCareProvider;
    }
}

