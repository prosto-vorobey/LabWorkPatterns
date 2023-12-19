using System;
using System.Windows.Forms;
using System.Drawing;
using LabWork1;

public partial class ClientForm : Form
{
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private IMatrix _matrix;
    private IMatrixVisitor _visitor;
    public IDrawer Drawer { get; private set; }
    public IDisplay Display { get; private set; }
    public IDisplayFactory TypeBorder { get; private set; }
    private System.ComponentModel.BackgroundWorker backgroundWorker2;
    private System.ComponentModel.IContainer components;
    private Random _rnd = new Random();
    private bool _isTranspose = false;
    private Panel panelDrawingMode;
    private Panel panelDrawing;
    private ClientSettingsForm _settingsForm;
    private int _matrixTypeIndex;
    private Panel panelLeftMenu;
    private Panel panelSideMenu;
    private Panel panelInteractionMode;
    private FontAwesome.Sharp.IconButton buttonRecoverMatrix;
    private FontAwesome.Sharp.IconButton buttonRenumMatrix;
    private FontAwesome.Sharp.IconButton buttonReinitMatrix;
    private FontAwesome.Sharp.IconButton buttonDrawMatrix;
    private FontAwesome.Sharp.IconButton buttonInteractionMode;
    private FontAwesome.Sharp.IconButton buttonSettingsMode;
    private Panel panelMatrixMode;
    private FontAwesome.Sharp.IconButton buttonHorizontalGroupMatrixMode;
    private FontAwesome.Sharp.IconButton buttonDischargedMatrixMode;
    private FontAwesome.Sharp.IconButton buttonOrdinaryMatrixMode;
    private FontAwesome.Sharp.IconButton buttonMatrixMode;
    private Panel panelStyleMode;
    private FontAwesome.Sharp.IconPictureBox iconPictureBoxSun;
    private FontAwesome.Sharp.IconPictureBox iconPictureBoxMoon;
    private Panel panelLogo;
    private PictureBox pictureBoxLogo;
    private Random rnd = new Random();
    public ClientForm()
    {
        InitializeComponent();
        customizeDesign();
        DoubleBuffered = true;
        TypeBorder = new SingleBorder();
        Display = TypeBorder.CreateConsoleDisplay();
        Drawer = new DrawerWithBorder(Display);

    }
    public Panel GetPanelDrawing()
    {
        return panelDrawing;

    }
    public void SetSettings()
    {
        Drawer = _settingsForm.Drawer;
        Display = _settingsForm.Display;
        TypeBorder = _settingsForm.TypeBorder;

    }
    private void InitializeComponent()
    {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelDrawingMode = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelInteractionMode = new System.Windows.Forms.Panel();
            this.buttonRecoverMatrix = new FontAwesome.Sharp.IconButton();
            this.buttonRenumMatrix = new FontAwesome.Sharp.IconButton();
            this.buttonReinitMatrix = new FontAwesome.Sharp.IconButton();
            this.buttonDrawMatrix = new FontAwesome.Sharp.IconButton();
            this.buttonInteractionMode = new FontAwesome.Sharp.IconButton();
            this.buttonSettingsMode = new FontAwesome.Sharp.IconButton();
            this.panelMatrixMode = new System.Windows.Forms.Panel();
            this.buttonHorizontalGroupMatrixMode = new FontAwesome.Sharp.IconButton();
            this.buttonDischargedMatrixMode = new FontAwesome.Sharp.IconButton();
            this.buttonOrdinaryMatrixMode = new FontAwesome.Sharp.IconButton();
            this.buttonMatrixMode = new FontAwesome.Sharp.IconButton();
            this.panelStyleMode = new System.Windows.Forms.Panel();
            this.iconPictureBoxSun = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxMoon = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDrawingMode.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelInteractionMode.SuspendLayout();
            this.panelMatrixMode.SuspendLayout();
            this.panelStyleMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMoon)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrawingMode
            // 
            this.panelDrawingMode.Controls.Add(this.panelDrawing);
            this.panelDrawingMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDrawingMode.Location = new System.Drawing.Point(198, 0);
            this.panelDrawingMode.Name = "panelDrawingMode";
            this.panelDrawingMode.Size = new System.Drawing.Size(806, 515);
            this.panelDrawingMode.TabIndex = 8;
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.Color.White;
            this.panelDrawing.Location = new System.Drawing.Point(30, 30);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(746, 455);
            this.panelDrawing.TabIndex = 4;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.panelSideMenu);
            this.panelLeftMenu.Controls.Add(this.panelStyleMode);
            this.panelLeftMenu.Controls.Add(this.panelLogo);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(200, 515);
            this.panelLeftMenu.TabIndex = 9;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.panelSideMenu.Controls.Add(this.panelInteractionMode);
            this.panelSideMenu.Controls.Add(this.buttonInteractionMode);
            this.panelSideMenu.Controls.Add(this.buttonSettingsMode);
            this.panelSideMenu.Controls.Add(this.panelMatrixMode);
            this.panelSideMenu.Controls.Add(this.buttonMatrixMode);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 78);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 394);
            this.panelSideMenu.TabIndex = 10;
            // 
            // panelInteractionMode
            // 
            this.panelInteractionMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.panelInteractionMode.Controls.Add(this.buttonRecoverMatrix);
            this.panelInteractionMode.Controls.Add(this.buttonRenumMatrix);
            this.panelInteractionMode.Controls.Add(this.buttonReinitMatrix);
            this.panelInteractionMode.Controls.Add(this.buttonDrawMatrix);
            this.panelInteractionMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInteractionMode.Location = new System.Drawing.Point(0, 311);
            this.panelInteractionMode.Name = "panelInteractionMode";
            this.panelInteractionMode.Size = new System.Drawing.Size(183, 167);
            this.panelInteractionMode.TabIndex = 12;
            // 
            // buttonRecoverMatrix
            // 
            this.buttonRecoverMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonRecoverMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecoverMatrix.FlatAppearance.BorderSize = 0;
            this.buttonRecoverMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecoverMatrix.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonRecoverMatrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRecoverMatrix.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonRecoverMatrix.IconColor = System.Drawing.Color.White;
            this.buttonRecoverMatrix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRecoverMatrix.IconSize = 30;
            this.buttonRecoverMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRecoverMatrix.Location = new System.Drawing.Point(0, 120);
            this.buttonRecoverMatrix.Name = "buttonRecoverMatrix";
            this.buttonRecoverMatrix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRecoverMatrix.Size = new System.Drawing.Size(183, 40);
            this.buttonRecoverMatrix.TabIndex = 7;
            this.buttonRecoverMatrix.Text = "Восстановить";
            this.buttonRecoverMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecoverMatrix.UseVisualStyleBackColor = false;
            this.buttonRecoverMatrix.Click += new System.EventHandler(this.buttonRecoverMatrix_Click);
            // 
            // buttonRenumMatrix
            // 
            this.buttonRenumMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonRenumMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRenumMatrix.FlatAppearance.BorderSize = 0;
            this.buttonRenumMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenumMatrix.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonRenumMatrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRenumMatrix.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonRenumMatrix.IconColor = System.Drawing.Color.White;
            this.buttonRenumMatrix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRenumMatrix.IconSize = 30;
            this.buttonRenumMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRenumMatrix.Location = new System.Drawing.Point(0, 80);
            this.buttonRenumMatrix.Name = "buttonRenumMatrix";
            this.buttonRenumMatrix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRenumMatrix.Size = new System.Drawing.Size(183, 40);
            this.buttonRenumMatrix.TabIndex = 6;
            this.buttonRenumMatrix.Text = "Транспонировать";
            this.buttonRenumMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRenumMatrix.UseVisualStyleBackColor = false;
            this.buttonRenumMatrix.Click += new System.EventHandler(this.buttonTransposeMatrix_Click);
            // 
            // buttonReinitMatrix
            // 
            this.buttonReinitMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonReinitMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReinitMatrix.FlatAppearance.BorderSize = 0;
            this.buttonReinitMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReinitMatrix.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonReinitMatrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReinitMatrix.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonReinitMatrix.IconColor = System.Drawing.Color.White;
            this.buttonReinitMatrix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReinitMatrix.IconSize = 30;
            this.buttonReinitMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReinitMatrix.Location = new System.Drawing.Point(0, 40);
            this.buttonReinitMatrix.Name = "buttonReinitMatrix";
            this.buttonReinitMatrix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonReinitMatrix.Size = new System.Drawing.Size(183, 40);
            this.buttonReinitMatrix.TabIndex = 5;
            this.buttonReinitMatrix.Text = "Пересобрать";
            this.buttonReinitMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReinitMatrix.UseVisualStyleBackColor = false;
            this.buttonReinitMatrix.Click += new System.EventHandler(this.buttonReinitMatrix_Click);
            // 
            // buttonDrawMatrix
            // 
            this.buttonDrawMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonDrawMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrawMatrix.FlatAppearance.BorderSize = 0;
            this.buttonDrawMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrawMatrix.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonDrawMatrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDrawMatrix.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonDrawMatrix.IconColor = System.Drawing.Color.White;
            this.buttonDrawMatrix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDrawMatrix.IconSize = 30;
            this.buttonDrawMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDrawMatrix.Location = new System.Drawing.Point(0, 0);
            this.buttonDrawMatrix.Name = "buttonDrawMatrix";
            this.buttonDrawMatrix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDrawMatrix.Size = new System.Drawing.Size(183, 40);
            this.buttonDrawMatrix.TabIndex = 4;
            this.buttonDrawMatrix.Text = "Вывести";
            this.buttonDrawMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrawMatrix.UseVisualStyleBackColor = false;
            this.buttonDrawMatrix.Click += new System.EventHandler(this.buttonDrawMatrix_Click);
            // 
            // buttonInteractionMode
            // 
            this.buttonInteractionMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInteractionMode.FlatAppearance.BorderSize = 0;
            this.buttonInteractionMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInteractionMode.Font = new System.Drawing.Font("Open Sans Semibold", 10F);
            this.buttonInteractionMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInteractionMode.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.buttonInteractionMode.IconColor = System.Drawing.Color.White;
            this.buttonInteractionMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonInteractionMode.IconSize = 30;
            this.buttonInteractionMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInteractionMode.Location = new System.Drawing.Point(0, 251);
            this.buttonInteractionMode.Name = "buttonInteractionMode";
            this.buttonInteractionMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonInteractionMode.Size = new System.Drawing.Size(183, 60);
            this.buttonInteractionMode.TabIndex = 11;
            this.buttonInteractionMode.Text = "Действие";
            this.buttonInteractionMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInteractionMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInteractionMode.UseVisualStyleBackColor = true;
            this.buttonInteractionMode.Click += new System.EventHandler(this.buttonInteractionMode_Click);
            // 
            // buttonSettingsMode
            // 
            this.buttonSettingsMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettingsMode.FlatAppearance.BorderSize = 0;
            this.buttonSettingsMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsMode.Font = new System.Drawing.Font("Open Sans Semibold", 10F);
            this.buttonSettingsMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSettingsMode.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.buttonSettingsMode.IconColor = System.Drawing.Color.White;
            this.buttonSettingsMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSettingsMode.IconSize = 30;
            this.buttonSettingsMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettingsMode.Location = new System.Drawing.Point(0, 191);
            this.buttonSettingsMode.Name = "buttonSettingsMode";
            this.buttonSettingsMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSettingsMode.Size = new System.Drawing.Size(183, 60);
            this.buttonSettingsMode.TabIndex = 10;
            this.buttonSettingsMode.Text = "Настройки";
            this.buttonSettingsMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettingsMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettingsMode.UseVisualStyleBackColor = true;
            this.buttonSettingsMode.Click += new System.EventHandler(this.buttonSettingsMode_Click);
            // 
            // panelMatrixMode
            // 
            this.panelMatrixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.panelMatrixMode.Controls.Add(this.buttonHorizontalGroupMatrixMode);
            this.panelMatrixMode.Controls.Add(this.buttonDischargedMatrixMode);
            this.panelMatrixMode.Controls.Add(this.buttonOrdinaryMatrixMode);
            this.panelMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMatrixMode.Location = new System.Drawing.Point(0, 60);
            this.panelMatrixMode.Name = "panelMatrixMode";
            this.panelMatrixMode.Size = new System.Drawing.Size(183, 131);
            this.panelMatrixMode.TabIndex = 8;
            // 
            // buttonHorizontalGroupMatrixMode
            // 
            this.buttonHorizontalGroupMatrixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonHorizontalGroupMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHorizontalGroupMatrixMode.FlatAppearance.BorderSize = 0;
            this.buttonHorizontalGroupMatrixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorizontalGroupMatrixMode.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonHorizontalGroupMatrixMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHorizontalGroupMatrixMode.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonHorizontalGroupMatrixMode.IconColor = System.Drawing.Color.White;
            this.buttonHorizontalGroupMatrixMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonHorizontalGroupMatrixMode.IconSize = 30;
            this.buttonHorizontalGroupMatrixMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHorizontalGroupMatrixMode.Location = new System.Drawing.Point(0, 80);
            this.buttonHorizontalGroupMatrixMode.Name = "buttonHorizontalGroupMatrixMode";
            this.buttonHorizontalGroupMatrixMode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonHorizontalGroupMatrixMode.Size = new System.Drawing.Size(183, 45);
            this.buttonHorizontalGroupMatrixMode.TabIndex = 6;
            this.buttonHorizontalGroupMatrixMode.Text = "Горизонтальная группа";
            this.buttonHorizontalGroupMatrixMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHorizontalGroupMatrixMode.UseVisualStyleBackColor = false;
            this.buttonHorizontalGroupMatrixMode.Click += new System.EventHandler(this.buttonHorizontalGroupMatrixMode_Click);
            // 
            // buttonDischargedMatrixMode
            // 
            this.buttonDischargedMatrixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonDischargedMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDischargedMatrixMode.FlatAppearance.BorderSize = 0;
            this.buttonDischargedMatrixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDischargedMatrixMode.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonDischargedMatrixMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDischargedMatrixMode.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonDischargedMatrixMode.IconColor = System.Drawing.Color.White;
            this.buttonDischargedMatrixMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDischargedMatrixMode.IconSize = 30;
            this.buttonDischargedMatrixMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDischargedMatrixMode.Location = new System.Drawing.Point(0, 40);
            this.buttonDischargedMatrixMode.Name = "buttonDischargedMatrixMode";
            this.buttonDischargedMatrixMode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDischargedMatrixMode.Size = new System.Drawing.Size(183, 40);
            this.buttonDischargedMatrixMode.TabIndex = 5;
            this.buttonDischargedMatrixMode.Text = "Разреженная";
            this.buttonDischargedMatrixMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDischargedMatrixMode.UseVisualStyleBackColor = false;
            this.buttonDischargedMatrixMode.Click += new System.EventHandler(this.buttonDischargedMatrixMode_Click);
            // 
            // buttonOrdinaryMatrixMode
            // 
            this.buttonOrdinaryMatrixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonOrdinaryMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrdinaryMatrixMode.FlatAppearance.BorderSize = 0;
            this.buttonOrdinaryMatrixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdinaryMatrixMode.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonOrdinaryMatrixMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrdinaryMatrixMode.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonOrdinaryMatrixMode.IconColor = System.Drawing.Color.White;
            this.buttonOrdinaryMatrixMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonOrdinaryMatrixMode.IconSize = 30;
            this.buttonOrdinaryMatrixMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOrdinaryMatrixMode.Location = new System.Drawing.Point(0, 0);
            this.buttonOrdinaryMatrixMode.Name = "buttonOrdinaryMatrixMode";
            this.buttonOrdinaryMatrixMode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonOrdinaryMatrixMode.Size = new System.Drawing.Size(183, 40);
            this.buttonOrdinaryMatrixMode.TabIndex = 4;
            this.buttonOrdinaryMatrixMode.Text = "Обычная";
            this.buttonOrdinaryMatrixMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrdinaryMatrixMode.UseVisualStyleBackColor = false;
            this.buttonOrdinaryMatrixMode.Click += new System.EventHandler(this.buttonOrdinaryMatrixMode_Click);
            // 
            // buttonMatrixMode
            // 
            this.buttonMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMatrixMode.FlatAppearance.BorderSize = 0;
            this.buttonMatrixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatrixMode.Font = new System.Drawing.Font("Open Sans Semibold", 10F);
            this.buttonMatrixMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMatrixMode.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.buttonMatrixMode.IconColor = System.Drawing.Color.White;
            this.buttonMatrixMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMatrixMode.IconSize = 30;
            this.buttonMatrixMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMatrixMode.Location = new System.Drawing.Point(0, 0);
            this.buttonMatrixMode.Name = "buttonMatrixMode";
            this.buttonMatrixMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonMatrixMode.Size = new System.Drawing.Size(183, 60);
            this.buttonMatrixMode.TabIndex = 9;
            this.buttonMatrixMode.Text = "Выбрать матрицу";
            this.buttonMatrixMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMatrixMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMatrixMode.UseVisualStyleBackColor = true;
            this.buttonMatrixMode.Click += new System.EventHandler(this.buttonMatrixMode_Click);
            // 
            // panelStyleMode
            // 
            this.panelStyleMode.Controls.Add(this.iconPictureBoxSun);
            this.panelStyleMode.Controls.Add(this.iconPictureBoxMoon);
            this.panelStyleMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStyleMode.Location = new System.Drawing.Point(0, 472);
            this.panelStyleMode.Name = "panelStyleMode";
            this.panelStyleMode.Size = new System.Drawing.Size(200, 43);
            this.panelStyleMode.TabIndex = 9;
            // 
            // iconPictureBoxSun
            // 
            this.iconPictureBoxSun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.iconPictureBoxSun.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconPictureBoxSun.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSun.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBoxSun.IconSize = 25;
            this.iconPictureBoxSun.Location = new System.Drawing.Point(34, 8);
            this.iconPictureBoxSun.Name = "iconPictureBoxSun";
            this.iconPictureBoxSun.Size = new System.Drawing.Size(30, 25);
            this.iconPictureBoxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxSun.TabIndex = 1;
            this.iconPictureBoxSun.TabStop = false;
            this.iconPictureBoxSun.Click += new System.EventHandler(this.iconPictureBoxSun_Click);
            // 
            // iconPictureBoxMoon
            // 
            this.iconPictureBoxMoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.iconPictureBoxMoon.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.iconPictureBoxMoon.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxMoon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBoxMoon.IconSize = 23;
            this.iconPictureBoxMoon.Location = new System.Drawing.Point(6, 8);
            this.iconPictureBoxMoon.Name = "iconPictureBoxMoon";
            this.iconPictureBoxMoon.Size = new System.Drawing.Size(30, 23);
            this.iconPictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxMoon.TabIndex = 0;
            this.iconPictureBoxMoon.TabStop = false;
            this.iconPictureBoxMoon.Click += new System.EventHandler(this.iconPictureBoxMoon_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 78);
            this.panelLogo.TabIndex = 8;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::LabWork1.Properties.Resources.IconDarkStyleMatrixDrawer;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(136, 76);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ClientForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.panelDrawingMode);
            this.Controls.Add(this.panelLeftMenu);
            this.Name = "ClientForm";
            this.panelDrawingMode.ResumeLayout(false);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelInteractionMode.ResumeLayout(false);
            this.panelMatrixMode.ResumeLayout(false);
            this.panelStyleMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMoon)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

    }
    private void customizeDesign()
    {
        this.panelMatrixMode.Visible = false;
        this.panelInteractionMode.Visible = false;
        this.panelDrawing.Visible = false;
        customizeStyleTheme(0);
        //...

    }
    private void customizeStyleTheme(int variant)
    {
        Color colorFormBack = new Color();
        Color colorPanelSideMenu = new Color();
        Color colorPanelSubMenu = new Color();
        Color colorPanelDrawing = new Color();
        Color colorFont = new Color();
        switch (variant)
        {
            case 0:
                colorFormBack = ColorFormStyle.GetColorStyle("colorLightFormBack");
                colorPanelSideMenu = ColorFormStyle.GetColorStyle("colorLightPanelSideMenu");
                colorPanelSubMenu = ColorFormStyle.GetColorStyle("colorLightPanelSubMenu");
                colorPanelDrawing = ColorFormStyle.GetColorStyle("colorLightPanelDrawing");
                colorFont = ColorFormStyle.GetColorStyle("colorLightFont");
                this.iconPictureBoxSun.IconFont = FontAwesome.Sharp.IconFont.Solid;
                this.iconPictureBoxMoon.IconFont = FontAwesome.Sharp.IconFont.Regular;
                this.pictureBoxLogo.Image = LabWork1.Properties.Resources.IconLightStyleMatrixDrawer;
                break;
            case 1:
                colorFormBack = ColorFormStyle.GetColorStyle("colorDarkFormBack");
                colorPanelSideMenu = ColorFormStyle.GetColorStyle("colorDarkPanelSideMenu");
                colorPanelSubMenu = ColorFormStyle.GetColorStyle("colorDarkPanelSubMenu");
                colorPanelDrawing = ColorFormStyle.GetColorStyle("colorDarkPanelDrawing");
                colorFont = ColorFormStyle.GetColorStyle("colorDarkFont");
                this.iconPictureBoxMoon.IconFont = FontAwesome.Sharp.IconFont.Solid;
                this.iconPictureBoxSun.IconFont = FontAwesome.Sharp.IconFont.Regular;
                this.pictureBoxLogo.Image = LabWork1.Properties.Resources.IconDarkStyleMatrixDrawer;
                break;

        }
        //Back
        this.BackColor = colorFormBack;
        //SideMenu
        this.panelSideMenu.BackColor = colorPanelSideMenu;
        this.panelStyleMode.BackColor = colorPanelSideMenu;
        this.iconPictureBoxMoon.BackColor = colorPanelSideMenu;
        this.iconPictureBoxSun.BackColor = colorPanelSideMenu;
        this.panelLogo.BackColor = colorPanelSideMenu;
        //SubMenu
        this.panelMatrixMode.BackColor = colorPanelSubMenu;
        this.buttonOrdinaryMatrixMode.BackColor = colorPanelSubMenu;
        this.buttonDischargedMatrixMode.BackColor = colorPanelSubMenu;
        this.buttonHorizontalGroupMatrixMode.BackColor = colorPanelSubMenu;
        this.panelInteractionMode.BackColor = colorPanelSubMenu;
        this.buttonDrawMatrix.BackColor = colorPanelSubMenu;
        this.buttonReinitMatrix.BackColor = colorPanelSubMenu;
        this.buttonRenumMatrix.BackColor = colorPanelSubMenu;
        this.buttonRecoverMatrix.BackColor = colorPanelSubMenu;
        //Drawing
        this.panelDrawing.BackColor = colorPanelDrawing;
        //Font
        this.buttonMatrixMode.ForeColor = colorFont;
        this.buttonOrdinaryMatrixMode.ForeColor = colorFont;
        this.buttonDischargedMatrixMode.ForeColor = colorFont;
        this.buttonHorizontalGroupMatrixMode.ForeColor = colorFont;
        this.buttonSettingsMode.ForeColor = colorFont;
        this.buttonInteractionMode.ForeColor = colorFont;
        this.buttonDrawMatrix.ForeColor = colorFont;
        this.buttonReinitMatrix.ForeColor = colorFont;
        this.buttonRenumMatrix.ForeColor = colorFont;
        this.buttonRecoverMatrix.ForeColor = colorFont;
        //Icon
        this.buttonMatrixMode.IconColor = colorFont;
        this.buttonOrdinaryMatrixMode.IconColor = colorFont;
        this.buttonDischargedMatrixMode.IconColor = colorFont;
        this.buttonHorizontalGroupMatrixMode.IconColor = colorFont;
        this.buttonSettingsMode.IconColor = colorFont;
        this.buttonInteractionMode.IconColor = colorFont;
        this.buttonDrawMatrix.IconColor = colorFont;
        this.buttonReinitMatrix.IconColor = colorFont;
        this.buttonRenumMatrix.IconColor = colorFont;
        this.buttonRecoverMatrix.IconColor = colorFont;
        //Specific Icon
        this.iconPictureBoxMoon.IconColor = colorFont;
        this.iconPictureBoxSun.IconColor = colorFont;

    }
    private void HideSubMenu()
    {
        if (panelMatrixMode.Visible)
        {
            panelMatrixMode.Visible = false;

        }
        if (panelInteractionMode.Visible)
        {
            panelInteractionMode.Visible = false;

        }
        //...

    }
    private void ClickSubMenu (Panel subMenu)
    {
        if (!subMenu.Visible)
        {
            subMenu.Visible = true;

        }
        else
        {
            subMenu.Visible = false;

        }

    }
    private void DrawMatrix(IMatrix matrix, IMatrixVisitor visitor)
    {
        panelDrawing.Visible = true;
        Console.Clear();
        panelDrawing.Refresh();
        if (matrix.GetComposite() != null)
        {
            IIterable iterable = matrix.GetComposite();
            IIteratorMatrix iterator = iterable.CreateIterator();
            IMatrix someMatrix;
            while (!iterator.IsDone())
            {
                someMatrix = iterator.GetCurrent();
                someMatrix.Accept(visitor);
                iterator.MoveNext();

            }

        }
        else
        {
            matrix.Accept(visitor);

        }

    }
    private void InitMatrix(int variant)
    {
        switch (variant)
        {
            case 0:
                _matrix = new OrdinaryMatrix(10, 5);
                MatrixInitiator.FillMatrix(_matrix, _rnd.Next(1, 51), _rnd.Next(1, 999));
                _visitor = new DrawLeafMatrixVisitor(Drawer);
                break;
            case 1:
                _matrix = new DischargedMatrix(5, 10);
                MatrixInitiator.FillMatrix(_matrix, _rnd.Next(1, 51), _rnd.Next(1, 999));
                _visitor = new DrawLeafMatrixVisitor(Drawer);
                break;
            case 2:
                HorizontalGroupMatrix compositeMatrix = new HorizontalGroupMatrix();
                IMatrix matrix1 = new OrdinaryMatrix(2, 2);
                IMatrix matrix2 = new OrdinaryMatrix(1, 5);
                IMatrix matrix3 = new DischargedMatrix(3, 3);
                IMatrix matrix4 = new DischargedMatrix(1, 1);
                MatrixInitiator.FillMatrix(matrix1, _rnd.Next(1, 3), _rnd.Next(1, 999));
                MatrixInitiator.FillMatrix(matrix2, _rnd.Next(1, 3), _rnd.Next(1, 999));
                MatrixInitiator.FillMatrix(matrix3, _rnd.Next(1, 5), _rnd.Next(1, 999));
                MatrixInitiator.FillMatrix(matrix4, 1, _rnd.Next(1, 999));
                compositeMatrix.AddMatrix(matrix1);
                compositeMatrix.AddMatrix(matrix2);
                compositeMatrix.AddMatrix(matrix3);
                compositeMatrix.AddMatrix(matrix4);
                _matrix = compositeMatrix;
                _visitor = new DrawHorizontalGroupMatrixVisitor(Drawer);
                return;

        }

    }
    private void FirstInitMatrix(int variant)
    {
        _matrixTypeIndex = variant;
        InitMatrix(_matrixTypeIndex);
        //CallSettingsForm();
        HideSubMenu();

    }
    private void CallSettingsForm()
    {
        if (_settingsForm == null || _settingsForm.IsDisposed)
        {
            _settingsForm = new ClientSettingsForm(this);
            _settingsForm.Show();

        }
        else
        {
            _settingsForm.Focus();

        }

    }
    private void DrawHoriaontalGroupMatirxVisitor()
    {
        _visitor = new DrawHorizontalGroupMatrixVisitor(Drawer);

    }
    private void DrawVerticalGroupMatirxVisitor()
    {
        _visitor = new DrawVerticalGroupMatrixVisitor(Drawer);

    }
    private void buttonMatrixMode_Click(object sender, EventArgs e)
    {
        ClickSubMenu(panelMatrixMode);

    }
    private void buttonOrdinaryMatrixMode_Click(object sender, EventArgs e)
    {
        FirstInitMatrix(0);

    }
    private void buttonDischargedMatrixMode_Click(object sender, EventArgs e)
    {
        FirstInitMatrix(1);

    }
    private void buttonHorizontalGroupMatrixMode_Click(object sender, EventArgs e)
    {
        FirstInitMatrix(2);

    }
    private void buttonSettingsMode_Click(object sender, EventArgs e)
    {
        CallSettingsForm();

    }
    private void buttonInteractionMode_Click(object sender, EventArgs e)
    {
        ClickSubMenu(panelInteractionMode);

    }
    private void buttonDrawMatrix_Click(object sender, EventArgs e)
    {
        if (_matrix != null)
        {
            DrawMatrix(_matrix, _visitor);

        }

    }
    private void iconPictureBoxMoon_Click(object sender, EventArgs e)
    {
        customizeStyleTheme(1);

    }
    private void iconPictureBoxSun_Click(object sender, EventArgs e)
    {
        customizeStyleTheme(0);

    }
    private void buttonReinitMatrix_Click(object sender, EventArgs e)
    {
        InitMatrix(_matrixTypeIndex);
        DrawMatrix(_matrix, _visitor);

    }
    private void buttonTransposeMatrix_Click(object sender, EventArgs e)
    {
        if (_matrix.GetComposite() != null)
        {
            if (!_isTranspose)
            {
                DrawVerticalGroupMatirxVisitor();
                _isTranspose = true;

            }
            else
            {
                DrawHoriaontalGroupMatirxVisitor();
                _isTranspose = false;

            }

        }
        _matrix = new MatrixTransposeDecorator(_matrix);
        DrawMatrix(_matrix, _visitor);

    }
    private void buttonRecoverMatrix_Click(object sender, EventArgs e)
    {
        if (_matrix.GetComposite() != null)
        {
            _visitor = new DrawHorizontalGroupMatrixVisitor(Drawer);

        }
        _matrix = _matrix.GetComponent();
        DrawMatrix(_matrix, _visitor);

    }

}
