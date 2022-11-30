<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculater.aspx.cs" Inherits="calculater.calculater" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="fff">
<head runat="server">
    <title></title>
  
</head>

<body>
   
    <form id="form1" runat="server">
        <div>


             <input style="width:55px;" id="Button9" type="button" value="9" />
 
             <input style="width:55px;" id="Button8" type="button" value="8" />
                    <input style="width:55px;" id="Button7" type="button" value="7" />
            <input style="width:30px;" id="Buttonadd" type="button" value="+" />
              <br />
               <input style="width:55px;" id="Button6" type="button" value="6" />

          
 
             <input  style="width:55px;" id="Button5" type="button" value="5" />
                    <input style="width:55px;" id="Button4" type="button" value="4" /> 
             <input style="width:30px;" id="Buttonsub" type="button" value="-" />
              <br />
               <input style="width:55px;"id="Button3" type="button" value="3" />
     
 
             <input style="width:55px;" id="Button2" type="button" value="2" />
                    <input style="width:55px;" id="Button1" type="button" value="1" /> 
             <input style="width:30px;" id="Buttonmul" type="button" value="*" />
            <br />
                        <input style="width:173px;" id="Button0" type="button" value="0" />
       <input style="width:30px; " id="Buttondev" type="button" value="/" />

            




            
        </div>
    </form>
</body>
</html>
