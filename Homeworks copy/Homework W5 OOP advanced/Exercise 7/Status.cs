using System;
namespace Homework_W5_OOP_advanced
{
	public enum Status
	{
		Available,
		Taken
	}

	public interface IDefaultStatus
	{
		public void SetRoomsStatus();
    }

}

