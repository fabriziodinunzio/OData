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
            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="True" />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReadDataTables" TypeName="XmlToExcel.XmlLoader">
                        <SelectParameters>
                            <asp:Parameter Name="xmlFilePathList" DefaultValue="Applicazione.xml|UnaApplicazione1.xml" Type="String"/>
                            <asp:Parameter Name="tableName" DefaultValue="Applicazione"  Type="String" />
                            <asp:Parameter Name="nsArray" DefaultValue="http://www.w3.org/2001/XMLSchema-instance" Type="String" />
                            <asp:Parameter Name="columnToRemoveList" DefaultValue="Id|Applicazione_Id|IsUsed" Type="String" />
                        </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <div>
            <asp:GridView ID="GridViewCollectionList" runat="server" DataSourceID="ObjectDataSource2" AutoGenerateColumns="True" />  
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="ReadDataTables" TypeName="XmlToExcel.XmlLoader">
                        <SelectParameters>
                            <asp:Parameter Name="xmlFilePathList" DefaultValue="Applicazione.xml|UnaApplicazione1.xml" Type="String"/>
                            <asp:Parameter Name="tableName" DefaultValue="Componente"  Type="String" />
                            <asp:Parameter Name="nsArray" DefaultValue="http://www.w3.org/2001/XMLSchema-instance" Type="String" />
                            <asp:Parameter Name="columnToRemoveList" DefaultValue="Id|ListComponente_Id|Componente_Id|IsUsed" Type="String" />
                        </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <div>
            <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSource3" AutoGenerateColumns="True" />  
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="ReadDataTables" TypeName="XmlToExcel.XmlLoader">
                        <SelectParameters>
                            <asp:Parameter Name="xmlFilePathList" DefaultValue="Applicazione.xml|UnaApplicazione1.xml" Type="String"/>
                            <asp:Parameter Name="tableName" DefaultValue="AaaComponente"  Type="String" />
                            <asp:Parameter Name="nsArray" DefaultValue="http://www.w3.org/2001/XMLSchema-instance" Type="String" />
                            <asp:Parameter Name="columnToRemoveList" DefaultValue="Id|ListAaaComponente_Id|IsUsed" Type="String" />
                        </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>

</body>
</html>
