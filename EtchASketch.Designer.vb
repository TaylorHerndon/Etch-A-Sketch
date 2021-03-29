<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketchForum
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.HandDrawButton = New System.Windows.Forms.Button()
        Me.PenSizeNumericControl = New System.Windows.Forms.NumericUpDown()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OscilloscopeButton = New System.Windows.Forms.Button()
        Me.SineWaveButton = New System.Windows.Forms.Button()
        Me.CosineButton = New System.Windows.Forms.Button()
        Me.TangentButton = New System.Windows.Forms.Button()
        Me.AmplitudeControl = New System.Windows.Forms.NumericUpDown()
        Me.FrequencyControl = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GeneralToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HandDrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableHandDrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OscilloscopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableOscilloscopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawSineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawCosineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawTangentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChageColorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.PenColorButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenSizeNumericControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmplitudeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrequencyControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.Menu
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(623, 581)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        Me.GeneralToolTips.SetToolTip(Me.PictureBox, "This is where you draw your pictures :)")
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(930, 561)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(129, 64)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "Exit"
        Me.GeneralToolTips.SetToolTip(Me.ExitButton, "Press to exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(651, 561)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(129, 64)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "CLEAR"
        Me.GeneralToolTips.SetToolTip(Me.ClearButton, "Press to erase your picture")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'HandDrawButton
        '
        Me.HandDrawButton.BackColor = System.Drawing.SystemColors.Control
        Me.HandDrawButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HandDrawButton.Location = New System.Drawing.Point(692, 58)
        Me.HandDrawButton.Name = "HandDrawButton"
        Me.HandDrawButton.Size = New System.Drawing.Size(327, 64)
        Me.HandDrawButton.TabIndex = 1
        Me.HandDrawButton.Text = "Hand Draw Mode"
        Me.GeneralToolTips.SetToolTip(Me.HandDrawButton, "Click to Enable / Disable Hand Draw Mode")
        Me.HandDrawButton.UseVisualStyleBackColor = False
        '
        'PenSizeNumericControl
        '
        Me.PenSizeNumericControl.Location = New System.Drawing.Point(692, 165)
        Me.PenSizeNumericControl.Name = "PenSizeNumericControl"
        Me.PenSizeNumericControl.Size = New System.Drawing.Size(102, 26)
        Me.PenSizeNumericControl.TabIndex = 2
        Me.GeneralToolTips.SetToolTip(Me.PenSizeNumericControl, "Change the width of the pen")
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(786, 561)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(138, 64)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "SAVE"
        Me.GeneralToolTips.SetToolTip(Me.SaveButton, "Press to save your picture")
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(687, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pen Size    Pen Color"
        '
        'OscilloscopeButton
        '
        Me.OscilloscopeButton.BackColor = System.Drawing.SystemColors.Control
        Me.OscilloscopeButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OscilloscopeButton.Location = New System.Drawing.Point(692, 236)
        Me.OscilloscopeButton.Name = "OscilloscopeButton"
        Me.OscilloscopeButton.Size = New System.Drawing.Size(327, 64)
        Me.OscilloscopeButton.TabIndex = 4
        Me.OscilloscopeButton.Text = "Oscilloscope Mode"
        Me.GeneralToolTips.SetToolTip(Me.OscilloscopeButton, "Click to Enable Oscilloscope Mode")
        Me.OscilloscopeButton.UseVisualStyleBackColor = False
        '
        'SineWaveButton
        '
        Me.SineWaveButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SineWaveButton.Location = New System.Drawing.Point(692, 306)
        Me.SineWaveButton.Name = "SineWaveButton"
        Me.SineWaveButton.Size = New System.Drawing.Size(102, 64)
        Me.SineWaveButton.TabIndex = 5
        Me.SineWaveButton.Text = "Sine"
        Me.GeneralToolTips.SetToolTip(Me.SineWaveButton, "If Oscilloscope Mode is enabled click here to draw a Sine Wave")
        Me.SineWaveButton.UseVisualStyleBackColor = True
        '
        'CosineButton
        '
        Me.CosineButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosineButton.Location = New System.Drawing.Point(800, 306)
        Me.CosineButton.Name = "CosineButton"
        Me.CosineButton.Size = New System.Drawing.Size(111, 64)
        Me.CosineButton.TabIndex = 6
        Me.CosineButton.Text = "Cosine"
        Me.GeneralToolTips.SetToolTip(Me.CosineButton, "If Oscilloscope Mode is enabled click here to draw a Cosine Wave")
        Me.CosineButton.UseVisualStyleBackColor = True
        '
        'TangentButton
        '
        Me.TangentButton.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TangentButton.Location = New System.Drawing.Point(917, 306)
        Me.TangentButton.Name = "TangentButton"
        Me.TangentButton.Size = New System.Drawing.Size(102, 64)
        Me.TangentButton.TabIndex = 7
        Me.TangentButton.Text = "Tan"
        Me.GeneralToolTips.SetToolTip(Me.TangentButton, "If Oscilloscope Mode is enabled click here to draw a Tangent Wave")
        Me.TangentButton.UseVisualStyleBackColor = True
        '
        'AmplitudeControl
        '
        Me.AmplitudeControl.Location = New System.Drawing.Point(692, 426)
        Me.AmplitudeControl.Name = "AmplitudeControl"
        Me.AmplitudeControl.Size = New System.Drawing.Size(158, 26)
        Me.AmplitudeControl.TabIndex = 8
        Me.GeneralToolTips.SetToolTip(Me.AmplitudeControl, "Change the amplitude of the selected waveform")
        '
        'FrequencyControl
        '
        Me.FrequencyControl.Location = New System.Drawing.Point(861, 426)
        Me.FrequencyControl.Name = "FrequencyControl"
        Me.FrequencyControl.Size = New System.Drawing.Size(158, 26)
        Me.FrequencyControl.TabIndex = 9
        Me.GeneralToolTips.SetToolTip(Me.FrequencyControl, "Change the frequency of the selected waveform")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(687, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amplitude (V)     Frequency (Hz)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1071, 33)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(151, 34)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenToolStripMenuItem, Me.PenToolStripMenuItem1, Me.ClearToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'PenToolStripMenuItem
        '
        Me.PenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HandDrawToolStripMenuItem, Me.OscilloscopeToolStripMenuItem})
        Me.PenToolStripMenuItem.Name = "PenToolStripMenuItem"
        Me.PenToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PenToolStripMenuItem.Text = "&Draw Mode"
        '
        'HandDrawToolStripMenuItem
        '
        Me.HandDrawToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableHandDrawToolStripMenuItem})
        Me.HandDrawToolStripMenuItem.Name = "HandDrawToolStripMenuItem"
        Me.HandDrawToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.HandDrawToolStripMenuItem.Text = "&Hand Draw"
        '
        'EnableHandDrawToolStripMenuItem
        '
        Me.EnableHandDrawToolStripMenuItem.Name = "EnableHandDrawToolStripMenuItem"
        Me.EnableHandDrawToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.EnableHandDrawToolStripMenuItem.Text = "&Enable"
        '
        'OscilloscopeToolStripMenuItem
        '
        Me.OscilloscopeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableOscilloscopeToolStripMenuItem, Me.DrawSineToolStripMenuItem, Me.DrawCosineToolStripMenuItem, Me.DrawTangentToolStripMenuItem})
        Me.OscilloscopeToolStripMenuItem.Name = "OscilloscopeToolStripMenuItem"
        Me.OscilloscopeToolStripMenuItem.Size = New System.Drawing.Size(214, 34)
        Me.OscilloscopeToolStripMenuItem.Text = "O&scilloscope"
        '
        'EnableOscilloscopeToolStripMenuItem
        '
        Me.EnableOscilloscopeToolStripMenuItem.Name = "EnableOscilloscopeToolStripMenuItem"
        Me.EnableOscilloscopeToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.EnableOscilloscopeToolStripMenuItem.Text = "&Enable"
        '
        'DrawSineToolStripMenuItem
        '
        Me.DrawSineToolStripMenuItem.Name = "DrawSineToolStripMenuItem"
        Me.DrawSineToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.DrawSineToolStripMenuItem.Text = "Draw &Sine"
        '
        'DrawCosineToolStripMenuItem
        '
        Me.DrawCosineToolStripMenuItem.Name = "DrawCosineToolStripMenuItem"
        Me.DrawCosineToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.DrawCosineToolStripMenuItem.Text = "Draw &Cosine"
        '
        'DrawTangentToolStripMenuItem
        '
        Me.DrawTangentToolStripMenuItem.Name = "DrawTangentToolStripMenuItem"
        Me.DrawTangentToolStripMenuItem.Size = New System.Drawing.Size(222, 34)
        Me.DrawTangentToolStripMenuItem.Text = "Draw &Tangent"
        '
        'PenToolStripMenuItem1
        '
        Me.PenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChageColorMenuItem})
        Me.PenToolStripMenuItem1.Name = "PenToolStripMenuItem1"
        Me.PenToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.PenToolStripMenuItem1.Text = "&Pen"
        '
        'ChageColorMenuItem
        '
        Me.ChageColorMenuItem.Name = "ChageColorMenuItem"
        Me.ChageColorMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ChageColorMenuItem.Text = "Ch&ange Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PenColorButton
        '
        Me.PenColorButton.Location = New System.Drawing.Point(817, 165)
        Me.PenColorButton.Name = "PenColorButton"
        Me.PenColorButton.Size = New System.Drawing.Size(182, 24)
        Me.PenColorButton.TabIndex = 14
        Me.PenColorButton.UseVisualStyleBackColor = True
        '
        'EtchASketchForum
        '
        Me.AcceptButton = Me.OscilloscopeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1071, 637)
        Me.Controls.Add(Me.PenColorButton)
        Me.Controls.Add(Me.FrequencyControl)
        Me.Controls.Add(Me.AmplitudeControl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PenSizeNumericControl)
        Me.Controls.Add(Me.TangentButton)
        Me.Controls.Add(Me.CosineButton)
        Me.Controls.Add(Me.SineWaveButton)
        Me.Controls.Add(Me.OscilloscopeButton)
        Me.Controls.Add(Me.HandDrawButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EtchASketchForum"
        Me.Text = "Etch - A - Sketch"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenSizeNumericControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmplitudeControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrequencyControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents HandDrawButton As Button
    Friend WithEvents PenSizeNumericControl As NumericUpDown
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OscilloscopeButton As Button
    Friend WithEvents SineWaveButton As Button
    Friend WithEvents CosineButton As Button
    Friend WithEvents TangentButton As Button
    Friend WithEvents AmplitudeControl As NumericUpDown
    Friend WithEvents FrequencyControl As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents GeneralToolTips As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HandDrawToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableHandDrawToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OscilloscopeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableOscilloscopeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawSineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawCosineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawTangentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ChageColorMenuItem As ToolStripMenuItem
    Friend WithEvents PenColorButton As Button
End Class
