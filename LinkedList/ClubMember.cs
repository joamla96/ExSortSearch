using System;
using System.Collections;

namespace Core {
	public class ClubMember : IComparable {
		public int Nr { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public int Age { get; set; }

		public ClubMember(int nr, string fname, string lname, int age) {
			this.Nr = nr;
			this.Fname = fname;
			this.Lname = lname;
			this.Age = age;
		}

		public override string ToString() {
			return this.Nr + " " + this.Fname + " " + this.Lname + " " + this.Age;
		}

		public int CompareTo(object y) {
			int Result = 0;
			ClubMember Other = (ClubMember)y;

			Result = this.Nr.CompareTo(Other.Nr);

			if(Result == 0) {
				Result = this.Fname.CompareTo(Other.Fname);
			}

			if(Result == 0) {
				Result = this.Lname.CompareTo(Other.Lname);
			}

			if (Result == 0) {
				Result = this.Age.CompareTo(Other.Age);
			}

			return Result;
		}

		public override bool Equals(object obj) {
			bool Result = false;
			ClubMember Other = (ClubMember)obj;

			if (
				this.Nr.Equals(Other.Nr) &&
				this.Fname.Equals(Other.Fname) &&
				this.Lname.Equals(Other.Lname) &&
				this.Age.Equals(Other.Age)
				) {
				Result = true;
			} else {
				Result = false;
			}

			return Result;
		}

		public override int GetHashCode() {
			return Nr.GetHashCode() + Fname.GetHashCode() + Lname.GetHashCode() + Age.GetHashCode();
		}
	}
}
