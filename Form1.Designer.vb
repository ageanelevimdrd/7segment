﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(146, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 22)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(317, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 130)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(317, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 130)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(146, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 22)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(119, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 130)
        Me.Label5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(119, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 130)
        Me.Label6.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(146, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 22)
        Me.Label7.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 399)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(230, 62)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Ageane Levi A. Madrid                 BSCpE 5-3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(464, 473)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Seven Segment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
