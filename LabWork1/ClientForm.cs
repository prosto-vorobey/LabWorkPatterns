using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class ClientForm : Form
{
    private Button ButtonGenOrdMatrix;
    private Button ButtonGenDisMatrix;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private IMatrix _matrix;
    private IDrawerMatrix _drawer;
    private IDrawerDisplay _display;
    private IPrimitives _primetives;
    public Panel _panel1;
    private System.ComponentModel.BackgroundWorker backgroundWorker2;
    private Button button1;
    private ComboBox borderOptions;
    private ContextMenuStrip contextMenuStrip1;
    private System.ComponentModel.IContainer components;
    private Random _rnd = new Random();
    private ComboBox displayOptions;
    private bool _isTranspose = false;
    public ClientForm()
    {
        InitializeComponent();
        borderOptions.SelectedIndex = 0;
        displayOptions.SelectedIndex = 0;
        DoubleBuffered = true;

    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.ButtonGenOrdMatrix = new System.Windows.Forms.Button();
            this.ButtonGenDisMatrix = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.borderOptions = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonGenOrdMatrix
            // 
            this.ButtonGenOrdMatrix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonGenOrdMatrix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGenOrdMatrix.Location = new System.Drawing.Point(44, 33);
            this.ButtonGenOrdMatrix.Name = "ButtonGenOrdMatrix";
            this.ButtonGenOrdMatrix.Size = new System.Drawing.Size(177, 95);
            this.ButtonGenOrdMatrix.TabIndex = 0;
            this.ButtonGenOrdMatrix.Text = "Генерация обычной матрицы";
            this.ButtonGenOrdMatrix.UseVisualStyleBackColor = false;
            this.ButtonGenOrdMatrix.Click += new System.EventHandler(this.ButtonGenOrdMatrix_Click);
            // 
            // ButtonGenDisMatrix
            // 
            this.ButtonGenDisMatrix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonGenDisMatrix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGenDisMatrix.Location = new System.Drawing.Point(44, 156);
            this.ButtonGenDisMatrix.Name = "ButtonGenDisMatrix";
            this.ButtonGenDisMatrix.Size = new System.Drawing.Size(177, 95);
            this.ButtonGenDisMatrix.TabIndex = 1;
            this.ButtonGenDisMatrix.Text = "Генерация разреженной матрицы";
            this.ButtonGenDisMatrix.UseVisualStyleBackColor = false;
            this.ButtonGenDisMatrix.Click += new System.EventHandler(this.ButtonGenDisMatrix_Click);
            // 
            // _panel1
            // 
            this._panel1.AutoScroll = true;
            this._panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._panel1.Location = new System.Drawing.Point(250, 33);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(700, 450);
            this._panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(44, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Генерация симметричной матрицы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonGenSymMatrix_Click);
            // 
            // borderOptions
            // 
            this.borderOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderOptions.Font = new System.Drawing.Font("Arial", 12F);
            this.borderOptions.FormattingEnabled = true;
            this.borderOptions.Items.AddRange(new object[] {
            "Нет границы",
            "Обычная граница",
            "Двойная граница"});
            this.borderOptions.Location = new System.Drawing.Point(44, 457);
            this.borderOptions.Name = "borderOptions";
            this.borderOptions.Size = new System.Drawing.Size(177, 26);
            this.borderOptions.TabIndex = 5;
            this.borderOptions.SelectedIndexChanged += new System.EventHandler(this.borderOptions_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // displayOptions
            // 
            this.displayOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayOptions.Font = new System.Drawing.Font("Arial", 12F);
            this.displayOptions.FormattingEnabled = true;
            this.displayOptions.Items.AddRange(new object[] {
            "Консоль",
            "Графика"});
            this.displayOptions.Location = new System.Drawing.Point(44, 401);
            this.displayOptions.Name = "displayOptions";
            this.displayOptions.Size = new System.Drawing.Size(177, 26);
            this.displayOptions.TabIndex = 6;
            this.displayOptions.SelectedIndexChanged += new System.EventHandler(this.displayOptions_SelectedIndexChanged);
            // 
            // ClientForm
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.displayOptions);
            this.Controls.Add(this.borderOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this.ButtonGenDisMatrix);
            this.Controls.Add(this.ButtonGenOrdMatrix);
            this.Name = "ClientForm";
            this.ResumeLayout(false);

    }
    private void DrawMatrix()
    {
        _panel1.Controls.Clear();
        Refresh();
        Console.Clear();
        switch (borderOptions.SelectedIndex)
        {
            case 0:
                _primitives = new 
                break;
            case 1:
                _primitives = new 
                break;
            //case 2:
            //    _driver = new DrawerMatrixWithBorder();
            //    break;

        }
        switch (displayOptions.SelectedIndex)
        {
            case 0:
                _display = new ConsoleDisplay(_primetives);
                break;
            case 1:
                _display = new GraphicsDisplay(_primetives);
                break;

        }
        _drawer = new DrawerMatrix(_display);
        _matrix.Draw(_drawer);

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
        }
        MatrixInitiator.FillMatrix(_matrix, _rnd.Next(1, 51), _rnd.Next(1, 999));

    }
    private void ButtonGenOrdMatrix_Click(object sender, EventArgs e)
    {
        InitMatrix(0);
        DrawMatrix();

    }
    private void ButtonGenDisMatrix_Click(object sender, EventArgs e)
    {
        InitMatrix(1);
        DrawMatrix();

    }
    private void ButtonGenSymMatrix_Click(object sender, EventArgs e)
    {
        //_display = RandomScheme();
        /*_matrix = new SymmetryMatrix(5, _scheme);
        int[,] symMat = new int[5, 5] { { 0, 10, 2, 0, 5 }, { 10, 4, 1, 0, 0 }, { 2, 1, 3, 2, 2 }, { 0, 0, 2, 4, 3 }, { 5, 0, 2, 3, 0 } };
        _matrix.WriteMatrix(symMat);*/
        //DrawMatrix();

    }
    private void borderOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_matrix != null)
        {
            DrawMatrix();

        }

    }

    private void displayOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_matrix != null)
        {
            DrawMatrix();

        }

    }
}
