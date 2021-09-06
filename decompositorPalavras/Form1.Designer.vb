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
        Me.btnDecompor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDecompor
        '
        Me.btnDecompor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecompor.Location = New System.Drawing.Point(30, 103)
        Me.btnDecompor.Name = "btnDecompor"
        Me.btnDecompor.Size = New System.Drawing.Size(249, 29)
        Me.btnDecompor.TabIndex = 0
        Me.btnDecompor.Text = "Decompor"
        Me.btnDecompor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informe uma palavra (máx. 20 letras):"
        '
        'txtPalavra
        '
        Me.txtPalavra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalavra.Location = New System.Drawing.Point(30, 64)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.Size = New System.Drawing.Size(249, 24)
        Me.txtPalavra.TabIndex = 2
        Me.txtPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 172)
        Me.Controls.Add(Me.txtPalavra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDecompor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDecompor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPalavra As System.Windows.Forms.TextBox

End Class
