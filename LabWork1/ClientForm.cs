﻿using System;
using System.Windows.Forms;
using System.Drawing;
using LabWork1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

public partial class ClientForm : Form
{
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private IMatrix _matrix;
    public IDrawerMatrix Drawer { get; set; }
    public IDrawerDisplay Display { get; set; }
    public IGraphicsPrimitives GraphicsPrimitives { get; set; }
    public IConsolePrimitives ConsolePrimitives { get; set; }
    private System.ComponentModel.BackgroundWorker backgroundWorker2;
    private System.ComponentModel.IContainer components;
    private Random _rnd = new Random();
    private Panel panelSideMenu;
    private Panel panelStyleMode;
    private FontAwesome.Sharp.IconPictureBox iconPictureBoxSun;
    private FontAwesome.Sharp.IconPictureBox iconPictureBoxMoon;
    private bool _isTranspose = false;
    private Panel panelDrawingMode;
    private Panel panelInteractionMode;
    private FontAwesome.Sharp.IconButton buttonDrawMatrix;
    private FontAwesome.Sharp.IconButton buttonInteractionMode;
    private FontAwesome.Sharp.IconButton buttonSettingsMode;
    private Panel panelMatrixMode;
    private FontAwesome.Sharp.IconButton buttonSymmetryMatrixMode;
    private FontAwesome.Sharp.IconButton buttonDischargedMatrixMode;
    private FontAwesome.Sharp.IconButton buttonOrdinaryMatrixMode;
    private FontAwesome.Sharp.IconButton buttonMatrixMode;
    private Panel panelLogo;
    private Panel panelDrawing;
    private PictureBox pictureBoxLogo;
    private ClientSettingsForm _settingsForm;
    public ClientForm()
    {
        InitializeComponent();
        customizeDesign();
        this.DoubleBuffered = true;

    }
    public Panel GetPanelDrawing()
    {
        return panelDrawing;

    }
    private void InitializeComponent()
    {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelInteractionMode = new System.Windows.Forms.Panel();
            this.buttonDrawMatrix = new FontAwesome.Sharp.IconButton();
            this.buttonInteractionMode = new FontAwesome.Sharp.IconButton();
            this.buttonSettingsMode = new FontAwesome.Sharp.IconButton();
            this.panelMatrixMode = new System.Windows.Forms.Panel();
            this.buttonSymmetryMatrixMode = new FontAwesome.Sharp.IconButton();
            this.buttonDischargedMatrixMode = new FontAwesome.Sharp.IconButton();
            this.buttonOrdinaryMatrixMode = new FontAwesome.Sharp.IconButton();
            this.buttonMatrixMode = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelStyleMode = new System.Windows.Forms.Panel();
            this.iconPictureBoxSun = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxMoon = new FontAwesome.Sharp.IconPictureBox();
            this.panelDrawingMode = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelInteractionMode.SuspendLayout();
            this.panelMatrixMode.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelStyleMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMoon)).BeginInit();
            this.panelDrawingMode.SuspendLayout();
            this.SuspendLayout();
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
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.panelStyleMode);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 515);
            this.panelSideMenu.TabIndex = 7;
            // 
            // panelInteractionMode
            // 
            this.panelInteractionMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.panelInteractionMode.Controls.Add(this.buttonDrawMatrix);
            this.panelInteractionMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInteractionMode.Location = new System.Drawing.Point(0, 383);
            this.panelInteractionMode.Name = "panelInteractionMode";
            this.panelInteractionMode.Size = new System.Drawing.Size(200, 45);
            this.panelInteractionMode.TabIndex = 12;
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
            this.buttonDrawMatrix.Size = new System.Drawing.Size(200, 40);
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
            this.buttonInteractionMode.Location = new System.Drawing.Point(0, 323);
            this.buttonInteractionMode.Name = "buttonInteractionMode";
            this.buttonInteractionMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonInteractionMode.Size = new System.Drawing.Size(200, 60);
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
            this.buttonSettingsMode.Location = new System.Drawing.Point(0, 263);
            this.buttonSettingsMode.Name = "buttonSettingsMode";
            this.buttonSettingsMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSettingsMode.Size = new System.Drawing.Size(200, 60);
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
            this.panelMatrixMode.Controls.Add(this.buttonSymmetryMatrixMode);
            this.panelMatrixMode.Controls.Add(this.buttonDischargedMatrixMode);
            this.panelMatrixMode.Controls.Add(this.buttonOrdinaryMatrixMode);
            this.panelMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMatrixMode.Location = new System.Drawing.Point(0, 138);
            this.panelMatrixMode.Name = "panelMatrixMode";
            this.panelMatrixMode.Size = new System.Drawing.Size(200, 125);
            this.panelMatrixMode.TabIndex = 8;
            // 
            // buttonSymmetryMatrixMode
            // 
            this.buttonSymmetryMatrixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.buttonSymmetryMatrixMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSymmetryMatrixMode.FlatAppearance.BorderSize = 0;
            this.buttonSymmetryMatrixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSymmetryMatrixMode.Font = new System.Drawing.Font("Open Sans Semibold", 9F);
            this.buttonSymmetryMatrixMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSymmetryMatrixMode.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSymmetryMatrixMode.IconColor = System.Drawing.Color.White;
            this.buttonSymmetryMatrixMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSymmetryMatrixMode.IconSize = 30;
            this.buttonSymmetryMatrixMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSymmetryMatrixMode.Location = new System.Drawing.Point(0, 80);
            this.buttonSymmetryMatrixMode.Name = "buttonSymmetryMatrixMode";
            this.buttonSymmetryMatrixMode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSymmetryMatrixMode.Size = new System.Drawing.Size(200, 40);
            this.buttonSymmetryMatrixMode.TabIndex = 6;
            this.buttonSymmetryMatrixMode.Text = "Симметричная";
            this.buttonSymmetryMatrixMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSymmetryMatrixMode.UseVisualStyleBackColor = false;
            this.buttonSymmetryMatrixMode.Click += new System.EventHandler(this.buttonSymmetryMatrixMode_Click);
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
            this.buttonDischargedMatrixMode.Size = new System.Drawing.Size(200, 40);
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
            this.buttonOrdinaryMatrixMode.Size = new System.Drawing.Size(200, 40);
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
            this.buttonMatrixMode.Location = new System.Drawing.Point(0, 78);
            this.buttonMatrixMode.Name = "buttonMatrixMode";
            this.buttonMatrixMode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonMatrixMode.Size = new System.Drawing.Size(200, 60);
            this.buttonMatrixMode.TabIndex = 9;
            this.buttonMatrixMode.Text = "Выбрать матрицу";
            this.buttonMatrixMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMatrixMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMatrixMode.UseVisualStyleBackColor = true;
            this.buttonMatrixMode.Click += new System.EventHandler(this.buttonMatrixMode_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 78);
            this.panelLogo.TabIndex = 7;
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
            // panelStyleMode
            // 
            this.panelStyleMode.Controls.Add(this.iconPictureBoxSun);
            this.panelStyleMode.Controls.Add(this.iconPictureBoxMoon);
            this.panelStyleMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStyleMode.Location = new System.Drawing.Point(0, 472);
            this.panelStyleMode.Name = "panelStyleMode";
            this.panelStyleMode.Size = new System.Drawing.Size(200, 43);
            this.panelStyleMode.TabIndex = 0;
            // 
            // iconPictureBoxSun
            // 
            this.iconPictureBoxSun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
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
            this.iconPictureBoxMoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
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
            // ClientForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.panelDrawingMode);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "ClientForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelInteractionMode.ResumeLayout(false);
            this.panelMatrixMode.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelStyleMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMoon)).EndInit();
            this.panelDrawingMode.ResumeLayout(false);
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
        //SubMenu
        this.panelMatrixMode.BackColor = colorPanelSubMenu;
        this.buttonOrdinaryMatrixMode.BackColor = colorPanelSubMenu;
        this.buttonDischargedMatrixMode.BackColor = colorPanelSubMenu;
        this.buttonSymmetryMatrixMode.BackColor = colorPanelSubMenu;
        this.panelInteractionMode.BackColor = colorPanelSubMenu;
        this.buttonDrawMatrix.BackColor = colorPanelSubMenu;
        //Drawing
        this.panelDrawing.BackColor = colorPanelDrawing;
        //Font
        this.buttonMatrixMode.ForeColor = colorFont;
        this.buttonOrdinaryMatrixMode.ForeColor = colorFont;
        this.buttonDischargedMatrixMode.ForeColor = colorFont;
        this.buttonSymmetryMatrixMode.ForeColor = colorFont;
        this.buttonSettingsMode.ForeColor = colorFont;
        this.buttonInteractionMode.ForeColor = colorFont;
        this.buttonDrawMatrix.ForeColor = colorFont;
        //Icon
        this.buttonMatrixMode.IconColor = colorFont;
        this.buttonOrdinaryMatrixMode.IconColor = colorFont;
        this.buttonDischargedMatrixMode.IconColor = colorFont;
        this.buttonSymmetryMatrixMode.IconColor = colorFont;
        this.buttonSettingsMode.IconColor = colorFont;
        this.buttonInteractionMode.IconColor = colorFont;
        this.buttonDrawMatrix.IconColor = colorFont;
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
    private void DrawMatrix(IMatrix matrix)
    {
        this.panelDrawing.Visible = true;
        Console.Clear();
        panelDrawing.Refresh();
        if (Drawer != null && Display != null && (GraphicsPrimitives != null || ConsolePrimitives != null))
        {
            matrix.Draw(Drawer);

        }

    }
    private void InitMatrix(int variant)
    {
        switch (variant)
        {
            case 0:
                _matrix = new OrdinaryMatrix(10, 5);
                break;
            case 1:
                _matrix = new DischargedMatrix(5, 10);
                break;
            case 2:
                //_matrix = new SymmetryMatrix(10, 10);
                return;

        }
        MatrixInitiator.FillMatrix(_matrix, _rnd.Next(1, 51), _rnd.Next(1, 999));

    }
    private void buttonMatrixMode_Click(object sender, EventArgs e)
    {
        ClickSubMenu(panelMatrixMode);

    }
    private void buttonOrdinaryMatrixMode_Click(object sender, EventArgs e)
    {
        InitMatrix(0);
        HideSubMenu();

    }
    private void buttonDischargedMatrixMode_Click(object sender, EventArgs e)
    {
        InitMatrix(1);
        HideSubMenu();

    }
    private void buttonSymmetryMatrixMode_Click(object sender, EventArgs e)
    {
        InitMatrix(2);
        HideSubMenu();

    }
    private void buttonSettingsMode_Click(object sender, EventArgs e)
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
    private void buttonInteractionMode_Click(object sender, EventArgs e)
    {
        ClickSubMenu(panelInteractionMode);

    }
    private void buttonDrawMatrix_Click(object sender, EventArgs e)
    {
        if (_matrix != null)
        {
            DrawMatrix(_matrix);

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

}
