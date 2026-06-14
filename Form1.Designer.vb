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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.btnGbpToEur = New System.Windows.Forms.Button()
        Me.btnEurToGbp = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnUpdateRate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Converter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter amount:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(312, 147)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtAmount.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Exchange Rate (GBP to EUR)"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(312, 208)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 22)
        Me.txtRate.TabIndex = 4
        Me.txtRate.Text = "1.18"
        '
        'btnGbpToEur
        '
        Me.btnGbpToEur.Location = New System.Drawing.Point(430, 146)
        Me.btnGbpToEur.Name = "btnGbpToEur"
        Me.btnGbpToEur.Size = New System.Drawing.Size(177, 23)
        Me.btnGbpToEur.TabIndex = 5
        Me.btnGbpToEur.Text = "Convert GBP to EUR"
        Me.btnGbpToEur.UseVisualStyleBackColor = True
        '
        'btnEurToGbp
        '
        Me.btnEurToGbp.Location = New System.Drawing.Point(430, 207)
        Me.btnEurToGbp.Name = "btnEurToGbp"
        Me.btnEurToGbp.Size = New System.Drawing.Size(177, 23)
        Me.btnEurToGbp.TabIndex = 6
        Me.btnEurToGbp.Text = "Convert EUR to GBP"
        Me.btnEurToGbp.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(358, 250)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 16)
        Me.lblResult.TabIndex = 7
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(358, 279)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 8
        '
        'btnUpdateRate
        '
        Me.btnUpdateRate.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdateRate.Name = "btnUpdateRate"
        Me.btnUpdateRate.Size = New System.Drawing.Size(159, 77)
        Me.btnUpdateRate.TabIndex = 9
        Me.btnUpdateRate.Text = "Change Exchange Rate"
        Me.btnUpdateRate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUpdateRate)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEurToGbp)
        Me.Controls.Add(Me.btnGbpToEur)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents btnGbpToEur As Button
    Friend WithEvents btnEurToGbp As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnUpdateRate As Button
End Class
