using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Traits.xUnit {
	public class TraitExample {
		[Fact]
		[Trait("Sprints","Sprint 15")]
		public void IntializeAccount_WhenCustomerInformationIsSupplied() {
		}

	}
}
