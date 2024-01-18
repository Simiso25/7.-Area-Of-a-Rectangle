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
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter Length"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(161, 193)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Area Is"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(310, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(178, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(161, 256)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "Perimeter is"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 0
        Label2.Text = "Engter Height"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(310, 124)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(178, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(310, 193)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(178, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(310, 256)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(178, 23)
        TextBox4.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox

End Class
