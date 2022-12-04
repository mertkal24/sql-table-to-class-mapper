using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ManagementStudio
{
    public class Role 
    {
       public int Role_Id;

public string Name;

public List<Films> films ;

       public void Insert(  string Name,Server server){server.Databases["Role"].ExecuteNonQuery("Insert Into Role (Name ) Values('"+Name+"')");
}
       public void Update(string sorgu , Server server){server.Databases["Role"].ExecuteNonQuery(sorgu);}
       public void Delete(string sorgu , Server server){server.Databases["Role"].ExecuteNonQuery(sorgu);}
      
    }
}
