using System;
namespace GenericsDeleteMethod
{
	public class DataList<T> where T: BaseEntity
	{
		private T[] _datas;

		public DataList()
		{
			_datas = Array.Empty<T>();
		}

		public void Add(T data)
		{
			Array.Resize(ref _datas, _datas.Length + 1);
			_datas[_datas.Length - 1] = data;
		}

		public T[] GetAll()
		{
			return _datas;
		}


		public T GetById(int id)
		{
			var datas = GetAll();

			foreach (var item in datas)
			{
				if (item.Id==id)
				{
					return item;
				}
			}
			return null;
		}

		public bool Delete(int id)
		{
			T data = GetById(id);
			data.IsDeleted = true;


			return data.IsDeleted;

		}
	}
}

