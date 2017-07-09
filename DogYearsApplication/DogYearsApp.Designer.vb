<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DogYearsApp
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
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.lblDogYears = New System.Windows.Forms.Label()
        Me.lblEnterDogsAge = New System.Windows.Forms.Label()
        Me.txtEnterDogsAge = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblYourDogsAgeIs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDogsAgeCalculation = New System.Windows.Forms.Label()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDisplaysAgeFromText = New System.Windows.Forms.Label()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDog
        '
        Me.picDog.Image = Global.DogYearsApplication.My.Resources.Resources.Dog
        Me.picDog.Location = New System.Drawing.Point(14, 77)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(274, 226)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDog.TabIndex = 0
        Me.picDog.TabStop = False
        '
        'lblDogYears
        '
        Me.lblDogYears.AutoSize = True
        Me.lblDogYears.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogYears.Location = New System.Drawing.Point(151, 20)
        Me.lblDogYears.Name = "lblDogYears"
        Me.lblDogYears.Size = New System.Drawing.Size(237, 30)
        Me.lblDogYears.TabIndex = 1
        Me.lblDogYears.Text = "The Age of your Dog"
        '
        'lblEnterDogsAge
        '
        Me.lblEnterDogsAge.AutoSize = True
        Me.lblEnterDogsAge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterDogsAge.Location = New System.Drawing.Point(324, 81)
        Me.lblEnterDogsAge.Name = "lblEnterDogsAge"
        Me.lblEnterDogsAge.Size = New System.Drawing.Size(172, 19)
        Me.lblEnterDogsAge.TabIndex = 2
        Me.lblEnterDogsAge.Text = "How old is your dog?"
        '
        'txtEnterDogsAge
        '
        Me.txtEnterDogsAge.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterDogsAge.Location = New System.Drawing.Point(393, 119)
        Me.txtEnterDogsAge.Name = "txtEnterDogsAge"
        Me.txtEnterDogsAge.Size = New System.Drawing.Size(40, 26)
        Me.txtEnterDogsAge.TabIndex = 3
        Me.txtEnterDogsAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.Coral
        Me.btnCompute.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(50, 331)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(149, 32)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute Age"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblYourDogsAgeIs
        '
        Me.lblYourDogsAgeIs.AutoSize = True
        Me.lblYourDogsAgeIs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourDogsAgeIs.Location = New System.Drawing.Point(314, 169)
        Me.lblYourDogsAgeIs.Name = "lblYourDogsAgeIs"
        Me.lblYourDogsAgeIs.Size = New System.Drawing.Size(201, 38)
        Me.lblYourDogsAgeIs.TabIndex = 5
        Me.lblYourDogsAgeIs.Text = "Your dog is        years old " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and         in people years"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 6
        '
        'lblDogsAgeCalculation
        '
        Me.lblDogsAgeCalculation.AutoSize = True
        Me.lblDogsAgeCalculation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDogsAgeCalculation.Location = New System.Drawing.Point(352, 188)
        Me.lblDogsAgeCalculation.Name = "lblDogsAgeCalculation"
        Me.lblDogsAgeCalculation.Size = New System.Drawing.Size(0, 19)
        Me.lblDogsAgeCalculation.TabIndex = 7
        '
        'btClear
        '
        Me.btClear.BackColor = System.Drawing.Color.Coral
        Me.btClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClear.Location = New System.Drawing.Point(257, 331)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(87, 32)
        Me.btClear.TabIndex = 9
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Coral
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(402, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 32)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDisplaysAgeFromText
        '
        Me.lblDisplaysAgeFromText.AutoSize = True
        Me.lblDisplaysAgeFromText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplaysAgeFromText.Location = New System.Drawing.Point(407, 169)
        Me.lblDisplaysAgeFromText.Name = "lblDisplaysAgeFromText"
        Me.lblDisplaysAgeFromText.Size = New System.Drawing.Size(0, 19)
        Me.lblDisplaysAgeFromText.TabIndex = 11
        '
        'DogYearsApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 383)
        Me.Controls.Add(Me.lblDisplaysAgeFromText)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.lblDogsAgeCalculation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblYourDogsAgeIs)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtEnterDogsAge)
        Me.Controls.Add(Me.lblEnterDogsAge)
        Me.Controls.Add(Me.lblDogYears)
        Me.Controls.Add(Me.picDog)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DogYearsApp"
        Me.Text = "Calculate Dog Years"
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDog As System.Windows.Forms.PictureBox
    Friend WithEvents lblDogYears As System.Windows.Forms.Label
    Friend WithEvents lblEnterDogsAge As System.Windows.Forms.Label
    Friend WithEvents txtEnterDogsAge As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblYourDogsAgeIs As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDogsAgeCalculation As System.Windows.Forms.Label
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDisplaysAgeFromText As System.Windows.Forms.Label

End Class
