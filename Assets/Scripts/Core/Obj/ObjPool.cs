using System;
using System.Collections.Generic;

namespace Core.Obj
{
	public interface IPooled 
	{
		bool IsPooled { get; set; }
	}

	public interface IPool<T> where T : IPooled
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

	public class ObjPool<T> : IPool<T>  where T : IPooled
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
			for ( int i = 0; i < capcity; i++ )
			{
				PushObj(Pooled);
			}
		}

		protected virtual T Pooled
		{
			get
			{
				return pooled;
			}
		}

		public virtual T PopObj ()
		{
			if (pools.Count > 0)
			{	
				T pop = pools.Dequeue ();
				pop.IsPooled = false;
				return pop;
			}
			else
			{
				PushObj(Pooled);
				return PopObj();
			}

		}

		public virtual void PushObj (T pushed)
		{
			pushed.IsPooled = true;
			pools.Enqueue(pushed);
		}

		protected T pooled;
		protected int capcity;

		Queue<T> pools;

	}
}
