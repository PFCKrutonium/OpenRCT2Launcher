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
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Launcher.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property cat_paw() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("cat_paw", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Apply.
        '''</summary>
        Friend ReadOnly Property common_apply() As String
            Get
                Return ResourceManager.GetString("common_apply", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cancel.
        '''</summary>
        Friend ReadOnly Property common_cancel() As String
            Get
                Return ResourceManager.GetString("common_cancel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Complete.
        '''</summary>
        Friend ReadOnly Property common_complete() As String
            Get
                Return ResourceManager.GetString("common_complete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Confirm.
        '''</summary>
        Friend ReadOnly Property common_confirm() As String
            Get
                Return ResourceManager.GetString("common_confirm", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Error has occured!.
        '''</summary>
        Friend ReadOnly Property common_errorOccurred() As String
            Get
                Return ResourceManager.GetString("common_errorOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to OK.
        '''</summary>
        Friend ReadOnly Property common_ok() As String
            Get
                Return ResourceManager.GetString("common_ok", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reset.
        '''</summary>
        Friend ReadOnly Property common_reset() As String
            Get
                Return ResourceManager.GetString("common_reset", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Saves moved to folder and Linked!.
        '''</summary>
        Friend ReadOnly Property extras_anyFolderSync_done() As String
            Get
                Return ResourceManager.GetString("extras_anyFolderSync_done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The folder you selected doesn&apos;t exist!.
        '''</summary>
        Friend ReadOnly Property extras_anyFolderSync_error_notexists() As String
            Get
                Return ResourceManager.GetString("extras_anyFolderSync_error_notexists", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select where you want the saves to be stored..
        '''</summary>
        Friend ReadOnly Property extras_anyFolderSync_fileDialog_desc() As String
            Get
                Return ResourceManager.GetString("extras_anyFolderSync_fileDialog_desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to move your saves to a new folder?.
        '''</summary>
        Friend ReadOnly Property extras_anyFolderSync_firstWarning_text() As String
            Get
                Return ResourceManager.GetString("extras_anyFolderSync_firstWarning_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure?.
        '''</summary>
        Friend ReadOnly Property extras_anyFolderSync_firstWarning_title() As String
            Get
                Return ResourceManager.GetString("extras_anyFolderSync_firstWarning_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Done! You&apos;re all good to go!.
        '''</summary>
        Friend ReadOnly Property extras_cdSoundtrack_done_text() As String
            Get
                Return ResourceManager.GetString("extras_cdSoundtrack_done_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to copy file - Do you have the CD inserted and the game installed?
        '''
        '''Exact Error:
        '''.
        '''</summary>
        Friend ReadOnly Property extras_cdSoundtrack_failed_text() As String
            Get
                Return ResourceManager.GetString("extras_cdSoundtrack_failed_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to If you are using a CD to run RollerCoaster Tycoon 1, Please insert it now..
        '''</summary>
        Friend ReadOnly Property extras_cdSoundtrack_firstWarning_text() As String
            Get
                Return ResourceManager.GetString("extras_cdSoundtrack_firstWarning_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please insert RCT 1 CD.
        '''</summary>
        Friend ReadOnly Property extras_cdSoundtrack_firstWarning_title() As String
            Get
                Return ResourceManager.GetString("extras_cdSoundtrack_firstWarning_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Show File Locations (Debug).
        '''</summary>
        Friend ReadOnly Property extras_fileLocationsButton_text() As String
            Get
                Return ResourceManager.GetString("extras_fileLocationsButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The file you are looking for is CSS17.dat.
        '''</summary>
        Friend ReadOnly Property extras_fileSoundtrack_hint() As String
            Get
                Return ResourceManager.GetString("extras_fileSoundtrack_hint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No file selected..
        '''</summary>
        Friend ReadOnly Property extras_fileSoundtrack_noFileSelected() As String
            Get
                Return ResourceManager.GetString("extras_fileSoundtrack_noFileSelected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add RCT 1 Title Music.
        '''</summary>
        Friend ReadOnly Property extras_rct1musicButton_text() As String
            Get
                Return ResourceManager.GetString("extras_rct1musicButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add RCT1 Title Music from File.
        '''</summary>
        Friend ReadOnly Property extras_rct1musicFileButton_text() As String
            Get
                Return ResourceManager.GetString("extras_rct1musicFileButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The launcher could not find the registry keys. Do you have Both RCT1 &amp; RCT2 Installed? If you do, please open an issue on GitHub..
        '''</summary>
        Friend ReadOnly Property extras_setupReg_noRegisterKeys() As String
            Get
                Return ResourceManager.GetString("extras_setupReg_noRegisterKeys", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to move your Saves to Dropbox?.
        '''</summary>
        Friend ReadOnly Property extras_syncDropbox_firstWarning_text() As String
            Get
                Return ResourceManager.GetString("extras_syncDropbox_firstWarning_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Move Saves?.
        '''</summary>
        Friend ReadOnly Property extras_syncDropbox_firstWarning_title() As String
            Get
                Return ResourceManager.GetString("extras_syncDropbox_firstWarning_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Saves moved to Dropbox and Linked!.
        '''</summary>
        Friend ReadOnly Property extras_syncDropbox_moved_text() As String
            Get
                Return ResourceManager.GetString("extras_syncDropbox_moved_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Saves Moved!.
        '''</summary>
        Friend ReadOnly Property extras_syncDropbox_moved_title() As String
            Get
                Return ResourceManager.GetString("extras_syncDropbox_moved_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sorry, I don&apos;t think you have Dropbox Installed..
        '''</summary>
        Friend ReadOnly Property extras_syncDropbox_notInstalled() As String
            Get
                Return ResourceManager.GetString("extras_syncDropbox_notInstalled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sync Saves to Any Folder.
        '''</summary>
        Friend ReadOnly Property extras_syncSavesAnyFolderButton_text() As String
            Get
                Return ResourceManager.GetString("extras_syncSavesAnyFolderButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sync Saves to Dropbox.
        '''</summary>
        Friend ReadOnly Property extras_syncSavesDropboxButton_text() As String
            Get
                Return ResourceManager.GetString("extras_syncSavesDropboxButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extras.
        '''</summary>
        Friend ReadOnly Property extras_title() As String
            Get
                Return ResourceManager.GetString("extras_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extra&apos;s.
        '''</summary>
        Friend ReadOnly Property frmLauncher_extrasButton_text() As String
            Get
                Return ResourceManager.GetString("frmLauncher_extrasButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Force Update.
        '''</summary>
        Friend ReadOnly Property frmLauncher_forceUpdateButton_text() As String
            Get
                Return ResourceManager.GetString("frmLauncher_forceUpdateButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to OpenRCT2 not installed or not found! Downloading. When it is done, feel free to press play again..
        '''</summary>
        Friend ReadOnly Property frmLauncher_launchGame_RCT2NotFound() As String
            Get
                Return ResourceManager.GetString("frmLauncher_launchGame_RCT2NotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Updating due to Missing Files....
        '''</summary>
        Friend ReadOnly Property frmLauncher_launchGame_updateMessage() As String
            Get
                Return ResourceManager.GetString("frmLauncher_launchGame_updateMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Launch OpenRCT2.
        '''</summary>
        Friend ReadOnly Property frmLauncher_launchGameButton_text() As String
            Get
                Return ResourceManager.GetString("frmLauncher_launchGameButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Have you installed and ran RCT2 at least once? If not, then please do so and try again..
        '''</summary>
        Friend ReadOnly Property frmLauncher_Load_neverRun() As String
            Get
                Return ResourceManager.GetString("frmLauncher_Load_neverRun", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log Output to File.
        '''</summary>
        Friend ReadOnly Property frmLauncher_logButton_text() As String
            Get
                Return ResourceManager.GetString("frmLauncher_logButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Options.
        '''</summary>
        Friend ReadOnly Property frmLauncher_optionsButton_title() As String
            Get
                Return ResourceManager.GetString("frmLauncher_optionsButton_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to OpenRCT2 Launcher.
        '''</summary>
        Friend ReadOnly Property frmLauncher_title() As String
            Get
                Return ResourceManager.GetString("frmLauncher_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to download update.
        '''</summary>
        Friend ReadOnly Property frmLauncher_update_failed() As String
            Get
                Return ResourceManager.GetString("frmLauncher_update_failed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Force updating....
        '''</summary>
        Friend ReadOnly Property frmLauncher_update_forceUpdate() As String
            Get
                Return ResourceManager.GetString("frmLauncher_update_forceUpdate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Update.
        '''</summary>
        Friend ReadOnly Property frmLauncher_updateButton_text() As String
            Get
                Return ResourceManager.GetString("frmLauncher_updateButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Updating....
        '''</summary>
        Friend ReadOnly Property frmLauncher_updateStateMessage_updating() As String
            Get
                Return ResourceManager.GetString("frmLauncher_updateStateMessage_updating", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Up to Date!.
        '''</summary>
        Friend ReadOnly Property frmLauncher_updateStateMessage_uptodate() As String
            Get
                Return ResourceManager.GetString("frmLauncher_updateStateMessage_uptodate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Checking if you are up to date....
        '''</summary>
        Friend ReadOnly Property frmLauncher_updateStatus_baseText() As String
            Get
                Return ResourceManager.GetString("frmLauncher_updateStatus_baseText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Verbose Output.
        '''</summary>
        Friend ReadOnly Property frmLauncher_verboseOutputButton_text() As String
            Get
                Return ResourceManager.GetString("frmLauncher_verboseOutputButton_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Gridlines on Landscape.
        '''</summary>
        Friend ReadOnly Property frmOptions_alwaysGridLines_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_alwaysGridLines_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Configuration has been changed. Save Changes?.
        '''</summary>
        Friend ReadOnly Property frmOptions_closeConfirmation_text() As String
            Get
                Return ResourceManager.GetString("frmOptions_closeConfirmation_text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Deutschmark (DM).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_deutchmark() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_deutchmark", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dollars ($).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_dollar() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_dollar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Euro (€).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_euro() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_euro", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Franc (F).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_franc() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_franc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Guilders (Dfl.).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_guilder() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_guilder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Krona (kr).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_krona() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_krona", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Currency:.
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lira (L).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_lira() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_lira", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Peseta (Pts).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_peseta() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_peseta", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pounds (£).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_pound() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_pound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Yen (¥).
        '''</summary>
        Friend ReadOnly Property frmOptions_currency_yen() As String
            Get
                Return ResourceManager.GetString("frmOptions_currency_yen", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Imperial.
        '''</summary>
        Friend ReadOnly Property frmOptions_distSpeed_imperial() As String
            Get
                Return ResourceManager.GetString("frmOptions_distSpeed_imperial", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Distance and Speed:.
        '''</summary>
        Friend ReadOnly Property frmOptions_distSpeed_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_distSpeed_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Metric.
        '''</summary>
        Friend ReadOnly Property frmOptions_distSpeed_metric() As String
            Get
                Return ResourceManager.GetString("frmOptions_distSpeed_metric", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Scroll view when pointer at screen edge.
        '''</summary>
        Friend ReadOnly Property frmOptions_edgeScrolling_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_edgeScrolling_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Forced Software Buffer Mixing.
        '''</summary>
        Friend ReadOnly Property frmOptions_forcedSoftwareBuffering_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_forcedSoftwareBuffering_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fullscreen height:.
        '''</summary>
        Friend ReadOnly Property frmOptions_fullscreenHeight_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_fullscreenHeight_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fullscreen.
        '''</summary>
        Friend ReadOnly Property frmOptions_fullscreenMode_fullscreen() As String
            Get
                Return ResourceManager.GetString("frmOptions_fullscreenMode_fullscreen", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fullscreen (desktop).
        '''</summary>
        Friend ReadOnly Property frmOptions_fullscreenMode_fullscreenDesktop() As String
            Get
                Return ResourceManager.GetString("frmOptions_fullscreenMode_fullscreenDesktop", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fullscreen mode:.
        '''</summary>
        Friend ReadOnly Property frmOptions_fullscreenMode_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_fullscreenMode_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Windowed.
        '''</summary>
        Friend ReadOnly Property frmOptions_fullscreenMode_windowed() As String
            Get
                Return ResourceManager.GetString("frmOptions_fullscreenMode_windowed", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fullscreen width:.
        '''</summary>
        Friend ReadOnly Property frmOptions_fullscreenWidth_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_fullscreenWidth_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Game Path:.
        '''</summary>
        Friend ReadOnly Property frmOptions_gamePath_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_gamePath_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Height Labels:.
        '''</summary>
        Friend ReadOnly Property frmOptions_heightLabels_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_heightLabels_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Real Values.
        '''</summary>
        Friend ReadOnly Property frmOptions_heightLabels_real() As String
            Get
                Return ResourceManager.GetString("frmOptions_heightLabels_real", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Units.
        '''</summary>
        Friend ReadOnly Property frmOptions_heightLabels_units() As String
            Get
                Return ResourceManager.GetString("frmOptions_heightLabels_units", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Landscape Smoothing.
        '''</summary>
        Friend ReadOnly Property frmOptions_landscapeSmoothing_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_landscapeSmoothing_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Language:.
        '''</summary>
        Friend ReadOnly Property frmOptions_language_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_language_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Output Path:.
        '''</summary>
        Friend ReadOnly Property frmOptions_outputPath_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_outputPath_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Play Intro.
        '''</summary>
        Friend ReadOnly Property frmOptions_playIntroButton_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_playIntroButton_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save Output to File.
        '''</summary>
        Friend ReadOnly Property frmOptions_saveOutputFile_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_saveOutputFile_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Export plug-in objects with saved games.
        '''</summary>
        Friend ReadOnly Property frmOptions_savePluginData_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_savePluginData_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Screenshot Format:.
        '''</summary>
        Friend ReadOnly Property frmOptions_screenshotFormat_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_screenshotFormat_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Show Confirmation Prompt.
        '''</summary>
        Friend ReadOnly Property frmOptions_showConfirmationPrompt_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_showConfirmationPrompt_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to High.
        '''</summary>
        Friend ReadOnly Property frmOptions_soundQuality_high() As String
            Get
                Return ResourceManager.GetString("frmOptions_soundQuality_high", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sound Quality:.
        '''</summary>
        Friend ReadOnly Property frmOptions_soundQuality_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_soundQuality_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Low.
        '''</summary>
        Friend ReadOnly Property frmOptions_soundQuality_low() As String
            Get
                Return ResourceManager.GetString("frmOptions_soundQuality_low", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Medium.
        '''</summary>
        Friend ReadOnly Property frmOptions_soundQuality_medium() As String
            Get
                Return ResourceManager.GetString("frmOptions_soundQuality_medium", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Arguments:.
        '''</summary>
        Friend ReadOnly Property frmOptions_startArguments_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_startArguments_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Celsius (°C).
        '''</summary>
        Friend ReadOnly Property frmOptions_temperature_celsius() As String
            Get
                Return ResourceManager.GetString("frmOptions_temperature_celsius", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fahrenheit (F).
        '''</summary>
        Friend ReadOnly Property frmOptions_temperature_fahrenheit() As String
            Get
                Return ResourceManager.GetString("frmOptions_temperature_fahrenheit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Temperature:.
        '''</summary>
        Friend ReadOnly Property frmOptions_temperature_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_temperature_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Options.
        '''</summary>
        Friend ReadOnly Property frmOptions_title() As String
            Get
                Return ResourceManager.GetString("frmOptions_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Title screen music:.
        '''</summary>
        Friend ReadOnly Property frmOptions_titleScreenMusic_label() As String
            Get
                Return ResourceManager.GetString("frmOptions_titleScreenMusic_label", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to None.
        '''</summary>
        Friend ReadOnly Property frmOptions_titleScreenMusic_none() As String
            Get
                Return ResourceManager.GetString("frmOptions_titleScreenMusic_none", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to RollerCoaster Tycoon 1.
        '''</summary>
        Friend ReadOnly Property frmOptions_titleScreenMusic_RCT1() As String
            Get
                Return ResourceManager.GetString("frmOptions_titleScreenMusic_RCT1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to RollerCoaster Tycoon 2.
        '''</summary>
        Friend ReadOnly Property frmOptions_titleScreenMusic_RCT2() As String
            Get
                Return ResourceManager.GetString("frmOptions_titleScreenMusic_RCT2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Password.
        '''</summary>
        Friend ReadOnly Property OpenRCTdotNetLogin_passwordLabel() As String
            Get
                Return ResourceManager.GetString("OpenRCTdotNetLogin_passwordLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Login to OpenRCT.NET.
        '''</summary>
        Friend ReadOnly Property OpenRCTdotNetLogin_title() As String
            Get
                Return ResourceManager.GetString("OpenRCTdotNetLogin_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to User name.
        '''</summary>
        Friend ReadOnly Property OpenRCTdotNetLogin_usernameLabel() As String
            Get
                Return ResourceManager.GetString("OpenRCTdotNetLogin_usernameLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property rollercoaster_tycoon_2_001() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("rollercoaster_tycoon_2_001", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
