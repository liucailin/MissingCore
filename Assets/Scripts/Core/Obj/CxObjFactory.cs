using Core.Obj;
using Core.Util;

namespace Core.Obj
{
	public class CxObjFactory : Singleton<CxObjFactory>
	{
		public CxObj GetSimpleCx ()
		{
			CxObjVO cxobjVO = new CxObjVO ();
			cxobjVO.objResPath = "man";
			CxObj cxObj = new CxObj ();
			cxObj.Create (cxobjVO);

			return cxObj;
		}
	}
}

