namespace task_1_2021
{
    partial class frm1
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
            this.lblStats = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.grpbxStats = new System.Windows.Forms.GroupBox();
            this.cmbxAttackSelector = new System.Windows.Forms.ComboBox();
            this.grpbxAction = new System.Windows.Forms.GroupBox();
            this.grpbxControls = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpbxStats.SuspendLayout();
            this.grpbxAction.SuspendLayout();
            this.grpbxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStats
            // 
            this.lblStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStats.Location = new System.Drawing.Point(8, 20);
            this.lblStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(289, 124);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "[stats]";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMap
            // 
            this.lblMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMap.Location = new System.Drawing.Point(16, 11);
            this.lblMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMap.Size = new System.Drawing.Size(699, 500);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "NO MAP LOADED";
            this.lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(103, 34);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 33);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeft.Location = new System.Drawing.Point(3, 75);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 36);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(201, 75);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 36);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(103, 118);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 33);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "v";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(8, 80);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(283, 54);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // grpbxStats
            // 
            this.grpbxStats.Controls.Add(this.lblStats);
            this.grpbxStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxStats.Location = new System.Drawing.Point(756, 11);
            this.grpbxStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxStats.Name = "grpbxStats";
            this.grpbxStats.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxStats.Size = new System.Drawing.Size(305, 154);
            this.grpbxStats.TabIndex = 7;
            this.grpbxStats.TabStop = false;
            this.grpbxStats.Text = "Stats";
            // 
            // cmbxAttackSelector
            // 
            this.cmbxAttackSelector.FormattingEnabled = true;
            this.cmbxAttackSelector.Location = new System.Drawing.Point(8, 39);
            this.cmbxAttackSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxAttackSelector.Name = "cmbxAttackSelector";
            this.cmbxAttackSelector.Size = new System.Drawing.Size(281, 24);
            this.cmbxAttackSelector.TabIndex = 8;
            // 
            // grpbxAction
            // 
            this.grpbxAction.Controls.Add(this.cmbxAttackSelector);
            this.grpbxAction.Controls.Add(this.btnAttack);
            this.grpbxAction.Location = new System.Drawing.Point(756, 172);
            this.grpbxAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAction.Name = "grpbxAction";
            this.grpbxAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAction.Size = new System.Drawing.Size(305, 146);
            this.grpbxAction.TabIndex = 9;
            this.grpbxAction.TabStop = false;
            this.grpbxAction.Text = "Action";
            // 
            // grpbxControls
            // 
            this.grpbxControls.Controls.Add(this.btnLoad);
            this.grpbxControls.Controls.Add(this.btnSave);
            this.grpbxControls.Controls.Add(this.btnUp);
            this.grpbxControls.Controls.Add(this.btnLeft);
            this.grpbxControls.Controls.Add(this.btnRight);
            this.grpbxControls.Controls.Add(this.btnDown);
            this.grpbxControls.Location = new System.Drawing.Point(756, 336);
            this.grpbxControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxControls.Name = "grpbxControls";
            this.grpbxControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxControls.Size = new System.Drawing.Size(305, 175);
            this.grpbxControls.TabIndex = 10;
            this.grpbxControls.TabStop = false;
            this.grpbxControls.Text = "Controls";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(222, 128);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 553);
            this.Controls.Add(this.grpbxControls);
            this.Controls.Add(this.grpbxAction);
            this.Controls.Add(this.grpbxStats);
            this.Controls.Add(this.lblMap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm1";
            this.Text = "Form1";
            this.grpbxStats.ResumeLayout(false);
            this.grpbxAction.ResumeLayout(false);
            this.grpbxControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.GroupBox grpbxStats;
        private System.Windows.Forms.ComboBox cmbxAttackSelector;
        private System.Windows.Forms.GroupBox grpbxAction;
        private System.Windows.Forms.GroupBox grpbxControls;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

