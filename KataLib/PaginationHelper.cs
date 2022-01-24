using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace KataLib
{
    public class PagnationHelper<T>
    {
        int _itemsPerPage;
        IList<T> _col;

        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            _itemsPerPage = itemsPerPage;
            _col = collection;
        }

        public int ItemCount
            => _col.Count;

        public int PageCount
         => ItemCount % _itemsPerPage > 0 ? ItemCount / _itemsPerPage + 1 : ItemCount / _itemsPerPage;

        public int PageItemCount(int pageIndex)
            => pageIndex < 0 ? -1
                        : pageIndex < PageCount - 1 ? _itemsPerPage
                        : pageIndex == PageCount - 1 ? ItemCount % _itemsPerPage
                        : -1;

        public int PageIndex(int itemIndex)
         => (itemIndex < 0 || itemIndex >= ItemCount) ? -1
                : (itemIndex < _itemsPerPage) ? 0
                : itemIndex / _itemsPerPage;
    }
}