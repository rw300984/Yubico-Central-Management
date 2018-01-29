Module plg_ykinv
    Public Structure dt_serial
        Dim dt As DataTable
        Dim Serial As String
        Dim GUID As String
        Dim Name As String
    End Structure

    Public cfg_ykinv As dt_serial

    ' Public cfg_ykinv As dt_serial

    Public Function Serial_ReadXMLtoDT(ByVal xmlfile As String) As DataTable
        Dim dt As New DataTable
        dt.ReadXml(xmlfile)
        Return dt
    End Function
    Public Function Serial_WriteDTtoXML(ByVal xmlfile As String, ByVal dt As DataTable)
        Try

            dt.WriteXml(xmlfile, XmlWriteMode.WriteSchema)
        Catch ex As Exception

        End Try

    End Function
    Public Function Serial_CreateDataTable(ByVal dt As DataTable) As DataTable
        dt.TableName = "SerialNumbers"
        dt.Columns.Add("Serial", GetType(String))
        dt.Columns.Add("GUID", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.AcceptChanges()
        Return dt
    End Function
    Public Function Serial_ExistInDT(ByVal dt As DataTable, ByVal serial As String) As Boolean
        '  MessageBox.Show(serial)
        Dim rows As DataRow() = dt.Select("Serial = " & serial)
        '  MessageBox.Show("here func existsinDT 1")
        If rows.Length > 0 Then
            '     MessageBox.Show("here func existsinDT 2")
            Return True
        Else
            '    MessageBox.Show("here func existsinDT 3")
            Return False
        End If
    End Function
    Public Function Serial_AddToDatabase(ByVal dt As DataTable, ByVal Serial As String)
        dt.Rows.Add(Serial, Guid.NewGuid.ToString, "")
        dt.AcceptChanges()
    End Function
    Public Function Serial_AddName(ByVal dt As DataTable, ByVal serial As String, ByVal name As String) As Boolean
        Try
            Dim rows As DataRow() = dt.Select("Serial = " & serial)
            For Each row In rows
                row("Name") = name
            Next

            dt.AcceptChanges()

            cfg_ykinv.dt = dt
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function
    Public Function Serial_GetYubiKey(ByVal dt As DataTable, ByVal serial As String) As dt_serial
        Try
            Dim ret_dt_serial As dt_serial
            Dim rows As DataRow() = dt.Select("Serial = " & serial)
            For Each row In rows
                ret_dt_serial.Serial = row("Serial")
                ret_dt_serial.GUID = row("GUID")
                ret_dt_serial.Name = row("Name")
            Next
            Return ret_dt_serial
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
