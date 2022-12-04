using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ManagementStudio
{
    public class Movie 
    {
       public int Movie_Id;

public string Name;

public int Date;

public string PictureLink;

public string Description;


       public void Insert(  string Name,  int Date,  string PictureLink,  string Description,Server server){server.Databases["imdb"].ExecuteNonQuery("Insert Into Movie (Name,Date,PictureLink,Description ) Values('"+Name+"','"+Date+"','"+PictureLink+"','"+Description+"')");
}
       public void Update(string sorgu , Server server){server.Databases["imdb"].ExecuteNonQuery(sorgu);}
       public void Delete(string sorgu , Server server){server.Databases["imdb"].ExecuteNonQuery(sorgu);}
      
    }
}
