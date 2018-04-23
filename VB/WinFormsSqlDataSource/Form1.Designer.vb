Namespace WinFormsSqlDataSource
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEAN13 = New DevExpress.XtraGrid.Columns.GridColumn()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.button1.Location = New System.Drawing.Point(668, 502)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(112, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "EditQuery"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.gridControl1.DataMember = "Products"
            Me.gridControl1.DataSource = Me.sqlDataSource1
            Me.gridControl1.Location = New System.Drawing.Point(-1, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(794, 496)
            Me.gridControl1.TabIndex = 2
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind.mdb"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Name = "Products"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued, Me.colEAN13})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default
            ' 
            ' colProductID
            ' 
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.Visible = True
            Me.colProductID.VisibleIndex = 0
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            ' 
            ' colSupplierID
            ' 
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.Name = "colSupplierID"
            Me.colSupplierID.Visible = True
            Me.colSupplierID.VisibleIndex = 2
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 3
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.Visible = True
            Me.colQuantityPerUnit.VisibleIndex = 4
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 5
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.VisibleIndex = 6
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.Visible = True
            Me.colUnitsOnOrder.VisibleIndex = 7
            ' 
            ' colReorderLevel
            ' 
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            Me.colReorderLevel.Visible = True
            Me.colReorderLevel.VisibleIndex = 8
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 9
            ' 
            ' colEAN13
            ' 
            Me.colEAN13.FieldName = "EAN13"
            Me.colEAN13.Name = "colEAN13"
            Me.colEAN13.Visible = True
            Me.colEAN13.VisibleIndex = 10
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 531)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents button1 As System.Windows.Forms.Button
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
        Private colEAN13 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

