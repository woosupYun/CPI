﻿namespace CRUX_Renewal.Ex_Form
{
    partial class Ex_Frm_Recipe_Link
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex_Frm_Recipe_Link));
            this.Tlp_Link = new System.Windows.Forms.TableLayoutPanel();
            this.Tlp_Display = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplayStatusBarV21 = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.Cog_ROI_Display = new Cognex.VisionPro.Display.CogDisplay();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplayToolbarV21 = new Cognex.VisionPro.CogDisplayToolbarV2();
            this.Btn_ImageLoad = new System.Windows.Forms.Button();
            this.Grb_ROI = new CRUX_Renewal.User_Controls.CenterAlignedGroupBox();
            this.Tlp_Roi = new System.Windows.Forms.TableLayoutPanel();
            this.Dgv_Roi = new System.Windows.Forms.DataGridView();
            this.Btn_ROIManager = new System.Windows.Forms.Button();
            this.Grb_Algorithm = new CRUX_Renewal.User_Controls.CenterAlignedGroupBox();
            this.Tlp_Algorithm = new System.Windows.Forms.TableLayoutPanel();
            this.LstB_RegistedAlgorithm = new System.Windows.Forms.ListBox();
            this.Btn_AlgorithmManage = new System.Windows.Forms.Button();
            this.Grb_Params = new CRUX_Renewal.User_Controls.CenterAlignedGroupBox();
            this.PGE_Params = new PropertyGridExt.PropertyGridEx();
            this.Tlp_Link.SuspendLayout();
            this.Tlp_Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cog_ROI_Display)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.Grb_ROI.SuspendLayout();
            this.Tlp_Roi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Roi)).BeginInit();
            this.Grb_Algorithm.SuspendLayout();
            this.Tlp_Algorithm.SuspendLayout();
            this.Grb_Params.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_Link
            // 
            this.Tlp_Link.ColumnCount = 4;
            this.Tlp_Link.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 636F));
            this.Tlp_Link.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.Tlp_Link.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.Tlp_Link.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Link.Controls.Add(this.Tlp_Display, 0, 0);
            this.Tlp_Link.Controls.Add(this.Grb_ROI, 1, 0);
            this.Tlp_Link.Controls.Add(this.Grb_Algorithm, 2, 0);
            this.Tlp_Link.Controls.Add(this.Grb_Params, 3, 0);
            this.Tlp_Link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Link.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Link.Name = "Tlp_Link";
            this.Tlp_Link.RowCount = 2;
            this.Tlp_Link.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.Tlp_Link.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Link.Size = new System.Drawing.Size(1532, 840);
            this.Tlp_Link.TabIndex = 1;
            // 
            // Tlp_Display
            // 
            this.Tlp_Display.ColumnCount = 1;
            this.Tlp_Display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Display.Controls.Add(this.cogDisplayStatusBarV21, 0, 2);
            this.Tlp_Display.Controls.Add(this.Cog_ROI_Display, 0, 1);
            this.Tlp_Display.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.Tlp_Display.Location = new System.Drawing.Point(3, 3);
            this.Tlp_Display.Name = "Tlp_Display";
            this.Tlp_Display.RowCount = 3;
            this.Tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.Tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.Tlp_Display.Size = new System.Drawing.Size(630, 574);
            this.Tlp_Display.TabIndex = 9;
            // 
            // cogDisplayStatusBarV21
            // 
            this.cogDisplayStatusBarV21.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBarV21.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBarV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayStatusBarV21.Location = new System.Drawing.Point(0, 548);
            this.cogDisplayStatusBarV21.Margin = new System.Windows.Forms.Padding(0);
            this.cogDisplayStatusBarV21.Name = "cogDisplayStatusBarV21";
            this.cogDisplayStatusBarV21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cogDisplayStatusBarV21.Size = new System.Drawing.Size(630, 26);
            this.cogDisplayStatusBarV21.TabIndex = 2;
            this.cogDisplayStatusBarV21.Use3DCoordinateSpaceTree = false;
            // 
            // Cog_ROI_Display
            // 
            this.Cog_ROI_Display.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.Cog_ROI_Display.ColorMapLowerRoiLimit = 0D;
            this.Cog_ROI_Display.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.Cog_ROI_Display.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.Cog_ROI_Display.ColorMapUpperRoiLimit = 1D;
            this.Cog_ROI_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cog_ROI_Display.DoubleTapZoomCycleLength = 2;
            this.Cog_ROI_Display.DoubleTapZoomSensitivity = 2.5D;
            this.Cog_ROI_Display.Location = new System.Drawing.Point(0, 26);
            this.Cog_ROI_Display.Margin = new System.Windows.Forms.Padding(0);
            this.Cog_ROI_Display.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.Cog_ROI_Display.MouseWheelSensitivity = 1D;
            this.Cog_ROI_Display.Name = "Cog_ROI_Display";
            this.Cog_ROI_Display.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Cog_ROI_Display.OcxState")));
            this.Cog_ROI_Display.Size = new System.Drawing.Size(630, 522);
            this.Cog_ROI_Display.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.cogDisplayToolbarV21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_ImageLoad, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 26);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cogDisplayToolbarV21
            // 
            this.cogDisplayToolbarV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayToolbarV21.Location = new System.Drawing.Point(0, 0);
            this.cogDisplayToolbarV21.Margin = new System.Windows.Forms.Padding(0);
            this.cogDisplayToolbarV21.Name = "cogDisplayToolbarV21";
            this.cogDisplayToolbarV21.Size = new System.Drawing.Size(430, 26);
            this.cogDisplayToolbarV21.TabIndex = 1;
            // 
            // Btn_ImageLoad
            // 
            this.Btn_ImageLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ImageLoad.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_ImageLoad.Location = new System.Drawing.Point(430, 0);
            this.Btn_ImageLoad.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ImageLoad.Name = "Btn_ImageLoad";
            this.Btn_ImageLoad.Size = new System.Drawing.Size(200, 26);
            this.Btn_ImageLoad.TabIndex = 2;
            this.Btn_ImageLoad.Text = "ImageLoad";
            this.Btn_ImageLoad.UseVisualStyleBackColor = true;
            this.Btn_ImageLoad.Click += new System.EventHandler(this.Btn_ImageLoad_Click);
            // 
            // Grb_ROI
            // 
            this.Grb_ROI.Controls.Add(this.Tlp_Roi);
            this.Grb_ROI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grb_ROI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grb_ROI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grb_ROI.Location = new System.Drawing.Point(636, 0);
            this.Grb_ROI.Margin = new System.Windows.Forms.Padding(0);
            this.Grb_ROI.Name = "Grb_ROI";
            this.Grb_ROI.Size = new System.Drawing.Size(300, 580);
            this.Grb_ROI.TabIndex = 10;
            this.Grb_ROI.TabStop = false;
            this.Grb_ROI.Text = "ROI";
            // 
            // Tlp_Roi
            // 
            this.Tlp_Roi.ColumnCount = 1;
            this.Tlp_Roi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Roi.Controls.Add(this.Dgv_Roi, 0, 0);
            this.Tlp_Roi.Controls.Add(this.Btn_ROIManager, 0, 1);
            this.Tlp_Roi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Roi.Location = new System.Drawing.Point(3, 20);
            this.Tlp_Roi.Name = "Tlp_Roi";
            this.Tlp_Roi.RowCount = 2;
            this.Tlp_Roi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Roi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Tlp_Roi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Roi.Size = new System.Drawing.Size(294, 557);
            this.Tlp_Roi.TabIndex = 0;
            // 
            // Dgv_Roi
            // 
            this.Dgv_Roi.AllowUserToAddRows = false;
            this.Dgv_Roi.AllowUserToDeleteRows = false;
            this.Dgv_Roi.AllowUserToResizeColumns = false;
            this.Dgv_Roi.AllowUserToResizeRows = false;
            this.Dgv_Roi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Roi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Roi.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Roi.MultiSelect = false;
            this.Dgv_Roi.Name = "Dgv_Roi";
            this.Dgv_Roi.RowHeadersVisible = false;
            this.Dgv_Roi.RowTemplate.Height = 23;
            this.Dgv_Roi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Roi.Size = new System.Drawing.Size(288, 476);
            this.Dgv_Roi.TabIndex = 15;
            this.Dgv_Roi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Roi_CellEndEdit);
            this.Dgv_Roi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Roi_CellMouseDoubleClick);
            this.Dgv_Roi.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Roi_CellMouseUp);
            this.Dgv_Roi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Roi_CellValueChanged);
            this.Dgv_Roi.CurrentCellDirtyStateChanged += new System.EventHandler(this.Dgv_Roi_CurrentCellDirtyStateChanged);
            this.Dgv_Roi.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_Roi_EditingControlShowing);
            // 
            // Btn_ROIManager
            // 
            this.Btn_ROIManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ROIManager.Location = new System.Drawing.Point(0, 482);
            this.Btn_ROIManager.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ROIManager.Name = "Btn_ROIManager";
            this.Btn_ROIManager.Size = new System.Drawing.Size(294, 75);
            this.Btn_ROIManager.TabIndex = 0;
            this.Btn_ROIManager.Text = "ROI 관리";
            this.Btn_ROIManager.UseVisualStyleBackColor = true;
            this.Btn_ROIManager.Click += new System.EventHandler(this.Btn_ROIManager_Click);
            // 
            // Grb_Algorithm
            // 
            this.Grb_Algorithm.Controls.Add(this.Tlp_Algorithm);
            this.Grb_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grb_Algorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grb_Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grb_Algorithm.Location = new System.Drawing.Point(936, 0);
            this.Grb_Algorithm.Margin = new System.Windows.Forms.Padding(0);
            this.Grb_Algorithm.Name = "Grb_Algorithm";
            this.Grb_Algorithm.Size = new System.Drawing.Size(300, 580);
            this.Grb_Algorithm.TabIndex = 11;
            this.Grb_Algorithm.TabStop = false;
            this.Grb_Algorithm.Text = "Algorithm";
            // 
            // Tlp_Algorithm
            // 
            this.Tlp_Algorithm.ColumnCount = 1;
            this.Tlp_Algorithm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Algorithm.Controls.Add(this.LstB_RegistedAlgorithm, 0, 0);
            this.Tlp_Algorithm.Controls.Add(this.Btn_AlgorithmManage, 0, 1);
            this.Tlp_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Algorithm.Location = new System.Drawing.Point(3, 20);
            this.Tlp_Algorithm.Margin = new System.Windows.Forms.Padding(0);
            this.Tlp_Algorithm.Name = "Tlp_Algorithm";
            this.Tlp_Algorithm.RowCount = 2;
            this.Tlp_Algorithm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Algorithm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Tlp_Algorithm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Algorithm.Size = new System.Drawing.Size(294, 557);
            this.Tlp_Algorithm.TabIndex = 0;
            // 
            // LstB_RegistedAlgorithm
            // 
            this.LstB_RegistedAlgorithm.AllowDrop = true;
            this.LstB_RegistedAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstB_RegistedAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstB_RegistedAlgorithm.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LstB_RegistedAlgorithm.FormattingEnabled = true;
            this.LstB_RegistedAlgorithm.ItemHeight = 20;
            this.LstB_RegistedAlgorithm.Location = new System.Drawing.Point(0, 0);
            this.LstB_RegistedAlgorithm.Margin = new System.Windows.Forms.Padding(0);
            this.LstB_RegistedAlgorithm.Name = "LstB_RegistedAlgorithm";
            this.LstB_RegistedAlgorithm.ScrollAlwaysVisible = true;
            this.LstB_RegistedAlgorithm.Size = new System.Drawing.Size(294, 482);
            this.LstB_RegistedAlgorithm.TabIndex = 3;
            this.LstB_RegistedAlgorithm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstB_RegistedAlgorithm_MouseClick);
            this.LstB_RegistedAlgorithm.SelectedIndexChanged += new System.EventHandler(this.LstB_Algorithm_SelectedIndexChanged);
            this.LstB_RegistedAlgorithm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstB_Algorithm_MouseDoubleClick);
            this.LstB_RegistedAlgorithm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LstB_RegistedAlgorithm_MouseMove);
            this.LstB_RegistedAlgorithm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LstB_RegistedAlgorithm_MouseUp);
            // 
            // Btn_AlgorithmManage
            // 
            this.Btn_AlgorithmManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AlgorithmManage.Location = new System.Drawing.Point(0, 482);
            this.Btn_AlgorithmManage.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AlgorithmManage.Name = "Btn_AlgorithmManage";
            this.Btn_AlgorithmManage.Size = new System.Drawing.Size(294, 75);
            this.Btn_AlgorithmManage.TabIndex = 4;
            this.Btn_AlgorithmManage.Text = "알고리즘 연결";
            this.Btn_AlgorithmManage.UseVisualStyleBackColor = true;
            this.Btn_AlgorithmManage.Click += new System.EventHandler(this.Btn_AlgorithmManage_Click);
            // 
            // Grb_Params
            // 
            this.Grb_Params.Controls.Add(this.PGE_Params);
            this.Grb_Params.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grb_Params.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grb_Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grb_Params.Location = new System.Drawing.Point(1236, 0);
            this.Grb_Params.Margin = new System.Windows.Forms.Padding(0);
            this.Grb_Params.Name = "Grb_Params";
            this.Grb_Params.Size = new System.Drawing.Size(296, 580);
            this.Grb_Params.TabIndex = 12;
            this.Grb_Params.TabStop = false;
            this.Grb_Params.Text = "Params";
            // 
            // PGE_Params
            // 
            // 
            // 
            // 
            this.PGE_Params.DocCommentDescription.AccessibleName = "";
            this.PGE_Params.DocCommentDescription.AutoEllipsis = true;
            this.PGE_Params.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.PGE_Params.DocCommentDescription.Location = new System.Drawing.Point(3, 22);
            this.PGE_Params.DocCommentDescription.Margin = new System.Windows.Forms.Padding(0);
            this.PGE_Params.DocCommentDescription.Name = "공백을 포함할 수 없습니다.";
            this.PGE_Params.DocCommentDescription.Size = new System.Drawing.Size(284, 33);
            this.PGE_Params.DocCommentDescription.TabIndex = 1;
            this.PGE_Params.DocCommentImage = null;
            // 
            // 
            // 
            this.PGE_Params.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.PGE_Params.DocCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.PGE_Params.DocCommentTitle.Location = new System.Drawing.Point(3, 3);
            this.PGE_Params.DocCommentTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PGE_Params.DocCommentTitle.Name = "공백을 포함할 수 없습니다.";
            this.PGE_Params.DocCommentTitle.Size = new System.Drawing.Size(284, 19);
            this.PGE_Params.DocCommentTitle.TabIndex = 0;
            this.PGE_Params.DocCommentTitle.UseMnemonic = false;
            this.PGE_Params.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGE_Params.DrawFlatToolbar = true;
            this.PGE_Params.Location = new System.Drawing.Point(3, 20);
            this.PGE_Params.Margin = new System.Windows.Forms.Padding(0);
            this.PGE_Params.Name = "PGE_Params";
            this.PGE_Params.SelectedItemWithFocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PGE_Params.SelectedItemWithFocusForeColor = System.Drawing.Color.White;
            this.PGE_Params.SelectedObject = ((object)(resources.GetObject("PGE_Params.SelectedObject")));
            this.PGE_Params.ShowCustomProperties = true;
            this.PGE_Params.Size = new System.Drawing.Size(290, 557);
            this.PGE_Params.TabIndex = 1;
            this.PGE_Params.ToolbarVisible = false;
            // 
            // 
            // 
            this.PGE_Params.ToolStrip.AccessibleName = "도구 모음";
            this.PGE_Params.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.PGE_Params.ToolStrip.AllowMerge = false;
            this.PGE_Params.ToolStrip.AutoSize = false;
            this.PGE_Params.ToolStrip.CanOverflow = false;
            this.PGE_Params.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.PGE_Params.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.PGE_Params.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.PGE_Params.ToolStrip.Name = "";
            this.PGE_Params.ToolStrip.Size = new System.Drawing.Size(0, 0);
            this.PGE_Params.ToolStrip.TabIndex = 1;
            this.PGE_Params.ToolStrip.TabStop = true;
            this.PGE_Params.ToolStrip.Text = "PropertyGridToolBar";
            this.PGE_Params.ToolStrip.Visible = false;
            this.PGE_Params.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PGE_Params_PropertyValueChanged);
            this.PGE_Params.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.PGE_Params_SelectedGridItemChanged);
            this.PGE_Params.SelectedObjectsChanged += new System.EventHandler(this.PGE_Params_SelectedObjectsChanged);
            this.PGE_Params.Leave += new System.EventHandler(this.Tlp_ROI_Leave);
            this.PGE_Params.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PGE_Params_PreviewKeyDown);
            // 
            // Ex_Frm_Recipe_Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1532, 840);
            this.Controls.Add(this.Tlp_Link);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Ex_Frm_Recipe_Link";
            this.Text = "Ex_Frm_AccountManage";
            this.Tlp_Link.ResumeLayout(false);
            this.Tlp_Display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cog_ROI_Display)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Grb_ROI.ResumeLayout(false);
            this.Tlp_Roi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Roi)).EndInit();
            this.Grb_Algorithm.ResumeLayout(false);
            this.Tlp_Algorithm.ResumeLayout(false);
            this.Grb_Params.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_Link;
        private User_Controls.CenterAlignedGroupBox Grb_Params;
        private User_Controls.CenterAlignedGroupBox Grb_Algorithm;
        private System.Windows.Forms.ListBox LstB_RegistedAlgorithm;
        private User_Controls.CenterAlignedGroupBox Grb_ROI;
        private System.Windows.Forms.TableLayoutPanel Tlp_Display;
        private Cognex.VisionPro.Display.CogDisplay Cog_ROI_Display;
        private Cognex.VisionPro.CogDisplayToolbarV2 cogDisplayToolbarV21;
        private Cognex.VisionPro.CogDisplayStatusBarV2 cogDisplayStatusBarV21;
        private PropertyGridExt.PropertyGridEx PGE_Params;
        private System.Windows.Forms.TableLayoutPanel Tlp_Algorithm;
        private System.Windows.Forms.Button Btn_AlgorithmManage;
        private System.Windows.Forms.TableLayoutPanel Tlp_Roi;
        private System.Windows.Forms.Button Btn_ROIManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_ImageLoad;
        private System.Windows.Forms.DataGridView Dgv_Roi;
    }
}