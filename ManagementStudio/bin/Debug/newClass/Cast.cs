using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ManagementStudio
{
    public class Cast 
    {
       public int Cast_ID;

public string Name;

public string Bio;

public string Image_Link;

public DateTime Born;

public string Link;

public List<Films> films ;

       public void Insert(  string Name,  string Bio,  string Image_Link,  DateTime Born,  string Link,Server server){server.Databases["Cast"].ExecuteNonQuery("Insert Into Cast (Name,Bio,Image_Link,Born,Link ) Values('"+Name+"','"+Bio+"','"+Image_Link+"','"+Born+"','"+Link+"')");
}
       public void Update(string sorgu , Server server){server.Databases["Cast"].ExecuteNonQuery(sorgu);}
       public void Delete(string sorgu , Server server){server.Databases["Cast"].ExecuteNonQuery(sorgu);}
      
    }
}
