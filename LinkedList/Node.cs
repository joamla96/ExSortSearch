using System;

namespace Core {
	public class Node {
		public Node Next = null;
		public IComparable Data = null;

		public Node(IComparable obj) {
			this.Data = obj;
		}
	}
}
