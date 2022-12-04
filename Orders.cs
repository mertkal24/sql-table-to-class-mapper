using Microsoft.SqlServer.Management.Smo;
 using System;
 using System.Collections.Generic;
 using System.ComponentModel;
 using System.Data;
 using System.Data.SqlClient;
 using System.Drawing;
 using System.IO;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks; 
 using System.Windows.Forms;
namespace ManagementStudio 
{
public class  Orders
{
public int OrderID;

public string CustomerID;

public int EmployeeID;

public DateTime OrderDate;

public DateTime RequiredDate;

public DateTime ShippedDate;

public int ShipVia;

public decimal Freight;

public string ShipName;

public string ShipAddress;

public string ShipCity;

public string ShipRegion;

public string ShipPostalCode;

public string ShipCountry;

}
}