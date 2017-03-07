using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
	class MyBST {
		private BNode Root;

		public void Insert(IComparable Data) {
			BNode CurNode = Root;
			while(CurNode != null) {
				int Compared = Data.CompareTo(CurNode.Data);
				if (Compared < 0) {
					CurNode = CurNode.Left;
				} else if(Compared > 0) {
					CurNode = CurNode.Right;
				} else if(Compared == 0) {
					CurNode = CurNode.Left;
				}
			}

			CurNode = new BNode(Data);
		}

		public IComparable Search(IComparable Data) {
			BNode CurNode = Root;
			IComparable Result = null;
			while(CurNode != null && Result == null) {
				int Compared = Data.CompareTo(CurNode.Data);
				if (Compared < 0) {
					CurNode = CurNode.Left;
				} else if (Compared > 0) {
					CurNode = CurNode.Right;
				} else if (Compared == 0) {
					Result = CurNode.Data;
				}
			}

			return Result;
		}
	}

	public class BNode {
		internal BNode Left;
		internal BNode Right;

		public IComparable Data;

		public BNode(IComparable data) {
			this.Data = data;
		}
	}
}
