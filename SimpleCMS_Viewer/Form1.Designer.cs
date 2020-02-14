namespace SimpleCMS_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tChartWave = new Steema.TeeChart.TChart();
            this.tChartFFT = new Steema.TeeChart.TChart();
            this.tChartTrends = new Steema.TeeChart.TChart();
            this.chartStartTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.chartEndTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartEndTime);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chartStartTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1036);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 1036);
            this.panel2.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1312, 1036);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1296, 989);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "channel1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tChartFFT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tChartTrends, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tChartWave, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1290, 983);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tChartWave
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Bottom.Labels.Font.Size = 9;
            this.tChartWave.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Axes.Bottom.Title.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Bottom.Title.Font.Size = 11;
            this.tChartWave.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Axes.Depth.Labels.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Depth.Labels.Font.Size = 9;
            this.tChartWave.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Axes.Depth.Title.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Depth.Title.Font.Size = 11;
            this.tChartWave.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChartWave.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.DepthTop.Title.Font.Size = 11;
            this.tChartWave.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Axes.Left.Labels.Brush.Solid = true;
            this.tChartWave.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChartWave.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Left.Labels.Font.Size = 9;
            this.tChartWave.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Axes.Left.Title.Brush.Solid = true;
            this.tChartWave.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChartWave.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Left.Title.Font.Size = 11;
            this.tChartWave.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Axes.Right.Labels.Brush.Solid = true;
            this.tChartWave.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChartWave.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Right.Labels.Font.Size = 9;
            this.tChartWave.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Axes.Right.Title.Brush.Solid = true;
            this.tChartWave.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChartWave.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Right.Title.Font.Size = 11;
            this.tChartWave.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Axes.Top.Labels.Brush.Solid = true;
            this.tChartWave.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChartWave.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Top.Labels.Font.Size = 9;
            this.tChartWave.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Axes.Top.Title.Brush.Solid = true;
            this.tChartWave.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChartWave.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Axes.Top.Title.Font.Size = 11;
            this.tChartWave.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChartWave.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Footer.Brush.Solid = true;
            this.tChartWave.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartWave.Footer.Font.Brush.Solid = true;
            this.tChartWave.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Footer.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Footer.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Footer.Font.Size = 8;
            this.tChartWave.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Footer.ImageBevel.Brush.Solid = true;
            this.tChartWave.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Footer.Shadow.Brush.Solid = true;
            this.tChartWave.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartWave.Header.Brush.Solid = true;
            this.tChartWave.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.Header.Font.Brush.Solid = true;
            this.tChartWave.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Header.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Header.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Header.Font.Size = 12;
            this.tChartWave.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Header.ImageBevel.Brush.Solid = true;
            this.tChartWave.Header.ImageBevel.Brush.Visible = true;
            this.tChartWave.Header.Lines = new string[] {
        "Wave"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartWave.Header.Shadow.Brush.Solid = true;
            this.tChartWave.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Legend.Brush.Solid = true;
            this.tChartWave.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartWave.Legend.Font.Brush.Solid = true;
            this.tChartWave.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Legend.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Legend.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Legend.Font.Size = 9;
            this.tChartWave.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Legend.ImageBevel.Brush.Solid = true;
            this.tChartWave.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartWave.Legend.Shadow.Brush.Solid = true;
            this.tChartWave.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChartWave.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Legend.Title.Brush.Solid = true;
            this.tChartWave.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChartWave.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChartWave.Legend.Title.Font.Brush.Solid = true;
            this.tChartWave.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChartWave.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChartWave.Legend.Title.Font.Size = 8;
            this.tChartWave.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChartWave.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Legend.Title.Shadow.Brush.Solid = true;
            this.tChartWave.Legend.Title.Shadow.Brush.Visible = true;
            this.tChartWave.Location = new System.Drawing.Point(3, 651);
            this.tChartWave.Name = "tChartWave";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartWave.Panel.Brush.Solid = true;
            this.tChartWave.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Panel.ImageBevel.Brush.Solid = true;
            this.tChartWave.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Panel.Shadow.Brush.Solid = true;
            this.tChartWave.Panel.Shadow.Brush.Visible = true;
            this.tChartWave.Size = new System.Drawing.Size(1284, 329);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.SubFooter.Brush.Solid = true;
            this.tChartWave.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartWave.SubFooter.Font.Brush.Solid = true;
            this.tChartWave.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChartWave.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChartWave.SubFooter.Font.Size = 8;
            this.tChartWave.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChartWave.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.SubFooter.Shadow.Brush.Solid = true;
            this.tChartWave.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartWave.SubHeader.Brush.Solid = true;
            this.tChartWave.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartWave.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChartWave.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartWave.SubHeader.Font.Brush.Solid = true;
            this.tChartWave.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChartWave.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChartWave.SubHeader.Font.Size = 12;
            this.tChartWave.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChartWave.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartWave.SubHeader.Shadow.Brush.Solid = true;
            this.tChartWave.SubHeader.Shadow.Brush.Visible = true;
            this.tChartWave.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChartWave.Walls.Back.Brush.Solid = true;
            this.tChartWave.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChartWave.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Walls.Back.Shadow.Brush.Solid = true;
            this.tChartWave.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChartWave.Walls.Bottom.Brush.Solid = true;
            this.tChartWave.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChartWave.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChartWave.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartWave.Walls.Left.Brush.Solid = true;
            this.tChartWave.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChartWave.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Walls.Left.Shadow.Brush.Solid = true;
            this.tChartWave.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartWave.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartWave.Walls.Right.Brush.Solid = true;
            this.tChartWave.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartWave.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChartWave.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartWave.Walls.Right.Shadow.Brush.Solid = true;
            this.tChartWave.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartWave.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.tChartWave.Zoom.Brush.Solid = true;
            this.tChartWave.Zoom.Brush.Visible = true;
            // 
            // tChartFFT
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Bottom.Labels.Font.Size = 9;
            this.tChartFFT.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Axes.Bottom.Title.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Bottom.Title.Font.Size = 11;
            this.tChartFFT.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Axes.Depth.Labels.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Depth.Labels.Font.Size = 9;
            this.tChartFFT.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Axes.Depth.Title.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Depth.Title.Font.Size = 11;
            this.tChartFFT.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChartFFT.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.DepthTop.Title.Font.Size = 11;
            this.tChartFFT.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Axes.Left.Labels.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Left.Labels.Font.Size = 9;
            this.tChartFFT.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Axes.Left.Title.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Left.Title.Font.Size = 11;
            this.tChartFFT.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Axes.Right.Labels.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Right.Labels.Font.Size = 9;
            this.tChartFFT.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Axes.Right.Title.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Right.Title.Font.Size = 11;
            this.tChartFFT.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Axes.Top.Labels.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Top.Labels.Font.Size = 9;
            this.tChartFFT.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Axes.Top.Title.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Axes.Top.Title.Font.Size = 11;
            this.tChartFFT.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChartFFT.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Footer.Brush.Solid = true;
            this.tChartFFT.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartFFT.Footer.Font.Brush.Solid = true;
            this.tChartFFT.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Footer.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Footer.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Footer.Font.Size = 8;
            this.tChartFFT.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Footer.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Footer.Shadow.Brush.Solid = true;
            this.tChartFFT.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartFFT.Header.Brush.Solid = true;
            this.tChartFFT.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.Header.Font.Brush.Solid = true;
            this.tChartFFT.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Header.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Header.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Header.Font.Size = 12;
            this.tChartFFT.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Header.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Header.ImageBevel.Brush.Visible = true;
            this.tChartFFT.Header.Lines = new string[] {
        "FFT"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartFFT.Header.Shadow.Brush.Solid = true;
            this.tChartFFT.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Legend.Brush.Solid = true;
            this.tChartFFT.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartFFT.Legend.Font.Brush.Solid = true;
            this.tChartFFT.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Legend.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Legend.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Legend.Font.Size = 9;
            this.tChartFFT.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Legend.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartFFT.Legend.Shadow.Brush.Solid = true;
            this.tChartFFT.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChartFFT.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Legend.Title.Brush.Solid = true;
            this.tChartFFT.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChartFFT.Legend.Title.Font.Brush.Solid = true;
            this.tChartFFT.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.Legend.Title.Font.Size = 8;
            this.tChartFFT.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Legend.Title.Shadow.Brush.Solid = true;
            this.tChartFFT.Legend.Title.Shadow.Brush.Visible = true;
            this.tChartFFT.Location = new System.Drawing.Point(3, 327);
            this.tChartFFT.Name = "tChartFFT";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartFFT.Panel.Brush.Solid = true;
            this.tChartFFT.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Panel.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Panel.Shadow.Brush.Solid = true;
            this.tChartFFT.Panel.Shadow.Brush.Visible = true;
            this.tChartFFT.Size = new System.Drawing.Size(1284, 318);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.SubFooter.Brush.Solid = true;
            this.tChartFFT.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartFFT.SubFooter.Font.Brush.Solid = true;
            this.tChartFFT.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.SubFooter.Font.Size = 8;
            this.tChartFFT.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChartFFT.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.SubFooter.Shadow.Brush.Solid = true;
            this.tChartFFT.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartFFT.SubHeader.Brush.Solid = true;
            this.tChartFFT.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartFFT.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChartFFT.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartFFT.SubHeader.Font.Brush.Solid = true;
            this.tChartFFT.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChartFFT.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChartFFT.SubHeader.Font.Size = 12;
            this.tChartFFT.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChartFFT.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartFFT.SubHeader.Shadow.Brush.Solid = true;
            this.tChartFFT.SubHeader.Shadow.Brush.Visible = true;
            this.tChartFFT.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChartFFT.Walls.Back.Brush.Solid = true;
            this.tChartFFT.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Walls.Back.Shadow.Brush.Solid = true;
            this.tChartFFT.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChartFFT.Walls.Bottom.Brush.Solid = true;
            this.tChartFFT.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChartFFT.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartFFT.Walls.Left.Brush.Solid = true;
            this.tChartFFT.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Walls.Left.Shadow.Brush.Solid = true;
            this.tChartFFT.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartFFT.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartFFT.Walls.Right.Brush.Solid = true;
            this.tChartFFT.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartFFT.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChartFFT.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartFFT.Walls.Right.Shadow.Brush.Solid = true;
            this.tChartFFT.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartFFT.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.tChartFFT.Zoom.Brush.Solid = true;
            this.tChartFFT.Zoom.Brush.Visible = true;
            // 
            // tChartTrends
            // 
            // 
            // 
            // 
            this.tChartTrends.Aspect.ColorPaletteIndex = -1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Bottom.Labels.Font.Size = 8;
            this.tChartTrends.Axes.Bottom.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Axes.Bottom.Title.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Bottom.Title.Font.Size = 8;
            this.tChartTrends.Axes.Bottom.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Axes.Depth.Labels.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Depth.Labels.Font.Size = 8;
            this.tChartTrends.Axes.Depth.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Axes.Depth.Title.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Depth.Title.Font.Size = 8;
            this.tChartTrends.Axes.Depth.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.DepthTop.Labels.Font.Size = 8;
            this.tChartTrends.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.DepthTop.Title.Font.Size = 8;
            this.tChartTrends.Axes.DepthTop.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Axes.Left.Labels.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Left.Labels.Font.Size = 8;
            this.tChartTrends.Axes.Left.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Axes.Left.Title.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Left.Title.Font.Size = 8;
            this.tChartTrends.Axes.Left.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Axes.Right.Labels.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Right.Labels.Font.Size = 8;
            this.tChartTrends.Axes.Right.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Axes.Right.Title.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Right.Title.Font.Size = 8;
            this.tChartTrends.Axes.Right.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Axes.Top.Labels.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Top.Labels.Font.Size = 8;
            this.tChartTrends.Axes.Top.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Axes.Top.Title.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Axes.Top.Title.Font.Size = 8;
            this.tChartTrends.Axes.Top.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChartTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.Footer.Brush.Solid = true;
            this.tChartTrends.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartTrends.Footer.Font.Brush.Solid = true;
            this.tChartTrends.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Footer.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Footer.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Footer.Font.Size = 8;
            this.tChartTrends.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Footer.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Footer.Shadow.Brush.Solid = true;
            this.tChartTrends.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChartTrends.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChartTrends.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Header.Brush.Gradient.SigmaFocus = 0F;
            this.tChartTrends.Header.Brush.Gradient.SigmaScale = 0F;
            this.tChartTrends.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Header.Brush.Solid = true;
            this.tChartTrends.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Header.Font.Brush.Solid = true;
            this.tChartTrends.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Header.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Header.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Header.Font.Size = 8;
            this.tChartTrends.Header.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Header.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Header.ImageBevel.Brush.Visible = true;
            this.tChartTrends.Header.Lines = new string[] {
        "Trends"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartTrends.Header.Shadow.Brush.Solid = true;
            this.tChartTrends.Header.Shadow.Brush.Visible = true;
            this.tChartTrends.Header.Shadow.Height = 0;
            this.tChartTrends.Header.Shadow.Width = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChartTrends.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tChartTrends.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Legend.Brush.Gradient.SigmaFocus = 0F;
            this.tChartTrends.Legend.Brush.Gradient.SigmaScale = 0F;
            this.tChartTrends.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChartTrends.Legend.Brush.Gradient.Visible = true;
            this.tChartTrends.Legend.Brush.Solid = true;
            this.tChartTrends.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Legend.Font.Brush.Solid = true;
            this.tChartTrends.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Legend.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Legend.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Legend.Font.Size = 8;
            this.tChartTrends.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Legend.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Legend.Shadow.Brush.Solid = true;
            this.tChartTrends.Legend.Shadow.Brush.Visible = true;
            this.tChartTrends.Legend.Shadow.Width = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChartTrends.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChartTrends.Legend.Title.Brush.Solid = true;
            this.tChartTrends.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChartTrends.Legend.Title.Font.Brush.Solid = true;
            this.tChartTrends.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.Legend.Title.Font.Size = 8;
            this.tChartTrends.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Legend.Title.Shadow.Brush.Solid = true;
            this.tChartTrends.Legend.Title.Shadow.Brush.Visible = true;
            this.tChartTrends.Location = new System.Drawing.Point(3, 3);
            this.tChartTrends.Name = "tChartTrends";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
            // 
            // 
            // 
            this.tChartTrends.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.tChartTrends.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChartTrends.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Panel.Brush.Gradient.SigmaFocus = 0F;
            this.tChartTrends.Panel.Brush.Gradient.SigmaScale = 0F;
            this.tChartTrends.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChartTrends.Panel.Brush.Gradient.UseMiddle = false;
            this.tChartTrends.Panel.Brush.Gradient.Visible = true;
            this.tChartTrends.Panel.Brush.Solid = true;
            this.tChartTrends.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Panel.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Panel.Shadow.Brush.Solid = true;
            this.tChartTrends.Panel.Shadow.Brush.Visible = true;
            this.tChartTrends.Size = new System.Drawing.Size(1284, 318);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChartTrends.SubFooter.Brush.Solid = true;
            this.tChartTrends.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartTrends.SubFooter.Font.Brush.Solid = true;
            this.tChartTrends.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.SubFooter.Font.Size = 8;
            this.tChartTrends.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChartTrends.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.SubFooter.Shadow.Brush.Solid = true;
            this.tChartTrends.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartTrends.SubHeader.Brush.Solid = true;
            this.tChartTrends.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartTrends.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChartTrends.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartTrends.SubHeader.Font.Brush.Solid = true;
            this.tChartTrends.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChartTrends.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChartTrends.SubHeader.Font.Size = 12;
            this.tChartTrends.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChartTrends.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartTrends.SubHeader.Shadow.Brush.Solid = true;
            this.tChartTrends.SubHeader.Shadow.Brush.Visible = true;
            this.tChartTrends.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.tChartTrends.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tChartTrends.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChartTrends.Walls.Back.Brush.Solid = true;
            this.tChartTrends.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Walls.Back.Shadow.Brush.Solid = true;
            this.tChartTrends.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChartTrends.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
            this.tChartTrends.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
            this.tChartTrends.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Walls.Bottom.Brush.Solid = true;
            this.tChartTrends.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChartTrends.Walls.Bottom.Shadow.Brush.Visible = true;
            this.tChartTrends.Walls.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.tChartTrends.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
            this.tChartTrends.Walls.Left.Brush.Gradient.SigmaScale = 0F;
            this.tChartTrends.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Walls.Left.Brush.Solid = true;
            this.tChartTrends.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Walls.Left.Shadow.Brush.Solid = true;
            this.tChartTrends.Walls.Left.Shadow.Brush.Visible = true;
            this.tChartTrends.Walls.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChartTrends.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChartTrends.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartTrends.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
            this.tChartTrends.Walls.Right.Brush.Gradient.SigmaScale = 0F;
            this.tChartTrends.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChartTrends.Walls.Right.Brush.Solid = true;
            this.tChartTrends.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartTrends.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChartTrends.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartTrends.Walls.Right.Shadow.Brush.Solid = true;
            this.tChartTrends.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartTrends.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.tChartTrends.Zoom.Brush.Solid = true;
            this.tChartTrends.Zoom.Brush.Visible = true;
            // 
            // chartStartTime
            // 
            this.chartStartTime.Location = new System.Drawing.Point(191, 16);
            this.chartStartTime.Name = "chartStartTime";
            this.chartStartTime.Size = new System.Drawing.Size(300, 35);
            this.chartStartTime.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1209, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "tchart editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartEndTime
            // 
            this.chartEndTime.Location = new System.Drawing.Point(743, 16);
            this.chartEndTime.Name = "chartEndTime";
            this.chartEndTime.Size = new System.Drawing.Size(300, 35);
            this.chartEndTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "시작구간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "종료구간";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 1112);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Steema.TeeChart.TChart tChartWave;
        private Steema.TeeChart.TChart tChartFFT;
        private Steema.TeeChart.TChart tChartTrends;
        private System.Windows.Forms.DateTimePicker chartStartTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker chartEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

