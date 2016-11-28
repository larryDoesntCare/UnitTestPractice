using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TestingLib {

	public static class Assert {
		public static ObservableCollection<TestResult> TestResults { get; set; }

		static Assert() {
			TestResults = new ObservableCollection<TestResult>();
		}

		public static void RunTests() {
			var testMethods = GetTestMethods();

			foreach (MethodInfo method in testMethods)
			{
				var instanceOfTestClass = Activator.CreateInstance(method.DeclaringType);
				method.Invoke(instanceOfTestClass, null);
			}
		}

		private static List<MethodInfo> GetTestMethods() {
			List<MethodInfo> theMethods = new List<MethodInfo>();
			var assemb = Assembly.GetExecutingAssembly();

			var q = from t in Assembly.GetExecutingAssembly().GetTypes()
							from m in t.GetMethods()
							from att in m.GetCustomAttributes(true)
							where att.GetType() ==  typeof (CheckThisMethod)
							
							select m;

			
			return q.ToList();
		}

		public static void AreEqual(object first, object second, string message, [CallerMemberName] string methodName = null) {
			var testResult = TestResults.Where(x => x.MethodName == methodName).FirstOrDefault();

			if (first.Equals(second))
			{
				testResult.TestPassed = true;
			}
			else {
				testResult.TestPassed = false;
				testResult.TestFailedMessage = message;
			}
			testResult.MethodName = methodName;
			if (TestResults.Contains(testResult) == false)
			{
				TestResults.Add(testResult);
			}
		}
	}
}