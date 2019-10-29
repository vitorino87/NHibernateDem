using System;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernateDemo
{
	public class NHibernateHelper
	{
		private static ISessionFactory _sessionFactory;

		private static ISessionFactory SessionFactory
		{
			get
			{
				if (_sessionFactory == null)
				{
					var configuration = new Configuration();
					//configuration.Configure("C:\\Users\\Win7\\source\\repos\\NHibernateDemo\\NHibernateDemo\\hibernate.cfg.xml");
					//configuration.Configure("C:\\Users\\Win7\\source\\repos\\NHibernateDemo\\NHibernateDemo\\hibernate2.hbm.xml");
					configuration.Configure("C:\\Users\\Win7\\source\\repos\\NHibernateDemo\\NHibernateDemo\\hibernate3.cfg.xml");
					//configuration.AddAssembly(typeof(Pessoa).Assembly);
					configuration.AddFile("C:\\Users\\Win7\\source\\repos\\NHibernateDemo\\NHibernateDemo\\Pessoa.hbm.xml");
					_sessionFactory = configuration.BuildSessionFactory();
				}
				return _sessionFactory;
			}
		}

		public static ISession OpenSession()
		{
			return SessionFactory.OpenSession();
		}
	}
}
