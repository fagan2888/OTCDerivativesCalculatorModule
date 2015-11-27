namespace ExcelOTCManagerAddIn
{
    partial class PositionRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PositionRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.bookingBtn = this.Factory.CreateRibbonButton();
            this.newProductBtn = this.Factory.CreateRibbonButton();
            this.positionLoadBtn = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.gallery1 = this.Factory.CreateRibbonGallery();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.bookingBtn);
            this.group1.Items.Add(this.newProductBtn);
            this.group1.Items.Add(this.positionLoadBtn);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // bookingBtn
            // 
            this.bookingBtn.Label = "booking";
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bookingBtn_Click);
            // 
            // newProductBtn
            // 
            this.newProductBtn.Label = "newProduct";
            this.newProductBtn.Name = "newProductBtn";
            this.newProductBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.newProductBtn_Click);
            // 
            // positionLoadBtn
            // 
            this.positionLoadBtn.Label = "positionLoad";
            this.positionLoadBtn.Name = "positionLoadBtn";
            this.positionLoadBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.positionLoadBtn_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.gallery1);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // gallery1
            // 
            this.gallery1.Label = "gallery1";
            this.gallery1.Name = "gallery1";
            // 
            // PositionRibbon
            // 
            this.Name = "PositionRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.PositionRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bookingBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton newProductBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton positionLoadBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery gallery1;
    }

    partial class ThisRibbonCollection
    {
        internal PositionRibbon PositionRibbon
        {
            get { return this.GetRibbon<PositionRibbon>(); }
        }
    }
}
