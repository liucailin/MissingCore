using System;
using System.Collections.Generic;

public class ObjContainer<T, V>
{
	public bool AddObj(T id, V obj)
	{
		bool isAdd = containerMap.ContainsKey(id);	
		if (!isAdd) containerMap.Add(id, obj);
		return isAdd;
	}

	public V GetObj(T id)
	{
		V obj = default(V);
		containerMap.TryGetValue(id, out obj);
		return obj;
	}

	public bool RemoveObj(T id)
	{
		return containerMap.Remove(id);
	}

	IDictionary<T, V> containerMap = new Dictionary<T, V>();
}


