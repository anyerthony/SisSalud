<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CONTROL = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CONTROL
        '
        Me.CONTROL.ActiveViewIndex = -1
        Me.CONTROL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CONTROL.DisplayGroupTree = False
        Me.CONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CONTROL.Location = New System.Drawing.Point(0, 0)
        Me.CONTROL.Name = "CONTROL"
        Me.CONTROL.SelectionFormula = ""
        Me.CONTROL.ShowRefreshButton = False
        Me.CONTROL.Size = New System.Drawing.Size(964, 742)
        Me.CONTROL.TabIndex = 1
        Me.CONTROL.ViewTimeSelectionFormula = ""
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 742)
        Me.Controls.Add(Me.CONTROL)
        Me.Name = "FrmReportes"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CONTROL As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
