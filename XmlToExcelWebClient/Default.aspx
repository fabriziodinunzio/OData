<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XmlToExcelWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1"></asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReadTable" TypeName="XmlToExcel.TableLoader">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Applicazione.xml" Name="xmlFilePath" Type="String" />
                    <asp:Parameter DefaultValue="Applicazione" Name="tableName" Type="String" />
                    <asp:Parameter DefaultValue="http://www.w3.org/2001/XMLSchema-instance" Name="nsArrayList" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
