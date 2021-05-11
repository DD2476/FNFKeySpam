<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spm
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
        Me.left = New System.Windows.Forms.Timer(Me.components)
        Me.always = New System.Windows.Forms.Timer(Me.components)
        Me.prp = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.down = New System.Windows.Forms.Timer(Me.components)
        Me.up = New System.Windows.Forms.Timer(Me.components)
        Me.right = New System.Windows.Forms.Timer(Me.components)
        CType(Me.prp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'left
        '
        Me.left.Enabled = True
        Me.left.Interval = 1
        '
        'always
        '
        Me.always.Enabled = True
        Me.always.Interval = 1
        '
        'prp
        '
        Me.prp.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.prp.Image = Global.FNFKeySpam.My.Resources.Resources.disabled
        Me.prp.Location = New System.Drawing.Point(415, 101)
        Me.prp.Name = "prp"
        Me.prp.Size = New System.Drawing.Size(122, 47)
        Me.prp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.prp.TabIndex = 3
        Me.prp.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FNFKeySpam.My.Resources.Resources.b5f1231d7cb0379cb30448bf13d69175
        Me.PictureBox3.Location = New System.Drawing.Point(187, 101)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(222, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FNFKeySpam.My.Resources.Resources._755edc3bb024c5ef078813f3db384a1f
        Me.PictureBox2.Location = New System.Drawing.Point(143, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(455, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FNFKeySpam.My.Resources.Resources.Boyfriend_FNF_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'down
        '
        Me.down.Enabled = True
        Me.down.Interval = 1
        '
        'up
        '
        Me.up.Enabled = True
        Me.up.Interval = 1
        '
        'right
        '
        Me.right.Enabled = True
        Me.right.Interval = 1
        '
        'spm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 162)
        Me.Controls.Add(Me.prp)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "spm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FNF Key Spammer"
        Me.TopMost = True
        CType(Me.prp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents prp As PictureBox
    Friend WithEvents left As Timer
    Friend WithEvents always As Timer
    Friend WithEvents down As Timer
    Friend WithEvents up As Timer
    Friend WithEvents right As Timer
End Class
