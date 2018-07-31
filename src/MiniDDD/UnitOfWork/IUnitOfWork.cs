﻿namespace MiniDDD.UnitOfWork
{
    public interface IUnitOfWork
    {
        SqlClient<T> GetSqlClient<T>() where T : class;

        void BeginTran();
        void CommitTran();
        void RollbackTran();
    }
}
