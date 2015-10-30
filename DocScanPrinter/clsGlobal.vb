Public Class clsGlobal
    Public ApplicationName As String = "DocScanPrinter"
    Public ApplicationVersion As String = "1.5"
    Public Site As String = System.Configuration.ConfigurationManager.AppSettings("Site")
    Public Department As String = System.Configuration.ConfigurationManager.AppSettings("Department")

    Public PharmacyQueueMode As String = System.Configuration.ConfigurationManager.AppSettings("PharmacyQueueMode")
    Public PharmacyQueuePriorityBuilder As String = System.Configuration.ConfigurationManager.AppSettings("PharmacyQueuePriorityBuilder")
    Public PharmacyQueuePriorityCounterBuilder As String = System.Configuration.ConfigurationManager.AppSettings("PharmacyQueuePriorityCounterBuilder")
    Public PrintTimeBuilder As String = System.Configuration.ConfigurationManager.AppSettings("PrintTimeBuilder")

    Public DrawFontName As String = System.Configuration.ConfigurationManager.AppSettings("DrawFontName")
    Public DrawFontSize As Single = System.Configuration.ConfigurationManager.AppSettings("DrawFontSize")
    Public DrawPosition As String = System.Configuration.ConfigurationManager.AppSettings("DrawPosition")
End Class
