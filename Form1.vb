Public Class Form1
    Dim Count As Integer = 0

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.ContactsDataSet.Table)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TableBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.TableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TableBindingSource.RemoveCurrent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Count = TableBindingSource.Count

        If CBool(CInt(Count > 1) And 2) Then
            Button4.Visible = True
            Button5.Visible = True
        End If
        If CBool(CInt(Count <= 1) And 2) Then
            Button4.Visible = False
            Button5.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TableBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TableBindingSource.MovePrevious()
    End Sub

    Private Sub LastNameToolStripButton_Click(sender As Object, e As EventArgs) Handles LastNameToolStripButton.Click
        Try
            Me.TableTableAdapter.LastName(Me.ContactsDataSet.Table, LastNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LastNameToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles LastNameToolStrip.ItemClicked

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TableDataGridView.ClearSelection()
        LastNameToolStripTextBox.Clear()
        ContactsDataSet.Clear()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click



    End Sub
End Class
