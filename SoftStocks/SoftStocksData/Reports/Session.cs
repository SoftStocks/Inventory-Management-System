﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
	public sealed class Session
	{
		private static Session instance;

		//Session data to be persisted
		private static List<Report> reports = new List<Report>();

		// Implements thread safety
		private static readonly object SessionLock = new object();

		private Session() {
			reports = new List<Report>();
		}

		public static Session GetInstance()
		{
			lock(SessionLock)  {
				if (instance == null)
				{
					instance = new Session();
				}
				
			}
			return instance;
		}

		public static void AddReport(Report report)
		{
			reports.Add(report);
		}

		public static void RemoveReportById(int Id)
		{
			reports.RemoveAll(r => r.Id == Id);
		}

		public static Report GetReportById(int Id)
		{
			return reports.FirstOrDefault(r => r.Id == Id);
		}

		public static List<Report> GetReports()
		{
			return reports;
		}

		public static void Clear()
		{
			reports = new List<Report>();
		}
	}
}
