using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;

namespace QLNHANSU.Reports
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }

        List<HOPDONG_DTO> _lstHD;

        public rptHopDongLaoDong(List<HOPDONG_DTO> lstHD)
        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD;
            loadData();
        }

        void loadData()
        {
            lblSoHD.DataBindings.Add("Text", _lstHD, "SOHD");
        }
    }
}
