<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.A = New System.Windows.Forms.Label()
        Me.B = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.D = New System.Windows.Forms.Label()
        Me.E = New System.Windows.Forms.Label()
        Me.F = New System.Windows.Forms.Label()
        Me.G = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.DimGray
        Me.A.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.A.Location = New System.Drawing.Point(146, 18)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(165, 22)
        Me.A.TabIndex = 0
        '
        'B
        '
        Me.B.AccessibleName = ""
        Me.B.BackColor = System.Drawing.Color.DimGray
        Me.B.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.B.Location = New System.Drawing.Point(313, 40)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(21, 130)
        Me.B.TabIndex = 1
        '
        'C
        '
        Me.C.BackColor = System.Drawing.Color.DimGray
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.C.Location = New System.Drawing.Point(313, 193)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(21, 130)
        Me.C.TabIndex = 2
        '
        'D
        '
        Me.D.BackColor = System.Drawing.Color.DimGray
        Me.D.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.D.Location = New System.Drawing.Point(146, 323)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(165, 22)
        Me.D.TabIndex = 3
        '
        'E
        '
        Me.E.BackColor = System.Drawing.Color.DimGray
        Me.E.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.E.Location = New System.Drawing.Point(123, 193)
        Me.E.Name = "E"
        Me.E.Size = New System.Drawing.Size(21, 130)
        Me.E.TabIndex = 4
        '
        'F
        '
        Me.F.BackColor = System.Drawing.Color.DimGray
        Me.F.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.F.Location = New System.Drawing.Point(123, 40)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(21, 130)
        Me.F.TabIndex = 5
        '
        'G
        '
        Me.G.BackColor = System.Drawing.Color.DimGray
        Me.G.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.G.Location = New System.Drawing.Point(146, 169)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(165, 22)
        Me.G.TabIndex = 6
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
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.E)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Seven Segment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents A As Label
    Friend WithEvents B As Label
    Friend WithEvents C As Label
    Friend WithEvents D As Label
    Friend WithEvents E As Label
    Friend WithEvents F As Label
    Friend WithEvents G As Label
    Friend WithEvents TextBox1 As TextBox
End Class
