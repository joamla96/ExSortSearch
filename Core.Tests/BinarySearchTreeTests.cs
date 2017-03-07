using System;
using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Tests
{
	[TestClass]
	public class BinarySearchTreeTests {

		[TestMethod]
		public void InsertIntoTree() {
			ClubMember CM1 = new ClubMember(1, "John", "Doe", 20);
			ClubMember CM2 = new ClubMember(2, "Marius", "Sibajevas", 21);
			ClubMember CM3 = new ClubMember(3, "Jonas", "Laursen", 21);
			ClubMember CM4 = new ClubMember(4, "Matt", "Peterson", 18);
			ClubMember CM5 = new ClubMember(5, "Roxana", "Ion", 22);
			ClubMember CM6 = new ClubMember(6, "Allan", "He", 30);
			ClubMember CM7 = new ClubMember(7, "Jane", "Smith", 20);
			ClubMember CM8 = new ClubMember(7, "Jane", "Smith", 20);

			MyBST BinaryTree = new MyBST();

			BinaryTree.Insert(CM1);
			BinaryTree.Insert(CM3);
			BinaryTree.Insert(CM7);
			BinaryTree.Insert(CM2);
			BinaryTree.Insert(CM4);
			BinaryTree.Insert(CM6);
			BinaryTree.Insert(CM5);

			Assert.AreEqual(CM6, BinaryTree.Search(CM6));
		}
	}
}
