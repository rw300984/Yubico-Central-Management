﻿Module Crypto
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Try
            If input Is Nothing Or input = "" Then
                Return ""
            Else
                Dim AES As New System.Security.Cryptography.RijndaelManaged
                Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim encrypted As String = ""
                Dim hash(31) As Byte
                Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
                Array.Copy(temp, 0, hash, 0, 16)
                Array.Copy(temp, 0, hash, 15, 16)
                AES.Key = hash
                AES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
                Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
                encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
                Return encrypted
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Try
            If input Is Nothing Or input = "" Then
                Return ""
            Else
                Dim AES As New System.Security.Cryptography.RijndaelManaged
                Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim decrypted As String = ""
                Dim hash(31) As Byte
                Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
                Array.Copy(temp, 0, hash, 0, 16)
                Array.Copy(temp, 0, hash, 15, 16)
                AES.Key = hash
                AES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
                Dim Buffer As Byte() = Convert.FromBase64String(input)
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
                Return decrypted
            End If
        Catch ex As Exception
        End Try
    End Function
    Public Function MD5FileHash(ByVal File As String) As String
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim Hash As Byte()
        Dim Result As String = ""
        Dim Tmp As String = ""
        Dim FN As New System.IO.FileStream(File, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read, 8192)
        MD5.ComputeHash(FN)
        FN.Close()
        Hash = MD5.Hash
        For i As Integer = 0 To Hash.Length - 1
            Tmp = Hex(Hash(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function
End Module