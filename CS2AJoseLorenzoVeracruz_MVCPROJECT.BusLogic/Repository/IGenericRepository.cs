
using Dapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace CS2AJoseLorenzoVeracruz_MVCPROJECT.BusLogic.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);

    }
}
