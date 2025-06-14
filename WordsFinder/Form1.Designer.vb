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
        LblSearchWord = New Label()
        LblRootDirectory = New Label()
        txtSearchWord = New TextBox()
        txtRootDirectory = New TextBox()
        BtnChooseDirectory = New Button()
        BtnSearch = New Button()
        SuspendLayout()
        ' 
        ' LblSearchWord
        ' 
        LblSearchWord.AutoSize = True
        LblSearchWord.Location = New Point(85, 36)
        LblSearchWord.Name = "LblSearchWord"
        LblSearchWord.Size = New Size(113, 25)
        LblSearchWord.TabIndex = 0
        LblSearchWord.Text = "Search Word"
        ' 
        ' LblRootDirectory
        ' 
        LblRootDirectory.AutoSize = True
        LblRootDirectory.Location = New Point(85, 166)
        LblRootDirectory.Name = "LblRootDirectory"
        LblRootDirectory.Size = New Size(128, 25)
        LblRootDirectory.TabIndex = 1
        LblRootDirectory.Text = "Root Directory"
        ' 
        ' txtSearchWord
        ' 
        txtSearchWord.Location = New Point(85, 98)
        txtSearchWord.Name = "txtSearchWord"
        txtSearchWord.Size = New Size(481, 31)
        txtSearchWord.TabIndex = 2
        ' 
        ' txtRootDirectory
        ' 
        txtRootDirectory.Location = New Point(85, 231)
        txtRootDirectory.Name = "txtRootDirectory"
        txtRootDirectory.Size = New Size(481, 31)
        txtRootDirectory.TabIndex = 3
        ' 
        ' BtnChooseDirectory
        ' 
        BtnChooseDirectory.Location = New Point(616, 228)
        BtnChooseDirectory.Name = "BtnChooseDirectory"
        BtnChooseDirectory.Size = New Size(49, 34)
        BtnChooseDirectory.TabIndex = 4
        BtnChooseDirectory.Text = "..."
        BtnChooseDirectory.UseVisualStyleBackColor = True
        ' 
        ' BtnSearch
        ' 
        BtnSearch.Location = New Point(327, 345)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(112, 34)
        BtnSearch.TabIndex = 5
        BtnSearch.Text = "Search"
        BtnSearch.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnSearch)
        Controls.Add(BtnChooseDirectory)
        Controls.Add(txtRootDirectory)
        Controls.Add(txtSearchWord)
        Controls.Add(LblRootDirectory)
        Controls.Add(LblSearchWord)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblSearchWord As Label
    Friend WithEvents LblRootDirectory As Label
    Friend WithEvents txtSearchWord As TextBox
    Friend WithEvents txtRootDirectory As TextBox
    Friend WithEvents BtnChooseDirectory As Button
    Friend WithEvents BtnSearch As Button
End Class
