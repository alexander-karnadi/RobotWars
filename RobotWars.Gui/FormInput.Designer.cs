namespace RobotWars.Gui
{
    partial class FormInput
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClearCommand = new System.Windows.Forms.Button();
            this.comboBoxInitialHeading = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
            this.buttonAddRobot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCommand = new System.Windows.Forms.ListBox();
            this.buttonMoveForward = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewRobotInput = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRobotInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownWidth);
            this.groupBox1.Controls.Add(this.numericUpDownHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Battle Area";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(136, 21);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownWidth.TabIndex = 1;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(136, 49);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownHeight.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecute.Location = new System.Drawing.Point(644, 407);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(145, 40);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Commance Battle";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClearCommand);
            this.groupBox2.Controls.Add(this.comboBoxInitialHeading);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDownPositionY);
            this.groupBox2.Controls.Add(this.numericUpDownPositionX);
            this.groupBox2.Controls.Add(this.buttonAddRobot);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.listBoxCommand);
            this.groupBox2.Controls.Add(this.buttonMoveForward);
            this.groupBox2.Controls.Add(this.buttonRight);
            this.groupBox2.Controls.Add(this.buttonLeft);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Your Robots";
            // 
            // buttonClearCommand
            // 
            this.buttonClearCommand.Location = new System.Drawing.Point(156, 236);
            this.buttonClearCommand.Name = "buttonClearCommand";
            this.buttonClearCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonClearCommand.TabIndex = 13;
            this.buttonClearCommand.Text = "Clear";
            this.buttonClearCommand.UseVisualStyleBackColor = true;
            this.buttonClearCommand.Click += new System.EventHandler(this.buttonClearCommand_Click);
            // 
            // comboBoxInitialHeading
            // 
            this.comboBoxInitialHeading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInitialHeading.FormattingEnabled = true;
            this.comboBoxInitialHeading.Items.AddRange(new object[] {
            "North",
            "East",
            "South",
            "West"});
            this.comboBoxInitialHeading.Location = new System.Drawing.Point(136, 117);
            this.comboBoxInitialHeading.Name = "comboBoxInitialHeading";
            this.comboBoxInitialHeading.Size = new System.Drawing.Size(212, 24);
            this.comboBoxInitialHeading.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Initial Heading";
            // 
            // numericUpDownPositionY
            // 
            this.numericUpDownPositionY.Location = new System.Drawing.Point(136, 89);
            this.numericUpDownPositionY.Name = "numericUpDownPositionY";
            this.numericUpDownPositionY.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownPositionY.TabIndex = 6;
            // 
            // numericUpDownPositionX
            // 
            this.numericUpDownPositionX.Location = new System.Drawing.Point(136, 61);
            this.numericUpDownPositionX.Name = "numericUpDownPositionX";
            this.numericUpDownPositionX.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownPositionX.TabIndex = 4;
            // 
            // buttonAddRobot
            // 
            this.buttonAddRobot.Location = new System.Drawing.Point(237, 236);
            this.buttonAddRobot.Name = "buttonAddRobot";
            this.buttonAddRobot.Size = new System.Drawing.Size(111, 23);
            this.buttonAddRobot.TabIndex = 14;
            this.buttonAddRobot.Text = "Add Robot >>";
            this.buttonAddRobot.UseVisualStyleBackColor = true;
            this.buttonAddRobot.Click += new System.EventHandler(this.buttonAddRobot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // listBoxCommand
            // 
            this.listBoxCommand.FormattingEnabled = true;
            this.listBoxCommand.ItemHeight = 16;
            this.listBoxCommand.Location = new System.Drawing.Point(136, 146);
            this.listBoxCommand.Name = "listBoxCommand";
            this.listBoxCommand.Size = new System.Drawing.Size(212, 84);
            this.listBoxCommand.TabIndex = 12;
            // 
            // buttonMoveForward
            // 
            this.buttonMoveForward.Location = new System.Drawing.Point(6, 185);
            this.buttonMoveForward.Name = "buttonMoveForward";
            this.buttonMoveForward.Size = new System.Drawing.Size(117, 31);
            this.buttonMoveForward.TabIndex = 11;
            this.buttonMoveForward.Text = "Move Forward";
            this.buttonMoveForward.UseVisualStyleBackColor = true;
            this.buttonMoveForward.Click += new System.EventHandler(this.buttonMoveForward_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(66, 146);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(57, 33);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(6, 146);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(54, 33);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Initial Position";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // dataGridViewRobotInput
            // 
            this.dataGridViewRobotInput.AllowUserToAddRows = false;
            this.dataGridViewRobotInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRobotInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRobotInput.Location = new System.Drawing.Point(395, 146);
            this.dataGridViewRobotInput.Name = "dataGridViewRobotInput";
            this.dataGridViewRobotInput.RowHeadersWidth = 15;
            this.dataGridViewRobotInput.RowTemplate.Height = 24;
            this.dataGridViewRobotInput.Size = new System.Drawing.Size(394, 255);
            this.dataGridViewRobotInput.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Robots So Far";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.Location = new System.Drawing.Point(548, 407);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(90, 40);
            this.buttonClearAll.TabIndex = 5;
            this.buttonClearAll.Text = "Clear";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(16, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "All fields are required";
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewRobotInput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInput";
            this.Text = "Input Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRobotInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCommand;
        private System.Windows.Forms.Button buttonMoveForward;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddRobot;
        private System.Windows.Forms.DataGridView dataGridViewRobotInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionY;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionX;
        private System.Windows.Forms.ComboBox comboBoxInitialHeading;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClearCommand;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label9;
    }
}

