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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(97, 122)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "What is your name?"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(35, 60)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(101, 13)
        Me.lblQuest.TabIndex = 2
        Me.lblQuest.Text = "What is your quest?"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(142, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(0, 83)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(136, 13)
        Me.lblColor.TabIndex = 4
        Me.lblColor.Text = "What is your favorite color?"
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(142, 57)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(100, 20)
        Me.txtQuest.TabIndex = 5
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(142, 83)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 6
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(117, 186)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblQuest)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQuest As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
