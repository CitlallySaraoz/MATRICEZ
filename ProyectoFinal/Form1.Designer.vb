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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnSumar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.Btnrestar = New System.Windows.Forms.Button()
        Me.BtnMulti = New System.Windows.Forms.Button()
        Me.Btndividir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvMatrizR = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvMatrizB = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvMatrizA = New System.Windows.Forms.DataGridView()
        Me.GbxDefinir = New System.Windows.Forms.GroupBox()
        Me.Btnplicar = New System.Windows.Forms.Button()
        Me.TxtFila = New System.Windows.Forms.TextBox()
        Me.Txtcolumna = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvMatrizR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvMatrizB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvMatrizA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxDefinir.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnSumar)
        Me.GroupBox4.Controls.Add(Me.Btnsalir)
        Me.GroupBox4.Controls.Add(Me.BtnBorrar)
        Me.GroupBox4.Controls.Add(Me.Btnrestar)
        Me.GroupBox4.Controls.Add(Me.BtnMulti)
        Me.GroupBox4.Controls.Add(Me.Btndividir)
        Me.GroupBox4.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(511, 363)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(567, 189)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Elejir"
        '
        'BtnSumar
        '
        Me.BtnSumar.Enabled = False
        Me.BtnSumar.Location = New System.Drawing.Point(15, 37)
        Me.BtnSumar.Name = "BtnSumar"
        Me.BtnSumar.Size = New System.Drawing.Size(94, 44)
        Me.BtnSumar.TabIndex = 7
        Me.BtnSumar.Text = "Sumar"
        Me.BtnSumar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(406, 123)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(94, 39)
        Me.Btnsalir.TabIndex = 11
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Enabled = False
        Me.BtnBorrar.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBorrar.Location = New System.Drawing.Point(406, 37)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(94, 44)
        Me.BtnBorrar.TabIndex = 12
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Btnrestar
        '
        Me.Btnrestar.Enabled = False
        Me.Btnrestar.Location = New System.Drawing.Point(15, 118)
        Me.Btnrestar.Name = "Btnrestar"
        Me.Btnrestar.Size = New System.Drawing.Size(94, 44)
        Me.Btnrestar.TabIndex = 8
        Me.Btnrestar.Text = "Restar"
        Me.Btnrestar.UseVisualStyleBackColor = True
        '
        'BtnMulti
        '
        Me.BtnMulti.Enabled = False
        Me.BtnMulti.Location = New System.Drawing.Point(165, 37)
        Me.BtnMulti.Name = "BtnMulti"
        Me.BtnMulti.Size = New System.Drawing.Size(163, 44)
        Me.BtnMulti.TabIndex = 9
        Me.BtnMulti.Text = "Multiplicar"
        Me.BtnMulti.UseVisualStyleBackColor = True
        '
        'Btndividir
        '
        Me.Btndividir.Enabled = False
        Me.Btndividir.Location = New System.Drawing.Point(188, 118)
        Me.Btndividir.Name = "Btndividir"
        Me.Btndividir.Size = New System.Drawing.Size(113, 44)
        Me.Btndividir.TabIndex = 10
        Me.Btndividir.Text = "Dividir"
        Me.Btndividir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvMatrizR)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(758, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 236)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Respuesta"
        '
        'DgvMatrizR
        '
        Me.DgvMatrizR.AllowUserToAddRows = False
        Me.DgvMatrizR.AllowUserToDeleteRows = False
        Me.DgvMatrizR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMatrizR.Location = New System.Drawing.Point(20, 26)
        Me.DgvMatrizR.Name = "DgvMatrizR"
        Me.DgvMatrizR.ReadOnly = True
        Me.DgvMatrizR.RowHeadersWidth = 51
        Me.DgvMatrizR.RowTemplate.Height = 29
        Me.DgvMatrizR.Size = New System.Drawing.Size(300, 188)
        Me.DgvMatrizR.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvMatrizB)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 236)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Matriz B"
        '
        'DgvMatrizB
        '
        Me.DgvMatrizB.AllowUserToAddRows = False
        Me.DgvMatrizB.AllowUserToDeleteRows = False
        Me.DgvMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMatrizB.Location = New System.Drawing.Point(29, 26)
        Me.DgvMatrizB.Name = "DgvMatrizB"
        Me.DgvMatrizB.RowHeadersWidth = 51
        Me.DgvMatrizB.RowTemplate.Height = 29
        Me.DgvMatrizB.Size = New System.Drawing.Size(300, 188)
        Me.DgvMatrizB.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvMatrizA)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 236)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Matriz A"
        '
        'DgvMatrizA
        '
        Me.DgvMatrizA.AllowUserToAddRows = False
        Me.DgvMatrizA.AllowUserToDeleteRows = False
        Me.DgvMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMatrizA.Location = New System.Drawing.Point(14, 26)
        Me.DgvMatrizA.Name = "DgvMatrizA"
        Me.DgvMatrizA.RowHeadersWidth = 51
        Me.DgvMatrizA.RowTemplate.Height = 29
        Me.DgvMatrizA.Size = New System.Drawing.Size(300, 188)
        Me.DgvMatrizA.TabIndex = 0
        '
        'GbxDefinir
        '
        Me.GbxDefinir.Controls.Add(Me.Btnplicar)
        Me.GbxDefinir.Controls.Add(Me.TxtFila)
        Me.GbxDefinir.Controls.Add(Me.Txtcolumna)
        Me.GbxDefinir.Controls.Add(Me.Label2)
        Me.GbxDefinir.Controls.Add(Me.Label1)
        Me.GbxDefinir.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GbxDefinir.Location = New System.Drawing.Point(23, 363)
        Me.GbxDefinir.Name = "GbxDefinir"
        Me.GbxDefinir.Size = New System.Drawing.Size(408, 189)
        Me.GbxDefinir.TabIndex = 14
        Me.GbxDefinir.TabStop = False
        Me.GbxDefinir.Text = "Definir"
        '
        'Btnplicar
        '
        Me.Btnplicar.Location = New System.Drawing.Point(269, 70)
        Me.Btnplicar.Name = "Btnplicar"
        Me.Btnplicar.Size = New System.Drawing.Size(109, 38)
        Me.Btnplicar.TabIndex = 4
        Me.Btnplicar.Text = "Aplicar"
        Me.Btnplicar.UseVisualStyleBackColor = True
        '
        'TxtFila
        '
        Me.TxtFila.Location = New System.Drawing.Point(127, 100)
        Me.TxtFila.Name = "TxtFila"
        Me.TxtFila.Size = New System.Drawing.Size(125, 35)
        Me.TxtFila.TabIndex = 3
        '
        'Txtcolumna
        '
        Me.Txtcolumna.Location = New System.Drawing.Point(127, 46)
        Me.Txtcolumna.Name = "Txtcolumna"
        Me.Txtcolumna.Size = New System.Drawing.Size(125, 35)
        Me.Txtcolumna.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fila"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Columna"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 593)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbxDefinir)
        Me.Name = "Form1"
        Me.Text = "Matriz"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvMatrizR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvMatrizB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvMatrizA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxDefinir.ResumeLayout(False)
        Me.GbxDefinir.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnSumar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents Btnrestar As Button
    Friend WithEvents BtnMulti As Button
    Friend WithEvents Btndividir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvMatrizR As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvMatrizB As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvMatrizA As DataGridView
    Friend WithEvents GbxDefinir As GroupBox
    Friend WithEvents Btnplicar As Button
    Friend WithEvents TxtFila As TextBox
    Friend WithEvents Txtcolumna As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
