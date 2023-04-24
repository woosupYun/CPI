﻿namespace CRUX_Renewal.Main_Form
{
    partial class Main_Frm_Recipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if ( disposing && ( components != null ) )
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
        private void InitializeComponent ()
        {
            this.Tlp_RecipeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Tab_RecipeMain = new System.Windows.Forms.TabControl();
            this.tab_job = new System.Windows.Forms.TabPage();
            this.cogToolGroupEditV2_Algorithm = new Cognex.VisionPro.ToolGroup.CogToolGroupEditV2();
            this.tab_roi = new System.Windows.Forms.TabPage();
            this.tab_optic = new System.Windows.Forms.TabPage();
            this.tab_align = new System.Windows.Forms.TabPage();
            this.Btn_Judge = new System.Windows.Forms.Button();
            this.Lb_UnderLine2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Revert = new System.Windows.Forms.Button();
            this.Lb_UnderLine1 = new System.Windows.Forms.Label();
            this.Cagb_Jobs = new CRUX_Renewal.User_Controls.CenterAlignedGroupBox();
            this.LstBoxJobList = new System.Windows.Forms.ListBox();
            this.Cagb_Recipe = new CRUX_Renewal.User_Controls.CenterAlignedGroupBox();
            this.LstBoxRecipeList = new System.Windows.Forms.ListBox();
            this.tab_Algorithm = new System.Windows.Forms.TabPage();
            this.Tlp_Algorithm = new System.Windows.Forms.TableLayoutPanel();
            this.Grb_Algorithm = new System.Windows.Forms.GroupBox();
            this.Tlp_AlgorithmList = new System.Windows.Forms.TableLayoutPanel();
            this.LstB_Algorithm = new System.Windows.Forms.ListBox();
            this.Tlp_RecipeLayout.SuspendLayout();
            this.Tab_RecipeMain.SuspendLayout();
            this.tab_job.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolGroupEditV2_Algorithm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Cagb_Jobs.SuspendLayout();
            this.Cagb_Recipe.SuspendLayout();
            this.tab_Algorithm.SuspendLayout();
            this.Tlp_Algorithm.SuspendLayout();
            this.Grb_Algorithm.SuspendLayout();
            this.Tlp_AlgorithmList.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_RecipeLayout
            // 
            this.Tlp_RecipeLayout.ColumnCount = 2;
            this.Tlp_RecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.Tlp_RecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_RecipeLayout.Controls.Add(this.Tab_RecipeMain, 1, 0);
            this.Tlp_RecipeLayout.Controls.Add(this.Btn_Judge, 0, 6);
            this.Tlp_RecipeLayout.Controls.Add(this.Lb_UnderLine2, 0, 5);
            this.Tlp_RecipeLayout.Controls.Add(this.splitContainer1, 0, 4);
            this.Tlp_RecipeLayout.Controls.Add(this.Btn_Revert, 0, 3);
            this.Tlp_RecipeLayout.Controls.Add(this.Lb_UnderLine1, 0, 1);
            this.Tlp_RecipeLayout.Controls.Add(this.Cagb_Jobs, 0, 2);
            this.Tlp_RecipeLayout.Controls.Add(this.Cagb_Recipe, 0, 0);
            this.Tlp_RecipeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_RecipeLayout.Location = new System.Drawing.Point(0, 0);
            this.Tlp_RecipeLayout.Margin = new System.Windows.Forms.Padding(0);
            this.Tlp_RecipeLayout.Name = "Tlp_RecipeLayout";
            this.Tlp_RecipeLayout.RowCount = 7;
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.Tlp_RecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Tlp_RecipeLayout.Size = new System.Drawing.Size(1641, 779);
            this.Tlp_RecipeLayout.TabIndex = 0;
            // 
            // Tab_RecipeMain
            // 
            this.Tab_RecipeMain.Controls.Add(this.tab_job);
            this.Tab_RecipeMain.Controls.Add(this.tab_roi);
            this.Tab_RecipeMain.Controls.Add(this.tab_optic);
            this.Tab_RecipeMain.Controls.Add(this.tab_align);
            this.Tab_RecipeMain.Controls.Add(this.tab_Algorithm);
            this.Tab_RecipeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_RecipeMain.HotTrack = true;
            this.Tab_RecipeMain.Location = new System.Drawing.Point(180, 0);
            this.Tab_RecipeMain.Margin = new System.Windows.Forms.Padding(0);
            this.Tab_RecipeMain.Name = "Tab_RecipeMain";
            this.Tlp_RecipeLayout.SetRowSpan(this.Tab_RecipeMain, 7);
            this.Tab_RecipeMain.SelectedIndex = 0;
            this.Tab_RecipeMain.Size = new System.Drawing.Size(1461, 779);
            this.Tab_RecipeMain.TabIndex = 0;
            this.Tab_RecipeMain.SelectedIndexChanged += new System.EventHandler(this.Tab_RecipeMain_SelectedIndexChanged);
            // 
            // tab_job
            // 
            this.tab_job.Controls.Add(this.cogToolGroupEditV2_Algorithm);
            this.tab_job.Location = new System.Drawing.Point(4, 22);
            this.tab_job.Name = "tab_job";
            this.tab_job.Size = new System.Drawing.Size(1453, 753);
            this.tab_job.TabIndex = 4;
            this.tab_job.Text = "Algorithm";
            this.tab_job.UseVisualStyleBackColor = true;
            // 
            // cogToolGroupEditV2_Algorithm
            // 
            this.cogToolGroupEditV2_Algorithm.AllowDrop = true;
            this.cogToolGroupEditV2_Algorithm.ContextMenuCustomizer = null;
            this.cogToolGroupEditV2_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolGroupEditV2_Algorithm.Location = new System.Drawing.Point(0, 0);
            this.cogToolGroupEditV2_Algorithm.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolGroupEditV2_Algorithm.Name = "cogToolGroupEditV2_Algorithm";
            this.cogToolGroupEditV2_Algorithm.ShowNodeToolTips = true;
            this.cogToolGroupEditV2_Algorithm.Size = new System.Drawing.Size(1453, 753);
            this.cogToolGroupEditV2_Algorithm.SuspendElectricRuns = false;
            this.cogToolGroupEditV2_Algorithm.TabIndex = 0;
            // 
            // tab_roi
            // 
            this.tab_roi.Location = new System.Drawing.Point(4, 22);
            this.tab_roi.Name = "tab_roi";
            this.tab_roi.Padding = new System.Windows.Forms.Padding(3);
            this.tab_roi.Size = new System.Drawing.Size(1453, 753);
            this.tab_roi.TabIndex = 0;
            this.tab_roi.Text = "ROI";
            this.tab_roi.UseVisualStyleBackColor = true;
            // 
            // tab_optic
            // 
            this.tab_optic.Location = new System.Drawing.Point(4, 22);
            this.tab_optic.Name = "tab_optic";
            this.tab_optic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_optic.Size = new System.Drawing.Size(1453, 753);
            this.tab_optic.TabIndex = 1;
            this.tab_optic.Text = "Optic";
            this.tab_optic.UseVisualStyleBackColor = true;
            // 
            // tab_align
            // 
            this.tab_align.Location = new System.Drawing.Point(4, 22);
            this.tab_align.Name = "tab_align";
            this.tab_align.Size = new System.Drawing.Size(1453, 753);
            this.tab_align.TabIndex = 2;
            this.tab_align.Text = "Align";
            this.tab_align.UseVisualStyleBackColor = true;
            // 
            // Btn_Judge
            // 
            this.Btn_Judge.AutoSize = true;
            this.Btn_Judge.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Judge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Judge.FlatAppearance.BorderSize = 0;
            this.Btn_Judge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Judge.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Judge.Location = new System.Drawing.Point(0, 744);
            this.Btn_Judge.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.Btn_Judge.Name = "Btn_Judge";
            this.Btn_Judge.Size = new System.Drawing.Size(176, 35);
            this.Btn_Judge.TabIndex = 3;
            this.Btn_Judge.Text = "판정";
            this.Btn_Judge.UseVisualStyleBackColor = false;
            // 
            // Lb_UnderLine2
            // 
            this.Lb_UnderLine2.AutoSize = true;
            this.Lb_UnderLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lb_UnderLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lb_UnderLine2.Font = new System.Drawing.Font("굴림", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_UnderLine2.Location = new System.Drawing.Point(3, 742);
            this.Lb_UnderLine2.Margin = new System.Windows.Forms.Padding(3);
            this.Lb_UnderLine2.Name = "Lb_UnderLine2";
            this.Lb_UnderLine2.Size = new System.Drawing.Size(174, 1);
            this.Lb_UnderLine2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 704);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Apply);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Save);
            this.splitContainer1.Size = new System.Drawing.Size(176, 35);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 2;
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.AutoSize = true;
            this.Btn_Apply.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Apply.FlatAppearance.BorderSize = 0;
            this.Btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Apply.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Apply.Location = new System.Drawing.Point(0, 0);
            this.Btn_Apply.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(86, 35);
            this.Btn_Apply.TabIndex = 0;
            this.Btn_Apply.Text = "적용";
            this.Btn_Apply.UseVisualStyleBackColor = false;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AutoSize = true;
            this.Btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Save.Location = new System.Drawing.Point(0, 0);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(86, 35);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "저장";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Revert
            // 
            this.Btn_Revert.AutoSize = true;
            this.Btn_Revert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Revert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Revert.FlatAppearance.BorderSize = 0;
            this.Btn_Revert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Revert.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Revert.Location = new System.Drawing.Point(0, 669);
            this.Btn_Revert.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.Btn_Revert.Name = "Btn_Revert";
            this.Btn_Revert.Size = new System.Drawing.Size(176, 35);
            this.Btn_Revert.TabIndex = 5;
            this.Btn_Revert.Text = "Revert";
            this.Btn_Revert.UseVisualStyleBackColor = false;
            this.Btn_Revert.Click += new System.EventHandler(this.Btn_Revert_Click);
            // 
            // Lb_UnderLine1
            // 
            this.Lb_UnderLine1.AutoSize = true;
            this.Lb_UnderLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lb_UnderLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lb_UnderLine1.Font = new System.Drawing.Font("굴림", 3F);
            this.Lb_UnderLine1.Location = new System.Drawing.Point(3, 169);
            this.Lb_UnderLine1.Margin = new System.Windows.Forms.Padding(3);
            this.Lb_UnderLine1.Name = "Lb_UnderLine1";
            this.Lb_UnderLine1.Size = new System.Drawing.Size(174, 1);
            this.Lb_UnderLine1.TabIndex = 6;
            // 
            // Cagb_Jobs
            // 
            this.Cagb_Jobs.Controls.Add(this.LstBoxJobList);
            this.Cagb_Jobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cagb_Jobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cagb_Jobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cagb_Jobs.Location = new System.Drawing.Point(0, 171);
            this.Cagb_Jobs.Margin = new System.Windows.Forms.Padding(0);
            this.Cagb_Jobs.Name = "Cagb_Jobs";
            this.Cagb_Jobs.Size = new System.Drawing.Size(180, 498);
            this.Cagb_Jobs.TabIndex = 7;
            this.Cagb_Jobs.TabStop = false;
            this.Cagb_Jobs.Text = "Jobs";
            // 
            // LstBoxJobList
            // 
            this.LstBoxJobList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstBoxJobList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LstBoxJobList.FormattingEnabled = true;
            this.LstBoxJobList.ItemHeight = 20;
            this.LstBoxJobList.Location = new System.Drawing.Point(3, 20);
            this.LstBoxJobList.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LstBoxJobList.Name = "LstBoxJobList";
            this.LstBoxJobList.ScrollAlwaysVisible = true;
            this.LstBoxJobList.Size = new System.Drawing.Size(174, 475);
            this.LstBoxJobList.TabIndex = 3;
            this.LstBoxJobList.SelectedIndexChanged += new System.EventHandler(this.LstBoxJobList_SelectedIndexChanged);
            this.LstBoxJobList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstBoxJobList_MouseDoubleClick);
            // 
            // Cagb_Recipe
            // 
            this.Cagb_Recipe.Controls.Add(this.LstBoxRecipeList);
            this.Cagb_Recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cagb_Recipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cagb_Recipe.Location = new System.Drawing.Point(0, 0);
            this.Cagb_Recipe.Margin = new System.Windows.Forms.Padding(0);
            this.Cagb_Recipe.Name = "Cagb_Recipe";
            this.Cagb_Recipe.Size = new System.Drawing.Size(180, 166);
            this.Cagb_Recipe.TabIndex = 8;
            this.Cagb_Recipe.TabStop = false;
            this.Cagb_Recipe.Text = "Recipe";
            // 
            // LstBoxRecipeList
            // 
            this.LstBoxRecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstBoxRecipeList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LstBoxRecipeList.FormattingEnabled = true;
            this.LstBoxRecipeList.ItemHeight = 20;
            this.LstBoxRecipeList.Location = new System.Drawing.Point(3, 20);
            this.LstBoxRecipeList.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LstBoxRecipeList.Name = "LstBoxRecipeList";
            this.LstBoxRecipeList.ScrollAlwaysVisible = true;
            this.LstBoxRecipeList.Size = new System.Drawing.Size(174, 143);
            this.LstBoxRecipeList.TabIndex = 3;
            this.LstBoxRecipeList.SelectedIndexChanged += new System.EventHandler(this.LstBoxRecipeList_SelectedIndexChanged);
            this.LstBoxRecipeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstBoxRecipeList_MouseDoubleClick);
            // 
            // tab_Algorithm
            // 
            this.tab_Algorithm.Controls.Add(this.Tlp_Algorithm);
            this.tab_Algorithm.Location = new System.Drawing.Point(4, 22);
            this.tab_Algorithm.Name = "tab_Algorithm";
            this.tab_Algorithm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Algorithm.Size = new System.Drawing.Size(1453, 753);
            this.tab_Algorithm.TabIndex = 5;
            this.tab_Algorithm.Text = "Algorithm";
            this.tab_Algorithm.UseVisualStyleBackColor = true;
            // 
            // Tlp_Algorithm
            // 
            this.Tlp_Algorithm.ColumnCount = 2;
            this.Tlp_Algorithm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.2405F));
            this.Tlp_Algorithm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.75951F));
            this.Tlp_Algorithm.Controls.Add(this.Grb_Algorithm, 0, 0);
            this.Tlp_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Algorithm.Location = new System.Drawing.Point(3, 3);
            this.Tlp_Algorithm.Name = "Tlp_Algorithm";
            this.Tlp_Algorithm.RowCount = 1;
            this.Tlp_Algorithm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_Algorithm.Size = new System.Drawing.Size(1447, 747);
            this.Tlp_Algorithm.TabIndex = 0;
            // 
            // Grb_Algorithm
            // 
            this.Grb_Algorithm.Controls.Add(this.Tlp_AlgorithmList);
            this.Grb_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grb_Algorithm.Location = new System.Drawing.Point(3, 3);
            this.Grb_Algorithm.Name = "Grb_Algorithm";
            this.Grb_Algorithm.Size = new System.Drawing.Size(229, 741);
            this.Grb_Algorithm.TabIndex = 0;
            this.Grb_Algorithm.TabStop = false;
            this.Grb_Algorithm.Text = "Algorithm\'s";
            // 
            // Tlp_AlgorithmList
            // 
            this.Tlp_AlgorithmList.ColumnCount = 2;
            this.Tlp_AlgorithmList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_AlgorithmList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_AlgorithmList.Controls.Add(this.LstB_Algorithm, 0, 0);
            this.Tlp_AlgorithmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_AlgorithmList.Location = new System.Drawing.Point(3, 17);
            this.Tlp_AlgorithmList.Name = "Tlp_AlgorithmList";
            this.Tlp_AlgorithmList.RowCount = 2;
            this.Tlp_AlgorithmList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.59778F));
            this.Tlp_AlgorithmList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.40222F));
            this.Tlp_AlgorithmList.Size = new System.Drawing.Size(223, 721);
            this.Tlp_AlgorithmList.TabIndex = 0;
            // 
            // LstB_Algorithm
            // 
            this.Tlp_AlgorithmList.SetColumnSpan(this.LstB_Algorithm, 2);
            this.LstB_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstB_Algorithm.FormattingEnabled = true;
            this.LstB_Algorithm.ItemHeight = 12;
            this.LstB_Algorithm.Location = new System.Drawing.Point(3, 3);
            this.LstB_Algorithm.Name = "LstB_Algorithm";
            this.LstB_Algorithm.Size = new System.Drawing.Size(217, 639);
            this.LstB_Algorithm.TabIndex = 0;
            // 
            // Main_Frm_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1641, 779);
            this.Controls.Add(this.Tlp_RecipeLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Frm_Recipe";
            this.Text = "Main_Frm_Recipe";
            this.Shown += new System.EventHandler(this.Main_Frm_Recipe_Shown);
            this.Tlp_RecipeLayout.ResumeLayout(false);
            this.Tlp_RecipeLayout.PerformLayout();
            this.Tab_RecipeMain.ResumeLayout(false);
            this.tab_job.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogToolGroupEditV2_Algorithm)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Cagb_Jobs.ResumeLayout(false);
            this.Cagb_Recipe.ResumeLayout(false);
            this.tab_Algorithm.ResumeLayout(false);
            this.Tlp_Algorithm.ResumeLayout(false);
            this.Grb_Algorithm.ResumeLayout(false);
            this.Tlp_AlgorithmList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_RecipeLayout;
        private System.Windows.Forms.TabControl Tab_RecipeMain;
        private System.Windows.Forms.TabPage tab_roi;
        private System.Windows.Forms.TabPage tab_optic;
        private System.Windows.Forms.TabPage tab_align;
        private System.Windows.Forms.TabPage tab_job;
        private Cognex.VisionPro.ToolGroup.CogToolGroupEditV2 cogToolGroupEditV2_Algorithm;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Judge;
        private System.Windows.Forms.Label Lb_UnderLine2;
        private System.Windows.Forms.Button Btn_Revert;
        private System.Windows.Forms.Label Lb_UnderLine1;
        private User_Controls.CenterAlignedGroupBox Cagb_Jobs;
        private User_Controls.CenterAlignedGroupBox Cagb_Recipe;
        private System.Windows.Forms.ListBox LstBoxJobList;
        private System.Windows.Forms.ListBox LstBoxRecipeList;
        private System.Windows.Forms.TabPage tab_Algorithm;
        private System.Windows.Forms.TableLayoutPanel Tlp_Algorithm;
        private System.Windows.Forms.GroupBox Grb_Algorithm;
        private System.Windows.Forms.TableLayoutPanel Tlp_AlgorithmList;
        private System.Windows.Forms.ListBox LstB_Algorithm;
    }
}