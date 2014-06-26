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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗатвориToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактиранеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзрежиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопирайToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоставиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ИзрежиToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопирайToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоставиToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.РедактиранеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(415, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НовToolStripMenuItem, Me.ЗатвориToolStripMenuItem, Me.ИзходToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'НовToolStripMenuItem
        '
        Me.НовToolStripMenuItem.Name = "НовToolStripMenuItem"
        Me.НовToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.НовToolStripMenuItem.Text = "Нов"
        '
        'ЗатвориToolStripMenuItem
        '
        Me.ЗатвориToolStripMenuItem.Name = "ЗатвориToolStripMenuItem"
        Me.ЗатвориToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.ЗатвориToolStripMenuItem.Text = "Затвори"
        '
        'ИзходToolStripMenuItem
        '
        Me.ИзходToolStripMenuItem.Name = "ИзходToolStripMenuItem"
        Me.ИзходToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.ИзходToolStripMenuItem.Text = "Изход"
        '
        'РедактиранеToolStripMenuItem
        '
        Me.РедактиранеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзрежиToolStripMenuItem, Me.КопирайToolStripMenuItem, Me.ПоставиToolStripMenuItem})
        Me.РедактиранеToolStripMenuItem.Name = "РедактиранеToolStripMenuItem"
        Me.РедактиранеToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.РедактиранеToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.РедактиранеToolStripMenuItem.Text = "Редактиране"
        '
        'ИзрежиToolStripMenuItem
        '
        Me.ИзрежиToolStripMenuItem.Enabled = False
        Me.ИзрежиToolStripMenuItem.Name = "ИзрежиToolStripMenuItem"
        Me.ИзрежиToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.ИзрежиToolStripMenuItem.Text = "Изрежи"
        '
        'КопирайToolStripMenuItem
        '
        Me.КопирайToolStripMenuItem.CheckOnClick = True
        Me.КопирайToolStripMenuItem.Name = "КопирайToolStripMenuItem"
        Me.КопирайToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.КопирайToolStripMenuItem.Text = "Копирай"
        '
        'ПоставиToolStripMenuItem
        '
        Me.ПоставиToolStripMenuItem.Enabled = False
        Me.ПоставиToolStripMenuItem.Name = "ПоставиToolStripMenuItem"
        Me.ПоставиToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.ПоставиToolStripMenuItem.Text = "Постави"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзрежиToolStripMenuItem1, Me.КопирайToolStripMenuItem1, Me.ПоставиToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 76)
        '
        'ИзрежиToolStripMenuItem1
        '
        Me.ИзрежиToolStripMenuItem1.Name = "ИзрежиToolStripMenuItem1"
        Me.ИзрежиToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.ИзрежиToolStripMenuItem1.Text = "Изрежи"
        '
        'КопирайToolStripMenuItem1
        '
        Me.КопирайToolStripMenuItem1.Name = "КопирайToolStripMenuItem1"
        Me.КопирайToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.КопирайToolStripMenuItem1.Text = "Копирай"
        '
        'ПоставиToolStripMenuItem1
        '
        Me.ПоставиToolStripMenuItem1.Name = "ПоставиToolStripMenuItem1"
        Me.ПоставиToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
        Me.ПоставиToolStripMenuItem1.Text = "Постави"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 336)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НовToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗатвориToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РедактиранеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИзрежиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КопирайToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПоставиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ИзрежиToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КопирайToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПоставиToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
