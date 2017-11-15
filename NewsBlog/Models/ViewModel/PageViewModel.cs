using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsBlog.Models.ViewModel
{
    public class PageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPage { get; private set; }
        public PageViewModel(int Count,int PageNumber, int PageSize)
        {
            this.PageNumber = PageNumber;
            TotalPage = (int)Math.Ceiling(Count / (double)PageSize);
        }
        public bool HasPreviosPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPage);
            }
        }
    }
}
