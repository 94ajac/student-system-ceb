<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckButton1 = New DevExpress.XtraEditors.CheckButton()
        Me.SuspendLayout()
        '
        'CheckButton1
        '
        Me.CheckButton1.Location = New System.Drawing.Point(163, 129)
        Me.CheckButton1.Name = "CheckButton1"
        Me.CheckButton1.Size = New System.Drawing.Size(75, 23)
        Me.CheckButton1.TabIndex = 0
        Me.CheckButton1.Text = "CheckButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CheckButton1)
        Me.Name = "Form1"
        Me.Text = "ti"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckButton1 As DevExpress.XtraEditors.CheckButton

End Class
