using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000366 RID: 870
internal sealed class Class412<T> : IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>, IEnumerable, ICollection, IList
{
	// Token: 0x0600165E RID: 5726 RVA: 0x0000F4E5 File Offset: 0x0000D6E5
	public Class412(T[] gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.gparam_0.GetEnumerator();
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x06001660 RID: 5728 RVA: 0x0000F501 File Offset: 0x0000D701
	int ICollection.Count
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x06001661 RID: 5729 RVA: 0x00003056 File Offset: 0x00001256
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x06001662 RID: 5730 RVA: 0x0000F50B File Offset: 0x0000D70B
	object ICollection.SyncRoot
	{
		get
		{
			return this;
		}
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0000F50E File Offset: 0x0000D70E
	void ICollection.CopyTo(Array array, int index)
	{
		this.gparam_0.CopyTo(array, index);
	}

	// Token: 0x1700036D RID: 877
	object IList.this[int index]
	{
		get
		{
			return this.gparam_0[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06001666 RID: 5734 RVA: 0x00003982 File Offset: 0x00001B82
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06001667 RID: 5735 RVA: 0x00003982 File Offset: 0x00001B82
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x000031EC File Offset: 0x000013EC
	int IList.Add(object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x000031EC File Offset: 0x000013EC
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0000F530 File Offset: 0x0000D730
	bool IList.Contains(object value)
	{
		return this.gparam_0.Contains(value);
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0000F53E File Offset: 0x0000D73E
	int IList.IndexOf(object value)
	{
		return this.gparam_0.IndexOf(value);
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x000031EC File Offset: 0x000013EC
	void IList.Insert(int index, object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x000031EC File Offset: 0x000013EC
	void IList.Remove(object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x000031EC File Offset: 0x000013EC
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x0000F54C File Offset: 0x0000D74C
	IEnumerator<T> IEnumerable<!0>.GetEnumerator()
	{
		return this.gparam_0.GetEnumerator();
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06001670 RID: 5744 RVA: 0x0000F501 File Offset: 0x0000D701
	int IReadOnlyCollection<!0>.Count
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x17000371 RID: 881
	T IReadOnlyList<!0>.this[int index]
	{
		get
		{
			return this.gparam_0[index];
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06001672 RID: 5746 RVA: 0x0000F501 File Offset: 0x0000D701
	int ICollection<!0>.Count
	{
		get
		{
			return this.gparam_0.Length;
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06001673 RID: 5747 RVA: 0x00003982 File Offset: 0x00001B82
	bool ICollection<!0>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x000031EC File Offset: 0x000013EC
	void ICollection<!0>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x000031EC File Offset: 0x000013EC
	void ICollection<!0>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x0000F567 File Offset: 0x0000D767
	bool ICollection<!0>.Contains(T item)
	{
		return this.gparam_0.Contains(item);
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0000F575 File Offset: 0x0000D775
	void ICollection<!0>.CopyTo(T[] array, int arrayIndex)
	{
		this.gparam_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x000031EC File Offset: 0x000013EC
	bool ICollection<!0>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17000374 RID: 884
	T IList<!0>.this[int index]
	{
		get
		{
			return this.gparam_0[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0000F584 File Offset: 0x0000D784
	int IList<!0>.IndexOf(T item)
	{
		return this.gparam_0.IndexOf(item);
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x000031EC File Offset: 0x000013EC
	void IList<!0>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x000031EC File Offset: 0x000013EC
	void IList<!0>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000EE0 RID: 3808
	private readonly T[] gparam_0;
}
