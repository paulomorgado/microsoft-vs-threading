﻿namespace Microsoft.Threading {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using System.Runtime.CompilerServices;
	using System.Runtime.Remoting.Messaging;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Stores reference types in the CallContext such that marshaling is safe.
	/// </summary>
	/// <typeparam name="T">The type of value to store.</typeparam>
	public class AsyncLocal<T> where T : class {
		private readonly object syncObject = new object();

		/// <summary>
		/// A weak reference table that associates simple objects with some specific type that cannot be marshaled.
		/// </summary>
		private readonly WeakKeyDictionary<object, T> valueTable = new WeakKeyDictionary<object, T>();

		/// <summary>
		/// A table that is used to look up a previously stored simple object to represent a given value.
		/// </summary>
		private readonly ConditionalWeakTable<T, object> reverseLookupTable = new ConditionalWeakTable<T, object>();

		/// <summary>
		/// A unique GUID that prevents this instance from conflicting with other instances.
		/// </summary>
		private readonly string callContextKey = Guid.NewGuid().ToString();

		/// <summary>
		/// An ever-incrementing unique value counter for boxing novel simple objects.
		/// </summary>
		private uint boxedValueCounter;

		/// <summary>
		/// Gets or sets the value to associate with the current CallContext.
		/// </summary>
		public T Value {
			get {
				object boxKey = CallContext.LogicalGetData(this.callContextKey);
				T value;
				if (boxKey != null) {
					lock (this.syncObject) {
						if (this.valueTable.TryGetValue(boxKey, out value)) {
							return value;
						}
					}
				}

				return null;
			}

			set {
				if (value != null) {
					lock (this.syncObject) {
						object callContextValue;
						if (!this.reverseLookupTable.TryGetValue(value, out callContextValue)) {
							// We box an incremented integer and use that as our key.
							// We need a ref type because we need the dictionary to based on references,
							// but an ordinary "new object" doesn't serialize/deserialize and maintain identity.
							// So we box an int so that it can be recognized across serialization.
							callContextValue = ++boxedValueCounter;
						}

						CallContext.LogicalSetData(this.callContextKey, callContextValue);
						this.valueTable[callContextValue] = value;
					}
				} else {
					CallContext.FreeNamedDataSlot(this.callContextKey);
				}
			}
		}
	}
}
