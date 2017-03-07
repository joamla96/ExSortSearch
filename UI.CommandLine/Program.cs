using System;
using Core;
using System.Diagnostics;

namespace UI.CommandLine {
	class Program {
		static void Main(string[] args) {
			Program program = new Program();
			program.Run2();
		}

		private void Run2() {
			int smallSize = 1000;
			int largeSize = smallSize * 10;

			ClubMember[] smallLinear = new ClubMember[smallSize];
			ClubMember[] largeLinear = new ClubMember[largeSize];

			ClubMember[] smallBinary = new ClubMember[smallSize];
			ClubMember[] largeBinary = new ClubMember[largeSize];

			FillCMArray(smallLinear);
			FillCMArray(largeLinear);

			FillCMArray(smallBinary);
			FillCMArray(largeBinary);

			Stopwatch TimeForLine = Stopwatch.StartNew();
			SearchLinear(smallLinear, "smallLinear");
			SearchLinear(largeLinear, "largeLinear");
			TimeForLine.Stop();
			Console.WriteLine("Total Time: " + TimeForLine.Elapsed + "\n");

			Stopwatch TimeForBinary = Stopwatch.StartNew();
			InsertionSort(smallBinary);
			InsertionSort(largeBinary);

			SearchBinary(smallBinary, "smallBinarySearch");
			SearchBinary(largeBinary, "largeBinarySearch");
			TimeForBinary.Stop();
			Console.WriteLine("Total Time: " + TimeForBinary.Elapsed + "\n");

			Console.ReadKey();
		}

		private void FillCMArray(ClubMember[] array) {
			for(int i = 0; i < array.Length; i++) {
				array[i] = CMFactory.GetClubMember();
			}
		}

		private void SearchBinary(IComparable[] arr, string Name) {
			Random rnd = new Random();

			int random1 = rnd.Next(0, arr.Length - 1);
			int random2 = rnd.Next(0, arr.Length - 1);
			int random3 = rnd.Next(0, arr.Length - 1);

			IComparable One = arr[random1];
			IComparable Two = arr[random2];
			IComparable Three = arr[random3];

			Stopwatch Timer = Stopwatch.StartNew();
			for (int i = 0; i < 1000; i++) {
				FindBinary(arr, One);
				FindBinary(arr, Two);
				FindBinary(arr, Three);
			}
			Timer.Stop();

			Console.WriteLine("Timer '" + Name + "':" + Timer.Elapsed);
		}

		private IComparable FindBinary(IComparable[] arr, IComparable Find) {
			int min = 0;
			int max = arr.Length - 1;
			IComparable Result = null;

			while(Result == null) {
				int Middle = FindMiddle(min, max);
				int Compared = Find.CompareTo(arr[Middle]);

				if(Compared > 0) {
					max = Middle;
				} else if(Compared < 0) {
					min = Middle;
				} else if(Compared == 0) {
					Result = arr[Middle];
				}
			}
						
			return Result;
		}

		private int FindMiddle(int min, int max) {
			return ((max - min) / 2) + min;
		}

		private void SearchLinear(IComparable[] arr, string Name) {
			Random rnd = new Random();

			int random1 = rnd.Next(0, arr.Length - 1);
			int random2 = rnd.Next(0, arr.Length - 1);
			int random3 = rnd.Next(0, arr.Length - 1);

			IComparable One = arr[random1];
			IComparable Two = arr[random2];
			IComparable Three = arr[random3];

			Stopwatch Timer = Stopwatch.StartNew();
			for (int i = 0; i < 1000; i++) {
				FindLinear(arr, One);
				FindLinear(arr, Two);
				FindLinear(arr, Three);
			}
			Timer.Stop();

			Console.WriteLine("Timer '"+ Name +"':" + Timer.Elapsed);
		}

		private IComparable FindLinear(IComparable[] arr, IComparable Find) {
			IComparable Result = null;
			foreach(IComparable Me in arr) {
				if(Me.Equals(Find)) {
					Result = Me;
					break; // TODO: Makeinto a while loop
				}
			}
			return Result;
		}

		private void InsertionSort(IComparable[] arr) {
			for(int i = 0; i < arr.Length-1; i++) {
				int j = i + 1;

				while(j > 0) {
					if(arr[j-1].CompareTo(arr[j]) < 0) {
						IComparable temp = arr[j - 1];
						arr[j - 1] = arr[j];
						arr[j] = temp;
					}

					j--;
				}
			}
		}

		private void Run() {
			MyList List = new MyList();
			ClubMember CM1 = new ClubMember(1, "John", "Doe", 20);
			ClubMember CM2 = new ClubMember(1, "Jane", "Doe", 22);
			ClubMember CM3 = new ClubMember(3, "Rox", "Ion", 22);
			ClubMember CM4 = new ClubMember(4, "Jhones", "Laurs", 21);
			ClubMember CM5 = new ClubMember(1, "John", "Doe", 21);

			List.Insert(CM1);
			List.Insert(CM3);
			List.Insert(CM2);
			List.Insert(CM4);
			List.Insert(CM5);

			Console.WriteLine("Unsorted");
			Console.WriteLine(List.ToString());

			List.Sort();

			Console.WriteLine("\nSorted");
			Console.WriteLine(List.ToString());

			Console.WriteLine("\n\nDONE!");
			Console.ReadKey();
		}

	}
}
