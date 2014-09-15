using UnityEngine;
using Core.Obj;

namespace Core.Obj
{
	public interface IProcess
	{
		void Process();
	}

	public interface IMoveController
	{
		void Move(Vector3 translation, Space relativeTo = Space.World);
	}

	public class MoveController : IMoveController
	{
		public void Move (Vector3 translation, Space relativeTo = Space.World)
		{
			trans.Translate(translation * Time.deltaTime, relativeTo);
		}		
		
		Transform trans;
	}
}

