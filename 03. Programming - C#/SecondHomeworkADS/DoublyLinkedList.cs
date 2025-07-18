using System;
using System.Collections.Generic;
using System.Text;

namespace SecondHomeworkADS
{
    class DoublyLinkedLists
    {
		public class DoubleLink
		{
			public string Title { get; set; }
			public DoubleLink PreviousLink { get; set; }
			public DoubleLink NextLink { get; set; }

			public DoubleLink(string title)
			{
				Title = title;
			}

			public override string ToString()
			{
				return Title;
			}
		}

		public class DoubleLinkedList
		{
			private DoubleLink first;
			public bool IsEmpty
			{
				get
				{
					return first == null;
				}
			}
			public DoubleLinkedList()
			{
				first = null;
				
			}

			public DoubleLink Insert(string title)
			{
			
				DoubleLink link = new DoubleLink(title);
				link.NextLink = first;
				if (first != null)
					first.PreviousLink = link;
				first = link;
				return link;
			}

			public DoubleLink Delete()
			{
				// Gets the first item, and sets it to be the one it is linked to
				DoubleLink temp = first;
				if (first != null)
				{
					first = first.NextLink;
					if (first != null)
						first.PreviousLink = null;
				}
				return temp;
			}

			public override string ToString()
			{
				DoubleLink currentLink = first;
				StringBuilder builder = new StringBuilder();
				while (currentLink != null)
				{
					builder.Append(currentLink);
					currentLink = currentLink.NextLink;
				}
				return builder.ToString();
			}

			///// New operations
			public void InsertAfter(DoubleLink link, string title)
			{
				if (link == null || string.IsNullOrEmpty(title))
					return;
				DoubleLink newLink = new DoubleLink(title);
				newLink.PreviousLink = link;
				// Update the 'after' link's next reference, so its previous points to the new one
				if (link.NextLink != null)
					link.NextLink.PreviousLink = newLink;
				// Steal the next link of the node, and set the after so it links to our new one
				newLink.NextLink = link.NextLink;
				link.NextLink = newLink;
			}
		}
	}
}
