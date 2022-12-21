﻿namespace QLNHANSU
{
    partial class frmHopDongLaoDong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongLaoDong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboThoiHan = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.txtSoHD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDung = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1742, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 752);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1742, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 722);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1742, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 722);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboThoiHan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBD);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1742, 722);
            this.splitContainer1.SplitterDistance = 519;
            this.splitContainer1.TabIndex = 6;
            // 
            // cboThoiHan
            // 
            this.cboThoiHan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboThoiHan.FormattingEnabled = true;
            this.cboThoiHan.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.cboThoiHan.Location = new System.Drawing.Point(137, 301);
            this.cboThoiHan.Name = "cboThoiHan";
            this.cboThoiHan.Size = new System.Drawing.Size(286, 29);
            this.cboThoiHan.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(37, 304);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 21);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Thời hạn";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(37, 351);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 21);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Nhân viên";
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(137, 345);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.slkNhanVien.Properties.Appearance.Options.UseFont = true;
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Size = new System.Drawing.Size(286, 28);
            this.slkNhanVien.TabIndex = 12;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMaNV.AppearanceHeader.Options.UseFont = true;
            this.colMaNV.Caption = "MÃ NV";
            this.colMaNV.FieldName = "MANV";
            this.colMaNV.MaxWidth = 80;
            this.colMaNV.MinWidth = 80;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colHoTen.AppearanceHeader.Options.UseFont = true;
            this.colHoTen.Caption = "HỌ TÊN";
            this.colHoTen.FieldName = "HOTEN";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(37, 259);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 21);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Hệ số lương";
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(137, 253);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spHeSoLuong.Properties.Appearance.Options.UseFont = true;
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(88, 28);
            this.spHeSoLuong.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 213);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 21);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Lần ký";
            // 
            // spLanKy
            // 
            this.spLanKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKy.Location = new System.Drawing.Point(137, 210);
            this.spLanKy.MenuManager = this.barManager1;
            this.spLanKy.Name = "spLanKy";
            this.spLanKy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spLanKy.Properties.Appearance.Options.UseFont = true;
            this.spLanKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKy.Properties.IsFloatValue = false;
            this.spLanKy.Properties.MaskSettings.Set("mask", "N00");
            this.spLanKy.Size = new System.Drawing.Size(88, 28);
            this.spLanKy.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 21);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ngày ký";
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKy.Location = new System.Drawing.Point(137, 162);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(286, 28);
            this.dtNgayKy.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ngày KT";
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKT.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKT.Location = new System.Drawing.Point(137, 117);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(286, 28);
            this.dtNgayKT.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày BĐ";
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBD.Location = new System.Drawing.Point(137, 72);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(286, 28);
            this.dtNgayBD.TabIndex = 2;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(137, 29);
            this.txtSoHD.MenuManager = this.barManager1;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSoHD.Properties.Appearance.Options.UseFont = true;
            this.txtSoHD.Properties.ReadOnly = true;
            this.txtSoHD.Size = new System.Drawing.Size(286, 28);
            this.txtSoHD.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số HĐ";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1742, 199);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvDanhSach.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvDanhSach.Appearance.Row.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOHD,
            this.NGAYKY,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.THOIHAN,
            this.HESOLUONG,
            this.LANKY,
            this.MANV,
            this.HOTEN});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // SOHD
            // 
            this.SOHD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SOHD.AppearanceCell.Options.UseFont = true;
            this.SOHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SOHD.AppearanceHeader.Options.UseFont = true;
            this.SOHD.Caption = "SỐ HỢP ĐỒNG";
            this.SOHD.FieldName = "SOHD";
            this.SOHD.MaxWidth = 200;
            this.SOHD.MinWidth = 200;
            this.SOHD.Name = "SOHD";
            this.SOHD.Visible = true;
            this.SOHD.VisibleIndex = 0;
            this.SOHD.Width = 200;
            // 
            // NGAYKY
            // 
            this.NGAYKY.Caption = "NGÀY KÝ";
            this.NGAYKY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAYKY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYKY.FieldName = "NGAYKY";
            this.NGAYKY.MaxWidth = 200;
            this.NGAYKY.MinWidth = 200;
            this.NGAYKY.Name = "NGAYKY";
            this.NGAYKY.Visible = true;
            this.NGAYKY.VisibleIndex = 1;
            this.NGAYKY.Width = 200;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NGAYBATDAU.AppearanceCell.Options.UseFont = true;
            this.NGAYBATDAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NGAYBATDAU.AppearanceHeader.Options.UseFont = true;
            this.NGAYBATDAU.Caption = "NGÀY BẮT ĐẦU";
            this.NGAYBATDAU.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAYBATDAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYBATDAU.FieldName = "NGAYBATDAU";
            this.NGAYBATDAU.MaxWidth = 200;
            this.NGAYBATDAU.MinWidth = 200;
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.Visible = true;
            this.NGAYBATDAU.VisibleIndex = 2;
            this.NGAYBATDAU.Width = 200;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.Caption = "NGÀY KẾT THÚC";
            this.NGAYKETTHUC.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAYKETTHUC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.NGAYKETTHUC.MaxWidth = 200;
            this.NGAYKETTHUC.MinWidth = 200;
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Visible = true;
            this.NGAYKETTHUC.VisibleIndex = 3;
            this.NGAYKETTHUC.Width = 200;
            // 
            // THOIHAN
            // 
            this.THOIHAN.Caption = "THỜI HẠN";
            this.THOIHAN.FieldName = "THOIHAN";
            this.THOIHAN.MaxWidth = 150;
            this.THOIHAN.MinWidth = 150;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Visible = true;
            this.THOIHAN.VisibleIndex = 4;
            this.THOIHAN.Width = 150;
            // 
            // HESOLUONG
            // 
            this.HESOLUONG.Caption = "HỆ SỐ LƯƠNG";
            this.HESOLUONG.FieldName = "HESOLUONG";
            this.HESOLUONG.MaxWidth = 150;
            this.HESOLUONG.MinWidth = 150;
            this.HESOLUONG.Name = "HESOLUONG";
            this.HESOLUONG.Visible = true;
            this.HESOLUONG.VisibleIndex = 5;
            this.HESOLUONG.Width = 150;
            // 
            // LANKY
            // 
            this.LANKY.Caption = "LẦN KÝ";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MaxWidth = 100;
            this.LANKY.MinWidth = 100;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 6;
            this.LANKY.Width = 100;
            // 
            // MANV
            // 
            this.MANV.Caption = "MÃ NV";
            this.MANV.FieldName = "MANV";
            this.MANV.MinWidth = 25;
            this.MANV.Name = "MANV";
            this.MANV.Width = 96;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "NHÂN VIÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 300;
            this.HOTEN.MinWidth = 300;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 7;
            this.HOTEN.Width = 300;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(558, 7);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 21);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(629, 7);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(1110, 497);
            this.txtNoiDung.TabIndex = 15;
            this.txtNoiDung.Text = "richEditControl1";
            // 
            // frmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 772);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHopDongLaoDong";
            this.Text = "Hợp đồng lao động";
            this.Load += new System.EventHandler(this.frmHopDongLaoDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SOHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKETTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn THOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spLanKy;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private DevExpress.XtraEditors.TextEdit txtSoHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox cboThoiHan;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKY;
        private DevExpress.XtraRichEdit.RichEditControl txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}