Imports System.Windows
Imports System.Data
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace AppearanceCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            InitializeComponent()
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded)
'''  End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim table As DataTable = New DataTable()
            table.Columns.Add("Category", GetType(String))
            table.Columns.Add("Product", GetType(String))
            table.Columns.Add("Year", GetType(Integer))
            table.Columns.Add("Quantity", GetType(Integer))
            table.Rows.Add("Category", "Coffee", 2019, 1)
            table.Rows.Add("Category", "Coffee", 2020, 7)
            table.Rows.Add("Category", "Coffee", 2021, 4)
            table.Rows.Add("Category", "Juice", 2019, 4)
            table.Rows.Add("Category", "Juice", 2020, 20)
            table.Rows.Add("Category", "Juice", 2021, 2)
            table.Rows.Add("Category", "Tea", 2019, 9)
            table.Rows.Add("Category", "Tea", 2020, 8)
            table.Rows.Add("Category", "Tea", 2021, 12)
            pivotGrid.DataSource = table
        End Sub
    End Class
End Namespace
