using System;
using System.Diagnostics;

namespace SolverEngines
{
	public static class Log
	{
		private static readonly KSPe.Util.Log.Logger log = KSPe.Util.Log.Logger.CreateForType<EngineSolver>();

		internal static void error(string msg, params object[] @parms)
		{
			log.error(msg, parms);
		}

		internal static void error(Exception e, string msg, params object[] @parms)
		{
			log.error(e, msg, parms);
		}

		internal static void warn(string msg, params object[] @parms)
		{
			log.warn(msg, parms);
		}

		internal static void info(string msg, params object[] @parms)
		{
			log.info(msg, parms);
		}
		
		[Conditional ("DEBUG")]
		internal static void dbg(string msg, params object[] @parms)
		{
			log.dbg(msg, parms);
		}
	}
}
