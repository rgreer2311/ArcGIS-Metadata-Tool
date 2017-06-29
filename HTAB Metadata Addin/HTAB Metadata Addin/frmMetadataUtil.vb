Imports ESRI.ArcGIS.CatalogUI
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Catalog
Imports System.Windows.Forms
Imports ESRI.ArcGIS.Geodatabase

Public Class frmMetadataUtil

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        '********************************************************************************
        'Author: Roger Greer
        'Date: 04 September 2012
        'Description: This program standardizes common metadata elements in selected shapefile(s).
        '             A windows form is presented to the user for entry of common metadata elements. 
        '             Upon execution the shapefile(s) XML is updated with the user input.         
        '             
        'Calls: None
        'Called By: HTABMetadata.vb
        '********************************************************************************
        Try
            Dim pGxApp As IGxApplication
            Dim pGxSelection As IGxSelection
            Dim pGxobj As IGxObject
            Dim pgxView As IGxView
            Dim pEnumGx As IEnumGxObject
            Dim pMD As IMetadata
            Dim pPS As IPropertySet
            Dim pXPS As IXmlPropertySet

            pGxApp = My.ArcCatalog.ThisApplication
            pgxView = pGxApp.View
            pGxSelection = pGxApp.Selection

            'Test for a selection
            If pGxSelection.Count = 0 Then
                MsgBox("Layer(s) not selected", vbCritical, "HTAB Metadata Standardization Utility")
                Exit Sub
            End If

            'Loop through selection
            pEnumGx = pGxSelection.SelectedObjects
            pGxobj = pEnumGx.Next

            'ArcGIS 9.3
            If RadioButton1.Checked = True Then
                Do While Not pGxobj Is Nothing
                    pMD = pGxobj
                    pPS = pMD.Metadata
                    pXPS = pPS

                    pXPS.DeleteProperty("Esri/DataProperties/lineage")
                    pXPS.DeleteProperty("dataqual/lineage/procstep") ' Deletes process steps
                    pXPS.SetPropertyX("Esri/Synonce", "True", esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("idinfo/citation/citeinfo/onlink", txtCitation.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("idinfo/citation/citeinfo/pubdate", txtPubDate.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("idinfo/timeperd/timeinfo/rngdates/begdate", txtStart.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("idinfo/timeperd/timeinfo/rngdates/enddate", txtEnd.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("idinfo/status/update", cboUpdateFreq.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("metainfo/metd", txtISOMetadataDate.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("distinfo/distributor/distorTran/onlineSrc/linkage", txtISOLinkage.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("distlnfo/resMaint/dateNext", txtISOPublishDate.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    pXPS.SetPropertyX("distlnfo/dateExt/TempEle/tempExtent/exTemp/TM_GeometricPrimative/TM_Period/end", txtISOTime.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                    'Save changes
                    pMD.Metadata = pPS
                    pGxobj = pEnumGx.Next
                Loop

                Dim myResponse As String
                myResponse = MsgBox("Elements updated for selected shapefile(s)", vbOK + vbExclamation + vbDefaultButton2, "HTAB Metadata Standardization Utility")

            End If

            'ArcGIS 10
            If RadioButton2.Checked = True Then

                Dim metaCheck As String
                metaCheck = MsgBox("Has Metadata been updated to ArcGIS 10 standard?", vbYesNo + vbExclamation + vbDefaultButton2, "HTAB Metadata Standardization Utility")

                If metaCheck = vbYes Then
                    Do While Not pGxobj Is Nothing
                        pMD = pGxobj
                        pPS = pMD.Metadata
                        pXPS = pPS

                        pXPS.DeleteProperty("Esri/DataProperties/lineage")
                        pXPS.DeleteProperty("dataqual/lineage/procstep") ' Deletes process steps
                        pXPS.SetPropertyX("Esri/Synonce", "True", esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("idinfo/citation/citeinfo/onlink", txtCitation.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("idinfo/citation/citeinfo/pubdate", txtPubDate.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("idinfo/timeperd/timeinfo/rngdates/begdate", txtStart.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("idinfo/timeperd/timeinfo/rngdates/enddate", txtEnd.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("idinfo/status/update", cboUpdateFreq.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("metainfo/metd", txtISOMetadataDate.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("distinfo/distributor/distorTran/onlineSrc/linkage", txtISOLinkage.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("distlnfo/resMaint/dateNext", txtISOPublishDate.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        pXPS.SetPropertyX("distlnfo/dateExt/TempEle/tempExtent/exTemp/TM_GeometricPrimative/TM_Period/end", txtISOTime.Text, esriXmlPropertyType.esriXPTText, esriXmlSetPropertyAction.esriXSPAAddOrReplace, False)
                        'Save changes
                        pMD.Metadata = pPS
                        pGxobj = pEnumGx.Next
                    Loop

                    Dim myResponse As String
                    myResponse = MsgBox("Elements updated for selected shapefile(s)", vbOK + vbExclamation + vbDefaultButton2, "HTAB Metadata Standardization Utility")

                ElseIf metaCheck = vbNo Then
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox("Unknow Error has occurred!", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Exit application
        Me.Close()
    End Sub

    Private Sub frmMetadataUtil_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Populate text and combo boxes 
        Dim myDate As Date = Date.Now

        RadioButton1.Checked = True
        txtCitation.Text = "http://"
        txtPubDate.Text = "N/A"
        txtStart.Text = "1962"
        txtEnd.Text = (Format(myDate, "M/dd/yyyy"))
        cboUpdateFreq.Items.Add("Annually")
        cboUpdateFreq.Items.Add("As Needed")
        cboUpdateFreq.Items.Add("Continually")
        cboUpdateFreq.Items.Add("Daily")
        cboUpdateFreq.Items.Add("Irregular")
        cboUpdateFreq.Items.Add("Monthly")
        cboUpdateFreq.Items.Add("Not Planned")
        cboUpdateFreq.Items.Add("Quarterly")
        cboUpdateFreq.Items.Add("Unknown")
        cboUpdateFreq.Items.Add("Weekly")
        txtISOPublishDate.Text = (Format(myDate, "M/dd/yyyy"))
        txtISOLinkage.Text = "http://"
        txtISOTime.Text = (Format(myDate, "M/dd/yyyy"))
        txtISOMetadataDate.Text = (Format(myDate, "M/dd/yyyy"))
    End Sub
End Class