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
        Me.MonthSelect = New System.Windows.Forms.ComboBox()
        Me.YearTxtBox = New System.Windows.Forms.TextBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.GBregIncomming = New System.Windows.Forms.GroupBox()
        Me.DGVregIn = New System.Windows.Forms.DataGridView()
        Me.regInRemBtn = New System.Windows.Forms.Button()
        Me.regInAddBtn = New System.Windows.Forms.Button()
        Me.GBincomming = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GBregSpends = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GBremDist = New System.Windows.Forms.GroupBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.GBregIncomming.SuspendLayout()
        CType(Me.DGVregIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBincomming.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBregSpends.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBremDist.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthSelect
        '
        Me.MonthSelect.FormattingEnabled = True
        Me.MonthSelect.Location = New System.Drawing.Point(15, 15)
        Me.MonthSelect.Name = "MonthSelect"
        Me.MonthSelect.Size = New System.Drawing.Size(125, 21)
        Me.MonthSelect.TabIndex = 0
        '
        'YearTxtBox
        '
        Me.YearTxtBox.Location = New System.Drawing.Point(155, 15)
        Me.YearTxtBox.Name = "YearTxtBox"
        Me.YearTxtBox.Size = New System.Drawing.Size(125, 20)
        Me.YearTxtBox.TabIndex = 1
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(295, 15)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(75, 25)
        Me.GoBtn.TabIndex = 2
        Me.GoBtn.Text = "Go"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'GBregIncomming
        '
        Me.GBregIncomming.Controls.Add(Me.DGVregIn)
        Me.GBregIncomming.Controls.Add(Me.regInRemBtn)
        Me.GBregIncomming.Controls.Add(Me.regInAddBtn)
        Me.GBregIncomming.Location = New System.Drawing.Point(15, 55)
        Me.GBregIncomming.Name = "GBregIncomming"
        Me.GBregIncomming.Size = New System.Drawing.Size(370, 200)
        Me.GBregIncomming.TabIndex = 3
        Me.GBregIncomming.TabStop = False
        Me.GBregIncomming.Text = "Regular Incomming"
        '
        'DGVregIn
        '
        Me.DGVregIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVregIn.Location = New System.Drawing.Point(15, 15)
        Me.DGVregIn.Name = "DGVregIn"
        Me.DGVregIn.Size = New System.Drawing.Size(340, 130)
        Me.DGVregIn.TabIndex = 3
        '
        'regInRemBtn
        '
        Me.regInRemBtn.Location = New System.Drawing.Point(190, 160)
        Me.regInRemBtn.Name = "regInRemBtn"
        Me.regInRemBtn.Size = New System.Drawing.Size(75, 25)
        Me.regInRemBtn.TabIndex = 2
        Me.regInRemBtn.Text = "Remove"
        Me.regInRemBtn.UseVisualStyleBackColor = True
        '
        'regInAddBtn
        '
        Me.regInAddBtn.Location = New System.Drawing.Point(280, 160)
        Me.regInAddBtn.Name = "regInAddBtn"
        Me.regInAddBtn.Size = New System.Drawing.Size(75, 25)
        Me.regInAddBtn.TabIndex = 1
        Me.regInAddBtn.Text = "Add"
        Me.regInAddBtn.UseVisualStyleBackColor = True
        '
        'GBincomming
        '
        Me.GBincomming.Controls.Add(Me.DataGridView2)
        Me.GBincomming.Controls.Add(Me.Button4)
        Me.GBincomming.Controls.Add(Me.Button5)
        Me.GBincomming.Location = New System.Drawing.Point(23, 305)
        Me.GBincomming.Name = "GBincomming"
        Me.GBincomming.Size = New System.Drawing.Size(245, 207)
        Me.GBincomming.TabIndex = 4
        Me.GBincomming.TabStop = False
        Me.GBincomming.Text = "GroupBox2"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(18, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(211, 131)
        Me.DataGridView2.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(145, 171)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(45, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GBregSpends
        '
        Me.GBregSpends.Controls.Add(Me.DataGridView3)
        Me.GBregSpends.Controls.Add(Me.Button6)
        Me.GBregSpends.Controls.Add(Me.Button7)
        Me.GBregSpends.Location = New System.Drawing.Point(23, 518)
        Me.GBregSpends.Name = "GBregSpends"
        Me.GBregSpends.Size = New System.Drawing.Size(245, 207)
        Me.GBregSpends.TabIndex = 5
        Me.GBregSpends.TabStop = False
        Me.GBregSpends.Text = "GroupBox3"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(211, 131)
        Me.DataGridView3.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(145, 171)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(45, 171)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GBremDist
        '
        Me.GBremDist.Controls.Add(Me.DataGridView4)
        Me.GBremDist.Controls.Add(Me.Button8)
        Me.GBremDist.Controls.Add(Me.Button9)
        Me.GBremDist.Location = New System.Drawing.Point(23, 731)
        Me.GBremDist.Name = "GBremDist"
        Me.GBremDist.Size = New System.Drawing.Size(245, 207)
        Me.GBremDist.TabIndex = 6
        Me.GBremDist.TabStop = False
        Me.GBremDist.Text = "GroupBox4"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(211, 131)
        Me.DataGridView4.TabIndex = 3
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(145, 171)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(45, 171)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView5)
        Me.GroupBox5.Controls.Add(Me.Button10)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Location = New System.Drawing.Point(599, 92)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 207)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(211, 131)
        Me.DataGridView5.TabIndex = 3
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(145, 171)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(45, 171)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button12)
        Me.GroupBox6.Controls.Add(Me.DataGridView6)
        Me.GroupBox6.Location = New System.Drawing.Point(501, 360)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(245, 207)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(143, 173)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(211, 131)
        Me.DataGridView6.TabIndex = 3
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DataGridView7)
        Me.GroupBox7.Controls.Add(Me.Button13)
        Me.GroupBox7.Location = New System.Drawing.Point(581, 647)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(245, 207)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(211, 131)
        Me.DataGridView7.TabIndex = 3
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(145, 171)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 2
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(23, 1010)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 1010)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 11
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(23, 954)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 12
        Me.Button14.Text = "Button14"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(144, 954)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 13
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 1053)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GBremDist)
        Me.Controls.Add(Me.GBregSpends)
        Me.Controls.Add(Me.GBincomming)
        Me.Controls.Add(Me.GBregIncomming)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.YearTxtBox)
        Me.Controls.Add(Me.MonthSelect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBregIncomming.ResumeLayout(False)
        CType(Me.DGVregIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBincomming.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBregSpends.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBremDist.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthSelect As ComboBox
    Friend WithEvents YearTxtBox As TextBox
    Friend WithEvents GoBtn As Button
    Friend WithEvents GBregIncomming As GroupBox
    Friend WithEvents DGVregIn As DataGridView
    Friend WithEvents regInRemBtn As Button
    Friend WithEvents regInAddBtn As Button
    Friend WithEvents GBincomming As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GBregSpends As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents GBremDist As GroupBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button12 As Button
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Button13 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
End Class
