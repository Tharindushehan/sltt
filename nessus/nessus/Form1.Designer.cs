namespace nessus
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
            this.pnlAssetDetails = new System.Windows.Forms.Panel();
            this.pnlSectionDetails = new System.Windows.Forms.Panel();
            this.pnlVulnearabilityAssesment = new System.Windows.Forms.Panel();
            this.pnlVAResult = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblVulnerabilityAssessment = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtCoordinatorName = new System.Windows.Forms.TextBox();
            this.txtSectionCode = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtCustodian = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOpenPorts = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtCriticality = new System.Windows.Forms.TextBox();
            this.txtOperatingSystem = new System.Windows.Forms.TextBox();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOpenPorts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssetDetails = new System.Windows.Forms.Button();
            this.btnSectionDetails = new System.Windows.Forms.Button();
            this.btnVA = new System.Windows.Forms.Button();
            this.btnVAResults = new System.Windows.Forms.Button();
            this.VAR = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pnlAssetDetails.SuspendLayout();
            this.pnlSectionDetails.SuspendLayout();
            this.pnlVulnearabilityAssesment.SuspendLayout();
            this.pnlVAResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAssetDetails
            // 
            this.pnlAssetDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAssetDetails.Controls.Add(this.pnlSectionDetails);
            this.pnlAssetDetails.Controls.Add(this.txtComments);
            this.pnlAssetDetails.Controls.Add(this.txtCustodian);
            this.pnlAssetDetails.Controls.Add(this.txtDescription);
            this.pnlAssetDetails.Controls.Add(this.txtOpenPorts);
            this.pnlAssetDetails.Controls.Add(this.txtIpAddress);
            this.pnlAssetDetails.Controls.Add(this.txtCriticality);
            this.pnlAssetDetails.Controls.Add(this.txtOperatingSystem);
            this.pnlAssetDetails.Controls.Add(this.txtAssetName);
            this.pnlAssetDetails.Controls.Add(this.comboBox1);
            this.pnlAssetDetails.Controls.Add(this.label9);
            this.pnlAssetDetails.Controls.Add(this.label7);
            this.pnlAssetDetails.Controls.Add(this.label6);
            this.pnlAssetDetails.Controls.Add(this.label5);
            this.pnlAssetDetails.Controls.Add(this.lblOpenPorts);
            this.pnlAssetDetails.Controls.Add(this.label3);
            this.pnlAssetDetails.Controls.Add(this.lblAssetName);
            this.pnlAssetDetails.Controls.Add(this.label1);
            this.pnlAssetDetails.Location = new System.Drawing.Point(1, 70);
            this.pnlAssetDetails.Name = "pnlAssetDetails";
            this.pnlAssetDetails.Size = new System.Drawing.Size(694, 492);
            this.pnlAssetDetails.TabIndex = 0;
            this.pnlAssetDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAssetDetails_Paint);
            // 
            // pnlSectionDetails
            // 
            this.pnlSectionDetails.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlSectionDetails.Controls.Add(this.pnlVulnearabilityAssesment);
            this.pnlSectionDetails.Controls.Add(this.txtEmail);
            this.pnlSectionDetails.Controls.Add(this.txtPhoneNo);
            this.pnlSectionDetails.Controls.Add(this.txtCoordinatorName);
            this.pnlSectionDetails.Controls.Add(this.txtSectionCode);
            this.pnlSectionDetails.Controls.Add(this.txtSection);
            this.pnlSectionDetails.Controls.Add(this.txtGroup);
            this.pnlSectionDetails.Controls.Add(this.label13);
            this.pnlSectionDetails.Controls.Add(this.label12);
            this.pnlSectionDetails.Controls.Add(this.label11);
            this.pnlSectionDetails.Controls.Add(this.label10);
            this.pnlSectionDetails.Controls.Add(this.label8);
            this.pnlSectionDetails.Controls.Add(this.label4);
            this.pnlSectionDetails.Controls.Add(this.label2);
            this.pnlSectionDetails.Location = new System.Drawing.Point(0, 60);
            this.pnlSectionDetails.Name = "pnlSectionDetails";
            this.pnlSectionDetails.Size = new System.Drawing.Size(694, 414);
            this.pnlSectionDetails.TabIndex = 18;
            // 
            // pnlVulnearabilityAssesment
            // 
            this.pnlVulnearabilityAssesment.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlVulnearabilityAssesment.Controls.Add(this.pnlVAResult);
            this.pnlVulnearabilityAssesment.Controls.Add(this.comboBox2);
            this.pnlVulnearabilityAssesment.Controls.Add(this.textBox5);
            this.pnlVulnearabilityAssesment.Controls.Add(this.textBox3);
            this.pnlVulnearabilityAssesment.Controls.Add(this.textBox2);
            this.pnlVulnearabilityAssesment.Controls.Add(this.textBox1);
            this.pnlVulnearabilityAssesment.Controls.Add(this.label18);
            this.pnlVulnearabilityAssesment.Controls.Add(this.label17);
            this.pnlVulnearabilityAssesment.Controls.Add(this.label16);
            this.pnlVulnearabilityAssesment.Controls.Add(this.label15);
            this.pnlVulnearabilityAssesment.Controls.Add(this.label14);
            this.pnlVulnearabilityAssesment.Controls.Add(this.lblVulnerabilityAssessment);
            this.pnlVulnearabilityAssesment.Location = new System.Drawing.Point(0, 62);
            this.pnlVulnearabilityAssesment.Name = "pnlVulnearabilityAssesment";
            this.pnlVulnearabilityAssesment.Size = new System.Drawing.Size(694, 370);
            this.pnlVulnearabilityAssesment.TabIndex = 21;
            this.pnlVulnearabilityAssesment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVulnearabilityAssesment_Paint);
            // 
            // pnlVAResult
            // 
            this.pnlVAResult.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlVAResult.Controls.Add(this.textBox6);
            this.pnlVAResult.Controls.Add(this.label22);
            this.pnlVAResult.Controls.Add(this.textBox4);
            this.pnlVAResult.Controls.Add(this.label21);
            this.pnlVAResult.Controls.Add(this.label20);
            this.pnlVAResult.Controls.Add(this.comboBox4);
            this.pnlVAResult.Controls.Add(this.comboBox3);
            this.pnlVAResult.Controls.Add(this.label19);
            this.pnlVAResult.Controls.Add(this.VAR);
            this.pnlVAResult.Location = new System.Drawing.Point(0, 59);
            this.pnlVAResult.Name = "pnlVAResult";
            this.pnlVAResult.Size = new System.Drawing.Size(694, 327);
            this.pnlVAResult.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "In progress",
            "Schedule",
            "Complete",
            "Not planned"});
            this.comboBox2.Location = new System.Drawing.Point(251, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(251, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(218, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(70, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 21);
            this.label18.TabIndex = 5;
            this.label18.Text = "VAComments";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(70, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(70, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Date";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(70, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cycle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Year";
            // 
            // lblVulnerabilityAssessment
            // 
            this.lblVulnerabilityAssessment.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVulnerabilityAssessment.Location = new System.Drawing.Point(217, 30);
            this.lblVulnerabilityAssessment.Name = "lblVulnerabilityAssessment";
            this.lblVulnerabilityAssessment.Size = new System.Drawing.Size(330, 38);
            this.lblVulnerabilityAssessment.TabIndex = 0;
            this.lblVulnerabilityAssessment.Text = "Vulnerability Assesment";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(258, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(258, 231);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(233, 20);
            this.txtPhoneNo.TabIndex = 19;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtCoordinatorName
            // 
            this.txtCoordinatorName.Location = new System.Drawing.Point(258, 204);
            this.txtCoordinatorName.Name = "txtCoordinatorName";
            this.txtCoordinatorName.Size = new System.Drawing.Size(233, 20);
            this.txtCoordinatorName.TabIndex = 18;
            // 
            // txtSectionCode
            // 
            this.txtSectionCode.Location = new System.Drawing.Point(258, 177);
            this.txtSectionCode.Name = "txtSectionCode";
            this.txtSectionCode.Size = new System.Drawing.Size(233, 20);
            this.txtSectionCode.TabIndex = 17;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(258, 150);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(233, 20);
            this.txtSection.TabIndex = 16;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(258, 123);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(233, 20);
            this.txtGroup.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Coordinator Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(66, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Section Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Phone No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Section Details";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(239, 289);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(202, 20);
            this.txtComments.TabIndex = 17;
            // 
            // txtCustodian
            // 
            this.txtCustodian.Location = new System.Drawing.Point(239, 262);
            this.txtCustodian.Name = "txtCustodian";
            this.txtCustodian.Size = new System.Drawing.Size(202, 20);
            this.txtCustodian.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(239, 208);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 20);
            this.txtDescription.TabIndex = 15;
            // 
            // txtOpenPorts
            // 
            this.txtOpenPorts.Location = new System.Drawing.Point(239, 181);
            this.txtOpenPorts.Name = "txtOpenPorts";
            this.txtOpenPorts.Size = new System.Drawing.Size(202, 20);
            this.txtOpenPorts.TabIndex = 14;
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(239, 154);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(202, 20);
            this.txtIpAddress.TabIndex = 13;
            this.txtIpAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCriticality
            // 
            this.txtCriticality.Location = new System.Drawing.Point(239, 235);
            this.txtCriticality.Name = "txtCriticality";
            this.txtCriticality.Size = new System.Drawing.Size(202, 20);
            this.txtCriticality.TabIndex = 12;
            // 
            // txtOperatingSystem
            // 
            this.txtOperatingSystem.Location = new System.Drawing.Point(239, 127);
            this.txtOperatingSystem.Name = "txtOperatingSystem";
            this.txtOperatingSystem.Size = new System.Drawing.Size(202, 20);
            this.txtOperatingSystem.TabIndex = 11;
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(239, 100);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(202, 20);
            this.txtAssetName.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Internal",
            "External",
            "NAT"});
            this.comboBox1.Location = new System.Drawing.Point(29, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Criticality";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comments";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Custodian";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // lblOpenPorts
            // 
            this.lblOpenPorts.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenPorts.Location = new System.Drawing.Point(29, 185);
            this.lblOpenPorts.Name = "lblOpenPorts";
            this.lblOpenPorts.Size = new System.Drawing.Size(121, 25);
            this.lblOpenPorts.TabIndex = 3;
            this.lblOpenPorts.Text = "Open Ports";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operating System";
            // 
            // lblAssetName
            // 
            this.lblAssetName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetName.Location = new System.Drawing.Point(29, 104);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(121, 25);
            this.lblAssetName.TabIndex = 1;
            this.lblAssetName.Text = "Asset Name";
            this.lblAssetName.Click += new System.EventHandler(this.lblAssetName_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAssetDetails
            // 
            this.btnAssetDetails.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssetDetails.Location = new System.Drawing.Point(17, 12);
            this.btnAssetDetails.Name = "btnAssetDetails";
            this.btnAssetDetails.Size = new System.Drawing.Size(134, 44);
            this.btnAssetDetails.TabIndex = 1;
            this.btnAssetDetails.Text = "Asset Details";
            this.btnAssetDetails.UseVisualStyleBackColor = true;
            this.btnAssetDetails.Click += new System.EventHandler(this.btnAssetDetails_Click);
            // 
            // btnSectionDetails
            // 
            this.btnSectionDetails.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionDetails.Location = new System.Drawing.Point(165, 12);
            this.btnSectionDetails.Name = "btnSectionDetails";
            this.btnSectionDetails.Size = new System.Drawing.Size(138, 44);
            this.btnSectionDetails.TabIndex = 2;
            this.btnSectionDetails.Text = "Section Details";
            this.btnSectionDetails.UseVisualStyleBackColor = true;
            this.btnSectionDetails.Click += new System.EventHandler(this.btnSectionDetails_Click);
            // 
            // btnVA
            // 
            this.btnVA.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVA.Location = new System.Drawing.Point(319, 12);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(184, 44);
            this.btnVA.TabIndex = 3;
            this.btnVA.Text = "Vulnerability Assement";
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // btnVAResults
            // 
            this.btnVAResults.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAResults.Location = new System.Drawing.Point(509, 12);
            this.btnVAResults.Name = "btnVAResults";
            this.btnVAResults.Size = new System.Drawing.Size(176, 44);
            this.btnVAResults.TabIndex = 4;
            this.btnVAResults.Text = "VA Results";
            this.btnVAResults.UseVisualStyleBackColor = true;
            this.btnVAResults.Click += new System.EventHandler(this.btnVAResults_Click);
            // 
            // VAR
            // 
            this.VAR.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAR.Location = new System.Drawing.Point(280, 21);
            this.VAR.Name = "VAR";
            this.VAR.Size = new System.Drawing.Size(127, 36);
            this.VAR.TabIndex = 0;
            this.VAR.Text = "VA Result";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(67, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 1;
            this.label19.Text = "Vulnerability";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tolerate",
            "Treat",
            "TBD"});
            this.comboBox3.Location = new System.Drawing.Point(241, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Pending ",
            "Comment"});
            this.comboBox4.Location = new System.Drawing.Point(241, 173);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(233, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(69, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 4;
            this.label20.Text = "Action";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(69, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 5;
            this.label21.Text = "Status";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(241, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(66, 221);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 23);
            this.label22.TabIndex = 7;
            this.label22.Text = "VARe Comment";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(242, 220);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(232, 20);
            this.textBox6.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(698, 574);
            this.Controls.Add(this.btnVAResults);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.btnSectionDetails);
            this.Controls.Add(this.btnAssetDetails);
            this.Controls.Add(this.pnlAssetDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAssetDetails.ResumeLayout(false);
            this.pnlAssetDetails.PerformLayout();
            this.pnlSectionDetails.ResumeLayout(false);
            this.pnlSectionDetails.PerformLayout();
            this.pnlVulnearabilityAssesment.ResumeLayout(false);
            this.pnlVulnearabilityAssesment.PerformLayout();
            this.pnlVAResult.ResumeLayout(false);
            this.pnlVAResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAssetDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOpenPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtCustodian;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtOpenPorts;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtCriticality;
        private System.Windows.Forms.TextBox txtOperatingSystem;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Panel pnlSectionDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtCoordinatorName;
        private System.Windows.Forms.TextBox txtSectionCode;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlVulnearabilityAssesment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblVulnerabilityAssessment;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAssetDetails;
        private System.Windows.Forms.Button btnSectionDetails;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.Button btnVAResults;
        private System.Windows.Forms.Panel pnlVAResult;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label VAR;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox6;
    }
}

