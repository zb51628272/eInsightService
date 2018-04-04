using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace ESBAPIServiceConsole.Dal
{
    public abstract class BaseDal<T> : IBaseDal<T> where T : class
    {
        static BaseDal()
        {
            SqlMapperExtensions.TableNameMapper = (type) => type.Name;
        }
        /// <summary>
        /// 数据库名字
        /// </summary>
        protected abstract string DbName
        {
            get;
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.Query(string, object, bool)"/>
        /// </summary>
        public IEnumerable<T> Query(string sql, object parameters = null)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentNullException("sql");
            }
            IDbConnection conn = null;
            try
            {
                using (conn = GetConnection())
                {
                    return conn.Query<T>(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.Add(T)"/>
        /// </summary>
        public long Add(T entity, IDbTransaction trans = null)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            IDbConnection conn = null;
            try
            {
                if (trans == null)
                {
                    using (conn = GetConnection())
                    {
                        return conn.Insert<T>(entity);
                    }
                }
                else
                {
                    conn = trans.Connection;
                    return conn.Insert<T>(entity, trans);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public long AddList(IEnumerable<T> entities, IDbTransaction trans = null)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            IDbConnection conn = null;
            try
            {
                if (trans == null)
                {
                    using (conn = GetConnection())
                    {
                        return conn.Insert<IEnumerable<T>>(entities);
                    }
                }
                else
                {
                    conn = trans.Connection;
                    return conn.Insert<IEnumerable<T>>(entities, trans);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.Update(T)"/>
        /// </summary>
        public bool Update(T entity, IDbTransaction trans = null)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            IDbConnection conn = null;
            try
            {
                if (trans == null)
                {
                    using (conn = GetConnection())
                    {
                        return conn.Update(entity);
                    }
                }
                else
                {
                    conn = trans.Connection;
                    return conn.Update(entity, trans);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.UpdateList(IEnumerable{T}, IDbTransaction)(T)"/>
        /// </summary>
        public bool UpdateList(IEnumerable<T> entities, IDbTransaction trans = null)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            IDbConnection conn = null;
            try
            {
                if (trans == null)
                {
                    using (conn = GetConnection())
                    {
                        return conn.Update<IEnumerable<T>>(entities);
                    }
                }
                else
                {
                    conn = trans.Connection;
                    return conn.Update<IEnumerable<T>>(entities, trans);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.Delete(T)"/>
        /// </summary>
        public bool Delete(T entity, IDbTransaction trans = null)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            IDbConnection conn = null;
            try
            {
                if (trans == null)
                {
                    using (conn = GetConnection())
                    {
                        return conn.Delete(entity);
                    }
                }
                else
                {
                    conn = trans.Connection;
                    return conn.Delete(entity, trans);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.ExecuteWriteSql(string, object)"/>
        /// </summary>
        public int ExecuteWriteSql(string sql, object parameters = null, IDbTransaction trans = null)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentNullException("sql");
            }
            IDbConnection conn = null;
            try
            {
                if (trans == null)
                {
                    using (conn = GetConnection())
                    {
                        return conn.Execute(sql, parameters);
                    }
                }
                else
                {
                    conn = trans.Connection;
                    return conn.Execute(sql, parameters, trans);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.QueryFirst(string, object, bool)"/>
        /// </summary>
        public T QueryFirst(string sql, object parameters = null)
        {
            IDbConnection conn = null;
            try
            {
                using (conn = GetConnection())
                {
                    return conn.QueryFirst<T>(sql, parameters);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// <see cref="IBaseDal{T}.GetById(string)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(string id)
        {
            var tableName = typeof(T).Name;
            var sql = $"select * from {tableName} where Id = @Id";
            try
            {
                using (var conn = GetConnection())
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", id);
                    return conn.Query<T>(sql, parameters).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 获取连接
        /// </summary>
        /// <param name="isWriteDb"></param>
        /// <returns></returns>
        internal IDbConnection GetConnection(bool isReadDb = false)
        {
            return new SqlConnection("server=.; database=SqlAllTheWay; trusted_connection=true");
        }

        public bool UpdateByCondition(T entity, IList<string> whereProperties, IList<string> updateProperties, IDbTransaction trans = null)
        {
            throw new NotImplementedException();
        }

        public bool UpdateByCondition(IEnumerable<T> entities, IList<string> whereProperties, IList<string> updateProperties, IDbTransaction trans = null)
        {
            throw new NotImplementedException();
        }
    }
}
