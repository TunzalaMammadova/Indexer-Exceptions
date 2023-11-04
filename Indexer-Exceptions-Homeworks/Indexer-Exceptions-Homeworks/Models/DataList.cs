using System;

namespace Indexer_Exceptions_Homeworks
{
	public class DataList<T> where T : BaseEntity
	{
		private T[] _datas;
		public DataList()
		{
			_datas = new T[0];
		}


		public void Add(T item)
		{
			Array.Resize(ref _datas, _datas.Length + 1);
			_datas[_datas.Length - 1] = item;
		}


		public T GetById(int id)
		{
			return _datas.FirstOrDefault(m => m.Id == id );
		}
	}
}
	

