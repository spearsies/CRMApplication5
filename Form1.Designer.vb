<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim Address1Label As System.Windows.Forms.Label
        Dim Address2Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim MobilePhoneLabel1 As System.Windows.Forms.Label
        Dim FaxNumberLabel1 As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CustIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.BusinessPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MobilePhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.FaxNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LastNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LastNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LastNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsDataSet = New CrmApplication5.ContactsDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableTableAdapter = New CrmApplication5.ContactsDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New CrmApplication5.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LastNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Button8 = New System.Windows.Forms.Button()
        CustIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        Address2Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        MobilePhoneLabel1 = New System.Windows.Forms.Label()
        FaxNumberLabel1 = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LastNameToolStrip.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustIDLabel
        '
        CustIDLabel.AutoSize = True
        CustIDLabel.Location = New System.Drawing.Point(18, 16)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(45, 13)
        CustIDLabel.TabIndex = 1
        CustIDLabel.Text = "Cust ID:"
        '
        'CustIDTextBox
        '
        Me.CustIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "CustID", True))
        Me.CustIDTextBox.Location = New System.Drawing.Point(110, 13)
        Me.CustIDTextBox.Name = "CustIDTextBox"
        Me.CustIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustIDTextBox.TabIndex = 1
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(18, 42)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(110, 39)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(18, 68)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(72, 13)
        MiddleNameLabel.TabIndex = 5
        MiddleNameLabel.Text = "Middle Name:"
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(110, 65)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiddleNameTextBox.TabIndex = 3
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(18, 94)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 7
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(110, 91)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Location = New System.Drawing.Point(20, 45)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(54, 13)
        Address1Label.TabIndex = 17
        Address1Label.Text = "Address1:"
        '
        'Address1TextBox
        '
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Address1", True))
        Me.Address1TextBox.Location = New System.Drawing.Point(112, 42)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Address1TextBox.TabIndex = 9
        '
        'Address2Label
        '
        Address2Label.AutoSize = True
        Address2Label.Location = New System.Drawing.Point(20, 71)
        Address2Label.Name = "Address2Label"
        Address2Label.Size = New System.Drawing.Size(54, 13)
        Address2Label.TabIndex = 19
        Address2Label.Text = "Address2:"
        '
        'Address2TextBox
        '
        Me.Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Address2", True))
        Me.Address2TextBox.Location = New System.Drawing.Point(112, 68)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Address2TextBox.TabIndex = 10
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(20, 97)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 21
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(112, 94)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 11
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(20, 123)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 23
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(112, 120)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 12
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(20, 149)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 25
        ZipLabel.Text = "Zip:"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(112, 146)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipTextBox.TabIndex = 13
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(0, 72)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(443, 265)
        Me.TableDataGridView.TabIndex = 27
        '
        'BusinessPhoneMaskedTextBox
        '
        Me.BusinessPhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "BusinessPhone", True))
        Me.BusinessPhoneMaskedTextBox.Location = New System.Drawing.Point(110, 118)
        Me.BusinessPhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.BusinessPhoneMaskedTextBox.Name = "BusinessPhoneMaskedTextBox"
        Me.BusinessPhoneMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BusinessPhoneMaskedTextBox.TabIndex = 5
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.AutoSize = True
        BusinessPhoneLabel.Location = New System.Drawing.Point(18, 121)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(86, 13)
        BusinessPhoneLabel.TabIndex = 27
        BusinessPhoneLabel.Text = "Business Phone:"
        '
        'MobilePhoneLabel1
        '
        MobilePhoneLabel1.AutoSize = True
        MobilePhoneLabel1.Location = New System.Drawing.Point(19, 146)
        MobilePhoneLabel1.Name = "MobilePhoneLabel1"
        MobilePhoneLabel1.Size = New System.Drawing.Size(75, 13)
        MobilePhoneLabel1.TabIndex = 28
        MobilePhoneLabel1.Text = "Mobile Phone:"
        '
        'MobilePhoneMaskedTextBox
        '
        Me.MobilePhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "MobilePhone", True))
        Me.MobilePhoneMaskedTextBox.Location = New System.Drawing.Point(110, 144)
        Me.MobilePhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.MobilePhoneMaskedTextBox.Name = "MobilePhoneMaskedTextBox"
        Me.MobilePhoneMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobilePhoneMaskedTextBox.TabIndex = 6
        '
        'FaxNumberLabel1
        '
        FaxNumberLabel1.AutoSize = True
        FaxNumberLabel1.Location = New System.Drawing.Point(19, 167)
        FaxNumberLabel1.Name = "FaxNumberLabel1"
        FaxNumberLabel1.Size = New System.Drawing.Size(67, 13)
        FaxNumberLabel1.TabIndex = 29
        FaxNumberLabel1.Text = "Fax Number:"
        '
        'FaxNumberMaskedTextBox
        '
        Me.FaxNumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FaxNumber", True))
        Me.FaxNumberMaskedTextBox.Location = New System.Drawing.Point(110, 170)
        Me.FaxNumberMaskedTextBox.Mask = "(999) 000-0000"
        Me.FaxNumberMaskedTextBox.Name = "FaxNumberMaskedTextBox"
        Me.FaxNumberMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FaxNumberMaskedTextBox.TabIndex = 7
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(20, 18)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel.TabIndex = 30
        Email_AddressLabel.Text = "Email Address:"
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Email Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(111, 11)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_AddressTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 38)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 37)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 35
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(103, 406)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 38)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 406)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 38)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Previous"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LastNameToolStrip
        '
        Me.LastNameToolStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastNameToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.LastNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LastNameToolStripLabel, Me.LastNameToolStripTextBox, Me.LastNameToolStripButton})
        Me.LastNameToolStrip.Location = New System.Drawing.Point(0, 35)
        Me.LastNameToolStrip.Name = "LastNameToolStrip"
        Me.LastNameToolStrip.Size = New System.Drawing.Size(373, 25)
        Me.LastNameToolStrip.TabIndex = 37
        Me.LastNameToolStrip.Text = "LastNameToolStrip"
        '
        'LastNameToolStripLabel
        '
        Me.LastNameToolStripLabel.Name = "LastNameToolStripLabel"
        Me.LastNameToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.LastNameToolStripLabel.Text = "LastName:"
        '
        'LastNameToolStripButton
        '
        Me.LastNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LastNameToolStripButton.Name = "LastNameToolStripButton"
        Me.LastNameToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.LastNameToolStripButton.Text = "Search"
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.ContactsDataSet
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MiddleName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BusinessPhone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "BusinessPhone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MobilePhone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MobilePhone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FaxNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FaxNumber"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Address1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Address1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Address2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Address2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn11.HeaderText = "City"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn12.HeaderText = "State"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Zip"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = CrmApplication5.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(458, 72)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.SplitContainer1.Panel1.Controls.Add(Me.MiddleNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(LastNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(MiddleNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(FirstNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustIDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(CustIDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BusinessPhoneMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(BusinessPhoneLabel)
        Me.SplitContainer1.Panel1.Controls.Add(FaxNumberLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MobilePhoneMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FaxNumberMaskedTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MobilePhoneLabel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.SplitContainer1.Panel2.Controls.Add(Me.CityTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ZipTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(ZipLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StateTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(StateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(CityLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Address2TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Address2Label)
        Me.SplitContainer1.Panel2.Controls.Add(Email_AddressLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Email_AddressTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Address1TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Address1Label)
        Me.SplitContainer1.Size = New System.Drawing.Size(489, 265)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 38
        '
        'LastNameToolStripTextBox
        '
        Me.LastNameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameToolStripTextBox.Name = "LastNameToolStripTextBox"
        Me.LastNameToolStripTextBox.Size = New System.Drawing.Size(250, 25)
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(720, 406)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 38)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(836, 406)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(85, 38)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Exit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(959, 26)
        Me.ToolStrip1.TabIndex = 41
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 23)
        Me.ToolStripLabel1.Text = "SPEARS IT SERVICES"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(193, 406)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 38)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Show All"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(959, 456)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.LastNameToolStrip)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableDataGridView)
        Me.Name = "Form1"
        Me.Text = "Riordan CRM Application Version 1.0"
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LastNameToolStrip.ResumeLayout(False)
        Me.LastNameToolStrip.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactsDataSet As CrmApplication5.ContactsDataSet
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableTableAdapter As CrmApplication5.ContactsDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As CrmApplication5.ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusinessPhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MobilePhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FaxNumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LastNameToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents LastNameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LastNameToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LastNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
