<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateRate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCurrentRate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUpdateMessage = New System.Windows.Forms.Label()
        Me.txtNewRate = New System.Windows.Forms.TextBox()
        Me.btnSaveRate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Exchange Rates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Rate (GBP TO EUR):"
        '
        'lblCurrentRate
        '
        Me.lblCurrentRate.AutoSize = True
        Me.lblCurrentRate.Location = New System.Drawing.Point(460, 233)
        Me.lblCurrentRate.Name = "lblCurrentRate"
        Me.lblCurrentRate.Size = New System.Drawing.Size(31, 16)
        Me.lblCurrentRate.TabIndex = 2
        Me.lblCurrentRate.Text = "1.18"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Add New Rate:"
        '
        'lblUpdateMessage
        '
        Me.lblUpdateMessage.AutoSize = True
        Me.lblUpdateMessage.Location = New System.Drawing.Point(322, 268)
        Me.lblUpdateMessage.Name = "lblUpdateMessage"
        Me.lblUpdateMessage.Size = New System.Drawing.Size(0, 16)
        Me.lblUpdateMessage.TabIndex = 4
        '
        'txtNewRate
        '
        Me.txtNewRate.Location = New System.Drawing.Point(391, 156)
        Me.txtNewRate.Name = "txtNewRate"
        Me.txtNewRate.Size = New System.Drawing.Size(100, 22)
        Me.txtNewRate.TabIndex = 6
        '
        'btnSaveRate
        '
        Me.btnSaveRate.Location = New System.Drawing.Point(349, 194)
        Me.btnSaveRate.Name = "btnSaveRate"
        Me.btnSaveRate.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRate.TabIndex = 7
        Me.btnSaveRate.Text = "Save"
        Me.btnSaveRate.UseVisualStyleBackColor = True
        '
        'frmUpdateRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSaveRate)
        Me.Controls.Add(Me.txtNewRate)
        Me.Controls.Add(Me.lblUpdateMessage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCurrentRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUpdateRate"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCurrentRate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUpdateMessage As Label
    Friend WithEvents txtNewRate As TextBox
    Friend WithEvents btnSaveRate As Button
End Class
