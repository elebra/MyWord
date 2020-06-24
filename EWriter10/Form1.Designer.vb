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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Redo = New System.Windows.Forms.PictureBox()
        Me.Undo = New System.Windows.Forms.PictureBox()
        Me.BuildNumber = New System.Windows.Forms.PictureBox()
        Me.Save = New System.Windows.Forms.PictureBox()
        Me.Open = New System.Windows.Forms.PictureBox()
        Me.NewFile = New System.Windows.Forms.PictureBox()
        Me.Words = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.Redo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Undo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Open, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RCMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Redo)
        Me.Panel1.Controls.Add(Me.Undo)
        Me.Panel1.Controls.Add(Me.BuildNumber)
        Me.Panel1.Controls.Add(Me.Save)
        Me.Panel1.Controls.Add(Me.Open)
        Me.Panel1.Controls.Add(Me.NewFile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 48)
        Me.Panel1.TabIndex = 0
        '
        'Redo
        '
        Me.Redo.BackColor = System.Drawing.Color.Transparent
        Me.Redo.BackgroundImage = CType(resources.GetObject("Redo.BackgroundImage"), System.Drawing.Image)
        Me.Redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Redo.Dock = System.Windows.Forms.DockStyle.Left
        Me.Redo.Location = New System.Drawing.Point(240, 0)
        Me.Redo.Name = "Redo"
        Me.Redo.Size = New System.Drawing.Size(48, 48)
        Me.Redo.TabIndex = 16
        Me.Redo.TabStop = False
        '
        'Undo
        '
        Me.Undo.BackColor = System.Drawing.Color.Transparent
        Me.Undo.BackgroundImage = CType(resources.GetObject("Undo.BackgroundImage"), System.Drawing.Image)
        Me.Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Undo.Dock = System.Windows.Forms.DockStyle.Left
        Me.Undo.Location = New System.Drawing.Point(192, 0)
        Me.Undo.Name = "Undo"
        Me.Undo.Size = New System.Drawing.Size(48, 48)
        Me.Undo.TabIndex = 15
        Me.Undo.TabStop = False
        '
        'BuildNumber
        '
        Me.BuildNumber.BackColor = System.Drawing.Color.Transparent
        Me.BuildNumber.BackgroundImage = CType(resources.GetObject("BuildNumber.BackgroundImage"), System.Drawing.Image)
        Me.BuildNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BuildNumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.BuildNumber.Location = New System.Drawing.Point(144, 0)
        Me.BuildNumber.Name = "BuildNumber"
        Me.BuildNumber.Size = New System.Drawing.Size(48, 48)
        Me.BuildNumber.TabIndex = 8
        Me.BuildNumber.TabStop = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.Transparent
        Me.Save.BackgroundImage = CType(resources.GetObject("Save.BackgroundImage"), System.Drawing.Image)
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Save.Dock = System.Windows.Forms.DockStyle.Left
        Me.Save.Location = New System.Drawing.Point(96, 0)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(48, 48)
        Me.Save.TabIndex = 7
        Me.Save.TabStop = False
        '
        'Open
        '
        Me.Open.BackColor = System.Drawing.Color.Transparent
        Me.Open.BackgroundImage = CType(resources.GetObject("Open.BackgroundImage"), System.Drawing.Image)
        Me.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Open.Dock = System.Windows.Forms.DockStyle.Left
        Me.Open.Location = New System.Drawing.Point(48, 0)
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(48, 48)
        Me.Open.TabIndex = 6
        Me.Open.TabStop = False
        '
        'NewFile
        '
        Me.NewFile.BackColor = System.Drawing.Color.Transparent
        Me.NewFile.BackgroundImage = CType(resources.GetObject("NewFile.BackgroundImage"), System.Drawing.Image)
        Me.NewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewFile.Location = New System.Drawing.Point(0, 0)
        Me.NewFile.Name = "NewFile"
        Me.NewFile.Size = New System.Drawing.Size(48, 48)
        Me.NewFile.TabIndex = 5
        Me.NewFile.TabStop = False
        '
        'Words
        '
        Me.Words.ContextMenuStrip = Me.RCMenu
        Me.Words.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Words.Location = New System.Drawing.Point(0, 48)
        Me.Words.Name = "Words"
        Me.Words.Size = New System.Drawing.Size(670, 287)
        Me.Words.TabIndex = 1
        Me.Words.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "MyWord X|*.MWX|Text Files|*.txt|All Files|*.*"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "MyWord X|*.MWX|Text Files|*.txt|All Files|*.*"
        '
        'RCMenu
        '
        Me.RCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.BuildToolStripMenuItem, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.RCMenu.Name = "ContextMenuStrip1"
        Me.RCMenu.Size = New System.Drawing.Size(104, 136)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 335)
        Me.Controls.Add(Me.Words)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyWord X"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Redo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Undo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Open, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RCMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Words As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NewFile As System.Windows.Forms.PictureBox
    Friend WithEvents BuildNumber As System.Windows.Forms.PictureBox
    Friend WithEvents Save As System.Windows.Forms.PictureBox
    Friend WithEvents Open As System.Windows.Forms.PictureBox
    Friend WithEvents Redo As System.Windows.Forms.PictureBox
    Friend WithEvents Undo As System.Windows.Forms.PictureBox
    Friend WithEvents RCMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
