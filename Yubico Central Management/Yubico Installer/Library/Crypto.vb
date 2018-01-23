Imports System.Text

Module Crypto
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
    Public Function SHA1FileHash(ByVal File As String) As String
        Dim SHA1 As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim Hash As Byte()
        Dim Result As String = ""
        Dim Tmp As String = ""
        Dim FN As New System.IO.FileStream(File, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read, 8192)
        SHA1.ComputeHash(FN)
        FN.Close()
        Hash = SHA1.Hash
        For i As Integer = 0 To Hash.Length - 1
            Tmp = Hex(Hash(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function
    Public Function ValidatePassword(ByVal pwd As String, Optional ByVal minLength As Integer = 8, Optional ByVal numUpper As Integer = 1, Optional ByVal numLower As Integer = 3, Optional ByVal numNumbers As Integer = 2, Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function
    Public Function GeneratePassword(ByVal length As Byte) As String
        Dim RawChars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuwvxyz!§$%&/()=?*':;,.-_><@"
        Dim str As New System.Text.StringBuilder
        For t As Byte = 1 To length 'length of req key
            Dim xx As Integer
            Randomize()
            xx = Rnd() * (Len(RawChars) - 1) 'number of rawchars
            str.Append(RawChars.Trim.Chars(xx))
        Next
        Return str.ToString
    End Function
End Module
