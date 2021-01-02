Public Class FrmEtat
    Public Sub printListFonction()
        CrystalReportViewer1.RefreshReport()
        Dim crlist As New CRListesFonction() 'variable qui contient la liste des fonctions
        CrystalReportViewer1.ReportSource = crlist
    End Sub
End Class