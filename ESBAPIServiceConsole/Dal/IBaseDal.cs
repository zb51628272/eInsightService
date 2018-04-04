using System.Collections.Generic;
using System.Data;

namespace ESBAPIServiceConsole.Dal
{
    /// <summary>
    /// 所有Dal的基类
    /// </summary>
    /// <typeparam name="T">表类型</typeparam>
    public interface IBaseDal<T> where T : class
    {
        /// <summary>
        /// 根据sql查询指定实体
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数</param>
        /// <param name="isWriteDb">是否读库</param>
        /// <returns></returns>
        IEnumerable<T> Query(string sql, object parameters = null);

        /// <summary>
        /// 添加实体进数据库
        /// </summary>
        /// <param name="entity">实体类</param>
        /// <returns></returns>
        long Add(T entity, IDbTransaction trans = null);

        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="entities">实体类集合</param>
        /// <returns></returns>
        long AddList(IEnumerable<T> entities, IDbTransaction trans = null);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        bool Update(T entity, IDbTransaction trans = null);

        /// <summary>
        /// 批量更新实体
        /// </summary>
        /// <param name="entities">实体类集合</param>
        /// <param name="trans">外部事务</param>
        /// <returns></returns>
        bool UpdateList(IEnumerable<T> entities, IDbTransaction trans = null);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        bool Delete(T entity, IDbTransaction trans = null);

        /// <summary>
        /// 执行Sql
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        int ExecuteWriteSql(string sql, object parameters = null, IDbTransaction trans = null);

        /// <summary>
        /// 查询第一个满足条件的
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="parameters">参数</param>
        /// <param name="isWriteDb">是否是读库</param>
        /// <returns></returns>
        T QueryFirst(string sql, object parameters = null);

        /// <summary>
        /// 根据Guid获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(string id);

        /// <summary>
        /// 根据条件更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="whereProperties">条件属性</param>
        /// <param name="updateProperties">更新属性</param>
        /// <param name="trans">事务</param>
        /// <returns>更新结果</returns>
        bool UpdateByCondition(T entity, IList<string> whereProperties, IList<string> updateProperties, IDbTransaction trans = null);

        /// <summary>
        /// 根据条件更新
        /// </summary>
        /// <param name="entities">实体集合</param>
        /// <param name="whereProperties">条件属性</param>
        /// <param name="updateProperties">更新属性</param>
        /// <param name="trans">事务</param>
        /// <returns>更新结果</returns>
        bool UpdateByCondition(IEnumerable<T> entities, IList<string> whereProperties, IList<string> updateProperties, IDbTransaction trans = null);

    }
}
