using UnityEngine;
using System.Collections;
using Core.Obj;
using Core.Obj.Manager;

namespace Core.Obj
{
	public class CxObjVO
	{
		public string objResPath;
	}

	public class CxObj
	{
		public virtual void Create (CxObjVO cxObjVO)
		{
			this.objVO = cxObjVO;
			Object resObj = ResManager.Instance.GetObj (cxObjVO.objResPath);

			objView = new CxObjView (resObj as GameObject);
		}

		public static CxObj Clone (CxObj cxObj)
		{
			CxObj newCx = new CxObj ();
			newCx.Create (cxObj.objVO);
			return newCx;
		}



		public CxObjView objView;
		public CxObjVO objVO;
	}

	public class CxObjView
	{
		public CxObjView (GameObject viewGamobject)
		{
			this.ViewGameObject = viewGamobject;
		}

		public GameObject ViewGameObject
		{
			get; private set;
		}

		public Transform ViewTransform
		{
			get { return ViewGameObject.transform; }
		}

		//protected GameObject viewGamobject;
	}
}

