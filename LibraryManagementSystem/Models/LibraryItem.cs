using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class LibraryItem <T>
    {
        public string Title { get; set; }
        public T Details { get; set; }

        public override string ToString()
        {
            if (Details is Book book)
            {
                return $"Title: {Title} - Author: {book.Author} - Type: Book";
            }
            else if (Details is Magazine magazine)
            {
                return $"Title: {Title} - IssueNumber: {magazine.IssueNumber} - Type: Magazine";
            }
            else if (Details is DVD dvd)
            {
                return $"Title: {Title} - Duration: {dvd.Duration} - Type: DVD";
            }

            return Title;
        }
    }
}
