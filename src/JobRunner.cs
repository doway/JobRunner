using System;
using System.IO;
using log4net;
using log4net.Config;
using Quartz;

namespace DOWAY.Tools
{
    class JobRunner
    {
        private static ILog _logger = LogManager.GetLogger(typeof(JobRunner));
        static void Main(string[] args)
        {
            ThreadContext.Properties["appname"] = "JobRunner";
            XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));
            try
            {
                if (args.Length > 0)
                {
                    IJob job = GetJobInstance(args[0]);
                    IJobExecutionContext context = null;
                    job.Execute(context);
                }
                else
                {
                    throw new ArgumentException("Have to assign full qualified name of job class.");
                }
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex.Message, ex);
                throw;
            }
        }
        public static IJob GetJobInstance(string class_assembly_qualified_name)
        {
            Type collector_type = Type.GetType(class_assembly_qualified_name);
            IJob job = (IJob)Activator.CreateInstance(collector_type);
            if (job == null) throw new NullReferenceException(class_assembly_qualified_name + " is unavailable job type, please check your setting.");
            return job;
        }
    }
}
