﻿using System;
using System.Collections.Generic;
using System.Text;

namespace testinG
{
    class basketlist<T>
    {
		
			private T[] arr;

			public basketlist()
			{
				arr = new T[0];
			}

			public void Add(T item)
			{
				Array.Resize(ref arr, arr.Length + 1);
				arr[arr.Length - 1] = item;
			}

			public T[] GetArray()
			{
				return arr;
			}

			public int Count
			{
				get
				{
					return arr.Length;
				}
			}
		}
	}

