using Core.Obj;
using UnityEngine;

namespace Core.Obj
{
	public interface IMover : IProcess
	{
		void MoveTo (CxObj cxObj);
	}

	public class CxMover : IMover
	{
		public void MoveTo (CxObj cxObj)
		{
			SetMoveDir (cxObj);
		}

		void SetMoveDir (CxObj cxObj)
		{
			moveDir = cxObj.objView.ViewTransform.position - trans.position;
		}

		public void Process ()
		{
			moveController.Move (moveDir * basicSpeed);
		}

		IMoveController moveController;
		Transform trans;
		int basicSpeed;
		Vector3 moveDir;
	}
}

