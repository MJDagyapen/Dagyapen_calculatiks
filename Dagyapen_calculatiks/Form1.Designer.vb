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
        Txtfirstnum = New TextBox()
        Txtsecondnum = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        lblresult = New Label()
        SuspendLayout()
        ' 
        ' Txtfirstnum
        ' 
        Txtfirstnum.Location = New Point(265, 49)
        Txtfirstnum.Name = "Txtfirstnum"
        Txtfirstnum.Size = New Size(212, 23)
        Txtfirstnum.TabIndex = 0
        ' 
        ' Txtsecondnum
        ' 
        Txtsecondnum.Location = New Point(265, 113)
        Txtsecondnum.Name = "Txtsecondnum"
        Txtsecondnum.Size = New Size(212, 23)
        Txtsecondnum.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(268, 84)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 23)
        Button1.TabIndex = 2
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(326, 84)
        Button2.Name = "Button2"
        Button2.Size = New Size(32, 23)
        Button2.TabIndex = 3
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(384, 84)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 23)
        Button3.TabIndex = 4
        Button3.Text = "/"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(448, 84)
        Button4.Name = "Button4"
        Button4.Size = New Size(29, 23)
        Button4.TabIndex = 5
        Button4.Text = "*"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' lblresult
        ' 
        lblresult.AutoSize = True
        lblresult.Location = New Point(352, 151)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(39, 15)
        lblresult.TabIndex = 6
        lblresult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblresult)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Txtsecondnum)
        Controls.Add(Txtfirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txtfirstnum As TextBox
    Friend WithEvents Txtsecondnum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lblresult As Label
End Class
