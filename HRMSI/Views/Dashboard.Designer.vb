<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CustomizableEdges1 As CustomizableEdges = New CustomizableEdges()
        Dim CustomizableEdges2 As CustomizableEdges = New CustomizableEdges()
        Dim CustomizableEdges3 As CustomizableEdges = New CustomizableEdges()
        Dim CustomizableEdges4 As CustomizableEdges = New CustomizableEdges()
        Guna2GradientPanel1 = New Guna2GradientPanel()
        Guna2GradientPanel2 = New Guna2GradientPanel()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Left
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(237, 599)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' Guna2GradientPanel2
        ' 
        Guna2GradientPanel2.CustomizableEdges = CustomizableEdges3
        Guna2GradientPanel2.Dock = DockStyle.Right
        Guna2GradientPanel2.Location = New Point(942, 0)
        Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Guna2GradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientPanel2.Size = New Size(185, 599)
        Guna2GradientPanel2.TabIndex = 1
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2GradientPanel2)
        Controls.Add(Guna2GradientPanel1)
        Name = "Dashboard"
        Size = New Size(1127, 599)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna2GradientPanel
End Class
