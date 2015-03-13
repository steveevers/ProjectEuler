using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers {
	public static class PE044 {
		public static int Answer() {
			var list = new List<int>();
			var hash = new HashSet<int>();
			foreach (var i in Sequences.Pentagonal().Take(10000)) {
				list.Add(i);
				hash.Add(i);
			}

			var answers = new List<int>();
			for (int j = 0; j < list.Count(); j++) {
				for (int k = j + 1; k < list.Count(); k++) {
					var sum = list[j] + list[k];
					var difference = list[k] - list[j];

					if (hash.Contains(sum) && hash.Contains(difference))
						answers.Add(Math.Abs(difference));
				}
			}

			return answers
				.OrderBy(i => i)
				.First();
		}
	}
}
