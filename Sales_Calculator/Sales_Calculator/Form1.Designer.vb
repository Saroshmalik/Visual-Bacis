<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.btn_LoadFile = New System.Windows.Forms.Button()
        Me.Lst_Track = New System.Windows.Forms.ListBox()
        Me.txt_Purchase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Purchase = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Sub = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Tax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Sale_Total = New System.Windows.Forms.TextBox()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_LoadFile
        '
        Me.btn_LoadFile.Location = New System.Drawing.Point(16, 12)
        Me.btn_LoadFile.Name = "btn_LoadFile"
        Me.btn_LoadFile.Size = New System.Drawing.Size(122, 35)
        Me.btn_LoadFile.TabIndex = 0
        Me.btn_LoadFile.Text = "&Load File"
        Me.btn_LoadFile.UseVisualStyleBackColor = True
        '
        'Lst_Track
        '
        Me.Lst_Track.FormattingEnabled = True
        Me.Lst_Track.ItemHeight = 20
        Me.Lst_Track.Location = New System.Drawing.Point(12, 112)
        Me.Lst_Track.Name = "Lst_Track"
        Me.Lst_Track.Size = New System.Drawing.Size(180, 224)
        Me.Lst_Track.TabIndex = 1
        '
        'txt_Purchase
        '
        Me.txt_Purchase.Location = New System.Drawing.Point(403, 77)
        Me.txt_Purchase.Name = "txt_Purchase"
        Me.txt_Purchase.Size = New System.Drawing.Size(165, 26)
        Me.txt_Purchase.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Purchase Value"
        '
        'Btn_Purchase
        '
        Me.Btn_Purchase.Location = New System.Drawing.Point(484, 112)
        Me.Btn_Purchase.Name = "Btn_Purchase"
        Me.Btn_Purchase.Size = New System.Drawing.Size(84, 33)
        Me.Btn_Purchase.TabIndex = 4
        Me.Btn_Purchase.Text = "&Purchase"
        Me.Btn_Purchase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Puchase List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sub Total"
        '
        'txt_Sub
        '
        Me.txt_Sub.Enabled = False
        Me.txt_Sub.Location = New System.Drawing.Point(403, 163)
        Me.txt_Sub.Name = "txt_Sub"
        Me.txt_Sub.Size = New System.Drawing.Size(165, 26)
        Me.txt_Sub.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tax Amount"
        '
        'txt_Tax
        '
        Me.txt_Tax.Enabled = False
        Me.txt_Tax.Location = New System.Drawing.Point(403, 212)
        Me.txt_Tax.Name = "txt_Tax"
        Me.txt_Tax.Size = New System.Drawing.Size(165, 26)
        Me.txt_Tax.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sales Total"
        '
        'Txt_Sale_Total
        '
        Me.Txt_Sale_Total.Enabled = False
        Me.Txt_Sale_Total.Location = New System.Drawing.Point(403, 261)
        Me.Txt_Sale_Total.Name = "Txt_Sale_Total"
        Me.Txt_Sale_Total.Size = New System.Drawing.Size(165, 26)
        Me.Txt_Sale_Total.TabIndex = 10
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(484, 12)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(94, 35)
        Me.btn_Reset.TabIndex = 12
        Me.btn_Reset.Text = "&Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 395)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Sale_Total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Tax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Sub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Purchase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Purchase)
        Me.Controls.Add(Me.Lst_Track)
        Me.Controls.Add(Me.btn_LoadFile)
        Me.Name = "form1"
        Me.Text = "Sales Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_LoadFile As Button
    Friend WithEvents Lst_Track As ListBox
    Friend WithEvents txt_Purchase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Purchase As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Sub As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Tax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Sale_Total As TextBox
    Friend WithEvents btn_Reset As Button
End Class
