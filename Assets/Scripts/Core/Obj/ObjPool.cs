using System;
using System.Collections.Generic;

namespace Core.Obj
{
	public interface IPooled {}
	public interface IPool<T>/* where T : IPooled*/
	{
		/// <summary>
		/// Pops the object.
		/// </summary>
		/// <returns>The object.</returns>
		T PopObj();

		/// <summary>
		/// Pushs the object.
		/// </summary>
		/// <param name="pushed">The object need to be pshed into pool.</param>
		void PushObj(T pushed);
	}

	public class ObjPool<T> : IPool<T>/*  where T : IPooled*/
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Core.Obj.ObjPool`1"/> class.
		/// </summary>
		/// <param name="pooled">Pooled object.</param>
		/// <param name="capcity">Pool Capcity.</param>
		public ObjPool (T pooled, int capcity)
		{
			this.pooled = pooled;
			this.capcity = capcity;

			InitPool();
		}

		void InitPool()
		{
			pools = new Queue<T>(capcity);
			for ( int i = 0; i < pools.Count; i++ )
			{
				AddPooledObj(pooled);
			}
		}

		protected virtual void AddPooledObj(T pooled)
		{
			pools.Enqueue(pooled);			
		}

		public virtual T PopObj ()
		{
			T pop = default(T);
			if (pools.Count > 0)
			{
				pop = pools.Dequeue();
			}
			else
			{
				pools.Enqueue(pooled);
				PopObj();
			}
			return pop;
		}

		public virtual void PushObj (T pushed)
		{
			pools.Enqueue(pushed);
		}

		protected T pooled;
		protected int capcity;

		Queue<T> pools;

	}
}
