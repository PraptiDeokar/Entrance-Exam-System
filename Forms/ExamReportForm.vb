Public Class ExamReportForm
    Sub ShowExamReport()
        Dim da As New SqlDataAdapter("select * from SetExamTable", cn)
        Dim ds As New ExamListDataSet()
        da.Fill(ds, "SetExamTable")  ' da.Fill(ds,"DataTableName")

        'PubReport.rpt ===> Report file ====>BackEnd class PubReport class

        Dim rt As New ExamListCrystalReport()
        rt.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = rt


    End Sub
    Private Sub ExamReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim da As New SqlDataAdapter("select * from SetExamTable where EDate= '" & DateTimePicker1.Text & "'", cn)
        Dim ds As New ExamListDataSet()
        da.Fill(ds, "SetExamTable")  ' da.Fill(ds,"DataTableName")

        'PubReport.rpt ===> Report file ====>BackEnd class PubReport class

        Dim rt As New ExamListCrystalReport()
        rt.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = rt



    End Sub
End Class