using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	internal delegate bool IsPromotable(Employee empl);

	class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Salary { get; set; }
		public int Experience { get; set; }

		public static void PromoteEmployee (List<Employee> employeeList, IsPromotable IsEligibleToPromote)
		{
			foreach (Employee employee in employeeList)
			{
				if (IsEligibleToPromote(employee))
				{
					Console.WriteLine(employee.Name + " promoted");
				}
			}
		}

		public static bool Promote (Employee emp)
		{
			if (emp.Experience >= 5)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
