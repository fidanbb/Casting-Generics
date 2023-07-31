using System;
namespace ClassWorkCastingGenererics
{
	public class IntList
	{
		private int[] _intList;

		public IntList()
		{
			_intList = new int[0];
		}


		public void Add(int num)
		{
			Array.Resize(ref _intList,_intList.Length+1);
			_intList[_intList.Length-1] = num;
		}

		public int[] GetAll()
		{
			return _intList;
		}
	}
}

