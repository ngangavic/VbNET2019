<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_c = New System.Windows.Forms.RadioButton()
        Me.rb_b = New System.Windows.Forms.RadioButton()
        Me.rb_a = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.tb_employee_no = New System.Windows.Forms.TextBox()
        Me.tb_employee_name = New System.Windows.Forms.TextBox()
        Me.tb_basic_salary = New System.Windows.Forms.TextBox()
        Me.tb_allowances = New System.Windows.Forms.TextBox()
        Me.tb_deduction = New System.Windows.Forms.TextBox()
        Me.tb_gloss_salary = New System.Windows.Forms.TextBox()
        Me.tb_net_salary = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salary Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Basic Salary:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_c)
        Me.GroupBox1.Controls.Add(Me.rb_b)
        Me.GroupBox1.Controls.Add(Me.rb_a)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade"
        '
        'rb_c
        '
        Me.rb_c.AutoSize = True
        Me.rb_c.Location = New System.Drawing.Point(31, 73)
        Me.rb_c.Name = "rb_c"
        Me.rb_c.Size = New System.Drawing.Size(33, 19)
        Me.rb_c.TabIndex = 2
        Me.rb_c.TabStop = True
        Me.rb_c.Text = "C"
        Me.rb_c.UseVisualStyleBackColor = True
        '
        'rb_b
        '
        Me.rb_b.AutoSize = True
        Me.rb_b.Location = New System.Drawing.Point(31, 47)
        Me.rb_b.Name = "rb_b"
        Me.rb_b.Size = New System.Drawing.Size(33, 19)
        Me.rb_b.TabIndex = 1
        Me.rb_b.TabStop = True
        Me.rb_b.Text = "B"
        Me.rb_b.UseVisualStyleBackColor = True
        '
        'rb_a
        '
        Me.rb_a.AutoSize = True
        Me.rb_a.Location = New System.Drawing.Point(31, 21)
        Me.rb_a.Name = "rb_a"
        Me.rb_a.Size = New System.Drawing.Size(32, 19)
        Me.rb_a.TabIndex = 0
        Me.rb_a.TabStop = True
        Me.rb_a.Text = "A"
        Me.rb_a.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Allowances:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Deduction:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gross Salary:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Net Salary:"
        '
        'btn_calculate
        '
        Me.btn_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.Location = New System.Drawing.Point(73, 370)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(75, 23)
        Me.btn_calculate.TabIndex = 9
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(168, 370)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(266, 370)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 11
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'tb_employee_no
        '
        Me.tb_employee_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_employee_no.Location = New System.Drawing.Point(121, 21)
        Me.tb_employee_no.Name = "tb_employee_no"
        Me.tb_employee_no.Size = New System.Drawing.Size(191, 21)
        Me.tb_employee_no.TabIndex = 12
        '
        'tb_employee_name
        '
        Me.tb_employee_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_employee_name.Location = New System.Drawing.Point(121, 57)
        Me.tb_employee_name.Name = "tb_employee_name"
        Me.tb_employee_name.Size = New System.Drawing.Size(191, 21)
        Me.tb_employee_name.TabIndex = 13
        '
        'tb_basic_salary
        '
        Me.tb_basic_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_basic_salary.Location = New System.Drawing.Point(121, 90)
        Me.tb_basic_salary.Name = "tb_basic_salary"
        Me.tb_basic_salary.Size = New System.Drawing.Size(191, 21)
        Me.tb_basic_salary.TabIndex = 14
        '
        'tb_allowances
        '
        Me.tb_allowances.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_allowances.Location = New System.Drawing.Point(121, 240)
        Me.tb_allowances.Name = "tb_allowances"
        Me.tb_allowances.Size = New System.Drawing.Size(191, 21)
        Me.tb_allowances.TabIndex = 15
        '
        'tb_deduction
        '
        Me.tb_deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_deduction.Location = New System.Drawing.Point(121, 272)
        Me.tb_deduction.Name = "tb_deduction"
        Me.tb_deduction.Size = New System.Drawing.Size(191, 21)
        Me.tb_deduction.TabIndex = 16
        '
        'tb_gloss_salary
        '
        Me.tb_gloss_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_gloss_salary.Location = New System.Drawing.Point(121, 302)
        Me.tb_gloss_salary.Name = "tb_gloss_salary"
        Me.tb_gloss_salary.Size = New System.Drawing.Size(191, 21)
        Me.tb_gloss_salary.TabIndex = 17
        '
        'tb_net_salary
        '
        Me.tb_net_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_net_salary.Location = New System.Drawing.Point(121, 330)
        Me.tb_net_salary.Name = "tb_net_salary"
        Me.tb_net_salary.Size = New System.Drawing.Size(191, 21)
        Me.tb_net_salary.TabIndex = 18
        '
        'Salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 425)
        Me.Controls.Add(Me.tb_net_salary)
        Me.Controls.Add(Me.tb_gloss_salary)
        Me.Controls.Add(Me.tb_deduction)
        Me.Controls.Add(Me.tb_allowances)
        Me.Controls.Add(Me.tb_basic_salary)
        Me.Controls.Add(Me.tb_employee_name)
        Me.Controls.Add(Me.tb_employee_no)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Salary"
        Me.Text = "Salary Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_c As RadioButton
    Friend WithEvents rb_b As RadioButton
    Friend WithEvents rb_a As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_calculate As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents tb_employee_no As TextBox
    Friend WithEvents tb_employee_name As TextBox
    Friend WithEvents tb_basic_salary As TextBox
    Friend WithEvents tb_allowances As TextBox
    Friend WithEvents tb_deduction As TextBox
    Friend WithEvents tb_gloss_salary As TextBox
    Friend WithEvents tb_net_salary As TextBox
End Class
