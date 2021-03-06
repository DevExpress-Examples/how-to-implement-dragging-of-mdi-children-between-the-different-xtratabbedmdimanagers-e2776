Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Samples.DocumentSelector
	Partial Public Class ChildForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ChildForm))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.textBox4 = New System.Windows.Forms.TextBox()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(413, 44)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(467, 335)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.textBox4)
			Me.layoutControl1.Controls.Add(Me.textBox3)
			Me.layoutControl1.Controls.Add(Me.pictureBox1)
			Me.layoutControl1.Controls.Add(Me.textBox2)
			Me.layoutControl1.Controls.Add(Me.textBox1)
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(904, 497)
			Me.layoutControl1.TabIndex = 1
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' textBox4
			' 
			Me.textBox4.Location = New System.Drawing.Point(70, 429)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.Size = New System.Drawing.Size(810, 20)
			Me.textBox4.TabIndex = 8
			Me.textBox4.Text = "12° 20.736′ N, 98° 45.924′ W"
			' 
			' textBox3
			' 
			Me.textBox3.Location = New System.Drawing.Point(24, 429)
			Me.textBox3.Multiline = True
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(856, 44)
			Me.textBox3.TabIndex = 7
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Location = New System.Drawing.Point(24, 44)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(385, 335)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 6
			Me.pictureBox1.TabStop = False
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(70, 429)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(810, 20)
			Me.textBox2.TabIndex = 5
			Me.textBox2.Text = "John Smith"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(70, 453)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(810, 20)
			Me.textBox1.TabIndex = 4
			Me.textBox1.Text = "johnsmith@gmail.com"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.tabbedControlGroup1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(904, 497)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "Grid"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem4})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(884, 383)
			Me.layoutControlGroup2.Text = "Preview"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.gridControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(389, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(471, 339)
			Me.layoutControlItem1.Text = "Employees"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.pictureBox1
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(389, 339)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' tabbedControlGroup1
			' 
			Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
			Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 383)
			Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
			Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup3
			Me.tabbedControlGroup1.SelectedTabPageIndex = 0
			Me.tabbedControlGroup1.Size = New System.Drawing.Size(884, 94)
			Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup3, Me.layoutControlGroup5, Me.layoutControlGroup4})
			Me.tabbedControlGroup1.Text = "tabbedControlGroup1"
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
			Me.layoutControlGroup3.Size = New System.Drawing.Size(866, 48)
			Me.layoutControlGroup3.Text = "Author"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.textBox2
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(860, 24)
			Me.layoutControlItem2.Text = "Contact:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(42, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.textBox1
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(860, 24)
			Me.layoutControlItem3.Text = "Mail:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(42, 13)
			' 
			' layoutControlGroup5
			' 
			Me.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5"
			Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem6})
			Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup5.Name = "layoutControlGroup5"
			Me.layoutControlGroup5.Size = New System.Drawing.Size(866, 48)
			Me.layoutControlGroup5.Text = "Photo Data (EXIF)"
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.textBox4
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(860, 48)
			Me.layoutControlItem6.Text = "GEO Tag"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(42, 13)
			' 
			' layoutControlGroup4
			' 
			Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
			Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5})
			Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup4.Name = "layoutControlGroup4"
			Me.layoutControlGroup4.Size = New System.Drawing.Size(866, 48)
			Me.layoutControlGroup4.Text = "Notes"
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.textBox3
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(860, 48)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' ChildForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(904, 497)
			Me.Controls.Add(Me.layoutControl1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "ChildForm"
			Me.Text = "Form2"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private textBox2 As System.Windows.Forms.TextBox
		Private textBox1 As System.Windows.Forms.TextBox
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private textBox4 As System.Windows.Forms.TextBox
		Private textBox3 As System.Windows.Forms.TextBox
		Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace