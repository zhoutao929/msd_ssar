VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "IWebAuthenticator"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
''
' IWebAuthenticator v4.0.17
' (c) Tim Hall - https://github.com/VBA-tools/VBA-Web
'
' Interface for creating authenticators for rest client
'
' @class IWebAuthenticator
' @author tim.hall.engr@gmail.com
' @license MIT (http://www.opensource.org/licenses/mit-license.php)
'' ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ '
Option Explicit

' ============================================= '
' Public Methods
' ============================================= '

''
' Hook for taking action before a request is executed
'
' @method BeforeExecute
' @param {WebClient} Client The client that is about to execute the request
' @param in|out {WebRequest} Request The request about to be executed
''
Public Sub BeforeExecute(ByVal client As WebClient, ByRef request As WebRequest)
    ' e.g Add headers, cookies, etc.
End Sub

''
' Hook for taking action after request has been executed
'
' @method AfterExecute
' @param {WebClient} Client The client that executed request
' @param {WebRequest} Request The request that was just executed
' @param in|out {WebResponse} Response to request
''
Public Sub AfterExecute(ByVal client As WebClient, ByVal request As WebRequest, ByRef response As WebResponse)
    ' e.g. Handle 401 Unauthorized or other issues
End Sub

''
' Hook for updating http before send
'
' @method PrepareHttp
' @param {WebClient} Client
' @param {WebRequest} Request
' @param in|out {WinHttpRequest} Http
''
Public Sub PrepareHttp(ByVal client As WebClient, ByVal request As WebRequest, ByRef Http As Object)
    ' e.g. Update option, headers, etc.
End Sub

''
' Hook for updating cURL before send
'
' @method PrepareCurl
' @param {WebClient} Client
' @param {WebRequest} Request
' @param in|out {String} Curl
''
Public Sub PrepareCurl(ByVal client As WebClient, ByVal request As WebRequest, ByRef Curl As String)
    ' e.g. Add flags to cURL
End Sub
