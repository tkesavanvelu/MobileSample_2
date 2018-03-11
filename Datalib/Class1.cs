using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datalib
{
	public class Class1
	{
		public string Title { get; set; }
		public string Description { get; set; }

	}

	public class DataManager
	{
		private readonly Class1[] DataElems;
		private int currentIndex;
		public DataManager()
		{
			DataElems = InitData();
		}

		private Class1[] InitData()
		{
			var InitData = new Class1[] {
				new Class1
				{
					Title = "Engineering",
					Description = "Engineering Team , Responsibility: Design, Develop, Test "
				},
				new Class1
				{
					Title = "Marketing",
					Description = "Marketing Team,Responsibility : Sales , Presentation"
				},
				new Class1
				{
					Title = "Accounting",
					Description = "Accounting Team, Responsibility : Accounts, Payroll, AR, AP"
				},
				new Class1
				{
					Title = "Project Management",
					Description = "Project Management, Responsibility : Projects, PMO , Delivery"
				},
				new Class1
				{
					Title = "Quality Assurance",
					Description = "Quality Assurance Team,Responsibilty : Testing,Automation "
				}
			};
			return InitData;
		}
		public void MoveFirst()
		{
			currentIndex = 0;
		}

		public void MovePrev()
		{
			if (currentIndex > 0)
				--currentIndex;
		}

		public void MoveNext()
		{
			if  ( currentIndex < DataElems.Length -1  )
				++currentIndex;
		}

		public Class1 Current
		{
			get { return DataElems[currentIndex]; }
		}

	}
}
