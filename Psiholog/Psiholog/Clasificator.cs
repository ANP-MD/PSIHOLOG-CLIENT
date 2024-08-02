using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//using System.Data;

namespace Psiholog
{
  public abstract class Clasificator
    {
      public abstract MySqlDataReader GetValues();
       public abstract void Closeconnection();
       public abstract void Add();
       public abstract void Edit(int _id);
       public abstract void Delete(int _id);
       public abstract MySqlDataReader Search(string _paramsearch);
    }
}
