Imports Webinar.VB.ViewModels

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrackView
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEditId = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditName = New DevExpress.XtraEditors.TextEdit()
        Me.txtEditComposer = New DevExpress.XtraEditors.TextEdit()
        Me.lblId = New DevExpress.XtraEditors.LabelControl()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.lblComposer = New DevExpress.XtraEditors.LabelControl()
        CType(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEditComposer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvvmContext1
        '
        Me.mvvmContext1.ContainerControl = Me
        Me.mvvmContext1.ViewModelType = GetType(Webinar.VB.ViewModels.TrackViewModel)
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(47, 30)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear &Name"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(294, 30)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(169, 30)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        '
        'txtEditId
        '
        Me.txtEditId.Location = New System.Drawing.Point(144, 98)
        Me.txtEditId.Name = "txtEditId"
        Me.txtEditId.Size = New System.Drawing.Size(178, 20)
        Me.txtEditId.TabIndex = 3
        '
        'txtEditName
        '
        Me.txtEditName.Location = New System.Drawing.Point(144, 140)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(178, 20)
        Me.txtEditName.TabIndex = 4
        '
        'txtEditComposer
        '
        Me.txtEditComposer.Location = New System.Drawing.Point(144, 183)
        Me.txtEditComposer.Name = "txtEditComposer"
        Me.txtEditComposer.Size = New System.Drawing.Size(178, 20)
        Me.txtEditComposer.TabIndex = 5
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(37, 101)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(10, 13)
        Me.lblId.TabIndex = 6
        Me.lblId.Text = "Id"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(37, 143)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(27, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblComposer
        '
        Me.lblComposer.Location = New System.Drawing.Point(37, 186)
        Me.lblComposer.Name = "lblComposer"
        Me.lblComposer.Size = New System.Drawing.Size(48, 13)
        Me.lblComposer.TabIndex = 8
        Me.lblComposer.Text = "Composer"
        '
        'TrackView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblComposer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtEditComposer)
        Me.Controls.Add(Me.txtEditName)
        Me.Controls.Add(Me.txtEditId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "TrackView"
        Me.Size = New System.Drawing.Size(432, 386)
        CType(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEditComposer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblComposer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEditComposer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEditId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
