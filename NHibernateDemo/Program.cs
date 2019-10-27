using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NHibernateDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{
				using (ITransaction tx = session.BeginTransaction())
				{
					var princess = new Pessoa
					{
						Nome = "Princess",
						Id = 12
					};
					session.Save(princess);
					tx.Commit();
				}
			}
			finally
			{
				//NHibernateHelper.CloseSession(session);
			}
		}
	}
}
