Public Class Form1

    Dim columna, fila As Byte

    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click
        Dim i, j As Byte
        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.DgvMatrizR.Rows(i).Cells(j).Value = Val(Me.DgvMatrizA.Rows(i).Cells(j).Value) + Val(Me.DgvMatrizB.Rows(i).Cells(j).Value)


            Next
        Next
    End Sub

    Private Sub Btnrestar_Click(sender As Object, e As EventArgs) Handles Btnrestar.Click
        Dim i, j As Byte
        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.DgvMatrizR.Rows(i).Cells(j).Value = Val(Me.DgvMatrizA.Rows(i).Cells(j).Value) - Val(Me.DgvMatrizB.Rows(i).Cells(j).Value)


            Next
        Next
    End Sub

    Private Sub BtnMulti_Click(sender As Object, e As EventArgs) Handles BtnMulti.Click
        Dim i, j As Byte
        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.DgvMatrizR.Rows(i).Cells(j).Value = Val(Me.DgvMatrizA.Rows(i).Cells(j).Value) * Val(Me.DgvMatrizB.Rows(i).Cells(j).Value)


            Next
        Next
    End Sub

    Private Sub Btndividir_Click(sender As Object, e As EventArgs) Handles Btndividir.Click
        Dim i, j As Byte
        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.DgvMatrizR.Rows(i).Cells(j).Value = Val(Me.DgvMatrizA.Rows(i).Cells(j).Value) / Val(Me.DgvMatrizB.Rows(i).Cells(j).Value)


            Next
        Next
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim i, j As Byte
        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.DgvMatrizR.Rows(i).Cells(j).Value = ""
                Me.DgvMatrizA.Rows(i).Cells(j).Value = ""
                Me.DgvMatrizB.Rows(i).Cells(j).Value = ""


            Next
        Next
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Btnplicar_Click(sender As Object, e As EventArgs) Handles Btnplicar.Click
        Dim i As Byte
        columna = Val(Me.Txtcolumna.Text)
        fila = Val(Me.TxtFila.Text)

        Me.DgvMatrizA.ColumnCount = columna
        Me.DgvMatrizA.RowCount = fila
        Me.DgvMatrizA.RowHeadersWidth = 70

        Me.DgvMatrizB.ColumnCount = columna
        Me.DgvMatrizB.RowCount = fila
        Me.DgvMatrizB.RowHeadersWidth = 70

        Me.DgvMatrizR.ColumnCount = columna
        Me.DgvMatrizR.RowCount = fila
        Me.DgvMatrizR.RowHeadersWidth = 70

        For i = 0 To columna - 1
            Me.DgvMatrizA.Columns(i).Width = 40
            Me.DgvMatrizB.Columns(i).Width = 40
            Me.DgvMatrizR.Columns(i).Width = 40

            Me.DgvMatrizA.Columns(i).HeaderText = i + 1
            Me.DgvMatrizB.Columns(i).HeaderText = i + 1
            Me.DgvMatrizR.Columns(i).HeaderText = i + 1

        Next

        For i = 0 To fila - 1
            Me.DgvMatrizA.Rows(i).HeaderCell.Value = (i + 1).ToString
            Me.DgvMatrizB.Rows(i).HeaderCell.Value = (i + 1).ToString
            Me.DgvMatrizR.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next

        Me.BtnSumar.Enabled = True
        Me.Btnrestar.Enabled = True
        Me.BtnMulti.Enabled = True
        Me.Btndividir.Enabled = True
        Me.BtnBorrar.Enabled = True




    End Sub
End Class
