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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_customer_no = New System.Windows.Forms.Label()
        Me.tb_customer_no = New System.Windows.Forms.TextBox()
        Me.lb_customer_name = New System.Windows.Forms.Label()
        Me.lb_item_name = New System.Windows.Forms.Label()
        Me.lb_quantity = New System.Windows.Forms.Label()
        Me.lb_price = New System.Windows.Forms.Label()
        Me.lb_total_amount = New System.Windows.Forms.Label()
        Me.grb_payment_methods = New System.Windows.Forms.GroupBox()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_credit = New System.Windows.Forms.RadioButton()
        Me.lb_discount = New System.Windows.Forms.Label()
        Me.lb_bill_amount = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.tb_customer_name = New System.Windows.Forms.TextBox()
        Me.cb_item_name = New System.Windows.Forms.ComboBox()
        Me.tb_quantity = New System.Windows.Forms.TextBox()
        Me.tb_price = New System.Windows.Forms.TextBox()
        Me.tb_total_amount = New System.Windows.Forms.TextBox()
        Me.tb_discount = New System.Windows.Forms.TextBox()
        Me.tb_bill_amount = New System.Windows.Forms.TextBox()
        Me.grb_payment_methods.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Form"
        '
        'lb_customer_no
        '
        Me.lb_customer_no.AutoSize = True
        Me.lb_customer_no.Location = New System.Drawing.Point(13, 43)
        Me.lb_customer_no.Name = "lb_customer_no"
        Me.lb_customer_no.Size = New System.Drawing.Size(68, 13)
        Me.lb_customer_no.TabIndex = 1
        Me.lb_customer_no.Text = "Customer No"
        '
        'tb_customer_no
        '
        Me.tb_customer_no.Location = New System.Drawing.Point(107, 43)
        Me.tb_customer_no.Name = "tb_customer_no"
        Me.tb_customer_no.Size = New System.Drawing.Size(181, 20)
        Me.tb_customer_no.TabIndex = 2
        '
        'lb_customer_name
        '
        Me.lb_customer_name.AutoSize = True
        Me.lb_customer_name.Location = New System.Drawing.Point(14, 86)
        Me.lb_customer_name.Name = "lb_customer_name"
        Me.lb_customer_name.Size = New System.Drawing.Size(82, 13)
        Me.lb_customer_name.TabIndex = 3
        Me.lb_customer_name.Text = "Customer Name"
        '
        'lb_item_name
        '
        Me.lb_item_name.AutoSize = True
        Me.lb_item_name.Location = New System.Drawing.Point(16, 124)
        Me.lb_item_name.Name = "lb_item_name"
        Me.lb_item_name.Size = New System.Drawing.Size(58, 13)
        Me.lb_item_name.TabIndex = 4
        Me.lb_item_name.Text = "Item Name"
        '
        'lb_quantity
        '
        Me.lb_quantity.AutoSize = True
        Me.lb_quantity.Location = New System.Drawing.Point(16, 160)
        Me.lb_quantity.Name = "lb_quantity"
        Me.lb_quantity.Size = New System.Drawing.Size(46, 13)
        Me.lb_quantity.TabIndex = 5
        Me.lb_quantity.Text = "Quantity"
        '
        'lb_price
        '
        Me.lb_price.AutoSize = True
        Me.lb_price.Location = New System.Drawing.Point(17, 196)
        Me.lb_price.Name = "lb_price"
        Me.lb_price.Size = New System.Drawing.Size(31, 13)
        Me.lb_price.TabIndex = 6
        Me.lb_price.Text = "Price"
        '
        'lb_total_amount
        '
        Me.lb_total_amount.AutoSize = True
        Me.lb_total_amount.Location = New System.Drawing.Point(16, 227)
        Me.lb_total_amount.Name = "lb_total_amount"
        Me.lb_total_amount.Size = New System.Drawing.Size(70, 13)
        Me.lb_total_amount.TabIndex = 7
        Me.lb_total_amount.Text = "Total Amount"
        '
        'grb_payment_methods
        '
        Me.grb_payment_methods.Controls.Add(Me.rb_credit)
        Me.grb_payment_methods.Controls.Add(Me.rb_cash)
        Me.grb_payment_methods.Location = New System.Drawing.Point(52, 260)
        Me.grb_payment_methods.Name = "grb_payment_methods"
        Me.grb_payment_methods.Size = New System.Drawing.Size(200, 100)
        Me.grb_payment_methods.TabIndex = 8
        Me.grb_payment_methods.TabStop = False
        Me.grb_payment_methods.Text = "Mode of payment"
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Location = New System.Drawing.Point(81, 20)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(49, 17)
        Me.rb_cash.TabIndex = 0
        Me.rb_cash.TabStop = True
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_credit
        '
        Me.rb_credit.AutoSize = True
        Me.rb_credit.Location = New System.Drawing.Point(81, 44)
        Me.rb_credit.Name = "rb_credit"
        Me.rb_credit.Size = New System.Drawing.Size(52, 17)
        Me.rb_credit.TabIndex = 1
        Me.rb_credit.TabStop = True
        Me.rb_credit.Text = "Credit"
        Me.rb_credit.UseVisualStyleBackColor = True
        '
        'lb_discount
        '
        Me.lb_discount.AutoSize = True
        Me.lb_discount.Location = New System.Drawing.Point(22, 383)
        Me.lb_discount.Name = "lb_discount"
        Me.lb_discount.Size = New System.Drawing.Size(49, 13)
        Me.lb_discount.TabIndex = 10
        Me.lb_discount.Text = "Discount"
        '
        'lb_bill_amount
        '
        Me.lb_bill_amount.AutoSize = True
        Me.lb_bill_amount.Location = New System.Drawing.Point(22, 413)
        Me.lb_bill_amount.Name = "lb_bill_amount"
        Me.lb_bill_amount.Size = New System.Drawing.Size(59, 13)
        Me.lb_bill_amount.TabIndex = 11
        Me.lb_bill_amount.Text = "Bill Amount"
        '
        'btn_calculate
        '
        Me.btn_calculate.Location = New System.Drawing.Point(38, 450)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(75, 23)
        Me.btn_calculate.TabIndex = 12
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(145, 449)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(250, 449)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 14
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'tb_customer_name
        '
        Me.tb_customer_name.Location = New System.Drawing.Point(107, 86)
        Me.tb_customer_name.Name = "tb_customer_name"
        Me.tb_customer_name.Size = New System.Drawing.Size(181, 20)
        Me.tb_customer_name.TabIndex = 15
        '
        'cb_item_name
        '
        Me.cb_item_name.FormattingEnabled = True
        Me.cb_item_name.Location = New System.Drawing.Point(107, 124)
        Me.cb_item_name.Name = "cb_item_name"
        Me.cb_item_name.Size = New System.Drawing.Size(181, 21)
        Me.cb_item_name.TabIndex = 16
        '
        'tb_quantity
        '
        Me.tb_quantity.Location = New System.Drawing.Point(107, 160)
        Me.tb_quantity.Name = "tb_quantity"
        Me.tb_quantity.Size = New System.Drawing.Size(181, 20)
        Me.tb_quantity.TabIndex = 17
        '
        'tb_price
        '
        Me.tb_price.Location = New System.Drawing.Point(107, 188)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.Size = New System.Drawing.Size(181, 20)
        Me.tb_price.TabIndex = 18
        '
        'tb_total_amount
        '
        Me.tb_total_amount.Location = New System.Drawing.Point(107, 224)
        Me.tb_total_amount.Name = "tb_total_amount"
        Me.tb_total_amount.Size = New System.Drawing.Size(181, 20)
        Me.tb_total_amount.TabIndex = 19
        '
        'tb_discount
        '
        Me.tb_discount.Location = New System.Drawing.Point(107, 379)
        Me.tb_discount.Name = "tb_discount"
        Me.tb_discount.Size = New System.Drawing.Size(181, 20)
        Me.tb_discount.TabIndex = 20
        '
        'tb_bill_amount
        '
        Me.tb_bill_amount.Location = New System.Drawing.Point(107, 410)
        Me.tb_bill_amount.Name = "tb_bill_amount"
        Me.tb_bill_amount.Size = New System.Drawing.Size(181, 20)
        Me.tb_bill_amount.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 511)
        Me.Controls.Add(Me.tb_bill_amount)
        Me.Controls.Add(Me.tb_discount)
        Me.Controls.Add(Me.tb_total_amount)
        Me.Controls.Add(Me.tb_price)
        Me.Controls.Add(Me.tb_quantity)
        Me.Controls.Add(Me.cb_item_name)
        Me.Controls.Add(Me.tb_customer_name)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.lb_bill_amount)
        Me.Controls.Add(Me.lb_discount)
        Me.Controls.Add(Me.grb_payment_methods)
        Me.Controls.Add(Me.lb_total_amount)
        Me.Controls.Add(Me.lb_price)
        Me.Controls.Add(Me.lb_quantity)
        Me.Controls.Add(Me.lb_item_name)
        Me.Controls.Add(Me.lb_customer_name)
        Me.Controls.Add(Me.tb_customer_no)
        Me.Controls.Add(Me.lb_customer_no)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grb_payment_methods.ResumeLayout(False)
        Me.grb_payment_methods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lb_customer_no As Label
    Friend WithEvents tb_customer_no As TextBox
    Friend WithEvents lb_customer_name As Label
    Friend WithEvents lb_item_name As Label
    Friend WithEvents lb_quantity As Label
    Friend WithEvents lb_price As Label
    Friend WithEvents lb_total_amount As Label
    Friend WithEvents grb_payment_methods As GroupBox
    Friend WithEvents rb_credit As RadioButton
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents lb_discount As Label
    Friend WithEvents lb_bill_amount As Label
    Friend WithEvents btn_calculate As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents tb_customer_name As TextBox
    Friend WithEvents cb_item_name As ComboBox
    Friend WithEvents tb_quantity As TextBox
    Friend WithEvents tb_price As TextBox
    Friend WithEvents tb_total_amount As TextBox
    Friend WithEvents tb_discount As TextBox
    Friend WithEvents tb_bill_amount As TextBox
End Class
