<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetadataUtil
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCitation = New System.Windows.Forms.Label()
        Me.lblPubDate = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblUpdateFreq = New System.Windows.Forms.Label()
        Me.lblISOLinkage = New System.Windows.Forms.Label()
        Me.txtCitation = New System.Windows.Forms.TextBox()
        Me.txtPubDate = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtISOLinkage = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtISOTime = New System.Windows.Forms.TextBox()
        Me.lblISOTime = New System.Windows.Forms.Label()
        Me.txtISOPublishDate = New System.Windows.Forms.TextBox()
        Me.lblISOPublishDate = New System.Windows.Forms.Label()
        Me.cboUpdateFreq = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbxTimePeriod = New System.Windows.Forms.GroupBox()
        Me.lblISOMetadataDate = New System.Windows.Forms.Label()
        Me.txtISOMetadataDate = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbxTimePeriod.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Format Metadata"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCitation
        '
        Me.lblCitation.AutoSize = True
        Me.lblCitation.Location = New System.Drawing.Point(36, 27)
        Me.lblCitation.Name = "lblCitation"
        Me.lblCitation.Size = New System.Drawing.Size(116, 13)
        Me.lblCitation.TabIndex = 2
        Me.lblCitation.Text = "Citation Online Linkage"
        '
        'lblPubDate
        '
        Me.lblPubDate.AutoSize = True
        Me.lblPubDate.Location = New System.Drawing.Point(36, 76)
        Me.lblPubDate.Name = "lblPubDate"
        Me.lblPubDate.Size = New System.Drawing.Size(85, 13)
        Me.lblPubDate.TabIndex = 3
        Me.lblPubDate.Text = "Publication Date"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(6, 20)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(29, 13)
        Me.lblStart.TabIndex = 4
        Me.lblStart.Text = "Start"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(251, 20)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblEnd.TabIndex = 5
        Me.lblEnd.Text = "End"
        '
        'lblUpdateFreq
        '
        Me.lblUpdateFreq.AutoSize = True
        Me.lblUpdateFreq.Location = New System.Drawing.Point(36, 206)
        Me.lblUpdateFreq.Name = "lblUpdateFreq"
        Me.lblUpdateFreq.Size = New System.Drawing.Size(95, 13)
        Me.lblUpdateFreq.TabIndex = 6
        Me.lblUpdateFreq.Text = "Update Frequency"
        '
        'lblISOLinkage
        '
        Me.lblISOLinkage.AutoSize = True
        Me.lblISOLinkage.Location = New System.Drawing.Point(36, 254)
        Me.lblISOLinkage.Name = "lblISOLinkage"
        Me.lblISOLinkage.Size = New System.Drawing.Size(99, 13)
        Me.lblISOLinkage.TabIndex = 7
        Me.lblISOLinkage.Text = "ISO Online Linkage"
        '
        'txtCitation
        '
        Me.txtCitation.Location = New System.Drawing.Point(39, 43)
        Me.txtCitation.Name = "txtCitation"
        Me.txtCitation.Size = New System.Drawing.Size(229, 20)
        Me.txtCitation.TabIndex = 8
        '
        'txtPubDate
        '
        Me.txtPubDate.Location = New System.Drawing.Point(39, 92)
        Me.txtPubDate.Name = "txtPubDate"
        Me.txtPubDate.Size = New System.Drawing.Size(229, 20)
        Me.txtPubDate.TabIndex = 9
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(9, 37)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(229, 20)
        Me.txtStart.TabIndex = 10
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(254, 36)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(229, 20)
        Me.txtEnd.TabIndex = 11
        '
        'txtISOLinkage
        '
        Me.txtISOLinkage.Location = New System.Drawing.Point(39, 272)
        Me.txtISOLinkage.Name = "txtISOLinkage"
        Me.txtISOLinkage.Size = New System.Drawing.Size(229, 20)
        Me.txtISOLinkage.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbxTimePeriod)
        Me.GroupBox1.Controls.Add(Me.txtISOMetadataDate)
        Me.GroupBox1.Controls.Add(Me.lblISOMetadataDate)
        Me.GroupBox1.Controls.Add(Me.txtISOTime)
        Me.GroupBox1.Controls.Add(Me.lblISOTime)
        Me.GroupBox1.Controls.Add(Me.txtISOPublishDate)
        Me.GroupBox1.Controls.Add(Me.lblISOPublishDate)
        Me.GroupBox1.Controls.Add(Me.cboUpdateFreq)
        Me.GroupBox1.Controls.Add(Me.txtISOLinkage)
        Me.GroupBox1.Controls.Add(Me.txtPubDate)
        Me.GroupBox1.Controls.Add(Me.txtCitation)
        Me.GroupBox1.Controls.Add(Me.lblISOLinkage)
        Me.GroupBox1.Controls.Add(Me.lblUpdateFreq)
        Me.GroupBox1.Controls.Add(Me.lblPubDate)
        Me.GroupBox1.Controls.Add(Me.lblCitation)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 449)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Common Metadata Elements"
        '
        'txtISOTime
        '
        Me.txtISOTime.Location = New System.Drawing.Point(39, 366)
        Me.txtISOTime.Name = "txtISOTime"
        Me.txtISOTime.Size = New System.Drawing.Size(229, 20)
        Me.txtISOTime.TabIndex = 18
        '
        'lblISOTime
        '
        Me.lblISOTime.AutoSize = True
        Me.lblISOTime.Location = New System.Drawing.Point(36, 348)
        Me.lblISOTime.Name = "lblISOTime"
        Me.lblISOTime.Size = New System.Drawing.Size(84, 13)
        Me.lblISOTime.TabIndex = 17
        Me.lblISOTime.Text = "ISO Time Period"
        '
        'txtISOPublishDate
        '
        Me.txtISOPublishDate.Location = New System.Drawing.Point(39, 320)
        Me.txtISOPublishDate.Name = "txtISOPublishDate"
        Me.txtISOPublishDate.Size = New System.Drawing.Size(229, 20)
        Me.txtISOPublishDate.TabIndex = 16
        '
        'lblISOPublishDate
        '
        Me.lblISOPublishDate.AutoSize = True
        Me.lblISOPublishDate.Location = New System.Drawing.Point(36, 302)
        Me.lblISOPublishDate.Name = "lblISOPublishDate"
        Me.lblISOPublishDate.Size = New System.Drawing.Size(106, 13)
        Me.lblISOPublishDate.TabIndex = 15
        Me.lblISOPublishDate.Text = "ISO Publication Date"
        '
        'cboUpdateFreq
        '
        Me.cboUpdateFreq.FormattingEnabled = True
        Me.cboUpdateFreq.Location = New System.Drawing.Point(39, 223)
        Me.cboUpdateFreq.Name = "cboUpdateFreq"
        Me.cboUpdateFreq.Size = New System.Drawing.Size(229, 21)
        Me.cboUpdateFreq.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 601)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 29)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ArcGIS 9.3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "ArcGIS 10"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(166, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(411, 28)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 508)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 51)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Metadata Version"
        '
        'gbxTimePeriod
        '
        Me.gbxTimePeriod.Controls.Add(Me.txtEnd)
        Me.gbxTimePeriod.Controls.Add(Me.txtStart)
        Me.gbxTimePeriod.Controls.Add(Me.lblEnd)
        Me.gbxTimePeriod.Controls.Add(Me.lblStart)
        Me.gbxTimePeriod.Location = New System.Drawing.Point(30, 126)
        Me.gbxTimePeriod.Name = "gbxTimePeriod"
        Me.gbxTimePeriod.Size = New System.Drawing.Size(496, 71)
        Me.gbxTimePeriod.TabIndex = 21
        Me.gbxTimePeriod.TabStop = False
        Me.gbxTimePeriod.Text = "Time Period"
        '
        'lblISOMetadataDate
        '
        Me.lblISOMetadataDate.AutoSize = True
        Me.lblISOMetadataDate.Location = New System.Drawing.Point(36, 393)
        Me.lblISOMetadataDate.Name = "lblISOMetadataDate"
        Me.lblISOMetadataDate.Size = New System.Drawing.Size(99, 13)
        Me.lblISOMetadataDate.TabIndex = 19
        Me.lblISOMetadataDate.Text = "ISO Metadata Date"
        '
        'txtISOMetadataDate
        '
        Me.txtISOMetadataDate.Location = New System.Drawing.Point(39, 411)
        Me.txtISOMetadataDate.Name = "txtISOMetadataDate"
        Me.txtISOMetadataDate.Size = New System.Drawing.Size(229, 20)
        Me.txtISOMetadataDate.TabIndex = 20
        '
        'frmMetadataUtil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 654)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmMetadataUtil"
        Me.Text = "HTAB Metadata Standardization Utilitty"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbxTimePeriod.ResumeLayout(False)
        Me.gbxTimePeriod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblCitation As System.Windows.Forms.Label
    Friend WithEvents lblPubDate As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblUpdateFreq As System.Windows.Forms.Label
    Friend WithEvents lblISOLinkage As System.Windows.Forms.Label
    Friend WithEvents txtCitation As System.Windows.Forms.TextBox
    Friend WithEvents txtPubDate As System.Windows.Forms.TextBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtISOLinkage As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboUpdateFreq As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtISOTime As System.Windows.Forms.TextBox
    Friend WithEvents lblISOTime As System.Windows.Forms.Label
    Friend WithEvents txtISOPublishDate As System.Windows.Forms.TextBox
    Friend WithEvents lblISOPublishDate As System.Windows.Forms.Label
    Friend WithEvents gbxTimePeriod As System.Windows.Forms.GroupBox
    Friend WithEvents lblISOMetadataDate As System.Windows.Forms.Label
    Friend WithEvents txtISOMetadataDate As System.Windows.Forms.TextBox
End Class
