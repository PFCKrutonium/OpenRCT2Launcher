﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class strings
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Launcher.strings", GetType(strings).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sorry, I don&apos;t think you have Dropbox Installed..
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_dropbox_not_installed() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_dropbox_not_installed", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Saves moved to Dropbox and Linked!.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_dropbox_succes_text() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_dropbox_succes_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Saves moved!.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_dropbox_succes_title() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_dropbox_succes_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to move your Saves to Dropbox?.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_dropbox_text() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_dropbox_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Move saves?.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_dropbox_title() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_dropbox_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to The folder you selected does not exist!.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_folder_does_not_exist() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_folder_does_not_exist", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Select where you want the saves to be stored..
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_folder_select() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_folder_select", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Saves moved to folder and Linked!.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_folder_succes_text() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_folder_succes_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Saved moved!.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_folder_succes_title() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_folder_succes_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to move your saves to a new folder?.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_folder_text() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_folder_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Are you sure?.
        '''</summary>
        Friend Shared ReadOnly Property extras_cloud_save_folder_title() As String
            Get
                Return ResourceManager.GetString("extras_cloud_save_folder_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Dropbox:.
        '''</summary>
        Friend Shared ReadOnly Property extras_debug_dropbox() As String
            Get
                Return ResourceManager.GetString("extras_debug_dropbox", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to RollerCoaster Tycoon 1: .
        '''</summary>
        Friend Shared ReadOnly Property extras_debug_rct1() As String
            Get
                Return ResourceManager.GetString("extras_debug_rct1", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to RollerCoaster Tycoon 2: .
        '''</summary>
        Friend Shared ReadOnly Property extras_debug_rct2() As String
            Get
                Return ResourceManager.GetString("extras_debug_rct2", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Exact error:.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_exact_error() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_exact_error", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Failed to copy file - Do you have the CD inserted and the game installed?.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_failed_text() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_failed_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to An Error has occured!.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_failed_title() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_failed_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to If you are using a CD to run RollerCoaster Tycoon 1, Please insert it now..
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_insert_disk_text() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_insert_disk_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Please Insert RCT 1 CD.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_insert_disk_title() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_insert_disk_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Done! Assuming you saw no errors, you&apos;re all good to go!.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_succes_text() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_succes_text", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Complete.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_copy_succes_title() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_copy_succes_title", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to The file you are looking for is CSS17.dat.
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_manual_copy_file_instrutions() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_manual_copy_file_instrutions", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to No file selected..
        '''</summary>
        Friend Shared ReadOnly Property extras_rct1_music_manual_copy_no_file_selected() As String
            Get
                Return ResourceManager.GetString("extras_rct1_music_manual_copy_no_file_selected", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to The launcher could not find the registry keys. Do you have Both RCT1 &amp; RCT2 Installed? If you do, please open an issue on GitHub..
        '''</summary>
        Friend Shared ReadOnly Property extras_registry_keys_not_found() As String
            Get
                Return ResourceManager.GetString("extras_registry_keys_not_found", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Force Updating....
        '''</summary>
        Friend Shared ReadOnly Property main_force_updating() As String
            Get
                Return ResourceManager.GetString("main_force_updating", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Have you installed and ran RCT2 at least once? If not, then please do so and try again..
        '''</summary>
        Friend Shared ReadOnly Property main_have_you_installed_and_ran_rct2_at_least_once() As String
            Get
                Return ResourceManager.GetString("main_have_you_installed_and_ran_rct2_at_least_once", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to OpenRCT2 Not Installed or Not Found!, Downloading. When it is done, feel free to press play again..
        '''</summary>
        Friend Shared ReadOnly Property main_openrct2_not_installed_or_not_found() As String
            Get
                Return ResourceManager.GetString("main_openrct2_not_installed_or_not_found", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Up to date!.
        '''</summary>
        Friend Shared ReadOnly Property main_up_to_date() As String
            Get
                Return ResourceManager.GetString("main_up_to_date", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Updating....
        '''</summary>
        Friend Shared ReadOnly Property main_updating() As String
            Get
                Return ResourceManager.GetString("main_updating", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Updating due to Missing Files....
        '''</summary>
        Friend Shared ReadOnly Property main_updating_due_to_missing_files() As String
            Get
                Return ResourceManager.GetString("main_updating_due_to_missing_files", resourceCulture)
            End Get
        End Property
    End Class
End Namespace