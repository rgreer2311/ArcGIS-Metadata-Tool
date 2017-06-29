Imports System.Windows.Forms

Public Class HTABMetadata
    '********************************************************************************
    'Author: Roger Greer
    'Date: 04 September 2012
    'Description: This button calls the HTAB Metadata Standardization Utility.       
    'Calls: frmMetadataUtil.vb
    'Called By: None
    '********************************************************************************

    Inherits ESRI.ArcGIS.Desktop.AddIns.Button

    Public Sub New()

    End Sub

    Protected Overrides Sub OnClick()
        '
        '  TODO: Sample code showing how to access button host
        '
        My.ArcCatalog.Application.CurrentTool = Nothing

        Dim Form As frmMetadataUtil = New frmMetadataUtil
        Form.Show()

    End Sub

    Protected Overrides Sub OnUpdate()
        Enabled = My.ArcCatalog.Application IsNot Nothing
    End Sub
    Private Sub UserForm_lnitialize()

    End Sub

End Class
