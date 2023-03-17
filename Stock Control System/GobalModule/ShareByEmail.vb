Imports System.IO
Imports System.Net
Imports System.Net.Mail

Module ShareByEmail
    Public Sub SendEmailWithDataGrid(ByVal dataGridView As DataGridView, ByVal emailTo As String, ByVal emailSubject As String, ByVal emailBody As String, ByVal attachmentFilePath As String)
        Try
            ' Create a new MailMessage object
            Dim mail As New MailMessage()

            ' Set the sender, recipient, subject and body of the email
            mail.From = New MailAddress("your-email-address@example.com")
            mail.To.Add(emailTo)
            mail.Subject = emailSubject
            mail.Body = emailBody

            ' Create a new Attachment object with the specified file path
            If attachmentFilePath <> "" Then
                Dim attachment As New Attachment(attachmentFilePath)
                mail.Attachments.Add(attachment)
            End If

            ' Create a new MemoryStream object to write the DataGridView data to
            Dim stream As New MemoryStream()
            Dim writer As New StreamWriter(stream)

            ' Write the column headers to the MemoryStream
            For i As Integer = 0 To dataGridView.ColumnCount - 1
                writer.Write(dataGridView.Columns(i).HeaderText)
                If i < dataGridView.ColumnCount - 1 Then
                    writer.Write(",")
                End If
            Next

            ' Write a new line character to the MemoryStream
            writer.WriteLine()

            ' Write the data rows to the MemoryStream
            For i As Integer = 0 To dataGridView.RowCount - 1
                For j As Integer = 0 To dataGridView.ColumnCount - 1
                    ' Add null check
                    If Not dataGridView(j, i) Is Nothing AndAlso Not dataGridView(j, i).Value Is Nothing Then
                        writer.Write(dataGridView(j, i).Value.ToString())
                    Else
                        writer.Write("")
                    End If

                    If j < dataGridView.ColumnCount - 1 Then
                        writer.Write(",")
                    End If
                Next
                writer.WriteLine()
            Next

            ' Flush the StreamWriter to the MemoryStream
            writer.Flush()

            ' Reset the MemoryStream position to the beginning
            stream.Position = 0

            ' Create a new Attachment object with the MemoryStream data
            Dim dataAttachment As New Attachment(stream, "datagridview.csv", "text/csv")
            mail.Attachments.Add(dataAttachment)

            ' Create a new SmtpClient object
            Dim smtpClient As New SmtpClient("smtp.example.com")

            ' Set the SMTP credentials and send the email
            smtpClient.Credentials = New NetworkCredential("your-username", "your-password")
            smtpClient.Send(mail)

            MessageBox.Show("Email sent successfully!")
        Catch ex As Exception
            MessageBox.Show("Failed to send email: " & ex.Message)
        End Try
    End Sub

End Module
