using UnityEngine;
using System.Collections;
using Core.Obj;

namespace Core.Obj
{
	public class CxObjVo
	{

	}

	public class CxObj
	{
		public CxObjView objView;
	}

	public class CxObjView
	{
		protected GameObject viewGamobject;

		public Transform ViewTransform
		{
			get { return viewGamobject.transform; }
		}
	}
}

