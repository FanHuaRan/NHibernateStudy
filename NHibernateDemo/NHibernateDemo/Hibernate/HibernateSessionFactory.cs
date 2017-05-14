using log4net;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NHibernateDemo.Hibernate
{
    /// <summary>
    /// HibernateSession 工厂封装 实现线程安全
    /// 2017/05/13 fhr
    /// </summary>
    public class HibernateSessionFactory
    {
        /// <summary>
        /// 日志工具
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(HibernateSessionFactory));
        /// <summary>
        /// Hibernate配置文件路径 默认为项目输出目录下的hibernate.cfg.xml 如果不是则在此写相对路径
        /// </summary>
        private static string _configFile =null;
        /// <summary>
        /// ISession的ThreadLocal封装
        /// </summary>
        private static readonly ThreadLocal<ISession> _threadLocalSession = new ThreadLocal<ISession>();
        /// <summary>
        /// Hibernate配置对象
        /// </summary>
        private static Configuration _configuration;
        /// <summary>
        /// Hibernate Session工厂对象
        /// </summary>
        private static ISessionFactory _sessionFactory;
        /// <summary>
        /// 利用静态构造方法进行初始化操作
        /// </summary>
        static HibernateSessionFactory()
        {
            try
            {
                CreateSessionFactory();
            }
            catch(Exception e)
            {
                logger.Error("Hibernate初始化失败", e);
            }
        }
        /// <summary>
        /// 获取当前线程中的session
        /// </summary>
        /// <returns></returns>
        public static ISession GetSession()
        {
            var session = _threadLocalSession.Value;
            //若无或者已关闭则创建
            if (session == null || !session.IsOpen)
            {
                if (_sessionFactory == null)
                {
                    RebuildSessionFactory();
                }
                session = (_sessionFactory != null) ? _sessionFactory.OpenSession() : null;
                _threadLocalSession.Value = session;
            }
            return session;
        }
        /// <summary>
        /// 重建Session工厂
        /// </summary>
        public static void RebuildSessionFactory()
        {
            try
            {
                CreateSessionFactory();
            }
            catch (Exception e)
            {
                logger.Error("重建Session工厂错误", e);
            }
        }
        /// <summary>
        /// 关闭当前线程下的seesion对象
        /// </summary>
        public static void CloseSession()
        {
            ISession session = _threadLocalSession.Value;
            _threadLocalSession.Value = null;
            if (session != null)
            {
                session.Close();
            }
        }
        /// <summary>
        /// 创建配置对象和ession工厂
        /// </summary>
        private static void CreateSessionFactory()
        {
            if (string.IsNullOrEmpty(_configFile))
            {
                _configuration = new NHibernate.Cfg.Configuration().Configure();
            }
            else
            {
                _configuration = new NHibernate.Cfg.Configuration().Configure(_configFile);
            }
            _sessionFactory = _configuration.BuildSessionFactory();
        }
        /// <summary>
        /// Session工厂 Getter
        /// </summary>
        public static ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory;
            }
        }
        /// <summary>
        /// 配置对象 Getter
        /// </summary>
        public static Configuration Configuration
        {
            get
            {
                return _configuration;
            }
        }
        /// <summary>
        /// 配置文件路径 setter
        /// </summary>
        public static String ConfigFile
        {
            set
            {
                if (_configFile != value)
                {
                    _configFile = value;
                    _sessionFactory = null;
                }
            }
        }
    }
}
