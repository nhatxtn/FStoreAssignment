using DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class DAOFactory
    {
        private static readonly Dictionary<Type, object> instances = new Dictionary<Type, object>();
        private static readonly object lockObject = new object();

        public static T GetInstance<T>() where T : Application_DbContext, new()
        {
            lock (lockObject)
            {
                Type DaoType = typeof(T);
                if (!instances.ContainsKey(DaoType))
                {
                    instances[DaoType] = new T();
                }
                return (T)instances[DaoType];
            }
        }
    }
}
