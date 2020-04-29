'This class allows you to handle specific events on the settings class:
' The SettingChanging event is raised before a setting's value is changed.
' The PropertyChanged event is raised after a setting's value is changed.
' The SettingsLoaded event is raised after the setting values are loaded.
' The SettingsSaving event is raised before the setting values are saved.
Namespace My
    Partial Friend NotInheritable Class MySettings
        Friend Structure [Default]
            Shared ReadOnly Property masterConnection As String
                Get
                    Return String.Format(My.Settings.masterConnection, My.Settings.Username, My.Settings.Password)
                End Get
            End Property

            Shared ReadOnly Property KeepLoggedIn As Boolean
                Get
                    Return False
                End Get
            End Property

            Shared ReadOnly Property Username As String
                Get
                    Return String.Empty
                End Get
            End Property

            Shared ReadOnly Property Password As String
                Get
                    Return String.Empty
                End Get
            End Property

            Shared ReadOnly Property AdminPass As String
                Get
                    Return String.Empty
                End Get
            End Property

            Shared ReadOnly Property AdminUser As String
                Get
                    Return String.Empty
                End Get
            End Property

            Shared ReadOnly Property AdminInfoReceived As Boolean
                Get
                    Return False
                End Get
            End Property
        End Structure
    End Class
End Namespace