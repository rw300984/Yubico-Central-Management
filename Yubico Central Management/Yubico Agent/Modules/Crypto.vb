Module Crypto
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Dim ciphertext As String = ""
        Try
            AES.GenerateIV()
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            AES.Mode = Security.Cryptography.CipherMode.CBC
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            ciphertext = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return Convert.ToBase64String(AES.IV) & Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            '  Return ex.Message
        End Try
    End Function
    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Dim plaintext As String = ""
        Dim iv As String = ""
        Try
            Dim ivct = input.Split({"=="}, StringSplitOptions.None)
            iv = ivct(0) & "=="
            input = If(ivct.Length = 3, ivct(1) & "==", ivct(1))
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            AES.IV = Convert.FromBase64String(iv)
            AES.Mode = Security.Cryptography.CipherMode.CBC
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            plaintext = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return plaintext
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
            ' Return ex.Message
        End Try
    End Function

    Public Function SHA512FileHash(ByVal File As String) As String
        Try
            Dim SHA1 As New System.Security.Cryptography.SHA512CryptoServiceProvider
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
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function SHA512StringHash(ByVal text As String) As String
        Try
            Dim SHA1 As New System.Security.Cryptography.SHA512CryptoServiceProvider
            Dim Hash As Byte()
            Dim Result As String = ""
            Dim Tmp As String = ""
            Dim data As Byte() = System.Text.Encoding.ASCII.GetBytes(text)
            SHA1.ComputeHash(data)
            Hash = SHA1.Hash
            For i As Integer = 0 To Hash.Length - 1
                Tmp = Hex(Hash(i))
                If Len(Tmp) = 1 Then Tmp = "0" & Tmp
                Result += Tmp
            Next
            Return Result
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function ValidatePassword(ByVal pwd As String, Optional ByVal minLength As Integer = 8, Optional ByVal numUpper As Integer = 1, Optional ByVal numLower As Integer = 3, Optional ByVal numNumbers As Integer = 2, Optional ByVal numSpecial As Integer = 1) As Boolean
        Try
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
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Function
    Public Function GeneratePassword(ByVal length As Byte) As String
        Try
            Dim RawChars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuwvxyz!§$%&/()=?*':;,.-_><@"
            Dim str As New System.Text.StringBuilder
            Do Until ValidatePassword(str.ToString) = True
                str.Clear()
                For t As Byte = 1 To length 'length of req key
                    Dim xx As Integer
                    Randomize()
                    xx = Rnd() * (Len(RawChars) - 1) 'number of rawchars
                    str.Append(RawChars.Trim.Chars(xx))
                Next
            Loop
            Return str.ToString
        Catch ex As Exception
            plg_debuglog.WriteLog(ex.Message, 4, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try

    End Function
End Module
