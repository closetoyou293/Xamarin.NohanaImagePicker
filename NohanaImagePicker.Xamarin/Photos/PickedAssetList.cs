﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NohanaImagePicker.Xamarin.Common;
using Item = NohanaImagePicker.Xamarin.Common.IAsset;

namespace NohanaImagePicker.Xamarin.Photos
{
    public class PickedAssetList : Common.IItemList, ICollection<Item>
    {
        public PickedAssetList()
        {
        }
        List<Item> _assetList;

        public string Title => "Selected Assets";

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Index(int i)
        {
            return i + 1;
        }

        public void Update(Action handler)
        {
            throw new Exception("Not supported");
        }

        public int StartIndex { get => 0; }

        public int EndIndex { get => _assetList.Count; }

        public Item this[int index] => _assetList[index];

        #region ICollection
 
        public void Add(Item item)
        {
            _assetList.Add(item);
        }

		public void Clear()
		{
			_assetList.Clear();
		}

		public bool Contains(Item item)
		{
			return _assetList.Contains(item);
		}

		public void CopyTo(Item[] array, int arrayIndex)
		{
			_assetList.CopyTo(array, arrayIndex);
		} 

		public bool Remove(Item item)
		{
			return _assetList.Remove(item);
		}

		public IEnumerator<Item> GetEnumerator()
		{
			return _assetList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _assetList.GetEnumerator();
		}

        #endregion

        #region Manage assetlist

        public bool Pick(IAsset asset)
        { 
            throw new NotImplementedException();
            return false;
        }
		public bool Drop(IAsset asset)
		{

			throw new NotImplementedException();
			return false;
		}

		public bool IsPicked(IAsset asset)
		{  
            return _assetList.FirstOrDefault(x => x.Identifier == asset.Identifier) != null;
		}
        #endregion


    }
} 