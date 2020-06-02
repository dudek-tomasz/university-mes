using System;
using System.ComponentModel;

namespace ProjektMES
{
    partial class Form1
    {/// <summary>
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
            this.components = new System.ComponentModel.Container();
            this.initTempBox = new System.Windows.Forms.TextBox();
            this.symTimeBox = new System.Windows.Forms.TextBox();
            this.symStepTimeBox = new System.Windows.Forms.TextBox();
            this.ambientTempBox = new System.Windows.Forms.TextBox();
            this.alphaBox = new System.Windows.Forms.TextBox();
            this.hBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.nHBox = new System.Windows.Forms.TextBox();
            this.nBBox = new System.Windows.Forms.TextBox();
            this.specHeatBox = new System.Windows.Forms.TextBox();
            this.conductivityBox = new System.Windows.Forms.TextBox();
            this.densityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buildMeshButton = new System.Windows.Forms.Button();
            this.showAllNodesButton = new System.Windows.Forms.Button();
            this.showAllElementsButton = new System.Windows.Forms.Button();
            this.showElementByIdBox = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.showNodesOfElementByIdBox = new System.Windows.Forms.Button();
            this.showNodeByIdBox = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.simulateButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // initTempBox
            // 
            this.initTempBox.Location = new System.Drawing.Point(142, 369);
            this.initTempBox.Name = "initTempBox";
            this.initTempBox.Size = new System.Drawing.Size(100, 20);
            this.initTempBox.TabIndex = 0;
            this.initTempBox.Text = "100";
            this.initTempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // symTimeBox
            // 
            this.symTimeBox.Location = new System.Drawing.Point(398, 369);
            this.symTimeBox.Name = "symTimeBox";
            this.symTimeBox.Size = new System.Drawing.Size(100, 20);
            this.symTimeBox.TabIndex = 1;
            this.symTimeBox.Text = "500";
            this.symTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // symStepTimeBox
            // 
            this.symStepTimeBox.Location = new System.Drawing.Point(663, 369);
            this.symStepTimeBox.Name = "symStepTimeBox";
            this.symStepTimeBox.Size = new System.Drawing.Size(100, 20);
            this.symStepTimeBox.TabIndex = 2;
            this.symStepTimeBox.Text = "50";
            this.symStepTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ambientTempBox
            // 
            this.ambientTempBox.Location = new System.Drawing.Point(142, 395);
            this.ambientTempBox.Name = "ambientTempBox";
            this.ambientTempBox.Size = new System.Drawing.Size(100, 20);
            this.ambientTempBox.TabIndex = 3;
            this.ambientTempBox.Text = "1200";
            this.ambientTempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // alphaBox
            // 
            this.alphaBox.Location = new System.Drawing.Point(398, 395);
            this.alphaBox.Name = "alphaBox";
            this.alphaBox.Size = new System.Drawing.Size(100, 20);
            this.alphaBox.TabIndex = 4;
            this.alphaBox.Text = "300";
            this.alphaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hBox
            // 
            this.hBox.Location = new System.Drawing.Point(142, 421);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(100, 20);
            this.hBox.TabIndex = 5;
            this.hBox.Text = "0.100";
            this.hBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(398, 421);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 20);
            this.bBox.TabIndex = 6;
            this.bBox.Text = "0.100";
            this.bBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nHBox
            // 
            this.nHBox.Location = new System.Drawing.Point(142, 447);
            this.nHBox.Name = "nHBox";
            this.nHBox.Size = new System.Drawing.Size(100, 20);
            this.nHBox.TabIndex = 7;
            this.nHBox.Text = "4";
            this.nHBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nBBox
            // 
            this.nBBox.Location = new System.Drawing.Point(398, 447);
            this.nBBox.Name = "nBBox";
            this.nBBox.Size = new System.Drawing.Size(100, 20);
            this.nBBox.TabIndex = 8;
            this.nBBox.Text = "4";
            this.nBBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // specHeatBox
            // 
            this.specHeatBox.Location = new System.Drawing.Point(142, 473);
            this.specHeatBox.Name = "specHeatBox";
            this.specHeatBox.Size = new System.Drawing.Size(100, 20);
            this.specHeatBox.TabIndex = 9;
            this.specHeatBox.Text = "700";
            this.specHeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // conductivityBox
            // 
            this.conductivityBox.Location = new System.Drawing.Point(398, 473);
            this.conductivityBox.Name = "conductivityBox";
            this.conductivityBox.Size = new System.Drawing.Size(100, 20);
            this.conductivityBox.TabIndex = 10;
            this.conductivityBox.Text = "25";
            this.conductivityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // densityBox
            // 
            this.densityBox.Location = new System.Drawing.Point(663, 473);
            this.densityBox.Name = "densityBox";
            this.densityBox.Size = new System.Drawing.Size(100, 20);
            this.densityBox.TabIndex = 11;
            this.densityBox.Text = "7800";
            this.densityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Initial temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Simulation time [s]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Simulation step time [s]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ambient temperature [°C]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Alpha[W/m²K]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "H [m]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "B [m]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "N_H";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "N_B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Specific heat [J/kg °C]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Conductivity [W/(m °C)]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Density [kg/m³]";
            // 
            // buildMeshButton
            // 
            this.buildMeshButton.Location = new System.Drawing.Point(318, 518);
            this.buildMeshButton.Name = "buildMeshButton";
            this.buildMeshButton.Size = new System.Drawing.Size(132, 64);
            this.buildMeshButton.TabIndex = 24;
            this.buildMeshButton.Text = "Build mesh (Push First!!!)";
            this.buildMeshButton.UseVisualStyleBackColor = true;
            this.buildMeshButton.Click += new System.EventHandler(this.buildMeshButton_Click);
            // 
            // showAllNodesButton
            // 
            this.showAllNodesButton.Location = new System.Drawing.Point(639, 529);
            this.showAllNodesButton.Name = "showAllNodesButton";
            this.showAllNodesButton.Size = new System.Drawing.Size(124, 23);
            this.showAllNodesButton.TabIndex = 25;
            this.showAllNodesButton.Text = "Show all nodes";
            this.showAllNodesButton.UseVisualStyleBackColor = true;
            this.showAllNodesButton.Click += new System.EventHandler(this.showAllNodesButton_Click);
            // 
            // showAllElementsButton
            // 
            this.showAllElementsButton.Location = new System.Drawing.Point(639, 559);
            this.showAllElementsButton.Name = "showAllElementsButton";
            this.showAllElementsButton.Size = new System.Drawing.Size(124, 23);
            this.showAllElementsButton.TabIndex = 26;
            this.showAllElementsButton.Text = "Show all elements";
            this.showAllElementsButton.UseVisualStyleBackColor = true;
            this.showAllElementsButton.Click += new System.EventHandler(this.showAllElementsButton_Click_1);
            // 
            // showElementByIdBox
            // 
            this.showElementByIdBox.Location = new System.Drawing.Point(9, 547);
            this.showElementByIdBox.Name = "showElementByIdBox";
            this.showElementByIdBox.Size = new System.Drawing.Size(156, 23);
            this.showElementByIdBox.TabIndex = 27;
            this.showElementByIdBox.Text = "Show element by ID";
            this.showElementByIdBox.UseVisualStyleBackColor = true;
            this.showElementByIdBox.Click += new System.EventHandler(this.showElementByIdBox_Click_1);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(199, 550);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(43, 20);
            this.idBox.TabIndex = 28;
            // 
            // showNodesOfElementByIdBox
            // 
            this.showNodesOfElementByIdBox.Location = new System.Drawing.Point(9, 576);
            this.showNodesOfElementByIdBox.Name = "showNodesOfElementByIdBox";
            this.showNodesOfElementByIdBox.Size = new System.Drawing.Size(156, 23);
            this.showNodesOfElementByIdBox.TabIndex = 29;
            this.showNodesOfElementByIdBox.Text = "Show nodes of element by ID";
            this.showNodesOfElementByIdBox.UseVisualStyleBackColor = true;
            this.showNodesOfElementByIdBox.Click += new System.EventHandler(this.showNodesOfElementByIdBox_Click_1);
            // 
            // showNodeByIdBox
            // 
            this.showNodeByIdBox.Location = new System.Drawing.Point(9, 518);
            this.showNodeByIdBox.Name = "showNodeByIdBox";
            this.showNodeByIdBox.Size = new System.Drawing.Size(156, 23);
            this.showNodeByIdBox.TabIndex = 30;
            this.showNodeByIdBox.Text = "Show node by ID";
            this.showNodeByIdBox.UseVisualStyleBackColor = true;
            this.showNodeByIdBox.Click += new System.EventHandler(this.showNodeByIdBox_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "ID:";
            // 
            // simulateButton
            // 
            this.simulateButton.BackColor = System.Drawing.SystemColors.Control;
            this.simulateButton.Location = new System.Drawing.Point(268, 588);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(230, 48);
            this.simulateButton.TabIndex = 32;
            this.simulateButton.Text = "SIMULATE";
            this.simulateButton.UseVisualStyleBackColor = false;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Results";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(9, 24);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(754, 327);
            this.results.TabIndex = 36;
            this.results.Text = "";
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 648);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.showNodeByIdBox);
            this.Controls.Add(this.showNodesOfElementByIdBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.showElementByIdBox);
            this.Controls.Add(this.showAllElementsButton);
            this.Controls.Add(this.showAllNodesButton);
            this.Controls.Add(this.buildMeshButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.densityBox);
            this.Controls.Add(this.conductivityBox);
            this.Controls.Add(this.specHeatBox);
            this.Controls.Add(this.nBBox);
            this.Controls.Add(this.nHBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.alphaBox);
            this.Controls.Add(this.ambientTempBox);
            this.Controls.Add(this.symStepTimeBox);
            this.Controls.Add(this.symTimeBox);
            this.Controls.Add(this.initTempBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initTempBox;
        private System.Windows.Forms.TextBox symTimeBox;
        private System.Windows.Forms.TextBox symStepTimeBox;
        private System.Windows.Forms.TextBox ambientTempBox;
        private System.Windows.Forms.TextBox alphaBox;
        private System.Windows.Forms.TextBox hBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox nHBox;
        private System.Windows.Forms.TextBox nBBox;
        private System.Windows.Forms.TextBox specHeatBox;
        private System.Windows.Forms.TextBox conductivityBox;
        private System.Windows.Forms.TextBox densityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buildMeshButton;
        private System.Windows.Forms.Button showAllNodesButton;
        private System.Windows.Forms.Button showAllElementsButton;
        private System.Windows.Forms.Button showElementByIdBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button showNodesOfElementByIdBox;
        private System.Windows.Forms.Button showNodeByIdBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox results;
        private EventHandler textBox3_TextChanged;
        private EventHandler label1_Click;
        private EventHandler button1_Click;
        private EventHandler button2_Click;
        private EventHandler showAllElementsButton_Click;
        private EventHandler showElementByIdBox_Click;
        private EventHandler showNodesOfElementByIdBox_Click;
        private EventHandler showNodeByIdBox_Click;
        private EventHandler simulateButton_Click;
        private CancelEventHandler contextMenuStrip1_Opening;
        private EventHandler Form1_Load;
    }
}


