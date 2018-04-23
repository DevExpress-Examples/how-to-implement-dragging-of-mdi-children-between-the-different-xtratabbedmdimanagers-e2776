Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace DevExpress.Samples.DocumentSelector
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			SkinManager.EnableFormSkins()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New StartForm())
		End Sub
	End Class
End Namespace