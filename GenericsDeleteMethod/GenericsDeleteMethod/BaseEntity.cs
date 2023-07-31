using System;
namespace GenericsDeleteMethod
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public bool IsDeleted { get; set; } = false;
    }
}

