using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Psiholog

{
   public class CautClasificator
    {
        private Clasificator _clasificator;

        public CautClasificator(Clasificator clasificator)
            {
                this._clasificator = clasificator;
             }

        public MySqlDataReader GetValues()
        {
           return _clasificator.GetValues();           
        }

        public void Closeconnection()
        {
            _clasificator.Closeconnection();
        }

        public void Add()
        {
            _clasificator.Add(); 
        }

        public void Edit(int _id)
        {
            _clasificator.Edit(_id);
        }

        public void Delete(int _id)
        {
            _clasificator.Delete(_id);
        }

        public MySqlDataReader Search(string _paramsearch)
        {
         return _clasificator.Search(_paramsearch);
        }

    }
}
