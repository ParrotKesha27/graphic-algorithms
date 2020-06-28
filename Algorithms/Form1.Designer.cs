namespace Algorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.ddaTab = new System.Windows.Forms.TabPage();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.inputContainer = new System.Windows.Forms.SplitContainer();
            this.algorithmsGroupBox = new System.Windows.Forms.GroupBox();
            this.bresenhamRadioButton = new System.Windows.Forms.RadioButton();
            this.ddaRadioButton = new System.Windows.Forms.RadioButton();
            this.selectAlgrotihmLabel = new System.Windows.Forms.Label();
            this.endYInput = new System.Windows.Forms.TextBox();
            this.endYLabel = new System.Windows.Forms.Label();
            this.endXInput = new System.Windows.Forms.TextBox();
            this.endXLabel = new System.Windows.Forms.Label();
            this.endPointTitle = new System.Windows.Forms.Label();
            this.startYInput = new System.Windows.Forms.TextBox();
            this.startYLabel = new System.Windows.Forms.Label();
            this.startXInput = new System.Windows.Forms.TextBox();
            this.startXLabel = new System.Windows.Forms.Label();
            this.startPointTitle = new System.Windows.Forms.Label();
            this.ddaButton = new System.Windows.Forms.Button();
            this.roundPage = new System.Windows.Forms.TabPage();
            this.roundContainer = new System.Windows.Forms.SplitContainer();
            this.inputRoundContainer = new System.Windows.Forms.SplitContainer();
            this.roundRadiusInput = new System.Windows.Forms.TextBox();
            this.inputRoundRadiusTitle = new System.Windows.Forms.Label();
            this.roundYInput = new System.Windows.Forms.TextBox();
            this.inputRoundYTitle = new System.Windows.Forms.Label();
            this.roundXInput = new System.Windows.Forms.TextBox();
            this.inputRoundXTitle = new System.Windows.Forms.Label();
            this.inputRoundTitle = new System.Windows.Forms.Label();
            this.roundButton = new System.Windows.Forms.Button();
            this.splinePage = new System.Windows.Forms.TabPage();
            this.splineContainer = new System.Windows.Forms.SplitContainer();
            this.inputSplineContainer = new System.Windows.Forms.SplitContainer();
            this.clearPointList = new System.Windows.Forms.Button();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.splinePointYInput = new System.Windows.Forms.TextBox();
            this.splinePointYTitle = new System.Windows.Forms.Label();
            this.splinePointXInput = new System.Windows.Forms.TextBox();
            this.splinePointXTitle = new System.Windows.Forms.Label();
            this.addPointTitle = new System.Windows.Forms.Label();
            this.listPointTitle = new System.Windows.Forms.Label();
            this.splinePointList = new System.Windows.Forms.ListBox();
            this.splineButton = new System.Windows.Forms.Button();
            this.ddaHost = new System.Windows.Forms.Integration.ElementHost();
            this.roundHost = new System.Windows.Forms.Integration.ElementHost();
            this.splineHost = new System.Windows.Forms.Integration.ElementHost();
            this.mainTabControl.SuspendLayout();
            this.ddaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputContainer)).BeginInit();
            this.inputContainer.Panel1.SuspendLayout();
            this.inputContainer.Panel2.SuspendLayout();
            this.inputContainer.SuspendLayout();
            this.algorithmsGroupBox.SuspendLayout();
            this.roundPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundContainer)).BeginInit();
            this.roundContainer.Panel1.SuspendLayout();
            this.roundContainer.Panel2.SuspendLayout();
            this.roundContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputRoundContainer)).BeginInit();
            this.inputRoundContainer.Panel1.SuspendLayout();
            this.inputRoundContainer.Panel2.SuspendLayout();
            this.inputRoundContainer.SuspendLayout();
            this.splinePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splineContainer)).BeginInit();
            this.splineContainer.Panel1.SuspendLayout();
            this.splineContainer.Panel2.SuspendLayout();
            this.splineContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSplineContainer)).BeginInit();
            this.inputSplineContainer.Panel1.SuspendLayout();
            this.inputSplineContainer.Panel2.SuspendLayout();
            this.inputSplineContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ddaTab);
            this.mainTabControl.Controls.Add(this.roundPage);
            this.mainTabControl.Controls.Add(this.splinePage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1184, 761);
            this.mainTabControl.TabIndex = 0;
            // 
            // ddaTab
            // 
            this.ddaTab.Controls.Add(this.mainContainer);
            this.ddaTab.Location = new System.Drawing.Point(4, 22);
            this.ddaTab.Name = "ddaTab";
            this.ddaTab.Padding = new System.Windows.Forms.Padding(3);
            this.ddaTab.Size = new System.Drawing.Size(1176, 735);
            this.ddaTab.TabIndex = 0;
            this.ddaTab.Text = "Построение отрезков";
            this.ddaTab.UseVisualStyleBackColor = true;
            // 
            // mainContainer
            // 
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(3, 3);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.inputContainer);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.ddaHost);
            this.mainContainer.Size = new System.Drawing.Size(1170, 729);
            this.mainContainer.SplitterDistance = 269;
            this.mainContainer.TabIndex = 1;
            // 
            // inputContainer
            // 
            this.inputContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputContainer.Location = new System.Drawing.Point(0, 0);
            this.inputContainer.Name = "inputContainer";
            this.inputContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // inputContainer.Panel1
            // 
            this.inputContainer.Panel1.Controls.Add(this.algorithmsGroupBox);
            this.inputContainer.Panel1.Controls.Add(this.selectAlgrotihmLabel);
            this.inputContainer.Panel1.Controls.Add(this.endYInput);
            this.inputContainer.Panel1.Controls.Add(this.endYLabel);
            this.inputContainer.Panel1.Controls.Add(this.endXInput);
            this.inputContainer.Panel1.Controls.Add(this.endXLabel);
            this.inputContainer.Panel1.Controls.Add(this.endPointTitle);
            this.inputContainer.Panel1.Controls.Add(this.startYInput);
            this.inputContainer.Panel1.Controls.Add(this.startYLabel);
            this.inputContainer.Panel1.Controls.Add(this.startXInput);
            this.inputContainer.Panel1.Controls.Add(this.startXLabel);
            this.inputContainer.Panel1.Controls.Add(this.startPointTitle);
            // 
            // inputContainer.Panel2
            // 
            this.inputContainer.Panel2.Controls.Add(this.ddaButton);
            this.inputContainer.Size = new System.Drawing.Size(269, 729);
            this.inputContainer.SplitterDistance = 603;
            this.inputContainer.TabIndex = 0;
            // 
            // algorithmsGroupBox
            // 
            this.algorithmsGroupBox.Controls.Add(this.bresenhamRadioButton);
            this.algorithmsGroupBox.Controls.Add(this.ddaRadioButton);
            this.algorithmsGroupBox.Location = new System.Drawing.Point(12, 504);
            this.algorithmsGroupBox.Name = "algorithmsGroupBox";
            this.algorithmsGroupBox.Size = new System.Drawing.Size(240, 94);
            this.algorithmsGroupBox.TabIndex = 12;
            this.algorithmsGroupBox.TabStop = false;
            // 
            // bresenhamRadioButton
            // 
            this.bresenhamRadioButton.AutoSize = true;
            this.bresenhamRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bresenhamRadioButton.Location = new System.Drawing.Point(6, 53);
            this.bresenhamRadioButton.Name = "bresenhamRadioButton";
            this.bresenhamRadioButton.Size = new System.Drawing.Size(181, 22);
            this.bresenhamRadioButton.TabIndex = 1;
            this.bresenhamRadioButton.TabStop = true;
            this.bresenhamRadioButton.Text = "Алгоритм Брезенхема";
            this.bresenhamRadioButton.UseVisualStyleBackColor = true;
            // 
            // ddaRadioButton
            // 
            this.ddaRadioButton.AutoSize = true;
            this.ddaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddaRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ddaRadioButton.Name = "ddaRadioButton";
            this.ddaRadioButton.Size = new System.Drawing.Size(128, 22);
            this.ddaRadioButton.TabIndex = 0;
            this.ddaRadioButton.TabStop = true;
            this.ddaRadioButton.Text = "Алгоритм DDA";
            this.ddaRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectAlgrotihmLabel
            // 
            this.selectAlgrotihmLabel.AutoSize = true;
            this.selectAlgrotihmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectAlgrotihmLabel.Location = new System.Drawing.Point(46, 483);
            this.selectAlgrotihmLabel.Name = "selectAlgrotihmLabel";
            this.selectAlgrotihmLabel.Size = new System.Drawing.Size(164, 18);
            this.selectAlgrotihmLabel.TabIndex = 11;
            this.selectAlgrotihmLabel.Text = "Выберите алгоритм";
            this.selectAlgrotihmLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // endYInput
            // 
            this.endYInput.Location = new System.Drawing.Point(12, 392);
            this.endYInput.Name = "endYInput";
            this.endYInput.Size = new System.Drawing.Size(240, 20);
            this.endYInput.TabIndex = 9;
            // 
            // endYLabel
            // 
            this.endYLabel.AutoSize = true;
            this.endYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endYLabel.Location = new System.Drawing.Point(9, 372);
            this.endYLabel.Name = "endYLabel";
            this.endYLabel.Size = new System.Drawing.Size(102, 16);
            this.endYLabel.TabIndex = 8;
            this.endYLabel.Text = "Координата Y:";
            // 
            // endXInput
            // 
            this.endXInput.Location = new System.Drawing.Point(12, 323);
            this.endXInput.Name = "endXInput";
            this.endXInput.Size = new System.Drawing.Size(240, 20);
            this.endXInput.TabIndex = 7;
            // 
            // endXLabel
            // 
            this.endXLabel.AutoSize = true;
            this.endXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endXLabel.Location = new System.Drawing.Point(9, 304);
            this.endXLabel.Name = "endXLabel";
            this.endXLabel.Size = new System.Drawing.Size(101, 16);
            this.endXLabel.TabIndex = 6;
            this.endXLabel.Text = "Координата X:";
            // 
            // endPointTitle
            // 
            this.endPointTitle.AutoSize = true;
            this.endPointTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endPointTitle.Location = new System.Drawing.Point(12, 257);
            this.endPointTitle.Name = "endPointTitle";
            this.endPointTitle.Size = new System.Drawing.Size(234, 18);
            this.endPointTitle.TabIndex = 5;
            this.endPointTitle.Text = "Координаты конечной точки";
            this.endPointTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startYInput
            // 
            this.startYInput.Location = new System.Drawing.Point(15, 174);
            this.startYInput.Name = "startYInput";
            this.startYInput.Size = new System.Drawing.Size(240, 20);
            this.startYInput.TabIndex = 4;
            // 
            // startYLabel
            // 
            this.startYLabel.AutoSize = true;
            this.startYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startYLabel.Location = new System.Drawing.Point(12, 154);
            this.startYLabel.Name = "startYLabel";
            this.startYLabel.Size = new System.Drawing.Size(102, 16);
            this.startYLabel.TabIndex = 3;
            this.startYLabel.Text = "Координата Y:";
            // 
            // startXInput
            // 
            this.startXInput.Location = new System.Drawing.Point(15, 105);
            this.startXInput.Name = "startXInput";
            this.startXInput.Size = new System.Drawing.Size(240, 20);
            this.startXInput.TabIndex = 2;
            // 
            // startXLabel
            // 
            this.startXLabel.AutoSize = true;
            this.startXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startXLabel.Location = new System.Drawing.Point(12, 86);
            this.startXLabel.Name = "startXLabel";
            this.startXLabel.Size = new System.Drawing.Size(101, 16);
            this.startXLabel.TabIndex = 1;
            this.startXLabel.Text = "Координата X:";
            // 
            // startPointTitle
            // 
            this.startPointTitle.AutoSize = true;
            this.startPointTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPointTitle.Location = new System.Drawing.Point(12, 39);
            this.startPointTitle.Name = "startPointTitle";
            this.startPointTitle.Size = new System.Drawing.Size(243, 18);
            this.startPointTitle.TabIndex = 0;
            this.startPointTitle.Text = "Координаты начальной точки";
            this.startPointTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ddaButton
            // 
            this.ddaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddaButton.Location = new System.Drawing.Point(0, 0);
            this.ddaButton.Name = "ddaButton";
            this.ddaButton.Size = new System.Drawing.Size(267, 120);
            this.ddaButton.TabIndex = 0;
            this.ddaButton.Text = "Построить";
            this.ddaButton.UseVisualStyleBackColor = true;
            this.ddaButton.Click += new System.EventHandler(this.ddaButton_Click);
            // 
            // roundPage
            // 
            this.roundPage.Controls.Add(this.roundContainer);
            this.roundPage.Location = new System.Drawing.Point(4, 22);
            this.roundPage.Name = "roundPage";
            this.roundPage.Padding = new System.Windows.Forms.Padding(3);
            this.roundPage.Size = new System.Drawing.Size(1176, 735);
            this.roundPage.TabIndex = 1;
            this.roundPage.Text = "Построение окружности";
            this.roundPage.UseVisualStyleBackColor = true;
            // 
            // roundContainer
            // 
            this.roundContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundContainer.Location = new System.Drawing.Point(3, 3);
            this.roundContainer.Name = "roundContainer";
            // 
            // roundContainer.Panel1
            // 
            this.roundContainer.Panel1.Controls.Add(this.inputRoundContainer);
            // 
            // roundContainer.Panel2
            // 
            this.roundContainer.Panel2.Controls.Add(this.roundHost);
            this.roundContainer.Size = new System.Drawing.Size(1170, 729);
            this.roundContainer.SplitterDistance = 269;
            this.roundContainer.TabIndex = 0;
            // 
            // inputRoundContainer
            // 
            this.inputRoundContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRoundContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputRoundContainer.Location = new System.Drawing.Point(0, 0);
            this.inputRoundContainer.Name = "inputRoundContainer";
            this.inputRoundContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // inputRoundContainer.Panel1
            // 
            this.inputRoundContainer.Panel1.Controls.Add(this.roundRadiusInput);
            this.inputRoundContainer.Panel1.Controls.Add(this.inputRoundRadiusTitle);
            this.inputRoundContainer.Panel1.Controls.Add(this.roundYInput);
            this.inputRoundContainer.Panel1.Controls.Add(this.inputRoundYTitle);
            this.inputRoundContainer.Panel1.Controls.Add(this.roundXInput);
            this.inputRoundContainer.Panel1.Controls.Add(this.inputRoundXTitle);
            this.inputRoundContainer.Panel1.Controls.Add(this.inputRoundTitle);
            // 
            // inputRoundContainer.Panel2
            // 
            this.inputRoundContainer.Panel2.Controls.Add(this.roundButton);
            this.inputRoundContainer.Size = new System.Drawing.Size(269, 729);
            this.inputRoundContainer.SplitterDistance = 603;
            this.inputRoundContainer.TabIndex = 0;
            // 
            // roundRadiusInput
            // 
            this.roundRadiusInput.Location = new System.Drawing.Point(12, 230);
            this.roundRadiusInput.Name = "roundRadiusInput";
            this.roundRadiusInput.Size = new System.Drawing.Size(240, 20);
            this.roundRadiusInput.TabIndex = 11;
            // 
            // inputRoundRadiusTitle
            // 
            this.inputRoundRadiusTitle.AutoSize = true;
            this.inputRoundRadiusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRoundRadiusTitle.Location = new System.Drawing.Point(9, 210);
            this.inputRoundRadiusTitle.Name = "inputRoundRadiusTitle";
            this.inputRoundRadiusTitle.Size = new System.Drawing.Size(59, 16);
            this.inputRoundRadiusTitle.TabIndex = 10;
            this.inputRoundRadiusTitle.Text = "Радиус:";
            // 
            // roundYInput
            // 
            this.roundYInput.Location = new System.Drawing.Point(12, 165);
            this.roundYInput.Name = "roundYInput";
            this.roundYInput.Size = new System.Drawing.Size(240, 20);
            this.roundYInput.TabIndex = 9;
            // 
            // inputRoundYTitle
            // 
            this.inputRoundYTitle.AutoSize = true;
            this.inputRoundYTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRoundYTitle.Location = new System.Drawing.Point(9, 145);
            this.inputRoundYTitle.Name = "inputRoundYTitle";
            this.inputRoundYTitle.Size = new System.Drawing.Size(102, 16);
            this.inputRoundYTitle.TabIndex = 8;
            this.inputRoundYTitle.Text = "Координата Y:";
            // 
            // roundXInput
            // 
            this.roundXInput.Location = new System.Drawing.Point(12, 96);
            this.roundXInput.Name = "roundXInput";
            this.roundXInput.Size = new System.Drawing.Size(240, 20);
            this.roundXInput.TabIndex = 7;
            // 
            // inputRoundXTitle
            // 
            this.inputRoundXTitle.AutoSize = true;
            this.inputRoundXTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRoundXTitle.Location = new System.Drawing.Point(9, 77);
            this.inputRoundXTitle.Name = "inputRoundXTitle";
            this.inputRoundXTitle.Size = new System.Drawing.Size(101, 16);
            this.inputRoundXTitle.TabIndex = 6;
            this.inputRoundXTitle.Text = "Координата X:";
            // 
            // inputRoundTitle
            // 
            this.inputRoundTitle.AutoSize = true;
            this.inputRoundTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRoundTitle.Location = new System.Drawing.Point(34, 37);
            this.inputRoundTitle.Name = "inputRoundTitle";
            this.inputRoundTitle.Size = new System.Drawing.Size(195, 18);
            this.inputRoundTitle.TabIndex = 5;
            this.inputRoundTitle.Text = "Параметры окружности";
            this.inputRoundTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roundButton
            // 
            this.roundButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton.Location = new System.Drawing.Point(0, 0);
            this.roundButton.Name = "roundButton";
            this.roundButton.Size = new System.Drawing.Size(267, 120);
            this.roundButton.TabIndex = 1;
            this.roundButton.Text = "Построить";
            this.roundButton.UseVisualStyleBackColor = true;
            this.roundButton.Click += new System.EventHandler(this.roundButton_Click);
            // 
            // splinePage
            // 
            this.splinePage.Controls.Add(this.splineContainer);
            this.splinePage.Location = new System.Drawing.Point(4, 22);
            this.splinePage.Name = "splinePage";
            this.splinePage.Padding = new System.Windows.Forms.Padding(3);
            this.splinePage.Size = new System.Drawing.Size(1176, 735);
            this.splinePage.TabIndex = 2;
            this.splinePage.Text = "Интерполяция сплайнами";
            this.splinePage.UseVisualStyleBackColor = true;
            // 
            // splineContainer
            // 
            this.splineContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splineContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splineContainer.Location = new System.Drawing.Point(3, 3);
            this.splineContainer.Name = "splineContainer";
            // 
            // splineContainer.Panel1
            // 
            this.splineContainer.Panel1.Controls.Add(this.inputSplineContainer);
            // 
            // splineContainer.Panel2
            // 
            this.splineContainer.Panel2.Controls.Add(this.splineHost);
            this.splineContainer.Size = new System.Drawing.Size(1170, 729);
            this.splineContainer.SplitterDistance = 269;
            this.splineContainer.TabIndex = 0;
            // 
            // inputSplineContainer
            // 
            this.inputSplineContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSplineContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSplineContainer.Location = new System.Drawing.Point(0, 0);
            this.inputSplineContainer.Name = "inputSplineContainer";
            this.inputSplineContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // inputSplineContainer.Panel1
            // 
            this.inputSplineContainer.Panel1.Controls.Add(this.clearPointList);
            this.inputSplineContainer.Panel1.Controls.Add(this.AddPointButton);
            this.inputSplineContainer.Panel1.Controls.Add(this.splinePointYInput);
            this.inputSplineContainer.Panel1.Controls.Add(this.splinePointYTitle);
            this.inputSplineContainer.Panel1.Controls.Add(this.splinePointXInput);
            this.inputSplineContainer.Panel1.Controls.Add(this.splinePointXTitle);
            this.inputSplineContainer.Panel1.Controls.Add(this.addPointTitle);
            this.inputSplineContainer.Panel1.Controls.Add(this.listPointTitle);
            this.inputSplineContainer.Panel1.Controls.Add(this.splinePointList);
            // 
            // inputSplineContainer.Panel2
            // 
            this.inputSplineContainer.Panel2.Controls.Add(this.splineButton);
            this.inputSplineContainer.Size = new System.Drawing.Size(269, 729);
            this.inputSplineContainer.SplitterDistance = 604;
            this.inputSplineContainer.TabIndex = 0;
            // 
            // clearPointList
            // 
            this.clearPointList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearPointList.Location = new System.Drawing.Point(8, 338);
            this.clearPointList.Name = "clearPointList";
            this.clearPointList.Size = new System.Drawing.Size(246, 30);
            this.clearPointList.TabIndex = 10;
            this.clearPointList.Text = "Очистить список";
            this.clearPointList.UseVisualStyleBackColor = true;
            this.clearPointList.Click += new System.EventHandler(this.clearPointList_Click);
            // 
            // AddPointButton
            // 
            this.AddPointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPointButton.Location = new System.Drawing.Point(8, 523);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(246, 64);
            this.AddPointButton.TabIndex = 9;
            this.AddPointButton.Text = "Добавить";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // splinePointYInput
            // 
            this.splinePointYInput.Location = new System.Drawing.Point(8, 497);
            this.splinePointYInput.Name = "splinePointYInput";
            this.splinePointYInput.Size = new System.Drawing.Size(246, 20);
            this.splinePointYInput.TabIndex = 8;
            // 
            // splinePointYTitle
            // 
            this.splinePointYTitle.AutoSize = true;
            this.splinePointYTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splinePointYTitle.Location = new System.Drawing.Point(5, 477);
            this.splinePointYTitle.Name = "splinePointYTitle";
            this.splinePointYTitle.Size = new System.Drawing.Size(102, 16);
            this.splinePointYTitle.TabIndex = 7;
            this.splinePointYTitle.Text = "Координата Y:";
            // 
            // splinePointXInput
            // 
            this.splinePointXInput.Location = new System.Drawing.Point(8, 440);
            this.splinePointXInput.Name = "splinePointXInput";
            this.splinePointXInput.Size = new System.Drawing.Size(246, 20);
            this.splinePointXInput.TabIndex = 6;
            // 
            // splinePointXTitle
            // 
            this.splinePointXTitle.AutoSize = true;
            this.splinePointXTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splinePointXTitle.Location = new System.Drawing.Point(5, 421);
            this.splinePointXTitle.Name = "splinePointXTitle";
            this.splinePointXTitle.Size = new System.Drawing.Size(101, 16);
            this.splinePointXTitle.TabIndex = 5;
            this.splinePointXTitle.Text = "Координата X:";
            // 
            // addPointTitle
            // 
            this.addPointTitle.AutoSize = true;
            this.addPointTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPointTitle.Location = new System.Drawing.Point(52, 390);
            this.addPointTitle.Name = "addPointTitle";
            this.addPointTitle.Size = new System.Drawing.Size(139, 18);
            this.addPointTitle.TabIndex = 4;
            this.addPointTitle.Text = "Добавить точку:";
            // 
            // listPointTitle
            // 
            this.listPointTitle.AutoSize = true;
            this.listPointTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPointTitle.Location = new System.Drawing.Point(70, 21);
            this.listPointTitle.Name = "listPointTitle";
            this.listPointTitle.Size = new System.Drawing.Size(121, 18);
            this.listPointTitle.TabIndex = 1;
            this.listPointTitle.Text = "Список точек:";
            // 
            // splinePointList
            // 
            this.splinePointList.FormattingEnabled = true;
            this.splinePointList.Location = new System.Drawing.Point(8, 42);
            this.splinePointList.Name = "splinePointList";
            this.splinePointList.Size = new System.Drawing.Size(246, 290);
            this.splinePointList.TabIndex = 0;
            // 
            // splineButton
            // 
            this.splineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splineButton.Location = new System.Drawing.Point(0, 0);
            this.splineButton.Name = "splineButton";
            this.splineButton.Size = new System.Drawing.Size(267, 119);
            this.splineButton.TabIndex = 2;
            this.splineButton.Text = "Построить";
            this.splineButton.UseVisualStyleBackColor = true;
            this.splineButton.Click += new System.EventHandler(this.splineButton_Click);
            // 
            // ddaHost
            // 
            this.ddaHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddaHost.Location = new System.Drawing.Point(0, 0);
            this.ddaHost.Name = "ddaHost";
            this.ddaHost.Size = new System.Drawing.Size(895, 727);
            this.ddaHost.TabIndex = 0;
            this.ddaHost.Text = "elementHost1";
            this.ddaHost.Child = null;
            // 
            // roundHost
            // 
            this.roundHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundHost.Location = new System.Drawing.Point(0, 0);
            this.roundHost.Name = "roundHost";
            this.roundHost.Size = new System.Drawing.Size(895, 727);
            this.roundHost.TabIndex = 0;
            this.roundHost.Text = "elementHost1";
            this.roundHost.Child = null;
            // 
            // splineHost
            // 
            this.splineHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splineHost.Location = new System.Drawing.Point(0, 0);
            this.splineHost.Name = "splineHost";
            this.splineHost.Size = new System.Drawing.Size(895, 727);
            this.splineHost.TabIndex = 0;
            this.splineHost.Text = "elementHost1";
            this.splineHost.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.ddaTab.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.inputContainer.Panel1.ResumeLayout(false);
            this.inputContainer.Panel1.PerformLayout();
            this.inputContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputContainer)).EndInit();
            this.inputContainer.ResumeLayout(false);
            this.algorithmsGroupBox.ResumeLayout(false);
            this.algorithmsGroupBox.PerformLayout();
            this.roundPage.ResumeLayout(false);
            this.roundContainer.Panel1.ResumeLayout(false);
            this.roundContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundContainer)).EndInit();
            this.roundContainer.ResumeLayout(false);
            this.inputRoundContainer.Panel1.ResumeLayout(false);
            this.inputRoundContainer.Panel1.PerformLayout();
            this.inputRoundContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputRoundContainer)).EndInit();
            this.inputRoundContainer.ResumeLayout(false);
            this.splinePage.ResumeLayout(false);
            this.splineContainer.Panel1.ResumeLayout(false);
            this.splineContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splineContainer)).EndInit();
            this.splineContainer.ResumeLayout(false);
            this.inputSplineContainer.Panel1.ResumeLayout(false);
            this.inputSplineContainer.Panel1.PerformLayout();
            this.inputSplineContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputSplineContainer)).EndInit();
            this.inputSplineContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage ddaTab;
        private System.Windows.Forms.TabPage roundPage;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.SplitContainer inputContainer;
        private System.Windows.Forms.Label startPointTitle;
        private System.Windows.Forms.TextBox startXInput;
        private System.Windows.Forms.Label startXLabel;
        private System.Windows.Forms.TextBox endYInput;
        private System.Windows.Forms.Label endYLabel;
        private System.Windows.Forms.TextBox endXInput;
        private System.Windows.Forms.Label endXLabel;
        private System.Windows.Forms.Label endPointTitle;
        private System.Windows.Forms.TextBox startYInput;
        private System.Windows.Forms.Label startYLabel;
        private System.Windows.Forms.Button ddaButton;
        private System.Windows.Forms.Label selectAlgrotihmLabel;
        private System.Windows.Forms.GroupBox algorithmsGroupBox;
        private System.Windows.Forms.RadioButton bresenhamRadioButton;
        private System.Windows.Forms.RadioButton ddaRadioButton;
        private System.Windows.Forms.SplitContainer roundContainer;
        private System.Windows.Forms.SplitContainer inputRoundContainer;
        private System.Windows.Forms.TextBox roundRadiusInput;
        private System.Windows.Forms.Label inputRoundRadiusTitle;
        private System.Windows.Forms.TextBox roundYInput;
        private System.Windows.Forms.Label inputRoundYTitle;
        private System.Windows.Forms.TextBox roundXInput;
        private System.Windows.Forms.Label inputRoundXTitle;
        private System.Windows.Forms.Label inputRoundTitle;
        private System.Windows.Forms.Button roundButton;
        private System.Windows.Forms.SplitContainer splineContainer;
        private System.Windows.Forms.SplitContainer inputSplineContainer;
        private System.Windows.Forms.TabPage splinePage;
        private System.Windows.Forms.Button splineButton;
        private System.Windows.Forms.Label addPointTitle;
        private System.Windows.Forms.Label listPointTitle;
        private System.Windows.Forms.ListBox splinePointList;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.TextBox splinePointYInput;
        private System.Windows.Forms.Label splinePointYTitle;
        private System.Windows.Forms.TextBox splinePointXInput;
        private System.Windows.Forms.Label splinePointXTitle;
        private System.Windows.Forms.Button clearPointList;
        private System.Windows.Forms.Integration.ElementHost ddaHost;
        private System.Windows.Forms.Integration.ElementHost roundHost;
        private System.Windows.Forms.Integration.ElementHost splineHost;
    }
}

