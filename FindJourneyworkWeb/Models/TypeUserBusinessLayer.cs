using FindJourneyworkWeb.DataAccessLaye;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindJourneyworkWeb.Models
{
    public class TypeUserBusinessLayer
    {
        public TypeUserBusinessLayer()
        {
            TypeUserERPDAL TypeuserDal = new TypeUserERPDAL();
            TypeuserDal.TypeUsers.ToList();
        }

        public List<TypeUser> GetTypeUser()
        {
            TypeUserERPDAL TypeuserDal = new TypeUserERPDAL();
            return TypeuserDal.TypeUsers.ToList();
        }



    }
}