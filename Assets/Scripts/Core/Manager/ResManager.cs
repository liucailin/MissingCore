using Core.Obj;
using Core.Util;
using UnityEngine;

namespace Core.Obj.Manager
{
	public class ResManager : Singleton<ResManager>
	{
		public Object GetObj (string objResPath)
		{
			if (string.IsNullOrEmpty (objResPath))
			{
				return GameObject.CreatePrimitive (PrimitiveType.Cube);
			}
			return null;
		}
	}
}

