'This class allows you to handle specific events on the settings class:
' The SettingChanging event is raised before a setting's value is changed.
' The PropertyChanged event is raised after a setting's value is changed.
' The SettingsLoaded event is raised after the setting values are loaded.
' The SettingsSaving event is raised before the setting values are saved.

Imports System.ComponentModel

Partial Friend NotInheritable Class MySettings
    Protected Overrides Sub OnSettingsSaving(sender As Object, e As CancelEventArgs)
        ''got this idea from 
        ''https://social.msdn.microsoft.com/Forums/en-US/7483b816-be7a-4204-a4d3-cfb14b2aae26/how-to-dynamically-change-connection-string-in-generated-dataset-class?forum=adodotnetdataset
        ''This handles making sure that the database connection string does not have hard coded passwords and usernames for security and future proofing
        MyBase.OnSettingsSaving(sender, e)
        Me.Item("masterConnection") = "Data Source=mediaministry.database.windows.net;Initial Catalog=""Media Ministry"";Persist Security Info=True;Encrypt=True;User ID=" & CType(Me.Item("Username"), String) & ";Password=" & CType(Me.Item("Password"), String)
    End Sub
End Class