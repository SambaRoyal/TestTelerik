Imports Telerik.TestStudio.Translators.Common
Imports Telerik.TestingFramework.Controls.TelerikUI.Blazor
Imports Telerik.TestingFramework.Controls.KendoUI.Angular
Imports Telerik.TestingFramework.Controls.KendoUI
Imports Telerik.WebAii.Controls.Html
Imports Telerik.WebAii.Controls.Xaml
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Linq

Imports ArtOfTest.Common.UnitTesting
Imports ArtOfTest.WebAii.Core
Imports ArtOfTest.WebAii.Controls.HtmlControls
Imports ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts
Imports ArtOfTest.WebAii.Design
Imports ArtOfTest.WebAii.Design.Execution
Imports ArtOfTest.WebAii.ObjectModel
Imports ArtOfTest.WebAii.Silverlight
Imports ArtOfTest.WebAii.Silverlight.UI

Namespace Letmecall

    Public Class Letmecall_Signup
        Inherits BaseWebAiiTest

#Region "[ Dynamic Pages Reference ]"

        Private _pages As Pages
        
        '''<summary>
        ''' Gets the Pages object that has references
        ''' to all the elements, frames or regions
        ''' in this project.
        '''</summary>
        Public ReadOnly Property Pages() As Pages
            Get
                If (_pages Is Nothing) Then
                    _pages = New Pages(Manager.Current)
                End If
                Return _pages
            End Get
        End Property
        
#End Region
        
        ' Add your test methods here...


        <CodedStep("Enter text 'sambaiah.patti@letmecall.com' in 'JUsernameText'")> _
        Public Sub Letmecall_Signup_CodedStep()
            'Enter text 'sambaiah.patti@letmecall.com' in 'JUsernameText'
            Actions.SetText(Pages.LetMeCallOnlineFood.JUsernameText, "sambaiah.patti@letmecall.com")
            
        End Sub
    End Class
End Namespace